function delModal(id, nome) {
    data.id = id;
    //document.querySelector('#nome-item').innerText = nome;
    $('#dataTipo').text(data.dataTipo);
    $('#nome-item').text(nome);
    $(`#${data.trId}-${data.id}`).addClass('del-modal');
    $('#delModal').modal('show');
}

function confirmarDel() {
    let params = {
        url: `${data.urlDel}/${data.id}`,
        method: 'delete',
        success: () => {
            toastr.success('Item excluído c/ sucesso', 'JD Consultores');
            $(`#${data.trId}-${data.id}`).fadeOut('slow', () => $(this).remove());
        },
        error: (resp) => { toastr.error(resp.statusText, 'JD Consultores'); },
        complete: () => {
            $('#delModal').modal('hide');
        }
    };

    $.ajax(params);
}

$('#delModal').on('hidden.bs.modal', function (e) {
    $(`#${data.trId}-${data.id}`).removeClass('del-modal');
})