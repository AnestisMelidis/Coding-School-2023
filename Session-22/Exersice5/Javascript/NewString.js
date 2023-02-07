function incrementString(str) {
    let regex = /\d+$/;
    let match = str.match(regex);
    if (match) {
        let number = parseInt(match[0]) + 1;
        return str.slice(0, -match[0].length) + number;
    } else {
        return str + "1";
    }
}

const inputField = document.getElementById("inputString");
const submitButton = document.getElementById("submitButton");
const outputField = document.getElementById("output");

submitButton.addEventListener("click", function () {
    outputField.innerHTML = incrementString(inputField.value);
});
