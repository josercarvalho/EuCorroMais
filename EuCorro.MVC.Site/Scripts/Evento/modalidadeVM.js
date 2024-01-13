var urlEvento = "painel/evento";
var url = window.location.pathname;
var profileId = url.substring(url.lastIndexOf('/') + 1);

$(function () {

    $(".btn-modalidade").on("click", function (e) {
        e.preventDefault();
        adicionaModalidade();
    });

    //Timepicker
    $(".timepicker").timepicker({
        showInputs: false,
        orientation: "bottom auto"
    });

    //$('#Ativo').bootstrapSwitch();
    $('#Ativo').checkboxpicker({
        offLabel: "Não",
        onLabel: "Sim",
        offCls: "btn-default",
        onCls: "btn-default"
    });

    $('#Reverzamento').checkboxpicker({
        offLabel: "Não",
        onLabel: "Sim",
        offCls: "btn-primary",
        onCls: "btn-primary"
    }).on('change', function () {
        $('#equipe').toggle(200);
    });
        
    $('.textarea-wysihtml5').wysihtml5();

    $("input.dinheiro").maskMoney({
        showSymbol: true,
        symbol: "R$",
        decimal: ",",
        thousands: "."
    });

    $("input.desconto").maskMoney({
        symbol: false,
        decimal: '.'
    });

    $(".DataEvento").datepicker({
        format: "dd/mm/yyyy",
        orientation: "bottom auto",
        todayBtn: true,
        language: "pt-BR"
    });

    $(".datas").datepicker({
        format: "dd/mm/yyyy",
        orientation: "bottom auto",
        todayBtn: true,
        language: "pt-BR"
    });

    var $validator = $("#eventoForm").validate({
        rules: {
            Nome: {
                required: true,
                minlength: 3
            },
            DescricaoEvento: {
                required: true,
                minlength: 3
            }
        }
    });

    $("#ddlEstados").on("change", function () {
        var estadoId = $(this).val();
        var url = '/Cadastro/LoadCidadeId/';
        $.getJSON(url, { estadoId: estadoId },
            function (estadosData) {
                $("#ddlCidades :gt(0)").remove();
                var select = $("#ddlCidades");
                select.attr('disabled', false);
                select.empty();
                select.append($('<option/>', {
                    value: 0,
                    text: "Selecione a Cidade... "
                }));
                $.each(estadosData, function (index, itemData) {
                    select.append($('<option/>', {
                        value: itemData.Value,
                        text: itemData.Text
                    }));
                });
            });
    });

    $("#form-precos").validate({
        rules: {
            DataIni: {
                required: true,
            },
            DataFin: {
                required: true,
            },
            HoraIni: {
                required: true,
            },
            HoraFin: {
                required: true,
            },
            Valor: {
                required: true,
            }
        },
        messages: {
            DataIni: "Data inicial obrigatória!",
            DataFin: "Data final obrigatória!",
            HoraIni: "Hora inicial obrigatória!",
            HoraFin: "Hora final obrigatória!",
            Valor: "Valor da inscrição obrigatória.",
        },
        highlight: function (element) {
            //adicionar border-color direto no element.id
            $('#' + element.id).addClass('erro');
        },
        unhighlight: function (element) {
            $('#' + element.id).removeClass('erro');
        },
        errorElement: 'span',
        errorClass: 'help-block',
        errorPlacement: function (error, element) {
            if (element.parent('.input-group').length) {
                error.insertAfter(element.parent());
            } else {
                error.insertAfter(element);
            }
        }
    });

    function adicionaModalidade() {
        $("#divModalidade").slideToggle("slow");
    };

    function formatCurrency(value) {
        return "R$ " + value.toFixed(2);
    };
    
    var VendaModel = function () {
        var self = this;

        self.TipoModalidade = ko.observable('Nova Modalidade');

        // Modalidade
        self.ModalidadeEventoId = ko.observable();
        self.EventoId = ko.observable();
        self.ModalidadeId = ko.observable();
        self.Reverzamento = ko.observable();
        self.AtletasPorEquipe = ko.observable();
        self.Vagas = ko.observable();
        self.NumeroInicial = ko.observable();
        self.NumeroFinal = ko.observable();
        self.IdadeMin = ko.observable();
        self.IdadeMax = ko.observable();
        self.DescricaoPercurso = ko.observable();
        self.PercursoImg = ko.observable();

        // Preços e Descontos
        self.DataIni = ko.observable();
        self.DataFin = ko.observable();
        self.HoraIni = ko.observable();
        self.HoraFin = ko.observable();
        self.Valor = ko.observable();
        self.Desconto = ko.observable();
        self.TipoDesconto = ko.observable();
        self.CodigoDesconto = ko.observable();
        self.ValidadeDesconto = ko.observable();

        // Lista de Preços da Modalidade
        var modalidade = {
            ModalidadeEventoId: self.ModalidadeEventoId,
            EventoId: self.EventoId,
            TipoModalidade: self.TipoModalidade,
            ModalidadeId: self.ModalidadeId,
            Reverzamento: self.Reverzamento,
            AtletasPorEquipe: self.AtletasPorEquipe,
            Vagas: self.Vagas,
            NumeroInicial: self.NumeroInicial,
            NumeroFinal: self.NumeroFinal,
            IdadeMin: self.IdadeMin,
            IdadeMax: self.IdadeMax,
            DescricaoPercurso: self.DescricaoPercurso,
            PercursoImg: self.PercursoImg,
            ListaPrecos: ko.observableArray([])
        };

        // Lista de preços
        var preco = {
            DataIni: self.DataIni,
            DataFin: self.DataFin,
            HoraIni: self.HoraIni,
            HoraFin: self.HoraFin,
            Valor: self.Valor,
            Desconto: self.Desconto,
            TipoDesconto: self.TipoDesconto,
            CodigoDesconto: self.CodigoDesconto,
            ValidadeDesconto: self.ValidadeDesconto
        };

        self.modalidade = ko.observable();
        self.ListaModalidade = ko.observableArray();
        self.ListaPrecos = ko.observableArray()

        //Initialize the view-model  
        $.ajax({
            url: "/Admin/Evento/GetEventoById",
            cache: false,
            type: 'GET',
            contentType: 'application/json; charset=utf-8',
            data: {},
            success: function (data) {
                self.ListaModalidade(data); //Put the response in ObservableArray
            }
        });

        self.addPreco = function () {
            var form = $('#form-precos');
            if (form.valid()) {
                bootbox.alert("Faltando dados Obrigatórios. Verifique!")
            } else {
                self.ListaPrecos.push(preco);
                self.limpar;
            }
        };

        self.checaPrecos = function () {
            var retorno = true;
            if (self.DataIni() === '') { retorno = false; };
            if (self.DataFin() === '') { retorno = false; };
            if (self.HoraIni() === '') { retorno = false; };
            if (self.HoraFin() === '') { retorno = false; };
            if (self.Valor() === '') { retorno = false; };

            return retorno;
        };


        //$.ajax({
        //    url: urlEvento + '/GetEventoById/' + ModalidadeEventoId,
        //    async: false,
        //    dataType: 'json',
        //    cache: false,
        //    type: 'GET',
        //    contentType: 'application/json; charset=utf-8',
        //    data: {},
        //    success: function (json) {
        //        if (json !== null) {
        //            self.ListaModalidade = ko.observable(new modalidade(json));
        //            self.ListaPrecos = ko.observableArray(ko.utils.arrayMap(json.ListaPrecos, function (preco) {
        //                return preco;
        //            }));
        //        } else {
        //            self.modalidade = ko.observable();
        //            self.ListaPrecos = ko.observableArray()
        //        }
        //    }
        //}).fail(function (xhr, textStatus, err) {
        //    bootbox.alert(err);
        //});       }

        self.SaveModalidade = function () {
            var isValid = false;
            var evento = $('#EventoId').val();

            alrt(self.Vagas);
            alert(self.IdadeMax);

            if (evento === '') {
                bootbox.alert("Verifique se o Evento já foi criado e salvo corretament!")
                return;
            }

            if (isValid) {
                self.modadlidade().PrecoDTO = self.ListaPrecos;
                //var profileModalidade = ko.toJS(self.modadlidade)
                //var profilelistaprecos = ko.toJS(self.ListaPrecos);

                $.ajax({
                    type: "POST",
                    cache: false,
                    dataType: 'json',
                    //url: '@Url.Action("Create", "Evento")',
                    url: "/Admin/Evento/Create",
                    data: JSON.stringify(ko.toJS(self.modadlidade)),
                    contentType: 'application/json; charset=utf-8',
                    async: false,
                    success: function () {
                        bootbox.alert("Dados salvos com sucesso!")
                    },
                    error: function (erro) {
                        var err = JSON.parse(erro.responseText);
                        var errors = "";
                        for (var key in err) {
                            if (err.hasOwnProperty(key)) {
                                errors += key.replace("modalidade.", "") + " : " + err[key];
                            }
                        }
                        $("<div></div>").html(errors).dialog({ modal: true, title: JSON.parse(err.responseText).Message, buttons: { "Ok": function () { $(this).dialog("close"); } } }).show();
                    },
                    complete: function (data) {
                        self.ListaModalidade.push(modadlidade);
                        self.cancel();
                        adicionaModalidade();
                    }
                });
            }
        };

        // Edita detailhes da Modadlidade
        self.editModadlidade = function (modalidade) {
            self.modalidade(modalidade);
        };

        // Delete Modadlidade details
        self.deleteModadlidade = function (modalidade) {
            if (bootbox.confirm('Tem certeza que deseja excluir "' + modalidade.Name + '" deste Evento ??')) {
                var id = modalidade.ModalidadeEventoId;

                $.ajax({
                    url: "/Admin/Evento/DelModalidade",
                    //url: '@Url.Action("DelModalidade", "Evento")',
                    cache: false,
                    type: 'POST',
                    contentType: 'application/json; charset=utf-8',
                    data: ko.toJSON(id),
                    success: function (data) {
                        self.modalidade.remove(modalidade);
                        Bootbox.alert(data);
                    }
                }).fail(
                    function (xhr, textStatus, err) {
                        alert(err);
                    });
            }
        };

        //self.addPreco = function () { self.ListaPrecos.push(PrecoLine()); };

        self.removePreco = function (item) {
            bootbox.confirm("Confirma exclusão desse campo?", function (result) {
                if (result) { self.ListaPrecos.remove(item); }
            });
        };

        self.cancela = function () {
            modalidade(null);
        };

        self.limpar = function () {
            self.DataIni('');
            self.DataFin('');
            self.HoraIni('');
            self.HoraFin('');
            self.Valor('');
            self.Desconto('');
        };
    }

    var viewModel = new VendaModel();
    ko.applyBindings(viewModel);
});

var clone = (function () {
    return function (obj) {
        clone.prototype = obj;
        return new clone();
    };
    function clone() { }
}());