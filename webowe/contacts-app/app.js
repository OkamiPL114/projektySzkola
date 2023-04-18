// pakiet Prettier - formater kodu, Shift + Alt + F
const express = require("express");
const path = require("path");
const bodyParser = require("body-parser");
const session = require("express-session");
const mongoose = require("mongoose");

const app = express();
const port = 3000;

const errorRoutes = require('./routes/error');
const userRoutes = require('./routes/user');

// consts
const YEAR = new Date().getFullYear();

// static resources
const publicPath = path.join(__dirname, "public");
app.use(express.static(publicPath));

// body parser
app.use(bodyParser.urlencoded({ extended: false }));
app.use(bodyParser.json());

// ejs
app.set("view engine", "ejs");
app.set("views", "./views");

// session
app.use(
    session({
        secret: "panieWezMniePanNieCzitujBoCieZnajdeIRozdupce",
        resave: false,
        saveUninitialized: false,
  })
);

// mongoose
mongoose.connect('mongodb://127.0.0.1:27017/contacts')
	.then(() => console.log('Connected!'));


app.use(userRoutes);
app.use(errorRoutes);

app.listen(port, () => {
	console.log(`Server running on ${port}`);
});
