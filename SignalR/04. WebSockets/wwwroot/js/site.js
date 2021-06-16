listen = (id) => {
    const socket = new WebSocket(`wss://localhost:5001/Coffee/${id}`);

    socket.onmessage = event => {
        document.getElementById("status").innerHTML = JSON.parse(event.data);
    };

    // We can send data back to the server: socket.send();
};

document.getElementById("submit").addEventListener("click", e => {
    e.preventDefault();
    const productValue = document.getElementById("product").value;
    const sizeValue = document.getElementById("size").value;
    fetch("/Coffee",
        {
            method: "POST",
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({ product: productValue, size: sizeValue })
        })
        .then(response => response.text())
        .then(id => {
            document.getElementById("status").innerHTML = `Starting coffee #${id}`;
            listen(id);
        });
});
