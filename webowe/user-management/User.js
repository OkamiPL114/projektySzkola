const mongoose = require('mongoose');

const userSchema = mongoose.Schema({
    firstname: String,
    lastname: String,
    age: Number,
    joinDate: Date,
    active: Boolean,
});

module.exports = mongoose.model("User", userSchema);