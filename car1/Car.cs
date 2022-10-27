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
        public int CurrentGear = 0;
        public readonly int Parking = 1;
        public readonly int MaxGear = 8;
        public readonly int MaxSpeed = 250;
        public readonly int MinGear;

        public string Name { get; }

        public Car(string v)
        {
            Name = v ?? throw new ArgumentException("Car must have a name");
        }

        public void IncreaseSpeed(int v)
        {
            ChangeValueCannotBeNegative(v);
            CurrentSpeed = v + CurrentSpeed;
            if(CurrentSpeed > MaxSpeed)
            {
                CurrentSpeed = MaxSpeed;
            }
        }

        public void DecreaseSpeed(int v )
        {
            ChangeValueCannotBeNegative(v);
            CurrentSpeed -= v;
            if(CurrentSpeed < 0)
            {
                CurrentSpeed = 0;
            }
        }

        private void ChangeValueCannotBeNegative(int v)
        {
            if (v < 0)
            {
              throw new ArgumentException("Nie można zmnienić prędkości o liczbę ujemną");
            }
        }

        public void IncreaseGear(int g)
        {
            ChangeValueCannotBeNegative(g);
            if(g == 0 )
            {
                throw new ArgumentException("Nie można zwiększać biegów o wartość zerową.");
            }
            if (g > 1)
            {
                g = 1;
            }
            CurrentGear = g + CurrentGear;
            if (CurrentGear > MaxGear)
            {
                CurrentGear = MaxGear;
            }
        }

        public void DecreaseGear(int m)
        {
            ChangeValueCannotBeNegative(m);
            if (m == 0)
            {
                throw new ArgumentException("Nie można zmniejszać biegów o wartość zerową.");
            }
            CurrentGear -= m;
            if ((CurrentGear - m) < 0)
            {
                CurrentGear = 0;
            }
            
        }

        public void NeutralGear(int n)
        {
            ChangeValueCannotBeNegative(n);
            CurrentGear = 0;
           
        }

        public void ParkingGear(int p)
        {
            ChangeValueCannotBeNegative(p);
            if(CurrentSpeed > 0)
            {
                throw new ArgumentException("Nie można ustawić biegu parkingowego jeżeli prędkość samochodu przekracza 0 kmh");
            }
            
        }
    }
}
