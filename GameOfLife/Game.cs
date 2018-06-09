
using System;

public class Game
{
    private Field field;//放置所有细胞的网格

    public Field Field { get { return field; }set { field = value; } }

    //新建一个游戏
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

    //随机生成细胞状态
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
    //返回一个存储每个细胞状态的二维数组
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

    //产生下一代
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
    //按照固定样式一设置细胞状态
    public void StyleOne()
    {

    }

}
