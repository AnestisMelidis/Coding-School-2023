function reverseString(str) {
    return str.split('').reverse().join('');
}

const inputField = document.getElementById("inputString");
const submitButton = document.getElementById("submitButton");
const outputField = document.getElementById("output");

submitButton.addEventListener("click", function () {
    outputField.innerHTML = reverseString(inputField.value);
});