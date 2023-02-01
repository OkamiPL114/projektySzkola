const express = require('express');
const Song = require("../models/Song");

const router = express.Router();

router.get('/', async (req, res, next)=>{
    let songs = [];

    try {
		songs = await Song.find();
	} catch (error) {
		console.log(error.message);
	}

    res.render('index', {
        pageTitle: "Moje ulubione piosenki",
        songs: songs
    });
})
router.post('/', async (req, res, next)=>{
    const newSong = {
		author: req.body.author,
		title: req.body.title,
		releaseDate: new Date(req.body.releaseDate),
		authorCountry: req.body.authorCountry
	};

	try {
		await new Song(newSong).save();
	} catch (error) {
		console.log(error.message);
	}

	res.redirect("/");
})

module.exports = router;