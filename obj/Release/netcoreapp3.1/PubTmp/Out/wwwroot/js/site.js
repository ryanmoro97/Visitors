// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var offset = new Date().getTimezoneOffset();
var timezone = document.getElementById("timezone")
if (Math.sign(offset) == 1) {
    timezone.innerHTML += "+" + offset / 60;
}
else if (Math.sign(offset) == -1) {
    timezone.innerHTML += "-" + offset / 60;
}


