/**
 * General routes.
 */
"use strict";

const express = require("express");
const router = express.Router();

// Add a route for the path /
router.get("/", (req, res) => {
    res.send("Hello World");
});

// Add a route for the path /about
router.get("/about", (req, res) => {
    res.send("About something");
});
router.get("/lotto", (req, res) => {
    var numbers = [];
    for (var i = 0; i < 7; i++) {
        numbers.push(Math.floor(Math.random() * 35));
    }
    res.send("7 random numbers between 1-35: " + numbers);
});

module.exports = router;