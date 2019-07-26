$(function () {
    $('#register').on('click', function () {
        $('.register-popup').dialog('open');
    });
    $('.register-popup').dialog({
        autoOpen: false,
        modal: true,
        width: '280',
        height: '300',
        title: 'Register Here',
        buttons: {
            'Register Now!': function () {
                $.ajax({
                    url: 'path/to/registration/controller',
                    type: 'POST',
                    data: $(this).find('form').serialize(),
                    success: function (data) {
                        console.log('This is where the data is returned from your controller to the web page');
                        $(this).dialog('close');
                    }
                });
            }
        }
    });
});