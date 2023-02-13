const mongoose = require('mongoose');

const locationSchema = mongoose.Schema({
   name: String,
   country: String
});

module.exports = mongoose.model("Location", locationSchema);