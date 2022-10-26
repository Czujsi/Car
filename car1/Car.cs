using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car1
{
    public class Car
    {
        public int CurrentSpeed;
        private readonly int MaxSpeed = 250;
        public string Name { get; }

        public Car(string v)
        {
            if(v == null)
            {
                throw new ArgumentException("Car must have a name"); 
            }
            
            Name = v;
        }

        public void IncreaseSpeed(int v)
        {
            changeValeCannotBeNegative(v);
            CurrentSpeed = v + CurrentSpeed;
            if(CurrentSpeed > MaxSpeed)
            {
                CurrentSpeed = MaxSpeed;
            }
        }

        public void DecreaseSpeed(int v )
        {
            changeValeCannotBeNegative(v);
            CurrentSpeed = CurrentSpeed - v;
            if(CurrentSpeed < 0)
            {
                CurrentSpeed = 0;
            }
        }

        private void changeValeCannotBeNegative(int v)
        {
            if (v < 0)
            {
              throw new ArgumentException("Nie można zmnienić prędkości o liczbę ujemną");
            }
        }

    }
}
