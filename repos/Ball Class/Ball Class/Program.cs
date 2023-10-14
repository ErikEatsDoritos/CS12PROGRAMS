using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ball_Class
{
    internal class Program
    {


        class Ball
        {
            public string Color;

            public Ball(string Color)
            {
                this.Color = Color;
            }

            public int GetPoints()
            {
                
                if (Color == "yellow") return 3;
                else if (Color == "blue") return 2;
                else if(Color == "white") return 1;
                else return 0;

            }
        }

        class robot
        {
            public string cargo;

           

            public void Pickup(string ball)
            {
                cargo = ball;
            }

            public void Dump()
            {
                
            }
        }
        
        class Bucket
        {
            public string[] Balls;
            public int capacity;

            public Bucket(int capacity)
            {
                this.capacity = capacity;
                this.Balls = new string[capacity];
            }

            public void Add(Ball ball)
            {
                for (int i = 0; i < Balls.Length; i++)
                {
                    if (Balls[i] == null)
                    {
                        this.Balls[i] = ball.Color;
                        break;
                    }
                        
                   
                }
                
                
            }


            public int GetPoints()                                                  
            {
                int total = 0; 
                foreach(string color  in this.Balls)
                {
                    if (color == "yellow") total += 3;
                    else if (color == "blue") total += 2;
                    else if (color == "white") total += 1;
                   
            
                }
                    return total; 
            }

        }
          

   
        static void Main(string[] args)
        {
            TestBucket();
            TestBall();
            

        }

        public static void TestBall()
        {
            Console.WriteLine("TestBall() running...");
            Ball b1 = new Ball("yellow");
            int b1Points = b1.GetPoints();
            Console.WriteLine(b1Points);

            Ball b2 = new Ball("blue");
            int b2Points = b2.GetPoints();
            Console.WriteLine(b2Points);

            // TODO: Should we allow robots (or anyone) to repaint the balls?
            // Note: encapsulation
            b2.Color = "white";
            b2Points = b2.GetPoints();
            Console.WriteLine(b2Points);
            Console.ReadLine();
            
        }
        public static void TestBucket()
        {
            Console.WriteLine("TestBucket() running...");
            Bucket bucket1 = new Bucket(1);
            bucket1.Add(new Ball("white"));
            int points = bucket1.GetPoints();
            Console.WriteLine(points);  // 1

            // Cannot add over capacity
            // TODO: shouldn't fail silently
            bucket1.Add(new Ball("yellow"));
            points = bucket1.GetPoints();
            Console.WriteLine(points);  // 1

            // Can calculate total points
            Bucket bucket2 = new Bucket(3);
            bucket2.Add(new Ball("yellow"));
            bucket2.Add(new Ball("blue"));
            bucket2.Add(new Ball("white"));
            points = bucket2.GetPoints();
            Console.WriteLine(points);  // 6

            // TODO: Cannot add the same ball
            Bucket bucket3 = new Bucket(2);
            Ball b = new Ball("yellow");
            // bucket3.Add(b);
            // Console.WriteLine(bucket3.GetPoints());  // 3
            // bucket3.Add(b);  // TODO: should throw error
            // Console.WriteLine(bucket3.GetPoints());  // 3

            // TODO: Shouldn't be able to manually place the same ball!!
            // This isn't possible in real life so we need to prevent this 
            // from happening.
            // Note: requires encapsulation (private attributes).
           

            // TODO: Cannot add same ball to multiple buckets!
            // Note: Class variables!
            bucket1 = new Bucket(1);
            bucket2 = new Bucket(1);
            Ball ball = new Ball("blue");
            bucket1.Add(ball);
            bucket2.Add(ball);

        }



















    }
}
