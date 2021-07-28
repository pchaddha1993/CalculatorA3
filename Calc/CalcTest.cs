using NUnit.Framework;
using CalculatorA3;

namespace Calc
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void Addition_of_two_positive_numbers()
        {
            double a = 10, b = 11;//arrange
            double res = Calculator.Addition(a, b);//act
            Assert.AreEqual(res, 21); //assert
        }
        [Test]
        public void Addition_of_two_negative_numbers()
        {
            double a = -5, b = -7;//arrange
            double res = Calculator.Addition(a, b);//act
            Assert.AreEqual(res, -12); //assert
        }

        [Test]
        public void Addition_of_one_negative_and_one_positive_number()
        {
            double a = -8, b = 6;//arrange
            double res = Calculator.Addition(a, b);//act
            Assert.AreEqual(res, -2); //assert
        }

        [Test]
        public void Subtraction_of_two_numbers()
        {
            double a = 8, b = 6;//arrange
            double res = Calculator.Subtraction(a, b);//act
            Assert.AreEqual(res, 2); //assert
        }

        [Test]
        public void Subtraction_of_two_negative_numbers()
        {
            double a = -9, b = -1;//arrange
            double res = Calculator.Subtraction(a, b);//act
            Assert.AreEqual(res, -8); //assert
        }

        [Test]
        public void Subtraction_of_one_negative_and_one_positive_number()
        {
            double a = -20, b = 20;//arrange
            double res = Calculator.Subtraction(a, b);//act
            Assert.AreEqual(res, -40); //assert
        }

        [Test]
        public void Multiplication_of_two_numbers()
        {
            double a = 8, b = 5;//arrange
            double res = Calculator.Multiplication(a, b);//act
            Assert.AreEqual(res, 40); //assert
        }

        [Test]
        public void Multiplication_of_two_negative_numbers()
        {
            double a = -10, b = -10;//arrange
            double res = Calculator.Multiplication(a, b);//act
            Assert.AreEqual(res, 100); //assert
        }

        [Test]
        public void Multiplication_of_any_number_with_zero()
        {
            double a = 5, b = 0;//arrange
            double res = Calculator.Multiplication(a, b);//act
            Assert.AreEqual(res, 0); //assert
        }

        [Test]
        public void Division_of_two_numbers()
        {
            double a = 12, b = 3;//arrange
            double res = Calculator.Division(a, b);//act
            Assert.AreEqual(res, 4); //assert
        }

        [Test]
        public void Division_of_any_number_by_zero()
        {

            double a = 6, b = 0;//arrange
            double res = Calculator.Division(a, b);//act
            Assert.AreEqual(res, double.PositiveInfinity); //assert
        }

        [Test]
        public void Division_of_two_negative_numbers()
        {
            double a = -10, b = -2;//arrange
            double res = Calculator.Division(a, b);//act
            Assert.AreEqual(res, 5); //assert
        }
        [Test]
        public void New_Testcase1_Division()
        {
            double a = 1, b = 3;//arrange
            double res = Calculator.Division(a, b);//act
            Assert.AreEqual(res, 0.33); //assert
        }
        [Test]
        public void New_Testcase2_Division()
        {
            double a = 2, b = 1;//arrange
            double res = Calculator.Division(a, b);//act
            Assert.AreEqual(res, 2); //assert
        }
        [Test]
        public void New_Testcase3_Division()
        {
            double a = 9, b = 3;//arrange
            double res = Calculator.Division(a, b);//act
            Assert.AreEqual(res, 3); //assert
        }
    }
}

