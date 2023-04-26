using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton s = Singleton.Instance;
            // Singleton s1 = Singleton.Instance;

//factorypattern
            // Animal asd;
            // CatFactory xyz = new CatFactory();
            // asd = xyz.CreateAnimal();
            // Console.WriteLine(asd.Name);

            //example2
            // class Program {
            //     static void Main(string[] args) {
            //         ProductFactory factory = new ProductFactory();
            //
            //         IProduct productA = factory.CreateProduct("A");
            //         productA.Ship();
            //
            //         IProduct productB = factory.CreateProduct("B");
            //         productB.Ship();
            //     }
            // }

            //Observerpattern

            // var weatherStation = new WeatherStation();
            // var phoneDisplay = new PhoneDisplay();
            // weatherStation.Attach(phoneDisplay);
            //
            // weatherStation.Temperature = 20;
            // weatherStation.Temperature = 25;

            //example2
            // WeatherStation weatherStation = new WeatherStation();
            //
            // Display display = new Display();
            // weatherStation.RegisterObserver(display);
            //
            // weatherStation.SetMeasurements(25.5f, 1013.25f, 60f);




            // var builder = new PizzaBuilder();
            // var director = new PizzaDirector(builder);
            //
            // director.BuildVegetarianPizza();
            // var vegetarianPizza = builder.GetPizza();
            //
            // director.BuildPepperoniPizza();
            // var pepperoniPizza = builder.GetPizza();



//             IBeverage espresso = new Espresso();
//

//             IBeverage milkEspresso = new Milk(espresso);
//
//             Console.WriteLine($"Description: {milkEspresso.Description}");
//             Console.WriteLine($"Cost: {milkEspresso.Cost()}");

            //
            // Facade facade = new Facade();
            // facade.Operation();



            //decoratorPractice

            // basecake sujarBday = new basecake();
            // sujarBday = new chocolateCake(sujarBday);
            //
            // Console.WriteLine(csujarBday.getDescription());
            // Console.WriteLine("Price: {0:C}", csujarBday.price());
            //
            // Display sujar = new Display();
            // StockMarket nepse = new StockMarket();
            //
            // nepse.RegisterObserver(sujar);
            // nepse.Add("Himal",200000.98f);
            // nepse.Update("Himalaya",2000000);
            //
            // nepse.showAll();

            // pizza two;
            // nepalipizzabuilder machine = new nepalipizzabuilder();
            // pizzamaker sujar = new pizzamaker(machine);
            //
            // sujar.makepizza();
            // two = sujar.returnfood();
            //
            // Console.WriteLine(two.toppings);







            // int gnum;
            // string value;
            // start1:
            // Console.WriteLine("input a random guess");
            // value = Console.ReadLine();
            // gnum = Int32.Parse(value);
            //
            // if (gnum == 0 || gnum > 5)
            // {
            //     Console.Write(" Error!!! guess should be in between 1- 5");
            //     goto start1;
            // }
            //
            // BallGame game = new BallGame();
            // BallGuessingObserver observer = new BallGuessingObserver(gnum);
            //
            //
            // int ballholder = game.GetBallHolder();
            // game.RegisterObserver(observer);
            //
            // while (gnum != ballholder)
            // {
            //     observer.id = gnum;
            //     game.PassBall();
            //     
            //     ballholder = game.GetBallHolder();
            //     
            //     if (ballholder != gnum)
            //     {
            //         Console.WriteLine("Wrong Guess");
            //         
            //     }
            //     
            //     start:
            //     
            //     Console.WriteLine("take a new guess");
            //     value = Console.ReadLine();
            //     gnum = Int32.Parse(value);
            //
            //     if (gnum == 0 || gnum > 5)
            //     {
            //         Console.WriteLine(" Error !!! guess should be in between 1- 5");
            //         goto start;
            //     }
            //
            //
            // }
            //
            // Console.WriteLine("Congrats Correct Guess");
            //



            char gplayer;
            string value;


            start1:
            int cvalue = 0;
            Console.WriteLine("input a random guessx");
            value = Console.ReadLine();
            value = value.ToLower();

            foreach (char c in value)
            {
                cvalue = System.Convert.ToInt32(c) + cvalue;
            }


            if (cvalue < 097 || cvalue > 101)
            {
                Console.WriteLine(" Error!!! guess should be in between a-e ");
                goto start1;
            }

            gplayer = char.Parse(value);


            BallGame game = new BallGame();
            BallGuessingObserver observer = new BallGuessingObserver(gplayer);



            char ballHolder = game.GetBallHolder();
            game.RegisterObserver(observer);



            while (gplayer != ballHolder)
            {
                char answer = game.GetBallHolder();
                Console.WriteLine($"right answer is {answer}");

                game.PassBall();
                ballHolder = game.GetBallHolder();

                if (ballHolder != gplayer)
                {
                    Console.WriteLine("Wrong Guess");
                    //     char answer = game.GetBallHolder();
                    //     Console.WriteLine($"right answer is {answer}");
                    }

                    start:
                    Console.WriteLine("input a random guess");
                    value = Console.ReadLine();
                    value = value.ToLower();
                    cvalue = 0;


                    gplayer = char.Parse(value);

                    foreach (char c in value)
                    {
                        cvalue = System.Convert.ToInt32(c) + cvalue;
                    }


                    if (cvalue < 097 || cvalue > 101)
                    {
                        Console.WriteLine(" Error!!! guess should be in between a-e ");
                        goto start;
                    }





                }

                Console.WriteLine("Congrats Correct Guess");


            }
        }
    }
