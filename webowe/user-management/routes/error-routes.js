const express = require('express');
const router = express.Router();

router.use((req, res, next) => {
    res.status(404).send('404 page');
});

router.use((err, req, res, next) => {
    res.status(500).send('500 page');
});

module.exports = router;