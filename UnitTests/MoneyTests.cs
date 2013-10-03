using System;
using Core.Extensions;
using Shouldly;

namespace UnitTests
{
    public class MoneyTests
    {
        public void should_add()
        {
            var a = 12.USD();
            var b = 23.USD();

            var result = a + b;

            result.ShouldBe(35.USD());
        }

        public void should_throw_when_subtracting_nonmatching_currencies()
        {
            var a = 10.USD();
            var b = 2.Euro();

            var ex = Should.Throw<ArgumentException>(() =>
            {
                var result = a - b;
            });
            Console.WriteLine(ex.Message);
        }

        public void should_throw_when_adding_nonmatching_currencies()
        {
            var a = 10.USD();
            var b = 6.Euro();

            var ex = Should.Throw<ArgumentException>(() =>
            {
                var result = a + b;
            });
            Console.WriteLine(ex.Message);
        }
    }
}
