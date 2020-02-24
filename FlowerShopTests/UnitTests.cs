using NUnit.Framework;
using NSubstitute;
using FlowerShop;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Arrange
            
            var order = Substitute.For<IOrderDAO>();
            var client = Substitute.For<IClient>();
            var der = new Order(order,client);

            //Act
            der.Deliver();

            //Assert
            Assert.That(der.Deliver, Is.True);
            
        }
    }
}