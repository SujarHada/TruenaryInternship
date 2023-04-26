// namespace DesignPatterns;
//
// interface ISubject
// {
//     void RegisterObserver(IObserver observer);
//     void RemoveObserver(IObserver observer);
//     void NotifyObservers();
// }
//
//
// interface IObserver
// {
//     void Update(ISubject subject);
// }
//
//
// class BallGame : ISubject
// {
//     private List<IObserver> observers = new List<IObserver>();
//     private Random random = new Random();
//     private int ballHolder;
//
//     public BallGame()
//     {
//         
//         ballHolder = random.Next(1, 6);
//     }
//
//     public void RegisterObserver(IObserver observer)
//     {
//         observers.Add(observer);
//     }
//
//     public void RemoveObserver(IObserver observer)
//     {
//         observers.Remove(observer);
//     }
//
//     public void NotifyObservers()
//     {
//         foreach (IObserver observer in observers)
//         {
//             observer.Update(this);
//         }
//     }
//
//     public int GetBallHolder()
//     {
//         return ballHolder;
//     }
//
//     public void PassBall()
//     {
//         
//         int newHolder = random.Next(1, 6);
//         while (newHolder == ballHolder)
//         {
//             newHolder = random.Next(1, 6);
//         }
//         
//         ballHolder = newHolder;
//
//        
//         NotifyObservers();
//     }
// }
//
//
// class BallGuessingObserver : IObserver
// {
//
//     public int id;
//     
//  
//     public BallGuessingObserver(int id)
//     {
//         this.id = id;
//     }
//
//     public void Update(ISubject subject)
//     {
//         BallGame game = (BallGame)subject;
//         int ballholdedby = game.GetBallHolder();
//         if (id != ballholdedby)
//         {
//             Console.WriteLine("Ball has been passed");
//         }
//         
//         Console.WriteLine($"I guess Subject NO. {id} has the ball.");
//         
//     }
// }
//
