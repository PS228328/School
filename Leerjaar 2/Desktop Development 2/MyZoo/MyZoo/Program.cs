// See https://aka.ms/new-console-template for more information
using MyZoo;

List<Animal> dieren = new List<Animal>();
Dog dog = new Dog();
Cat cat = new Cat();
Tiger tiger = new Tiger();
Wolf wolf = new Wolf();
Hippo hippo = new Hippo();
Lion lion = new Lion();

dieren.Add(dog);
dieren.Add(cat);
dieren.Add(tiger);
dieren.Add(wolf);
dieren.Add(hippo);
dieren.Add(lion);

dog.BeFriendly();

foreach (Animal animal in dieren)
{
    Console.WriteLine(".......");
    Console.WriteLine(animal.GetType());
    animal.MakeNoise();
}
