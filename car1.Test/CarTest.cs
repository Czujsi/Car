using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace car1.Test
{
    [TestClass]
    public class CarTest
    {
        public const int ExpectedMaxSpeed = 250;

        [TestMethod]
        public void CarMustHaveAMaxSpeed()
        {
            var car = new Car("Toyota")
            {
                CurrentSpeed = 260
            };

            Assert.AreEqual(ExpectedMaxSpeed, car.MaxSpeed);
        }

        [TestMethod]
        public void CarMustHaveAName()
        {
            var car = new Car("Toyota");

            Assert.AreEqual("Toyota", car.Name);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Car must have name.")]
        public void CarCannotHaveNullName()
        {
            _ = new Car(null);

        }
    }

    [TestClass]
    public class CarIncreaseSpeed
    {
        [TestMethod]
        public void When_car_increase_current_speed_by_x_number_then_set_current_speed_at_x_number()
        {
            // Given
            var car = new Car("Toyota");
            
            // When
            car.IncreaseSpeed(10);
            
            // Then
            Assert.AreEqual(10, car.CurrentSpeed);
        }

        [TestMethod]
        public void When_car_increase_current_speed_by_y_number_then_set_current_speed_at_y_number()
        {
            // Given
            var car = new Car("Toyota");
            
            // When
            car.IncreaseSpeed(20);
            
            // Then
            Assert.AreEqual(20, car.CurrentSpeed);
        }

        [TestMethod]
        public void When_car_increase_current_speed_multiple_times_then_sum_each_other_and_set_at_current_speed()
        {
            // Given
            var car = new Car("Toyota");
            
            // When
            car.IncreaseSpeed(10);
            car.IncreaseSpeed(20);
            
            // Then
            Assert.AreEqual(30, car.CurrentSpeed);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Nie mo¿na zwiêkszaæ prêdkoœci o wartoœci ujemne.")]
        public void When_car_increase_speed_by_negative_number_then_throw_argument_exception()
        {
            // Given
            var car = new Car("Toyota");
            
            // When
            car.IncreaseSpeed(-10);
            
            // Then
            // Throws Exception
        }

        [TestMethod]
        public void When_car_increase_speed_by_0_then_set_speed_at_last_currentSpeed()
        {
            // Given
            var car = new Car("Toyota");
            
            // When
            car.IncreaseSpeed(0);
            
            // Then
            Assert.AreEqual(0, car.CurrentSpeed);
        }

        [TestMethod]
        public void When_car_increase_speed_over_max_speed_then_set_current_speed_to_maxSpeed()
        {
            // Given
            var car = new Car("Toyota");
            
            // When
            car.IncreaseSpeed(CarTest.ExpectedMaxSpeed + 10);
            
            // Then
            Assert.AreEqual(CarTest.ExpectedMaxSpeed, car.CurrentSpeed);
        }

    }

    [TestClass]
    public class CarDecreaseSpeed
    {
        [TestMethod]
        public void When_car_decrease_current_speed_then_decrease_car_current_speed()
        {
            // Given
            var car = new Car("Toyota");
            car.IncreaseSpeed(40);
            
            // When
            car.DecreaseSpeed(40);
            
            // Then
            Assert.AreEqual(0, car.CurrentSpeed);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Nie mo¿na zmniejszyæ prêdkoœci o liczbê ujemn¹")]
        public void When_car_decrease_current_speed_by_x_value_then_decrease_current_speed_value_by_x()
        {
            // Given
            var car = new Car("Toyota");
            
            // When
            car.DecreaseSpeed(-10);

            // Then
            // Throws Exception
        }

        [TestMethod]
        public void When_car_decrease_current_speed_then_decrease_current_speed()
        {
            // Given
            var car = new Car("Toyota");
            car.IncreaseSpeed(40);
            
            // When
            car.DecreaseSpeed(10);
            
            // Then
            Assert.AreEqual(30, car.CurrentSpeed);
        }

        [TestMethod]
        public void When_car_decrease_currentSpeed_by_0_then_the_speed_does_not_change()
        {
            // Given
            var car = new Car("Toyota");
            
            // When
            car.DecreaseSpeed(0);
            
            // Then
            Assert.AreEqual(0, car.CurrentSpeed);
        }

        [TestMethod]
        public void When_car_decrease_speed_below_0_then_speed_is_0()
        {
            // Given
            var car = new Car("Toyota");
            
            // When
            car.DecreaseSpeed(10);
            
            // Then
            Assert.AreEqual(0, car.CurrentSpeed);
        }
    }

    [TestClass]
    public class ManualCarIncreaseGears
    {
        public const int ExceptedMaxGear = 8;
        [TestMethod]
        public void Car_must_have_a_max_gear()
        {
            //Given
            var car = new Car("Toyota");

            //When
        
            //Then
            Assert.AreEqual(ExceptedMaxGear, car.MaxGear);
        }

        [TestMethod]
        public void When_car_current_gear_is_bigger_than_max_gear_set_max_gear()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.IncreaseGear();
            car.IncreaseGear();
            car.IncreaseGear();
            car.IncreaseGear();
            car.IncreaseGear();
            car.IncreaseGear();
            car.IncreaseGear();
            car.IncreaseGear();
            car.IncreaseGear();
            car.IncreaseGear();
            car.IncreaseGear();

            // Then
            Assert.AreEqual(ExceptedMaxGear, car.CurrentGear);
        }

        [TestMethod]
        public void When_car_increase_gear_then_increase_gear()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.IncreaseGear();

            // Then
            Assert.AreEqual(1, car.CurrentGear);
        }

        [TestMethod]
        public void When_car_increase_gear_by_number_bigger_than_1_then_increase_gear_by_1()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.IncreaseGear();

            // Then
            Assert.AreEqual(1, car.CurrentGear);
        }

        [TestMethod]
        public void When_car_increase_gear_multiple_times_then_inncrease_gear_multiple_times()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.IncreaseGear();
            car.IncreaseGear();
            car.IncreaseGear();

            // Then
            Assert.AreEqual(3, car.CurrentGear);
        }

    } 

    [TestClass]
    public class ManualCarDecreaseGears
    {
        public const int ExceptedMinGear = 0;

        [TestMethod]
        public void Car_must_have_a_min_gear()
        {
            //Given
            var car = new Car("Toyota");

            //When
            car.IncreaseGear();
            car.IncreaseGear();
            car.DecreaseGear(1);
            car.DecreaseGear(1);
            car.DecreaseGear(1);
            ///3 - 1 - 1 - 1 - 1 = 0
            //Then
            Assert.AreEqual(ExceptedMinGear, car.MinGear);
        }

        [TestMethod]
        public void When_car_decrease_gear_then_decrease_gear()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.IncreaseGear();
            car.IncreaseGear();
            car.DecreaseGear(1);

            // Then
            Assert.AreEqual(1, car.CurrentGear);
        }
        [TestMethod]
        public void When_car_decrease_gear_by_2_then_decrease_gear_by_2()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.IncreaseGear();
            car.IncreaseGear();
            car.DecreaseGear(2);

            // Then
            Assert.AreEqual(0, car.CurrentGear);
        }
        [TestMethod]
        public void When_car_decrease_gear_below_min_gear_then_set_min_gear()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.IncreaseGear();
            car.IncreaseGear();
            car.DecreaseGear(5);

            // Then
            Assert.AreEqual(0, car.CurrentGear);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Nie mo¿na zmniejszaæ biegów o wartoœci ujemne.")]
        public void When_car_decrease_gear_by_negative_x_then_expected_exception()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.DecreaseGear(-4);

            // Then
            /// Nie mo¿na zmniejszaæ biegów o wartoœci ujemne
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Nie mo¿na zmniejszaæ biegów o wartoœæ zerow¹.")]
        public void When_car_decrease_gear_by_0_then_expected_exception()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.DecreaseGear(0);

            // Then
            /// ExpectedException
        }
    }

    [TestClass]
    public class ManualCarParkingGear
    {
        public readonly int ParkingGear;

        [TestMethod]
        public void Car_must_have_a_parking_gear()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.ParkingGear();

            // Then
            Assert.AreEqual(ParkingGear, car.Parking);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Nie mo¿na ustawiæ biegu parkingowego je¿eli prêdkoœæ samochodu przekracza 0 kmh")]
        public void When_current_speed_is_above_0_then_car_cant_set_parking_gear()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.IncreaseSpeed(100);

            car.ParkingGear();

            // Then
            Assert.AreEqual(ParkingGear, car.CurrentSpeed);
            // ExpectedException
        }

    }

    [TestClass]
    public class ManualCarNeutralGear
    {
        public readonly int NeutralGear;

        [TestMethod]
        public void Car_must_have_a_neutral_gear()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.NeutralGear();

            // Then
            Assert.AreEqual(NeutralGear, car.CurrentGear);
        }
    }

    [TestClass]
    public class EngineSpeed
    {
        [TestMethod]

        [DataRow(0, 900)]
        [DataRow(1, 100)]
        [DataRow(20, 2000)]
        [DataRow(21, 1000)]
        [DataRow(50, 2500)]
        [DataRow(51, 1700)]
        [DataRow(80, 2600)]
        [DataRow(81, 2000)]
        [DataRow(110, 2700)]
        [DataRow(111, 2200)]
        [DataRow(150, 3000)]
        [DataRow(151, 2500)]
        [DataRow(180, 3000)]
        [DataRow(181, 2500)]
        [DataRow(210, 3000)]
        [DataRow(211, 2600)]
        [DataRow(250, 3100)]
        [DataTestMethod]
        public void Car_must_have_engine_speed(int speed, int expextedEngineSpeed)
        {
            var car = new Car("Toyota");

            car.IncreaseSpeed(speed);

            Assert.AreEqual(expextedEngineSpeed, car.CurrentEngineSpeed);
        }
    }
    

    [TestClass]
    public class CarShifterSystem
    {
        
        [DataRow(0, Car.Neutral)]
        [DataRow(1, 1)]
        [DataRow(20, 1)]
        [DataRow(21, 2)]
        [DataRow(50, 2)]
        [DataRow(51, 3)]
        [DataRow(80, 3)]
        [DataRow(81, 4)]
        [DataRow(110, 4)]
        [DataRow(111, 5)]
        [DataRow(150, 5)]
        [DataRow(151, 6)]
        [DataRow(180, 6)]
        [DataRow(181, 7)]
        [DataRow(210, 7)]
        [DataRow(211, 8)]
        [DataRow(250, 8)]
        [DataTestMethod]
        public void When_car_increase_speed_then_increase_gears(int speed, int expectedGear)
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.IncreaseSpeed(speed);

            // Then
            Assert.AreEqual(expectedGear, car.CurrentGear);
        }
     
        [DataRow(250, Car.Neutral)]
        [DataRow(249, 1)]
        [DataRow(230, 1)]
        [DataRow(229, 2)]
        [DataRow(200, 2)]
        [DataRow(199, 3)]
        [DataRow(170, 3)]
        [DataRow(169, 4)]
        [DataRow(140, 4)]
        [DataRow(139, 5)]
        [DataRow(100, 5)]
        [DataRow(99, 6)]
        [DataRow(70, 6)]
        [DataRow(69, 7)]
        [DataRow(40, 7)]
        [DataRow(39, 8)]
        [DataRow(1, 8)]
        [DataTestMethod]
        public void When_car_decrease_speed_then_decrease_gears(int speed, int expectedGear)
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.IncreaseSpeed(250);
            car.DecreaseSpeed(speed);

            // Then
            Assert.AreEqual(expectedGear, car.CurrentGear);
        }

        



    }

}