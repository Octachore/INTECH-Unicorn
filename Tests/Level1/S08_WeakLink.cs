using FluentAssertions;
using ITI.Unicorn.Core.Level1;
using NUnit.Framework;

namespace ITI.Unicorn.Tests.Level1
{
    public class S08_WeakLink
    {
        [TestCase(17, 14)]
        [TestCase(44, 6)]
        [TestCase(85, 10)]
        [TestCase(512, 15)]
        public void P08_WeakLink_GetResult(int initialValue, int expected)
        {
            var result = P08_WeakLink.GetResult(initialValue);

            result.Should().Be(expected);
        }
    }
}
