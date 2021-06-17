using System;

namespace InheritanceLesson
{
    class Car
    {
        private readonly int maxSpeed;
        private int currSpeed;
        public Car(int max){
            maxSpeed=max;
        }
        public Car(){
            maxSpeed=55;
        }
        public int Speed{
            get{return currSpeed;}
            set{
                currSpeed=value;
                if(currSpeed>maxSpeed){currSpeed=maxSpeed;}
            }
        }

    }
}
