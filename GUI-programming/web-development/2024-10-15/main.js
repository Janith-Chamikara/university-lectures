const inputElement = document.getElementById("name-input");
const submitButton = document.getElementById("submit-button");
console.log(submitButton);
console.log(inputElement);
let submittedName = undefined;
inputElement.addEventListener("change", (e) => {
  console.log(e.target.value);
  submittedName = e.target.value;
});
console.log(submittedName);

submitButton.addEventListener("click", () => onSubmit());

const onSubmit = async () => {
  console.log("Predicting...");
  try {
    const response = await fetch(
      `https://api.genderize.io/?name=${submittedName}`
    )
      .then((res) => res.json())
      .then((res) => res);
    alert(JSON.stringify(response));
    console.log(response);
  } catch (error) {
    console.error(error);
  }
};
