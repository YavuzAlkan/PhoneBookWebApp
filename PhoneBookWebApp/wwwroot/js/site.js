// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
    $(".myTable").DataTable({
        responsive: true,
        scrollX: true
    })

    $(".dt-length label").html("")
    $(".dt-info").html("").css({
        'display': "none"
    })
    $(".dt-search label").html("Arama: ")

    $("#uploadStudentImage").on("change", function () {
        if (this.files && this.files[0]) {
            $("#imageStudent").attr("src", URL.createObjectURL(this.files[0]))
        }
    })
})