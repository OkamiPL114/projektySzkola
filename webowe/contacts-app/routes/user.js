const express = require("express");
const router = express.Router();
const userController = require('../controllers/user');

router.get("/", userController.getLogin);
router.get("/signup", userController.getSignup);
router.post("/signup", userController.postSignup);

module.exports = router;