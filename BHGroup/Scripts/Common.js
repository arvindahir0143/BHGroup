//$(document).ready(function () {
//    //init CkEditor
//    name = ".HtmlEditor";
//    delete CKEDITOR.instances[name];
//    $(name).ckeditor({ toolbar: "Basic" });

//});

//Append Random Parameter to URL to avoid caching
$(document).ajaxSend(function (event, request, settings) {
    var randomNum = Math.floor((Math.random() * 999) + 1); //returns random no between 1 to 999
    if (settings.url.indexOf('?') > 0)
        settings.url = settings.url + "&rand_ie=" + randomNum;
    else
        settings.url = settings.url + "?rand_ie=" + randomNum;
});

//$.validator.setDefaults({
//    ignore: ':hidden, [readonly=readonly]'
//});

//Common Ajax Error
jQuery(document).ajaxError(function (event, jqXHR, settings, exception) {
    if (jqXHR.status === 0) {
        alert('Not connect.\n Verify Network.');
    } else if (jqXHR.status == 401) {
        alert("Sorry session timeout, You will be redirected to login page.")
        window.location.reload();
    } else if (jqXHR.status == 404) {
        alert('Requested page not found. [404]');
    } else if (jqXHR.status == 500) {
        alert('Internal Server Error [500].');
    } else if (exception === 'parsererror') {
        alert('Requested JSON parse failed.');
    } else if (exception === 'timeout') {
        alert('Time out error.');
    } else if (exception === 'abort') {
        alert('Ajax request aborted.');
    } else {
        alert('Uncaught Error.\n' + jqXHR.responseText);
    }
});

//**********JQ Grid**************
var JQ_sopt_int = JSON.parse('{"sopt": ["eq","ne","le","lt","gt","ge"]}');
var JQ_sopt_string = JSON.parse('{"sopt": ["cn","eq"]}');
var JQ_sopt_bool = JSON.parse('{"sopt": ["eq","ne"], "value": ":All;True:Yes;False:No"}');
var JQ_sopt_status = JSON.parse('{"sopt": ["eq","ne"], "value": ":All;Active:Active;InActive:InActive"}');
var JQ_sopt_date = JSON.parse('{"sopt": ["eq","ge","le"]}');

var JQ_DateFormat = 'm/d/Y';

function ReloadGrid(grid) {
    $("#" + grid).trigger('reloadGrid');
}
//**********JQ Grid**************

function SuccessMessage(data) {
    if (data == null || data.length <= 0)
        return;

    $('body').showMessage({
        'thisMessage': [data],
        className: 'success',
        displayNavigation: false,
        location: 'top',
        autoClose: true
    });
}

function ErrorMessage(data) {
    if (data == null || data.length <= 0)
        return;

    $('body').showMessage({
        'thisMessage': [data],
        className: 'fail',
        displayNavigation: false,
        location: 'top',
        useEsc: false,
        autoClose: true
    });
}

//jQuery(document).ready(function () {
//    //for apply changes of datepicker througoht the Project.
//    $(".bts_datepicker").datepicker({
//        format: "mm/dd/yy", autoclose: true, todayHighlight: true
//    });
//});

//Replace All
String.prototype.replaceAll = function (find, replace) {
    var str = this;
    return str.replace(new RegExp(find.replace(/[-\/\\^$*+?.()|[\]{}]/g, '\\$&'), 'g'), replace);
};


//$.validator.methods.date = function (value, element) {
//    return this.optional(element) || (/^\d{1,2}[\/-]\d{1,2}[\/-]\d{4}(\s\d{2}:\d{2}(:\d{2})?)?$/.test(value)
//    && !/Invalid|NaN/.test(new Date(value.substr(6, 4) + '-' + value.substr(3, 2) + '-' + value.substr(0, 2))));
//}

//Set PopUp Dialog at Center
function Set_Dialog_at_Center(dialog_ID) {    
    var offset = $(document).scrollTop();
    var viewportHeight = $(window).height();// Get the window viewport height    
    $myDialog = $('#' + dialog_ID);// cache your dialog element        
    $myDialog.css('margin', (offset + (viewportHeight / 2)) - ($myDialog.outerHeight() / 2));// now set your dialog position
}

//Get URL Parameter
function GetURLParameter(sParam) {
    var sPageURL = window.location.search.substring(1);
    var sURLVariables = sPageURL.split('&');
    for (var i = 0; i < sURLVariables.length; i++) {
        var sParameterName = sURLVariables[i].split('=');
        if (sParameterName[0] == sParam) {
            return sParameterName[1];
        }
    }
}

//If User Confirm then Call Argument Function 
function ConfirmAndCall(funName, args) {
    $("#dialog-confirm").removeClass('hide').dialog({
        resizable: false,
        modal: true,
        title: "<div class='widget-header'><h4 class='smaller'><i class='ace-icon fa fa-exclamation-triangle red'></i> Delete </h4></div>",
        title_html: true,
        buttons: [
            {
                html: "<i class='ace-icon fa fa-trash-o bigger-110'></i>&nbsp; Ok &nbsp;",
                "class": "btn btn-danger btn-xs",
                click: function () {
                    window[funName](args);
                    $(this).dialog("close");
                    return true;
                }
            }
            ,
            {
                html: "<i class='ace-icon fa fa-times bigger-110'></i>&nbsp; Cancel",
                "class": "btn btn-xs",
                click: function () {
                    $(this).dialog("close");
                    return false;
                }
            }
        ]
    });
}