const express = require("express");
const bodyParser = require("body-parser");
const cookieParser = require('cookie-parser');
const path = require('path');

const app = express();

app.use(express.static(path.join(__dirname, "public")));

app.set('view engine', 'ejs');
app.set('views', './views');
app.use(bodyParser.urlencoded({ extended: false}));

//cookie config
app.use(cookieParser("dlugiKluczSzyfrujace")); //parametr jest kluczem kodowania

app.get('/', (req, res, next) => {
    if(!req.cookies.theme){
        res.cookie('theme', 'lightTheme'); //tworzenie cookie
    }

    res.render("index", {
        siteTheme: req.cookies.theme
    });
})

app.post('/changeTheme', (req, res, next) => {
    res.cookie('visitDate', new Date().toLocaleDateString())
    res.cookie('secret', 'strona testowa', {signed: true, maxage:1000*60});
    if(req.cookies.theme === "lightTheme"){
        res.cookie('theme', "darkTheme", {maxAge:1000*60*60*24});
    } else {
        res.cookie('theme', "lightTheme", {maxAge:1000*60*60*24});
    }
    res.redirect('/');
})

app.post("/deleteCookies", (req, res, next) => {
    res.clearCookie('secret');
    res.clearCookie('visitDate');
    res.clearCookie('theme');
    res.redirect('/');
})

app.listen(3000);