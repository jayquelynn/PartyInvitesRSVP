using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MotorizedVehicles;
using Structures;

namespace TestMotorizedVehicle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsDrivingClass()
        {
            Coupe car = new Coupe();
            //Is the car driving
            Assert.AreEqual(true, car.IsDriving());

            //Start the car
            car.SetDriving(true);
            //Is the car Driving
            Assert.IsTrue(car.IsDriving());

            //stop the car
            car.SetDriving(false);
            //has the car stopped driving
            Assert.IsFalse(car.IsDriving());
        }

        [TestMethod]
        public void TestIsDrivingStructure()
        {
            Automobile car = new Automobile();
            //Is the car driving
            Assert.AreEqual(false, car.IsDriving());

            //Start the car
            car.SetDriving(true);
            //Is the car Driving
            Assert.IsTrue(car.IsDriving());

            //stop the car
            car.SetDriving(false);
            //has the car stopped driving
            Assert.IsFalse(car.IsDriving());
        }
    }
}
