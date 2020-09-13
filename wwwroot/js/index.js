$(document).ready(function () {
    var x = 0;

    console.log("Hello ps");


    var theForm = $("#theForm");
    theForm.hide();


    var btn = $("#buyButton");
    btn.on("click", function () {
        console.log("buying item");
    });

    var prod = $(".product-props li");

    prod.on("click", function () {
        console.log("you clicked " + $(this).text())

    });

    var $loginToggle = $("#loginToggle");
    var $popupForm = $(".popup-form");

    $loginToggle.on("click", function () { $popupForm.toggle(1000) });

});