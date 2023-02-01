const path = require('path');

const express = require("express");
const bodyParser = require('body-parser');
const mongoose = require('mongoose');

const mainRoutes = require('./routes/main-routes');
const errorRoutes = require('./routes/error-routes');

const port = 3000;
const app = express();

// połączenie z bazą danych
mongoose.connect('mongodb://localhost:27017/usersManagement')

// zasoby statyczne
const publicPath = path.join(__dirname, 'public');
app.use(express.static(publicPath));

// EJS
app.set('view engine', 'ejs');
app.set('views', './views');

// body-parser
app.use(bodyParser.urlencoded({ extended: false }))
app.use(bodyParser.json())

// routing
app.use(mainRoutes);

app.use(errorRoutes);

app.listen(port, () => {
  console.log(`Server is running on port ${port}.`);
});
