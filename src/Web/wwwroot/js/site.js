// Write your JavaScript code.
$("#btn-open-notepad").click(function () {

    if (window.ShellConnector) {
        window.ShellConnector.OpenNotepad();
    }
    else {
        alert("Not using shell!")
    }
});