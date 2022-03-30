using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uss_1
{
    class FoodCreator
    {
        //создание значений пространства и сомвола еды
        int mapWidth;
        int mapHeight;
        char sym;

        Random random = new Random();

        public FoodCreator(int mapWidth, int mapHeight, char sym)//Конструктор создания еды
        {
            this.mapWidth = mapWidth;//Присваиваем к полям значения
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood() // Генерация еды в случайной точке
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}