function isPalindrome(str) {
    return str === str.split('').reverse().join('');
}

const inputField = document.getElementById("inputString");
const submitButton = document.getElementById("submitButton");
const outputField = document.getElementById("output");

submitButton.addEventListener("click", function () {
    outputField.innerHTML = isPalindrome(inputField.value)
        ? "The string is a palindrome."
        : "The string is not a palindrome.";
});
