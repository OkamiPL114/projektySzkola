const mongoose = require('mongoose');

const bookSchema = mongoose.Schema({
    title: String,
    author: String,
    price: Number
});

module.exports = mongoose.model("Book", bookSchema);