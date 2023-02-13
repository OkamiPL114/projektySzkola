const express = require("express");
const Location = require("../models/Location");

const router = express.Router();

router.get("/", async (req, res, next) => {
  let country = req.query.country;

  try {
    const locations = await Location.find();

    const countryList = [""];

    locations.forEach((location) => {
      let uniqueItem = true;

      countryList.forEach((country) => {
        if (country === location.country) {
          uniqueItem = false;
        }
      });
      if (uniqueItem) {
        countryList.push(location.country);
      }
    });

    let filterLocations;
    let selectedCountry;
    if (country === "" || country === undefined) {
      filterLocations = await Location.find();
      selectedCountry = "Wszystkie państwa";
    } else {
      filterLocations = await Location.find({ country: country });
      selectedCountry = country;
    }

    res.render("home", {
      pageTitle: "Odwiedzone miejsca",
      locations: filterLocations,
      countryList: countryList,
      selectedCountry: selectedCountry,
    });
  } catch (e) {
    console.log(e.message);
  }
});

router.post("/add-location", async (req, res, next) => {
  const name = req.body.name;
  const country = req.body.country;
  console.log(name, country);

  try {
    let newLocation = {
      name: name,
      country: country,
    };
    await new Location(newLocation).save();
  } catch (e) {
    console.log(e.message);
  }

  res.redirect("/");
});

router.post("/filter", (req, res, next) => {
  let selectedCountry = req.body.countryListSelect;
  console.log(selectedCountry);
  res.redirect(`/?country=${selectedCountry}`);
})

module.exports = router;