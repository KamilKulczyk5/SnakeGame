using System;

class Food
{
    public (int x, int y) Position { get; private set; }

    public Food()
    {
        GenerateNew();
    }

    public void GenerateNew()
    {
        Random rand = new Random();
        Position = (rand.Next(0, Console.WindowWidth), rand.Next(0, Console.WindowHeight));
        Console.SetCursorPosition(Position.x, Position.y);
        Console.Write("*");
    }
}
