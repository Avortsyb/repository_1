using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_laba_oop
{

    // Создаем класс "Car"
    class Car
    {
        // Определяем поле "марка"
        public string brand;

        // Определяем поле "год выпуска"
        public int year;

        // Определяем метод "Старт"
        public void Start()
        {
            Console.WriteLine("Автомобиль {0} завелся!", brand);
        }

        // Определяем метод "Остановка"
        public void Stop()
        {
            Console.WriteLine("Автомобиль {0} остановился.", brand);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект класса "Car"
            Car myCar = new Car();

            // Присваиваем значения полям объекта
            myCar.brand = "Toyota";
            myCar.year = 2020;

            // Вызываем методы объекта
            myCar.Start();
            myCar.Stop();

            // Выводим значения полей объекта
            Console.WriteLine("Марка автомобиля: {0}", myCar.brand);
            Console.WriteLine("Год выпуска автомобиля: {0}", myCar.year);
        }
    }

}
