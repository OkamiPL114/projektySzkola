const express = require("express");
const { emit } = require("nodemon");
const credentials = require("../credentials"); // tablica z mailami i hasłami

const router = express.Router();

router.get("/", (req, res, next) => {
  res.render("index");
});

router.get("/calc-post", (req, res, next) => {
  res.render("calc-post");
});

router.post("/calc-post", (req, res, next) => {
  let n1 = parseInt(req.body.number1);
  let n2 = parseInt(req.body.number2);

  if (isNaN(n1) || isNaN(n2)) {
    res.redirect("/calc-post"); // przekierowanie na trasę /calc-post
  }

  res.render("calc-post", {
    num1: n1,
    num2: n2,
  });
});

router.get("/login", (req, res, next) => {
  res.render("login");
});

router.post("/login", (req, res, next) => {
  const email = req.body.email;
  const password = req.body.password;

  let isLoggedIn = false;

  credentials.forEach((user) => {
    if (user.email === email && user.password === password) {
      isLoggedIn = true;
    }
  });

  res.render("login", {
    isLoggedIn: isLoggedIn,
    email: email,
  });
});

module.exports = router;
