const express = require("express");
const User = require("../models/User");

const router = express.Router();

router.get("/users", async (req, res, next) => {
	let users = [];

	try {
		users = await User.find();
	} catch (error) {
		console.log(error.message);
	}

	res.render("users", {
		pageTitle: "Użytkownicy",
		users: users,
	});
});

router.post("/users", async (req, res, next) => {
	const newUser = {
		firstname: req.body.firstname,
		lastname: req.body.lastname,
		birthdate: new Date(req.body.birthdate),
		gender: req.body.gender,
		joinDate: new Date(),
		active: req.body.active === "on" ? true : false,
	};

	try {
		await new User(newUser).save();
	} catch (error) {
		console.log(error.message);
	}

	res.redirect("/users");
});

router.post("/delete", async (req, res, next) => {
	const id = req.body.userId;

	try {
		await User.findByIdAndDelete(id);
	} catch (e) {
		console.log(e.message);
	}

	res.redirect("/users");
});

router.post("/edit", async (req, res) => {
	const id = req.body.userId;

	try {
		const userToEdit = await User.findById(id);

		let birthdate = new Date(userToEdit.birthdate);
		let year = birthdate.getFullYear();
		let month = birthdate.getMonth() + 1;
		let day = birthdate.getDate();

		let birthdateStr = year + "-";
		birthdateStr += month < 10 ? "0" + month : month;
		birthdateStr += "-";
		birthdateStr += day < 10 ? "0" + day : day;

		res.render("edit", {
			pageTitle: "Edycja użytkownika",
			user: userToEdit,
			birthdateStr: birthdateStr,
		});
	} catch (e) {
		console.log(e.message);
	}
});

router.post("/update", async (req, res, next) => {
	const applyBtn = req.body.applyBtn;

	if (applyBtn === undefined) {
		res.redirect("/users");
		return;
	}

	const id = req.body.userId;
	const firstname = req.body.firstname;
	const lastname = req.body.lastname;
	const birthdate = new Date(req.body.birthdate);
	const active = req.body.active === "on" ? true : false;

	try {
		await User.findByIdAndUpdate(id, {
			firstname: firstname,
			lastname: lastname,
			birthdate: birthdate,
			active: active,
		});
		res.redirect("/users");
	} catch (e) {
		console.log(e.message);
	}
});

router.post("/details", async (req, res, next) => {
	try {
		const detailedUser = await User.findById(req.body.userId);
		res.render("details", {
			pageTitle: "Szczegóły użytkownika",
			user: detailedUser
		});
	} catch (e) {
		console.log(e.message);
	}
	res.end();
})

module.exports = router;
