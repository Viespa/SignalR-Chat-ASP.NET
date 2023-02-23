// "use strict";


// var connection = new signalR.HubConnectionBuilder().withUrl("/chat").build();

// connection.start().then(() => {
//     connection.on("ReceiveMessage", (user, message) => {
//         var message = "<div><b>" + user + " dijo:</b> " + message + "</div>";
//         document.getElementById("messages").innerHTML = message + document.getElementById("messages").innerHTML;
//     })
//     connection.invoke("AddToGroup", "@Model")
// }).catch((e) => console.error(e));


// document.getElementById("btnSend").addEventListener("click", (event) => {

//     let room = "@Model";
//     let user = document.getElementById("user").value;
//     let message = document.getElementById("message").value;

//     connection.invoke("SendMessage", room, user, message).catch((err) => console.error(err.toString()));

//     document.getElementById("message").value = "";
//     document.getElementById("message").focus();

//     event.preventDefault();
// })

