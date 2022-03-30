using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uss_1
{
    class Point
    {
        //Поля значений x, y и символов
        public int x;
        public int y;
        public char sym;

        public Point() { }

        public Point(int x, int y, char sym)
        {
            this.x = x; //Присваеваем полям значения
            this.y = y;
            this.sym = sym;
        }

        public Point(Point p)
        {
            x = p.x; //Заменяем старые значения на новые
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)//удаление или добавление точек в зависимости от движения
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }

        public bool IsHit(Point p)//поедание еды
        {
            return p.x == this.x && p.y == this.y;
        }

        public void Draw()//Отрисовка точек
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()//отчистка
        {
            sym = ' ';
            Draw();
        }
        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}