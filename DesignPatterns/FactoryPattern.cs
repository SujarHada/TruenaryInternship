namespace DesignPatterns;


// public interface AnimalFactory
// {
//     public Animal CreateAnimal();
// }
//
// public class CatFactory : AnimalFactory
// {
//     public  Animal CreateAnimal()
//     {
//         return new Cat();
//     }
// }
//
// public class DogFactory : AnimalFactory
// {
//     public  Animal CreateAnimal()
//     {
//         return new Dog();
//     }
// }
//
// public class Animal
// {
//     public string Name { get; set; }
// }
//
// public class Cat : Animal
// {
//     public Cat()
//     {
//         Name = "Cat";
//     }
// }
//
// public class Dog : Animal
// {
//     public Dog()
//     {
//         Name = "Dog";
//     }
// }


// The product interface
public interface IProduct {
    void Ship();
}

// Concrete products
public class ProductA : IProduct {
    public void Ship() {
        Console.WriteLine("Product A has been shipped.");
    }
}

public class ProductB : IProduct {
    public void Ship() {
        Console.WriteLine("Product B has been shipped.");
    }
}

// The factory class
public class ProductFactory {
    public IProduct CreateProduct(string productType) {
        switch (productType) {
            case "A":
                return new ProductA();
            case "B":
                return new ProductB();
            default:
                throw new ArgumentException("Invalid product type");
        }
    }
}

