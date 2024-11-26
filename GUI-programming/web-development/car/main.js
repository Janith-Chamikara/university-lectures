const car = document.getElementById("car");
const gameContainer = document.getElementById("game-container");
const scoreElement = document.getElementById("score");
const gameOverElement = document.getElementById("game-over");
const finalScoreElement = document.getElementById("final-score");
const restartBtn = document.getElementById("restart-btn");

let carPosition = 180;
let score = 0;
let gameSpeed = 5;
let isGameOver = false;
let animationFrameId;
let obstacles = [];
let coins = [];

function moveLeft() {
  if (carPosition > 0) {
    carPosition -= 10;
    car.style.left = carPosition + "px";
  }
}

function moveRight() {
  if (carPosition < gameContainer.offsetWidth - car.offsetWidth) {
    carPosition += 10;
    car.style.left = carPosition + "px";
  }
}

function handleKeyPress(e) {
  if (isGameOver) return;

  if (e.key === "ArrowLeft") moveLeft();
  if (e.key === "ArrowRight") moveRight();
}

function createObstacle() {
  const obstacle = document.createElement("div");
  obstacle.className = "obstacle";
  obstacle.innerHTML = "💥";
  obstacle.style.left = Math.random() * (gameContainer.offsetWidth - 40) + "px";
  obstacle.style.top = "-40px";
  gameContainer.appendChild(obstacle);
  obstacles.push(obstacle);
}

function createCoin() {
  const coin = document.createElement("div");
  coin.className = "coin";
  coin.innerHTML = "🪙";
  coin.style.left = Math.random() * (gameContainer.offsetWidth - 30) + "px";
  coin.style.top = "-30px";
  gameContainer.appendChild(coin);
  coins.push(coin);
}

function moveObjects() {
  // Move obstacles
  obstacles.forEach((obstacle, index) => {
    const top = parseFloat(obstacle.style.top);
    if (top > gameContainer.offsetHeight) {
      obstacle.remove();
      obstacles.splice(index, 1);
      score += 1;
      scoreElement.textContent = `Score: ${score}`;
    } else {
      obstacle.style.top = top + gameSpeed + "px";
      checkCollision(obstacle);
    }
  });

  // Move coins
  coins.forEach((coin, index) => {
    const top = parseFloat(coin.style.top);
    if (top > gameContainer.offsetHeight) {
      coin.remove();
      coins.splice(index, 1);
    } else {
      coin.style.top = top + gameSpeed + "px";
      checkCoinCollection(coin);
    }
  });
}

function checkCollision(obstacle) {
  const carRect = car.getBoundingClientRect();
  const obstacleRect = obstacle.getBoundingClientRect();

  if (
    carRect.left < obstacleRect.right &&
    carRect.right > obstacleRect.left &&
    carRect.top < obstacleRect.bottom &&
    carRect.bottom > obstacleRect.top
  ) {
    gameOver();
  }
}

function checkCoinCollection(coin) {
  const carRect = car.getBoundingClientRect();
  const coinRect = coin.getBoundingClientRect();

  if (
    carRect.left < coinRect.right &&
    carRect.right > coinRect.left &&
    carRect.top < coinRect.bottom &&
    carRect.bottom > coinRect.top
  ) {
    coin.remove();
    coins = coins.filter((c) => c !== coin);
    score += 5;
    scoreElement.textContent = `Score: ${score}`;
  }
}

function gameOver() {
  isGameOver = true;
  gameOverElement.classList.remove("hidden");
  finalScoreElement.textContent = `Final Score: ${score}`;
  cancelAnimationFrame(animationFrameId);
}

function gameLoop() {
  if (!isGameOver) {
    if (Math.random() < 0.02) createObstacle();
    if (Math.random() < 0.01) createCoin();
    moveObjects();
    animationFrameId = requestAnimationFrame(gameLoop);
  }
}

function startGame() {
  isGameOver = false;
  score = 0;
  gameSpeed = 5;
  carPosition = 180;
  car.style.left = carPosition + "px";
  scoreElement.textContent = `Score: ${score}`;
  gameOverElement.classList.add("hidden");

  // Clear existing obstacles and coins
  obstacles.forEach((obstacle) => obstacle.remove());
  coins.forEach((coin) => coin.remove());
  obstacles = [];
  coins = [];

  gameLoop();
}

document.addEventListener("keydown", handleKeyPress);
restartBtn.addEventListener("click", startGame);

// Start the game initially
startGame();
