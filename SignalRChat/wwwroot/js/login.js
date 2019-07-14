
window.connectionUrl = "";

document.getElementById("okButton").addEventListener("click", function (event) {
    event.preventDefault();
    var agentNumber = document.getElementById("agentInput").value;
    window.connectionUrl = "/chatHub?agentNumber=" + agentNumber;
    localStorage.setItem('connectionUrl', window.connectionUrl);
    window.location.href = '/Login';
});