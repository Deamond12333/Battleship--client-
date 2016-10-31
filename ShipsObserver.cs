using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship_online
{
    class ShipsObserver
    {
        private bool[,] buffer;
        private int[] countOfShips;
        private int allCount;
        private int[,] field {get; set;}
        public ShipsObserver(int[, ] field)
        {
            buffer = new bool[10, 10];
            countOfShips = new int[4];
            allCount = 0;
            this.field = field;
        }

        public void observe()
        {
            while (allCount < 10)
            {
                int i = 0, j = 0, neighbours = 1;
                bool down = false;
                for (i = 0; i < 10; ++i)
                {
                    for (j = 0; j < 10; ++j)
                    {
                        if (buffer[i, j]) continue;
                        buffer[i, j] = true;
                        if (field[i, j] == 0) continue;
                        goto n;
                    }
                }

              n:while (true)
                {
                    if ((i + neighbours <= 9) && (field[i + neighbours, j] == 1) && !down)
                    {
                        buffer[i + neighbours, j] = true;
                        neighbours++;
                    }
                    else if ((j + neighbours <= 9) && (field[i, j + neighbours] == 1))
                    {
                        buffer[i, j + neighbours] = true;
                        neighbours++;
                        down = true;
                    }
                    else break;
                }
                switch (neighbours)
                {
                    case 1:
                        {
                            countOfShips[0]++;
                            if (countOfShips[0] > 4) throw new Exception("Слишком много 1х-палубных кораблей!");
                        } break;

                    case 2:
                        {
                            countOfShips[1]++;
                            if (countOfShips[1] > 3) throw new Exception("Слишком много 2х-палубных кораблей!");
                        } break;

                    case 3:
                        {
                            countOfShips[2]++;
                            if (countOfShips[2] > 2) throw new Exception("Слишком много 3х-палубных кораблей!");
                        } break;

                    case 4:
                        {
                            countOfShips[3]++;
                            if (countOfShips[3] > 1) throw new Exception("Слишком много 4х-палубных кораблей!");
                        } break;
                    default: throw new Exception("Обнаружен слишком длинный корабль!");
                }

                int px, py;
                if (down)
                {
                    px = 1;
                    py = neighbours;
                }
                else
                {
                    px = neighbours;
                    py = 1;
                }
                for (int x = -1; x <= px; ++x)
                {
                    for (int y = -1; y <= py; ++y)
                    {
                        if ((i + x < 0) || (j + y < 0)) continue;
                        if ((i + x > 9) || (j + y > 9)) continue;
                        if ((y > -1 && y < py) && (x > -1 && x < px)) continue;
                        if (field[i + x, j + y] == 1) throw new Exception("Возможно, не выдержано расстояние в 1 клетку! Координаты ["+(i+x)+", "+(j+y)+"]");
                        else buffer[i + x, j + y] = true;
                    }
                }
                allCount++;
            }
        }
        public void randomShipsArrangement()
        {
            int count = 4, length = 1;
            Random r = new Random((int)(DateTime.Now.Ticks % int.MaxValue));
            while (length < 5)
            {
                for (int i = 0; i <= count; ++i)
                {
                    int x = r.Next(10), y = r.Next(10), down = r.Next(2), dx, dy;
                    if (down == 0)// прямо
                    {
                        dx = count;
                        dy = 1;
                    }
                    else
                    {
                        dy = count;
                        dx = 1;
                    }
                    for (int px = x - 1; px <= x + dx; ++px)
                    {
                        for (int py = y - 1; py <= y + dy; ++py)
                        {

                        }
                    }
                }
            }
        }
    }
}
