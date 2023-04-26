namespace DesignPatterns;


interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}


interface IObserver
{
    void Update(ISubject subject);
}


class BallGame : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    
    private Dictionary<char, bool> ballHolder = new Dictionary<char, bool>(){
        {'a', false},
        {'b', false},
        {'c', false},
        {'d', false},
        {'e', false},
    };
    
    private Random random = new Random();
    private char name;
    private char holder;
    

    public BallGame()
    {
        int rvalue = random.Next(0, 5);
        name = Convert.ToChar(rvalue + 97);

        if (ballHolder.ContainsKey(name))
        {
            ballHolder[name] = true;
        }

        foreach (KeyValuePair<char, bool> player in ballHolder)
        {
            if (!player.Key.Equals(name))
            {
                ballHolder[player.Key] = false;
            }
        }
        
        foreach (KeyValuePair<char, bool> player in ballHolder)
        {
            if (player.Key.Equals(name))
            {
                holder = player.Key;
            }
        }
        
        
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.Update(this);
        }
    }

    public char GetBallHolder()
    {

     
        foreach (KeyValuePair<char, bool> player in ballHolder)
        {
            if (player.Key.Equals(name))
            {
                holder = player.Key;
            }
        }
    
        return holder;
        
        
       
    }

    public void PassBall()
    {
        int rvalue = random.Next(0, 5);
        name = Convert.ToChar(rvalue + 97);

      
            ballHolder[name] = true;
        

        foreach (KeyValuePair<char, bool> player in ballHolder)
        {
            if (!player.Key.Equals(name))
            {
                ballHolder[player.Key] = false;
            }
        }
        
        NotifyObservers();
    }
}


class BallGuessingObserver : IObserver
{
    public char id;

    public BallGuessingObserver(char id )
    {
        this.id = id;
    }

    public void Update(ISubject subject)
    {
        BallGame game = (BallGame)subject;
        // char ballholdedby = game.GetBallHolder();
      

        Console.WriteLine($"I guess {id} has the ball.");
        
    }
}

