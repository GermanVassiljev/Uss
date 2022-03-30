using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uss_1
{
    class Figure
    {
        protected List<Point> pList;//поле списка, в котором будут значения из Point

        public void Draw()//Рисование точке
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure)//Проверка столкновенния
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))//Возрат true или false в зависимости от касания
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)//Проверка столкновенния, который использоует объект класса Point
        {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}