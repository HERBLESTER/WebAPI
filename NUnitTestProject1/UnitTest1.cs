using NUnit.Framework;
using ClassLibrary;


namespace Tests
{
    public class Tests
    {
        private Class1 generator;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            generator = new Class1();

            var values = generator.GetFizzBuzz();
            int index = 0;
            foreach (string val in values)
            {
                index++;
                bool isNumber = false;
                int num = 0;

                isNumber = int.TryParse(val, out num);
                bool isMultipleof3 = index % 3 == 0;
                bool isMultipleof5 = index % 5 == 0;

                if (isMultipleof3 && isMultipleof5)
                {
                    Assert.IsTrue(val == "FizzBuzz");
                }
                else if (isMultipleof3)
                {
                    Assert.IsTrue(val == "Fizz");
                }
                else if (isMultipleof5)
                {
                    Assert.IsTrue(val == "Buzz");
                }
                else
                {
                    num = int.Parse(val);
                    Assert.IsTrue(index == num);
                }
            }

            Assert.IsTrue(index == 100);

        }

        [Test]
        public void TestGetnthElement()
        {
            generator = new Class1();

            string value = generator.GetFizzBuzzNthelement(1);
            int num = int.Parse(value);
            Assert.IsTrue(num == 1);

            value = generator.GetFizzBuzzNthelement(3);
            Assert.IsTrue(value == "Fizz");

            value = generator.GetFizzBuzzNthelement(5);
            Assert.IsTrue(value == "Buzz");

            value = generator.GetFizzBuzzNthelement(15);
            Assert.IsTrue(value == "FizzBuzz");

        }
    }
}