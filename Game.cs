using System;
using System.Threading;

class Game
{
    private Snake snake;
    private Food food;
    private ScoreManager scoreManager;

    public void Start()
    {
        snake = new Snake();
        food = new Food();
        scoreManager = new ScoreManager();

        while (true)
        {
            if (Console.KeyAvailable)
                snake.ChangeDirection(Console.ReadKey(true).Key);

            snake.Move();
            scoreManager.DisplayScore();

            if (snake.HasEaten(food))
            {
                snake.Grow();
                scoreManager.AddPoint();
                food.GenerateNew();
            }

            if (snake.HasCollided())
            {
                Console.Clear();
                Console.WriteLine("Game Over! Final Score: " + scoreManager.Score);
                break;
            }

            Thread.Sleep(150);
        }
    }
}
