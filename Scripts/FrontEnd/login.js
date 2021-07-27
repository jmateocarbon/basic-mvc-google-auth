const signUpButton = document.getElementById('signUp');
const signInButton = document.getElementById('signIn');
const container = document.getElementById('container');


function onSignIn(googleUser) {
    var profile = googleUser.getBasicProfile();
    var a = profile.getName()
    var b = profile.getEmail()
    var account = {
        Name: a,
        Email: b
    }
    console.log(a);
    $.ajax({
        type: 'POST',
        url: '/Home/SignIn',
        contentType: 'application/json',
        data: JSON.stringify(account),
        dataType:'json',
        success: function (data) {
            window.location.href = "/Home/Landing";
        },
        error: function (xhr, textStatus, errorThrown) {
            window.location.href ='/Error/Index';
        }
    });
}
