const express = require('express');
const app = express();
const path = require('path');
const bodyParser = require('body-parser');
const fs = require('fs');

const subsPath = path.join(__dirname, "subscribers.json");
const countriesPath = path.join(__dirname, "countries.json");

// mongoose 
const mongoose = require('mongoose');
mongoose.connect('mongodb://127.0.0.1:27017/test')
  .then(() => console.log('Connected!'));
const Book = require("./models/Book");

// folder public
const publicPath = path.join(__dirname, "public");
app.use(express.static(publicPath));

// ejs
app.set("view engine", "ejs");
app.set('views', './views');

// body parser
app.use(bodyParser.urlencoded({ extended: false }))
app.use(bodyParser.json());

app.get('/', (req, res) => {
    res.render('index', {
        pageTitle: "Strona domowa"
    });
})

app.get('/calc', (req, res) => {
    let result = "";
    if(req.query.number1) {
        let number1 = parseFloat(req.query.number1);
        let number2 = parseFloat(req.query.number2);
        let sign = req.query.sign;

        result = `${number1} `;
        switch(sign) {
            case 'add': result += "+";break;
            case 'subtract': result += "-";break;
            case 'multiply': result += "*";break;
            case 'divide': result += "/";break;
        }
        result += ` ${number2} = `;
        switch(sign) {
            case 'add': result += (number1 + number2);break;
            case 'subtract': result += (number1 - number2);break;
            case 'multiply': result += (number1 * number2);break;
            case 'divide': result += (number1 / number2);break;
        }
    }

    res.render('calc', {
        pageTitle: "Kalkulator",
        result: result
    });
})

app.get('/subs', (req, res) => {
    const subs = getSubscribers(subsPath); // tablica
    res.render('subscribers', {
        pageTitle: "Subskrybenci",
        subscribers: subs
    });
})

app.post('/subs', (req, res) => {
    const subs = getSubscribers(subsPath); // tablica
    
    subs.push({
        firstName: req.body.firstName,
        lastName: req.body.lastName,
        email: req.body.email
    });
    
    saveToFile(subsPath, subs);
    res.redirect("/subs");
})
function getSubscribers(path) {
    if(fs.existsSync(path)) {
        let dataJson = fs.readFileSync(path);
        return JSON.parse(dataJson);
    }
    return [];
}

function getDataFromFile(path) {
    if(fs.existsSync(path)) {
        let dataJson = fs.readFileSync(path);
        return JSON.parse(dataJson);
    }
    return [];
}

function saveToFile(path, data) {
    fs.writeFileSync(path, JSON.stringify(data));
}

app.get('/countries', (req, res) => {
    res.render("countries", {
        pageTitle: "Kraje",
        countries: getDataFromFile(countriesPath)
    });
})

app.post('/countries', (req, res) => {
    let countries = getDataFromFile(countriesPath);

    let newCountry = {
        name: req.body.name,
        capital: req.body.capital,
        population: req.body.population,
        continent: req.body.continent,
        has10Milion: req.body.has10Milion === "on" ? true : false
    }
    countries = [...countries, newCountry];

    saveToFile(countriesPath, countries);

    res.redirect("/countries");
})

app.get('/books', async (req, res) => {
    let Books = [];
    try {
        Books = await Book.find();
    } catch (error) {
        console.log(e.message);
    }
    
    res.render('books', {
        pageTitle: "Książki",
        books: Books
    });
})

app.post('/books', async (req, res) => {
    const newBook = {
        title: req.body.title,
        author: req.body.author,
        price: req.body.price
    };
    try {
        await new Book(newBook).save();
    } catch (error) {
        console.log(e.message);
    }
    res.redirect('/books');
})

app.listen(3000, () => {
    console.log("Server is running on port 3000");
});