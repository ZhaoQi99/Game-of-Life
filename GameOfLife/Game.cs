
using System;

public class Game
{
    private Field field;

    public Field Field { get { return field; }set { field = value; } }

    public Game(int width, int height)
    {
        field = new Field(width, height);
        for (int row = 0; row < field.getHeight(); row++)
        {
            for (int col = 0; col < field.getWidth(); col++)
            {
                field.place(row, col, new Cell());
            }
        }
    }
    public void Rand()
    {
        Random rand = new Random();
        for (int row = 0; row < Field.getHeight(); row++)
        {
            for (int col = 0; col < Field.getWidth(); col++)
            {
                Cell cell = Field.get(row, col);
                if (rand.NextDouble() < 0.4)
                {
                    cell.reborn();
                }
            }
        }
    }
    public bool[,] cellStatus()
    {
        bool[,] status = new bool[field.getHeight(), field.getWidth()];
        for (int row = 0; row < field.getHeight(); row++)
        {
            for (int col = 0; col < field.getWidth(); col++)
            {
                Cell cell = field.get(row, col);
                status[row, col] = cell.isAlive();
            }
        }
        return status;
    }

    public void generation()
    {
        Field f = new Field(field.getHeight(), field.getWidth());
        for (int row = 0; row < f.getHeight(); row++)
        {
            for (int col = 0; col < f.getWidth(); col++)
            {
                f.place(row, col, new Cell());
            }
        }

        for (int row = 0; row < field.getHeight(); row++)
        {
            for (int col = 0; col < field.getWidth(); col++)
            {
                Cell temp = f.get(row, col);
                Cell[] neighbour = field.getNeighbour(row, col);
                int numOfLive = 0;
                foreach (Cell c in neighbour)
                {
                    if (c.isAlive())
                    {
                        numOfLive++;
                    }
                }
                if (numOfLive > 3 || numOfLive < 2)
                {
                    temp.die();
                }
                else if (numOfLive == 3)
                {
                    temp.reborn();
                }
            }
        }
        field = f;
    }
    public void StyleOne()
    {

    }

}
