const User = require("../models/user");
const YEAR = new Date().getFullYear();

exports.getLogin = (req, res, next) => {
	res.render('login', {
		pageTitle: "Logowanie",
		year: YEAR
	});
}
exports.getSignup = (req, res, next) => {
    let errMsg = "";
    switch(req.query.msg){
        case "0": errMsg = "Konto zostało poprawnie dodane"; break;
        case "1": errMsg = "Hasła są różne"; break;
        case "2": errMsg = "Istnieje już użytkownik o takim emailu"; break;
    }
    
    res.render('signup', {
        pageTitle: "Tworzenie konta",
        year: YEAR,
        error: errMsg
    });
}

exports.postSignup = async (req, res, next) => {
    let firstName = req.body.firstName;
    let lastName = req.body.lastName;
    let email = req.body.email;
    let password = req.body.password;
    let repeatPassword = req.body.repeatPassword;

    console.log(`${firstName}, ${lastName}, ${email}, ${password}, ${repeatPassword}`);

    if(password !== repeatPassword){
        res.redirect('/signup?msg=1');
        return;
    }

    const users = await User.find();
    let alreadyExists = false;
    users.forEach(user => {
        if(user.email == email){
            alreadyExists = true; // jak dasz tu redirect to wywala
        }
    })
    if(alreadyExists){
        res.redirect('/signup?msg=2');
        return;
    }

    const newUser = {
        firstName: firstName,
        lastName: lastName,
        email: email,
        password: password
    }
    try {
        await new User(newUser).save();
        res.redirect('/signup?msg=0');
        return;
    } catch (error) {
        console.log(error);
    }
    res.redirect('/signup');
}