const express = require('express');
const router = express.Router();

router.get('/', (req, res, next) => {
    res.render('index', {
        pageTitle: 'Strona główna',
    })
})

router.get('/about', (req, res, next) => {
    res.render('about', {
        pageTitle: 'O Nas',
    })
})

router.get('/contact', (req, res, next) => {
    res.render('contact', {
        pageTitle: 'Kontakt',
    })
})

module.exports = router;