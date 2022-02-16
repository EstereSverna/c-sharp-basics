using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main()
        {
            var animals = new List<Animal>();

            var line = Console.ReadLine();
            while (!line.Equals("End"))
            {
                var animalArguments = line.Split();
                var type = animalArguments[0];

                if (type.Equals("Mouse"))
                {
                    animals.Add(new Mouse(animalArguments[0], animalArguments[1], double.Parse(animalArguments[2]), animalArguments[3]));
                }
                else if (type.Equals("Zebra"))
                {
                    animals.Add(new Zebra(animalArguments[0], animalArguments[1], double.Parse(animalArguments[2]), animalArguments[3]));
                }
                else if (type.Equals("Cat"))
                {
                    animals.Add(new Cat(animalArguments[0], animalArguments[1], double.Parse(animalArguments[2]), animalArguments[3], animalArguments[4]));
                }
                else if (type.Equals("Tiger"))
                {
                    animals.Add(new Tiger(animalArguments[0], animalArguments[1], double.Parse(animalArguments[2]), animalArguments[3]));
                }

                Console.Write("> ");
                Console.WriteLine(animals[^1].MakeSound());

                var foodArgs = Console.ReadLine().Split();
                var foodType = foodArgs[0];
                var quantity = int.Parse(foodArgs[1]);
                var curentFood = new Food[1];

                if (foodType.Equals("Meat"))
                {
                    curentFood[0] = new Meat(quantity);
                }
                else
                {
                    curentFood[0] = new Vegetable(quantity);
                }

                try
                {
                    animals[^1].Eat(curentFood[0]);
                    Console.Write("> ");
                    Console.WriteLine(animals[^1]);
                }
                catch (Exception exception)
                {
                    Console.Write("> ");
                    Console.WriteLine(exception.Message);
                }

                line = Console.ReadLine();
            }
            Console.Write("> ");
            Console.WriteLine(String.Join(", ", animals));
        }
    }
}