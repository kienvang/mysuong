jQuery.jalert = function (mesaage, options) {
    $('#jalert .modal-body').html(mesaage);
    $('#jalert').modal('show');
};