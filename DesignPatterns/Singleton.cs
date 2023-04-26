namespace DesignPatterns;

public class Singleton
{
    private static Singleton instance;
    
        private Singleton()
        {
            // Constructor is private to prevent direct instantiation
        }
    
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                    Console.WriteLine("new object has been created");
                    return instance;
                }

                else
                {
                    Console.WriteLine("new object has not been created");
                    return instance;
                }
            }
            
            
        }
    

    
}