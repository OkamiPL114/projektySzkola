const express = require('express');
const app = express();
const path = require('path');
const bodyParser = require('body-parser');
const fs = require('fs');

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
    res.render('subscribers', {
        pageTitle: "Subskrybenci"
    });
})

app.post('/subs', (req, res) => {
    const subsPath = path.join(__dirname, "subscribers.json");
    
})

app.listen(3000);