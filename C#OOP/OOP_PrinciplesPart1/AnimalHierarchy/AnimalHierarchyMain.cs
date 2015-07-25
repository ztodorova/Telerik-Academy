/*
 * Problem 3. Animal hierarchy

Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).
 */

namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class AnimalHierarchyMain
    {
        static void Main()
        {
            Dog rex = new Dog("Rex", 2, Sex.male);
            Frog froggy = new Frog("Froggy", 1, Sex.female);
            Cat maca = new Cat("Maca", 2, Sex.female);
            Kitten kitty = new Kitten("Kitty", 1);
            Tomcat tom = new Tomcat("Tom", 3);


            List<Animal> animals = new List<Animal> { rex, froggy, maca, kitty, tom };

            foreach (var animal in animals)
            {
                Console.WriteLine("{0} says: {1}",animal.Name,animal.ProduceSound());
            }

            Console.WriteLine();

            Dog[] dogs = new Dog[] {
                                    new Dog("Sharo", 1,Sex.male),
                                    new Dog("Rex", 4, Sex.male),
                                    new Dog("Lady", 3, Sex.female )    
                                   };

            Frog[] frogs = new Frog[] {
                                        new Frog("Kikirica", 5, Sex.female),
                                        new Frog("LudaJaba", 3, Sex.female),
                                        new Frog("Froggy", 2,Sex.male)
                                      };

            Kitten[] kittens = new Kitten[] {
                                               new Kitten("Kitty",1),
                                               new Kitten("Lazy",2)
                                             };

            
            Console.WriteLine("Average age of the dogs: {0:F2}",Animal.AverageAge(dogs));
            Console.WriteLine("Average age of the frogs: {0:F2}",Animal.AverageAge(frogs));
            Console.WriteLine("Average age of the kittens: {0:F2}", Animal.AverageAge(kittens));

            Console.WriteLine();

        }
    }
}
