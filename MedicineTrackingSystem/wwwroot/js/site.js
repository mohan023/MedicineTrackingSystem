// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $("#Create").click(function (e) {
        e.preventDefault();
        var _data = {

            id: $("#Id").val(),
            name: $("#Name").val(),
            brand: $("#Brand").val(),
            price: $("#Price").val(),
            quantity: $("#Quantity").val(),
            expiryDate: $("#ExpiryDate").val(),
            notes: $("#Notes").val()
        }

        $.ajax({
            type: "POST",
            url: "http://localhost:57647/api/Medicine",
            //beforeSend: function (request) {
            //    request.setRequestHeader("Content-Type", "application/json; charset=utf-8");
            //},
            data: JSON.stringify(_data),

            contentType: "application/json",

            success: function (result) {
                //$("#sharelink").html(result);
                alert(result);
            },
            error: function (e) {
                console.log(e);
            }
        });
    });
});
