using Xunit;
using KEANID;

namespace KEANIDTEST
{
    public class UnitTest1
    {
        [Fact]
        public void TestMultOfTwoNumbers()
        {
            double a = 2;
            double b = 3;
            double expected = 6;

            double actual = MyMath.Mult(a, b);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMultOfThreeNumbers()
        {
            double a = 2;
            double b = 3;
            double c = 4;
            double expected = 24;

            double actual = MyMath.Mult(a, b, c);

            Assert.Equal(expected, actual);
        }
    }
}
             