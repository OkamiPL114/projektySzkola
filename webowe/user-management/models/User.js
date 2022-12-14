const mongoose = require('mongoose');

const userSchema = mongoose.Schema({
    firstname: String,
    lastname: String,
    birthdate: Date,
    gender: String,
    joinDate: Date,
    active: Boolean,
});

module.exports = mongoose.model("User", userSchema);