using System;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        if ( white.Column + white.Row == black.Column + black.Row || white.Column - white.Row == black.Column - black.Row || white.Column == black.Column || white.Row == black.Row)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static Queen Create(int row, int column)
    {
        if (row < 0 || column < 0 || row > 7 || column > 7)
        {
            throw new ArgumentOutOfRangeException("Numbet should be between 0-7");
        }
        else
        {
            var Queen = new Queen(row, column);
            return Queen;
        }
    }
}