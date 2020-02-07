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
    let data = {};

    data.numbers = [];

    for (var i = 0; i < 7; i++) {
        data.numbers[i] = Math.floor(Math.random() * 35) + 1;
    }
    res.render("lotto", data);
});

module.exports = router;