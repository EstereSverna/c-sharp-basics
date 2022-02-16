using System;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {
        public static void Main(string[] args)
        {
            var cars = new List<ICar>();
            cars.Add(new Audi());
            cars.Add(new Bmw());
            cars.Add(new Lexus());
            cars.Add(new Tesla());
            cars.Add(new Lada());
            cars.Add(new Volvo());

            for(int i = 1; i <= 10; i++)
            {
                foreach(var car in cars)
                {
                    if(i == 1)
                    {
                        Console.WriteLine(car.StartEngine());
                        continue;
                    }

                    else if(i == 3 )
                    {
                        if(car is IBoostable boostable)
                        {
                            boostable.UseNitrousOxideEngine();
                            continue;
                        }
                    }

                    car.SpeedUp();
                }
            }

            foreach(var car in cars)
            {
                Console.WriteLine($"{car.GetType().Name} : {car.ShowCurrentSpeed()}");
            }    
        }
    }
}
