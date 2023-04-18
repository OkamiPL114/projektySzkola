const User = require("../models/user");
const YEAR = new Date().getFullYear();
exports.getLogin = (req, res, next) => {
	res.render('login', {
		pageTitle: "Logowanie",
		year: YEAR
	});
}
exports.getSignup = (req, res, next) => {
    res.render('signup', {
        pageTitle: "Tworzenie konta",
        year: YEAR,
        //error: req.msg
    });
}

exports.postSignup = (req, res, next) => {
    let firstName = req.body.firstName;
    let lastName = req.body.lastName;
    let email = req.body.email;
    let password = req.body.password;
    let repeatedPassword = req.body.repeatedPassword;

    if(password !== repeatedPassword){
        res.redirect('signup');
    }
}