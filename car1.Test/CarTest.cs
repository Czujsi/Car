namespace car1.Test
{
    [TestClass]
    public class CarTest
    {
        public const int ExpectedMaxSpeed = 250;

        [TestMethod]
        public void CarMustHaveAMaxSpeed()
        {
            var car = new Car("Toyota");

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
            var car = new Car(null);
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
        public void CarMustDecreaseSpeed7()
        {
            // Given
            var car = new Car("Toyota");
            
            // When
            car.DecreaseSpeed(10);
            
            // Then
            Assert.AreEqual(0, car.CurrentSpeed);
        }


    }
}