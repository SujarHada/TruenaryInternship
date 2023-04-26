// namespace DesignPatterns;
//
//     public class Pizza
//     {
//         public string Dough { get; set; }
//         public string Sauce { get; set; }
//         public string Topping { get; set; }
//     }
//
//     public interface IPizzaBuilder
//     {
//         void SetDough(string dough);
//         void SetSauce(string sauce);
//         void SetTopping(string topping);
//         Pizza GetPizza();
//     }
//
//     public class PizzaBuilder : IPizzaBuilder
//     {
//         private readonly Pizza _pizza;
//
//         public PizzaBuilder()
//         {
//             _pizza = new Pizza();
//         }
//
//         public void SetDough(string dough)
//         {
//             _pizza.Dough = dough;
//         }
//
//         public void SetSauce(string sauce)
//         {
//             _pizza.Sauce = sauce;
//         }
//
//         public void SetTopping(string topping)
//         {
//             _pizza.Topping = topping;
//         }
//
//         public Pizza GetPizza()
//         {
//             return _pizza;
//         }
//     }
//
//     public class PizzaDirector
//     {
//         private readonly IPizzaBuilder _builder;
//
//         public PizzaDirector(IPizzaBuilder builder)
//         {
//             _builder = builder;
//         }
//
//         public void BuildVegetarianPizza()
//         {
//             _builder.SetDough("Whole wheat");
//             _builder.SetSauce("Tomato");
//             _builder.SetTopping("Mushrooms");
//         }
//
//         public void BuildPepperoniPizza()
//         {
//             _builder.SetDough("White");
//             _builder.SetSauce("Tomato");
//             _builder.SetTopping("Pepperoni");
//         }
//     }
//
