function Click(event, args) {
    var userWindow = window,
        browserName = userWindow.navigator.appCodeName,
        IsFirefox = (browserName == "Mozilla");

    if (IsFirefox) {
        alert("Yes");
    } else {
        alert("No");
    }
}
