document.addEventListener("DOMContentLoaded", () => {
  const lightEffectContainer = document.querySelector(
    ".light-effect-container"
  );
  const fallingManContainer = document.querySelector(".falling-man-container");

  setTimeout(() => {
    lightEffectContainer.style.transition =
      "opacity 1.5s ease-out, transform 1.5s ease-out";
    lightEffectContainer.style.opacity = "1";
    lightEffectContainer.style.transform = "scale(1)";
  }, 10);

  setTimeout(() => {
    fallingManContainer.style.transition =
      "opacity 1s ease-out, transform 1s ease-out";
    fallingManContainer.style.opacity = "1";
    fallingManContainer.style.transform = "translate(-50%, -50%)";
  }, 1000);
});
