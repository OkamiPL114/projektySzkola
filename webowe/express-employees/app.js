const path = require('path');
const express = require('express');
const bodyParser = require('body-parser');

const mainRoutes = require('./routes/main-routes');
const errorRoutes = require('./routes/error-routes');

const app = express();

// zasoby statyczne
const publicPath = path.join(__dirname, "public");
app.use(express.static(publicPath));

// silnik widoków
app.set("view engine", "ejs");
app.set("views", "./views");

// konfiguracja body-parser
app.use(bodyParser.urlencoded({ extended: false }))

// trasy
app.use(mainRoutes);
app.use(errorRoutes);

app.listen(3000);