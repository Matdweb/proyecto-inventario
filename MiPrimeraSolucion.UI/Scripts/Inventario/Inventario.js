let table = new DataTable('#laTableDelInventario');

$(document).ready(function () {

    $('#alertaNormal').click(function () {
        alert('Esta es una alerta normal.');
    });

    $('#alertaSweet').click(function () {
        Swal.fire({
            title: "Good job!",
            text: "Hola Mundo!",
            icon: "success"
        });
    });
});