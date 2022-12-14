const mongoose = require('mongoose');

const userSchema = mongoose.Schema({
    firstName: String,
    lastName: String,
    birthDate: Date,
    joinDate: Date,
    active: Boolean,
});

module.exports = mongoose.model("User", userSchema);