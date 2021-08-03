using System;

namespace CarEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Delegate lessons
            //Car car1 = new Car("Sheggy", 20, 100);
            //EventHandler<CarEventArgs> carEngineHandler = new EventHandler<CarEventArgs>(CarEventMessage);
            //car1.AboutToBlow += carEngineHandler;
            //Program program = new Program();
            //car1.Exploded += program.CarDeadMessage;
            //for (int i = 0; i < 10; i++)
            //{
            //    car1.Accelerate(10);
            //}
            #endregion
            #region Anonymous Methods
            Console.WriteLine("****** Anonymous Methods *****");
            Car car = new Car("Louge", 10, 120);
            int aboutToBlowCounter=0;
            car.AboutToBlow += delegate//Объявление анонимного метода
            {
                aboutToBlowCounter++;
                Console.WriteLine("Eak,you're going too fast");
            };
            car.AboutToBlow += delegate (object sender, CarEventArgs e) {
                if (sender is Car c)
                {
                    Console.WriteLine("{0} is message: {1}", c.CarName,e.msg);
                    aboutToBlowCounter++;
                }
                
            };
            car.Exploded += delegate (object sender, CarEventArgs e) 
            {
                Console.WriteLine(e.msg); aboutToBlowCounter++;
            };
            for (int i = 0; i < 10; i++)
            {
                car.Accelerate(20);
                Console.WriteLine("aboutToBlowCounter ={0}", aboutToBlowCounter) ;
            }
            #endregion

        }


        static void CarEventMessage(object sender,CarEventArgs msg)
        {
            if (sender is Car c)
            {
                Console.WriteLine("__________________");
                Console.WriteLine("Car {1} is message:{0}\n", msg.msg, c.CarName) ;
                Console.WriteLine("__________________");
            }
            
        }
        public void CarDeadMessage(object sender,CarEventArgs msg) {
            if (sender is Car c)
            {
                Console.WriteLine("OOOoh {1},{0}", msg.msg,c.CarName);
            }
            
        }
    }
}
