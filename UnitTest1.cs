using HelloWorld;
using Microsoft.AspNetCore.Mvc;
using MVC;
using MVC.Controllers;

namespace TestProject1
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
            Calculator c = new Calculator();
            Assert.AreEqual(20, c.AddNums(13, 7));
        }

        [Test]
        public void Test2()
        {
            Calculator c = new Calculator();
            Assert.AreEqual(7, c.AddNums(3,4));
        }

        [Test]
        public void TrainerName()
        {
            DotnetBatch db = new DotnetBatch();
            Assert.AreEqual("Logeshwaran", db.TrinerName().ToString());
        }

        [Test]
        public void CircleArea()
        {
            HomeController hc = new();
            Assert.AreEqual(153.9380400259m, hc.AreaofCircle(7));
        }

        [Test]
        public void ShowNative()
        {
            TrainingController tct = new();
            Assert.That("Thanjavur", Is.EqualTo(tct.MyNative().ToString()));
        }



        [Test]
        public void Index()
        {
            // Arrange
            TrainingController trc = new();
            // Act
            ViewResult result = trc.Index() as ViewResult;
            // Assert
            //Assert.IsNotNull(result);
            Assert.That("Relevantz", Is.EqualTo(trc.ViewData["Company"].ToString()));
        }

        [Test]
        public void Privacy()
        {
            // Arrange
            HomeController controller = new HomeController();
            // Act
            ViewResult result = controller.Privacy() as ViewResult;
            // Assert
            Assert.That("Privacy Policy", Is.EqualTo(result.ViewData["Title"].ToString()));
        }

        //[Test]
        //public void SquareTest() 
        //{ 
        //    Calculator c = new Calculator();
        //    //Assert.AreEqual(81, c.SquareNum(9));
        //}

    }
}