const express = require('express');
const path = require('path');

const app = express();
const port = 3000;

const mainRoutes = require('./routes/main-routes');
const errorRoutes = require('./routes/error-routes');

//zasoby statyczne
const publicPath = path.join(__dirname, "public");
app.use(express.static(publicPath));

//silnik widoków
app.set("view engine", "ejs");
app.set("views", "./views");

//trasy
app.use(mainRoutes);
app.use(errorRoutes);

app.listen(port, ()=> {
    console.log(`Server is running on port ${port}`);
});