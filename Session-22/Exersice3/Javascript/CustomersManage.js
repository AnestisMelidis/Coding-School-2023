const nameInput = document.getElementById("nameInput");
const surnameInput = document.getElementById("surnameInput");
const ageInput = document.getElementById("ageInput");
const genderInput = document.getElementById("genderInput");
const submitButton = document.getElementById("submitButton");
const customersTableBody = document.getElementById("customersTableBody");
const selectedNameInput = document.getElementById("selectedNameInput");
const selectedSurnameInput = document.getElementById("selectedSurnameInput");
const selectedAgeInput = document.getElementById("selectedAgeInput");
const selectedGenderInput = document.getElementById("selectedGenderInput");

let customers = [];

submitButton.addEventListener("click", function (event) {
    event.preventDefault();
    customers.push({
        name: nameInput.value,
        surname: surnameInput.value,
        age: ageInput.value,
        gender: genderInput.value
    });
    renderCustomersTable();
});

function renderCustomersTable() {
    customersTableBody.innerHTML = "";
    customers.forEach(function (customer) {
        const tr = document.createElement("tr");
        tr.addEventListener("click", function () {
            selectedNameInput.value = customer.name;
            selectedSurnameInput.value = customer.surname;
            selectedAgeInput.value = customer.age;
            selectedGenderInput.value = customer.gender;
        });
        tr.innerHTML = `
      <td>${customer.name}</td>
      <td>${customer.surname}</td>
      <td>${customer.age}</td>
      <td>${customer.gender}</td>
    `;
        customersTableBody.appendChild(tr);
    });
}