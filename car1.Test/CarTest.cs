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
        "Nie mo¿na zmniejszyæ prêdkoœci o liczbê dodatni¹")]
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
    public class CarIncreaseGears
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
            car.IncreaseGear(1);
            car.IncreaseGear(1);
            car.IncreaseGear(1);
            car.IncreaseGear(1);
            car.IncreaseGear(1);
            car.IncreaseGear(1);
            car.IncreaseGear(1);
            car.IncreaseGear(1);
            car.IncreaseGear(1);
            car.IncreaseGear(1);
            car.IncreaseGear(1);

            // Then
            Assert.AreEqual(ExceptedMaxGear, car.CurrentGear);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Nie mo¿na zwiêkszaæ biegów o wartoœæ zerow¹.")]
        public void When_car_increase_gear_by_0_then_expected_exception()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.IncreaseGear(0);

            // Then
            /// ExpectedException
        }

        [TestMethod]
        public void When_car_increase_gear_then_increase_gear()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.IncreaseGear(1);

            // Then
            Assert.AreEqual(1, car.CurrentGear);
        }

        [TestMethod]
        public void When_car_increase_gear_by_number_bigger_than_1_then_increase_gear_by_1()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.IncreaseGear(4);

            // Then
            Assert.AreEqual(1, car.CurrentGear);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "Nie mo¿na zwiêkszaæ biegów o wartoœci ujemne.")]
        public void When_car_increase_gear_by_negative_x_then_expected_exception()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.IncreaseGear(-4);

            // Then
            /// Nie mo¿na zwiêkszaæ biegów o wartoœci ujemne
        }

        [TestMethod]
        public void When_car_increase_gear_multiple_times_then_inncrease_gear_multiple_times()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.IncreaseGear(1);
            car.IncreaseGear(1);
            car.IncreaseGear(1);

            // Then
            Assert.AreEqual(3, car.CurrentGear);
        }

    }

    [TestClass]
    public class CarDecreaseGears
    {
        public const int ExceptedMinGear = 0;

        [TestMethod]
        public void Car_must_have_a_min_gear()
        {
            //Given
            var car = new Car("Toyota");

            //When
            car.IncreaseGear(1);
            car.IncreaseGear(1);
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
            car.IncreaseGear(1);
            car.IncreaseGear(1);
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
            car.IncreaseGear(1);
            car.IncreaseGear(1);
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
            car.IncreaseGear(1);
            car.IncreaseGear(1);
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
    public class CarParkingGear
    {
        public readonly int ParkingGear = 1;

        [TestMethod]
        public void Car_must_have_a_parking_gear()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.ParkingGear(ParkingGear);

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

            car.ParkingGear(ParkingGear);

            // Then
            Assert.AreEqual(ParkingGear, car.CurrentSpeed);
            // ExpectedException
        }

    }
    [TestClass]
    public class CarNeutralGear
    {
        public readonly int NeutralGear = 0;

        [TestMethod]
        public void Car_must_have_a_neutral_gear()
        {
            // Given
            var car = new Car("Toyota");

            // When
            car.NeutralGear(NeutralGear);

            // Then
            Assert.AreEqual(NeutralGear, car.CurrentGear);
        }
    }
    
}