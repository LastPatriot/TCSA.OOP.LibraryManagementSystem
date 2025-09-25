using Spectre.Console;
using TCSA.OOP.LibraryManagementSystem;

// UserInterface.MainMenu();

UserInterface userInterface = new UserInterface();
userInterface.MainMenu();


// internal abstract class Animal
// {
//     public string Name { get; set; }
//     public int Age { get; set; }

//     protected Animal(string name, int age)
//     {
//         name = Name;
//         age = Age;
//     }
//     public abstract void MakeSound();
// }

// internal class Dog : Animal
// {
//     public Dog(string name, int age)
//         : base(name, age)
//     {
//     }
//     public override void MakeSound()
//     {
//         System.Console.WriteLine($"{Name} says: Woof!"); ;
//     }
// }

// internal class Cat : Animal
// {
//     public Cat(string name, int age) 
//         : base(name, age) // Calling the base class constructor
//     {
//     }

//     public override void MakeSound()
//     {
//         Console.WriteLine($"{Name} says: Meow!");
//     }
// }
// Animal myDog = new Dog("Buddy", 3);
// Animal myCat = new Cat("Whiskers", 2);

// myDog.MakeSound(); // Output: Buddy says: Woof!
// myCat.MakeSound(); // Output: Whiskers says: Meow!

// var book1 = new Book("Hamlet", 200);
// var book2 = new Book("Great Gatsby", 300);

// Car car1 = new Car();
// Car car2 = new Car();

// car1.name = "Ferrari";
// car2.name = "BMW";

// car1.PrintName();
// car2.PrintName();
// class Car()
// {
//     internal string name;
//     internal void PrintName()
//     {
//         name = name.ToUpper();
//         System.Console.WriteLine($"I'm a {name}");
//     }
// }
