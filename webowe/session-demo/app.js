const path = require('path');
const express = require('express');
const bodyParser = require('body-parser');
const session = require('express-session');

const app = express();

app.use(express.static(path.join(__dirname, "public")));

app.set('view engine', 'ejs');
app.set('views', './views');
app.use(bodyParser.urlencoded({ extended: false}));

//session config
app.use(session({
    resave: false,
    saveUninitialized: false,
    secret: "your secret long string"
}))

app.get('/', (req, res, next) => {
    res.render('login');
})

app.post('/login', (req, res, next) => {
    const email = req.body.email;
    const password = req.body.password;

    if(email === "user@test.pl" && password === "1234"){
        req.session.isLoggedIn = true;
        res.redirect('/home');
        return;
    }
    res.redirect('/');
})

app.get('/home', (req, res, next) => {
    if(!req.session.isLoggedIn){
        res.redirect('/');
        return;
    }

    res.render('home');
})

app.post('/logout', (req, res, next) => {
    req.session.destroy( (error) => {
        if(error !== undefined){
            console.log(error);
        }
        res.redirect('/');
    });
})

app.listen(3000);