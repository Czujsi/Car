using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car1
{
    public class Car
    {
        /*
        •włączenie/ wyłączenie silnika,
        •zmiana biegów,
        •przyspieszanie,
        •hamowanie.
        Podczas jazdy użytkownik powinien mieć możliwość obserwowania parametrów samochodu(szybkość, włączony bieg, obroty silnika).
        */

        public int CurrentSpeed;
        public int CurrentGear = 0;
        public double CurrentEngineSpeed = 0;
        public readonly int Parking;
        public readonly int MaxGear = 8;
        public readonly int MaxSpeed = 250;
        public readonly int MinGear;
        public const int Neutral = 0;

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
            SetEngineSpeed(CurrentSpeed);
            //SetGear(CurrentSpeed);
            //SetEngineSpeed(CurrentSpeed);
        }

        public void DecreaseSpeed(int v )
        {
            ChangeValueCannotBeNegative(v);
            CurrentSpeed -= v;
            if(CurrentSpeed < 0)
            {
                CurrentSpeed = 0;
            }
            SetGear(CurrentSpeed);
            SetEngineSpeed(CurrentSpeed);
        }
        private void SetGear(int currentSpeed)
        {
            /*if (CurrentSpeed == 0)
            {
                CurrentGear = Neutral;
            }
            else if (CurrentSpeed > 0 && CurrentSpeed <= 20)
            {
                CurrentGear = 1;
            }
            else if (CurrentSpeed > 20 && CurrentSpeed <= 50)
            {
                CurrentGear = 2;
            }
            else if (CurrentSpeed > 50 && CurrentSpeed <= 80)
            {
                CurrentGear = 3;
            }
            else if (CurrentSpeed > 80 && CurrentSpeed <= 110)
            {
                CurrentGear = 4;
            }
            else if (CurrentSpeed > 110 && CurrentSpeed <= 150)
            {
                CurrentGear = 5;
            }
            else if (CurrentSpeed > 150 && CurrentSpeed <= 180)
            {
                CurrentGear = 6;
            }
            else if (CurrentSpeed > 180 && CurrentSpeed <= 210)
            {
                CurrentGear = 7;
            }
            else if (CurrentSpeed > 210 && CurrentSpeed <= 250)
            {
                CurrentGear = 8;
            }
            */
        }

        public void SetEngineSpeed(int currentSpeed)
        {
            if (CurrentSpeed == 0)
            {
                CurrentEngineSpeed = 900;
            }
            else
            {
                CurrentEngineSpeed = (CurrentSpeed / CurrentGear) * 100;
            }
           
        }

        public void ChangeValueCannotBeNegative(int v)
        {
            if (v < 0)
            {
              throw new ArgumentException("Nie można zmnienić prędkości o liczbę ujemną");
            }
        }

        public void IncreaseGear()
        {
            CurrentGear = 1 + CurrentGear;
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

        public void NeutralGear()
        {
            CurrentGear = Neutral;
            if (CurrentGear == Neutral)
            {
                CurrentEngineSpeed = 900;
                CurrentSpeed = 0;
            }
            
            
        }

        public void ParkingGear()
        {
            if(CurrentSpeed > 0)
            {
                throw new ArgumentException("Nie można ustawić biegu parkingowego jeżeli prędkość samochodu przekracza 0 kmh");
            }
            else
            {
                CurrentSpeed = 0;
                CurrentGear = 1;
                CurrentEngineSpeed = 0;
            }
        }
    }
}
