namespace OOPracticeTest
{
    using OOPractice;
    using System.Diagnostics;
    using Xunit;

    public class CarTest
    {
        [Fact]
        public void Should_return_message_when_speed_up_given_car_name_cool_car_and_engine_gasoline()
        {
            //given
            Car car = new Car("Cool Car", new Engine("gasoline"));

            //when
            string message = car.SpeedUp();

            //then
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }

        [Fact]
        public void Should_return_message_when_speed_up_given_truck_name_big_truck()
        {
            //given
            Truck truck = new Truck("Big Truck", 10);

            //when
            string message = truck.SpeedUp();

            //then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }

        [Fact]
        public void Should_return_message_when_driver_speed_up_given_a_car()
        {
            //given
            Car car = new Car("Cool Car", new Engine("gasoline"));
            Driver driver = new Driver(car);

            //when
            string message = driver.SpeedUp();

            //then
            Assert.Equal("Cool Car: speed up 30 km/h", message);
        }

        [Fact]
        public void Should_return_message_when_driver_speed_up_given_a_truck()
        {
            //given
            Truck truck = new Truck("Big Truck", 10);
            Driver driver = new Driver(truck);

            //when
            string message = driver.SpeedUp();

            //then
            Assert.Equal("Big Truck: speed up 10 km/h", message);
        }
    }
}
