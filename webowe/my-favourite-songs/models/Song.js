const mongoose = require('mongoose');

const songSchema = mongoose.Schema({
    author: String,
    title: String,
    releaseDate: Date,
    authorCountry: String
});

module.exports = mongoose.model("Song", songSchema);