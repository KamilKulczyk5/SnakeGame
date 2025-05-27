using System;

class ScoreManager
{
    public int Score { get; private set; } = 0;

    public void AddPoint()
    {
        Score++;
    }
}