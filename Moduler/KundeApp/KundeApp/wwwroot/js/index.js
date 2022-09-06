$(function () {
    hentAlleKunder();
})

function hentAlleKunder() {
    $.get("kunde/hentAlle", function (kunder) {
        formatKunder(kunder);
    });
}

function formatKunder(kunder) {
    let out = "<table class='table table-striped'>" +
        "<tr>" +
        "<th>Navn</th><th>Adresse</th><th></th><th></th>" + "</tr>";
    for (let kunde of kunder) {
        out += "<tr>" +
            "<td>" + kunde.navn + "</td>" +
            "<td>" + kunde.adresse + "</td> +
        "</tr>";
    }
    out += "</table>"; 
    $("#kundene").html(out)
}