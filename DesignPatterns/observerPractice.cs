// namespace DesignPatterns;
//
// public interface IObserver
// {
//     void Update(string stock, float price);
//     void Addnew(string stock, float price);
// }
//
// public interface ISubject
// {
//     void RegisterObserver(IObserver observer);
//     void RemoveObserver(IObserver observer);
//     void NotifyUpdate();
//     void NotifyNew();
// }
//
// public class Display : IObserver
// {
//     public void Update(string stock, float price)
//     {
//         Console.WriteLine($"Update {stock} is at priced {price}");
//     }
//
//     public void Addnew(string stock , float price)
//     {
//         Console.WriteLine($"New Stock {stock} is added at the price of {price}");
//     }
//     
//     
// }
//
// public class StockMarket : ISubject
// {
//     private List<IObserver> _observers = new List<IObserver>();
//     new Dictionary<string,float> stocklist = new Dictionary<string,float>()
//     {
//         {"Himalaya",300000},
//         {"Everest", 50000},
//         {"Nepal",70000}
//     };
//
//     private string name;
//     private float price;
//   
//     
//         public void RegisterObserver(IObserver observer)
//     {
//         _observers.Add(observer);
//     }
//         
//         public void RemoveObserver(IObserver observer)
//         {
//             _observers.Remove(observer);
//         }
//
//         public void NotifyNew()
//         {
//             foreach (IObserver obj in _observers)
//             {
//                 obj.Addnew( name , price);
//             }
//         }
//
//         public void NotifyUpdate()
//         {
//             foreach (IObserver obj in _observers)
//             {
//                 obj.Update( name, price );
//             }
//         }
//
//         public void Add(string name , float price)
//         {
//             this.name = name;
//             this.price = price;
//             stocklist.Add(name,price);
//             NotifyNew();
//         }
//
//         public void Update(string name, float price)
//         {
//             this.name = name;
//             this.price = price;
//             stocklist[name]= price;
//             NotifyUpdate();
//         }
//
//         public void showAll()
//         {
//             foreach (var stock in stocklist)
//             {
//                 Console.WriteLine(stock);
//             }
//         }
// }
