﻿
    var GlobalFunction = {
        AjaxBegin: function () {
            toastr.remove();
            toastr.options = {
                "closeButton": false,
                "debug": false,
                "newestOnTop": true,
                "progressBar": true,
                "positionClass": "toast-top-right",
                "preventDuplicates": false,
                "onclick": null,
                "showEasing": "swing",
                "hideEasing": "linear",
                "showMethod": "fadeIn",
                "hideMethod": "fadeOut"
            };

            toastr.success("Processing Request...");
        },
        
        AjaxSuccess: function (data) {
            toastr.remove();
            toastr.options = {
                "closeButton": false,
                "debug": false,
                "newestOnTop": true,
                "progressBar": true,
                "positionClass": "toast-top-right",
                "preventDuplicates": false,
                "onclick": null,
                "hideDuration": "1000",
                "timeOut": "5000",
                "extendedTimeOut": "1000",
                "showEasing": "swing",
                "hideEasing": "linear",
                "showMethod": "fadeIn",
                "hideMethod": "fadeOut"
            };

            if (data.status === 1) {
                toastr.success(data.message);

                if (data.returnUrl !== null) {
                    window.location.reload;
                }
                //callback(data);
            }
            else {
                toastr.error(data.message);
            }
        }
    };