using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Game game = new Game(30, 30);
            for (int row = 0; row < game.Field.getHeight(); row++)
            {
                for (int col = 0; col < game.Field.getWidth(); col++)
                {
                    Cell cell = game.Field.get(row, col);
                    Random rand = new Random();
                    if (rand.Next(0, 1) < 0.2)
                    {
                        cell.reborn();
                    }
                }
            }
            for (int i = 0; i < 1000; i++)
            {
                for (int row = 0; row < game.Field.getHeight(); row++)
                {
                    for (int col = 0; col < game.Field.getWidth(); col++)
                    {
                        Cell cell = game.Field.get(row, col);
                        Cell[] neighbour = game.Field.getNeighbour(row, col);
                        int numOfLive = 0;
                        foreach (Cell c in neighbour)
                        {
                            if (c.isAlive())
                            {
                                numOfLive++;
                            }
                        }
                        if (cell.isAlive())
                        {
                            if (numOfLive < 2 || numOfLive > 3)
                            {
                                cell.die();
                                Console.WriteLine("die");
                            }
                        }
                        else if (numOfLive == 3)
                        {
                            cell.reborn();
                            Console.WriteLine("reboren");
                        }
                        Console.WriteLine("66");
                        //System.out.println();
                    }
                }


            }
        }
    }
}
