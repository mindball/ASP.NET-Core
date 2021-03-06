let token = null;

function login() {
    let username = $('#username-login').val();
    let password = $('#password-login').val();
    
	checkUserDataInput(username, password);	
	
    //clear input field
    $('#username-login').val('');
    $('#password-login').val('');

    let requestBody = {
        username: username,
        password: password
    };

    console.log(requestBody);
    $('#guest-navbar').hide();
    $('#caption').text('Welcome to Chat-Inc!');
    hideLoginAndRegisterAndShowLoggedInData();

    

    $.post({
        url: APP_SERVICE_URL + 'users/login',
        contentType: 'application/json',
        data: JSON.stringify(requestBody),        
        success: function (data) {
            // CHANGE CAPTION TO 'Welcome to Chat-Inc!'
            hideGuestNavbar();
            $('#guest-navbar').hide();
            $('#caption').text('Welcome to Chat-Inc');
           
            token = data.rawHeader + 
                '.' + 
                data.rawPayload + 
                '.' +
                data.rawSignature;

            console.log(token);

            saveToken(token);

            $('#username-logged-in').text(getUser());
            
            // Save token to localStorage using saveToken()
            // EXTRACT FROM JWT TOKEN currently logged in user's username
            // Logged-in-data visualize
            // Hide Guest Navbar

            hideLoginAndRegisterAndShowLoggedInData();
        },
        error: function (error) {
            console.error(error);
        }
    });
}

function register() {
    let username = $('#username-register').val();
    let password = $('#password-register').val();

	checkUserDataInput(username, password);	
	
    $('#username-register').val('');
    $('#password-register').val('');

    let requestBody = {
        username: username,
        password: password
    };

    $.post({
        url: APP_SERVICE_URL + 'users/register',
        data: JSON.stringify(requestBody),
		contentType: 'application/json',
		dataType:"json",
        success: function (data) {
            // toggleLogin();
        },
        error: function (error) {
            console.error(error);
        }
    });
}

function toggleLogin() {
    $('#login-data').show();
    $('#register-data').hide();
}

function toggleRegister() {
    $('#login-data').hide();
    $('#register-data').show();
}

function hideLoginAndRegisterAndShowLoggedInData() {
    $('#login-data').hide();
    $('#register-data').hide();

    $('#logged-in-data').show();
}

function hideGuestNavbar() {
    $('#guest-navbar')
    .removeClass('d-block')
    .addClass('d-none');
}

function showGuestNavbar() {
    $('#guest-navbar')
    .removeClass('d-none')
    .addClass('d-block');
}

function showLoginAndHideLoggedInData() {
    toggleLogin();

    $('#logged-in-data').hide();
}

function logout() {
    // TODO: Copy Functionality described in the Exercise
    $('#caption').text('Choose your username to begin chatting!');
    showGuestNavbar();

    showLoginAndHideLoggedInData();
}

function saveToken(token) {
    localStorage.setItem('auth_token', token);
}

function evictToken() {
    localStorage.removeItem('auth_token', token);
}

function getUser() {
    let token = localStorage.getItem('auth_token');

    let claims = token.split('.')[1];
    let decodedClaims = atob(claims);
    let parsedClaims = JSON.parse(decodedClaims);   

    return parsedClaims.nameid;
}

function isLoggedIn() {
    return localStorage.getItem('auth_token') != null;
}

function checkUserDataInput(username, password) {	
	if(username.length === 0 || password.length === 0) {
		alert('username or password not be emtpy');
		return;
	}
}
$('#logged-in-data').hide();
toggleLogin();