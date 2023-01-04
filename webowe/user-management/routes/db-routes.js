const express = require('express');
const router = express.Router();
const User = require('../models/User');

router.get('/users', async (req, res, next) => {
    const users = await User.find();

    res.render('users', {
        pageTitle: 'Użytkownicy',
        users: users
    })
})

router.post('/users', async (req, res, next) => {
    const newUser = {
        firstName: req.body.firstName,
        lastName: req.body.lastName,
        birthDate: new Date(req.body.birthDate),
        joinDate: new Date(),
        active: req.body.active === "on" ? true : false
    }
    try {
        await new User(newUser).save();
    } catch (error) {
        console.log(error.message);
    }
    res.redirect('/users');
})

router.post('/delete', async (req, res, next) => {
    const id = req.body.userId;

    try {
        await User.findByIdAndDelete(id);
    } catch (e) {
        console.log(e.message);
    }
    res.redirect('/users');
})

module.exports = router;