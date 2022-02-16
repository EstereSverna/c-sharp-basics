using System;

namespace exercise_7
{
    internal class DogTest
    {
        static void Main()
        {
            var max = new Dog("Max", "male");
            var rocky = new Dog("Rocky", "male");
            var sparky = new Dog("Sparky", "male");
            var buster = new Dog("Buster", "male");
            var sam = new Dog("Sam", "male");
            var lady = new Dog("Lady", "female");
            var molly = new Dog("Molly", "female");
            var coco = new Dog("Coco", "female");

            max.SetMother(lady);
            max.SetFather(rocky);
            coco.SetMother(molly);
            coco.SetFather(buster);
            rocky.SetMother(molly);
            rocky.SetFather(sam);
            buster.SetMother(lady);
            buster.SetFather(sparky);

            coco.FathersName();
            sparky.FathersName();
            Console.WriteLine(coco.HasSameMotherAs(rocky));
        }
    }
}
