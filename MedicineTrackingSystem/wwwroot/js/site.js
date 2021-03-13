// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $("#Create").click(function (e) {
        e.preventDefault();
        $.ajax({
            type: "POST",
            beforeSend: function (request) {
                request.setRequestHeader("Content-Type", "application/json; charset=utf-8");
            },
            url: "http://localhost:57647/api/Medicine",
            data: {
                id: $("#Id").val(),
                Name: $("#Name").val(),
                Brand: $("#Brand").val(),
                Price: $("#Price").val(),
                Quantity: $("#Quantity").val(),
                ExpiryDate: $("#ExpiryDate").val(),
                Notes: $("#Notes").val()
            },
            
            success: function (result) {
                $("#sharelink").html(result);
            }
        });
    });
});
