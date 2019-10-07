// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

    $('.summernote').summernote({
        height: 350,
        tooltip: false,
        lang: 'pt-BR',
        toolbar: [
            ['style', ['style']],
            ['font', ['bold', 'italic', 'underline', 'clear']],
            ['fontname', ['fontname']],
            ['color', ['color']],
            ['para', ['ul', 'ol', 'paragraph']],
            ['table', ['table']],
            ['insert', ['gxcode', 'link', 'picture', 'video', 'hr']],
            ['view', ['fullscreen', 'codeview', 'help']],
        ],
        fontNames: ['Arial', 'Arial Black', 'Comic Sans MS', 'Courier New'],
        popover: {
            image: [],
            link: [],
            air: []
        }
    });

    var v = $('#formAddEditBC').validate({
        // Excluí-lo da Validação
        ignore: ":hidden:not(#summernote),.note-editable.panel-body"
    });

    // Configurando o Summernote para a validação do form (asp-validation-for)
    var summer = $('#summernote');

    summer.summernote({
        callbacks: {
            onChange: function (contents, $editable) {

                // Observe que, neste momento, o valor da `textarea` não é o mesmo que você inseriu no editor Summernote, 
                // portanto, você deve configurá-lo para tornar a validação consistente e sincronizada com o valor.
                summer.val(summer.summernote('isEmpty') ? "" : contents);

                // You should re-validate your element after change, because the plugin will have
                // no way to know that the value of your `textarea` has been changed if the change
                // was done programmatically.
                v.element(summer);
            }
        }
    });

    $('#dtBasicExample').DataTable();
    $('.dataTables_length').addClass('bs-select');
});

function ExcluirDepto(id, descdepto) {

    let resp = confirm(`Deseja excluir o departamento ${descdepto}?`);

    if (resp) {
        // xmlhttprequest
        let xhr = new XMLHttpRequest();

        xhr.open('delete', `/SOL_Depto/Excluir/${id}`);

        xhr.onloadend = function () {
            if (xhr.status == 200) {
                document.querySelector(`#depto-${id}`).remove();
            } else {
                alert(`O departamento de id ${id} não foi encontrado!`);
            }
        }
        xhr.send();
    }
}

function ExcluirTipoVisual(id, desctipo) {

    let resp = confirm(`Deseja excluir o Tipo de Visualização ${desctipo}?`);

    if (resp) {
        // xmlhttprequest
        let xhr = new XMLHttpRequest();

        xhr.open('delete', `/TipoVisualizacao/Excluir/${id}`);

        xhr.onloadend = function () {
            if (xhr.status == 200) {
                document.querySelector(`#tipovisual-${id}`).remove();
            } else {
                alert(`O Tipo de Visualizacao de id ${id} não foi encontrado!`);
            }
        }
        xhr.send();
    }
}

function TesteToast() {
    toastr.success("teste");
}