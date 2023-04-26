// namespace DesignPatterns;
//
// // public interface ISubject
// // {
// //     void Attach(IObserver observer);
// //     void Detach(IObserver observer);
// //     void Notify();
// // }
// //
// // // The ConcreteSubject class implements the Subject interface and maintains a list of its observers.
// // public class WeatherStation : ISubject
// // {
// //     private List<IObserver> _observers = new List<IObserver>();
// //     private int _temperature;
// //
// //     public int Temperature
// //     {
// //         get { return _temperature; }
// //         set
// //         {
// //             _temperature = value;
// //             Notify();  // Notify observers when the temperature changes
// //         }
// //     }
// //
// //     public void Attach(IObserver observer)
// //     {
// //         _observers.Add(observer);
// //     }
// //
// //     public void Detach(IObserver observer)
// //     {
// //         _observers.Remove(observer);
// //     }
// //
// //     public void Notify()
// //     {
// //         foreach (var observer in _observers)
// //         {
// //             observer.Update(this);  // Call the Update method on each observer
// //         }
// //     }
// // }
// //
// // // The Observer interface defines a method for updating its state when it is notified by a subject.
// // public interface IObserver
// // {
// //     void Update(ISubject subject);
// // }
// //
// // // The ConcreteObserver class implements the Observer interface and maintains a reference to the subject it is observing.
// // public class PhoneDisplay : IObserver
// // {
// //     public void Update(ISubject subject)
// //     {
// //         var weatherStation = (WeatherStation)subject;
// //         Console.WriteLine("The temperature is " + weatherStation.Temperature + " degrees.");
// //     }
// // }
//
//
//
//
// // The observer interface
// public interface IObserver {
//     void Update(float temperature, float pressure, float humidity);
// }
//
// // The subject interface
// public interface ISubject {
//     void RegisterObserver(IObserver observer);
//     void RemoveObserver(IObserver observer);
//     void NotifyObservers();
// }
//
// // The concrete subject class
// public class WeatherStation : ISubject {
//     private List<IObserver> observers = new List<IObserver>();
//     private float temperature;
//     private float pressure;
//     private float humidity;
//
//     public void RegisterObserver(IObserver observer) {
//         observers.Add(observer);
//     }
//
//     public void RemoveObserver(IObserver observer) {
//         observers.Remove(observer);
//     }
//
//     public void NotifyObservers() {
//         foreach (IObserver observer in observers) {
//             observer.Update(temperature, pressure, humidity);
//         }
//     }
//
//     public void SetMeasurements(float temperature, float pressure, float humidity) {
//         this.temperature = temperature;
//         this.pressure = pressure;
//         this.humidity = humidity;
//         NotifyObservers();
//     }
// }
//
// // The concrete observer class
// public class Display : IObserver {
//     public void Update(float temperature, float pressure, float humidity) {
//         Console.WriteLine("Temperature: {0}", temperature);
//         Console.WriteLine("Pressure: {0}", pressure);
//         Console.WriteLine("Humidity: {0}", humidity);
//     }
// }