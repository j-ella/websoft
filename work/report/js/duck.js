"use strict";

(function() {

    var element = document.getElementById("duck");

    element.addEventListener("click", function() {

        if (element.offsetLeft <= window.innerWidth - 180) {
            element.style.left = element.offsetLeft + 50 + "px";
        } else {
            console.log("cant move more")

        }
    });

})();