var m_txtName = $('#m_txtName');
var m_txtLastName = $('#m_txtLastName');
var m_txtUserName = $('#m_txtUserName');
var m_txtEmail = $('#m_txtEmail');
var m_txtPassword = $('#m_txtPassword');
var m_btnSignUp = $('#m_btnSignUp');

$(document).ready(function () {
    m_btnSignUp.click(function () {
        var user = {};
        var obj = {
            Name: m_txtName.val(),
            LastName: m_txtLastName.val(),
            UserType: null,
            Email: m_txtEmail.val(),
            UserName:m_txtUserName.val(),
            Active: null,
            PassW: m_txtPassword.val()
        };
       
        var dataJson = JSON.stringify({ obj } );
        $.ajax(
        {
            type: "POST",
            url: "SignUp.aspx/Save",
            data: dataJson,
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: OnSuccess,
            failure: function (response) {
                alert(response.d);
            },
            error: function (response) {
                alert(response.d);
            }
        });
        function OnSuccess(response) {
            //ShowMessage(response.d, type)
            alert(response.d);
        };
        

    });
    



});