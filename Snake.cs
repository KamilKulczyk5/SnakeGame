using System;
using System.Collections.Generic;

class Snake
{
    private List<(int x, int y)> body = new List<(int, int)>();
    private string direction = "Right";

    public Snake()
    {
        body.Add((10, 10));
    }

    public void ChangeDirection(ConsoleKey key)
    {
        if (key == ConsoleKey.UpArrow && direction != "Down") direction = "Up";
        if (key == ConsoleKey.DownArrow && direction != "Up") direction = "Down";
        if (key == ConsoleKey.LeftArrow && direction != "Right") direction = "Left";
        if (key == ConsoleKey.RightArrow && direction != "Left") direction = "Right";
    }

    public void Move()
    {
        var head = body[0];
        (int x, int y) newHead = direction switch
        {
            "Up" => (head.x, head.y - 1),
            "Down" => (head.x, head.y + 1),
            "Left" => (head.x - 1, head.y),
            _ => (head.x + 1, head.y)
        };

        body.Insert(0, newHead);
        body.RemoveAt(body.Count - 1);
        Draw();
    }

    public void Grow()
    {
        body.Add(body[^1]);
    }

    public bool HasEaten(Food food) => body[0] == food.Position;

    public bool HasCollided()
    {
        var head = body[0];
        if (head.x < 0 || head.y < 0 || head.x >= Console.WindowWidth || head.y >= Console.WindowHeight)
            return true;

        for (int i = 1; i < body.Count; i++)
            if (body[i] == head) return true;

        return false;
    }

    private void Draw()
    {
        Console.Clear();
        foreach (var segment in body)
        {
            Console.SetCursorPosition(segment.x, segment.y);
            Console.Write("O");
        }
    }
}