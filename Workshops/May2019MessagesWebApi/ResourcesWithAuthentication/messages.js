function renderMessages(data) {
    $('#messages').empty();

    for(let message of data) {
        $('#messages')
            .append('<div class="message d-flex justify-content-start"><strong>'
                + (message.user = getUser())
                + '</strong>: '
                + message.content
                +'</div>')
    }
}

function loadMessages() {
    $.get({
        url: appUrl + 'messages/all',
        success: function success(data) {
            console.log(data);
            renderMessages(data);
        },
        error: function error(error) {
            console.log(error);
        }
    });
}

function createMessage() {
    let message = $('#message').val();

    if(!isLoggedIn()) {
        alert('You cannot send a message before logging in!');
        return;
    }

    if(message.length === 0) {
        alert('You cannot send empty messages!');
        return;
    }


    let username = getUser();
    let token = localStorage.getItem('auth_token');
    console.log(username);

    $.post({
        url: appUrl + 'messages/create',
        headers: {
            'Content-Type': 'application/json',
            'Authorization': 'Bearer ' + token
        },
        data: JSON.stringify({content: message, user: username}),
        success: function success(data) {
            loadMessages();
        },
        error: function error(error) {
            console.log(error);
        }
    });
}