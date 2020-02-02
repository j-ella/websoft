/**
 * A sample of a main function stating the famous Hello World.
 *
 * @returns void
 */

"use strict";

function main() {
    let a = 1;
    let b;
    let range = "";
    let j = 0;
    let today = new Date();
    let birthday = new Date('17 April, 1998 06:00:00');


    b = a + 1;

    for (let i = 0; i < 9; i++) {
        range += i + ", ";
    }

    while (j < 9) {
        j++;
        range += j + ", ";
    }

    console.info("Hello World");
    console.info(range.substring(0, range.length - 2));
    console.info(a, b);
    console.info(today);
    console.info(birthday);
}
main();