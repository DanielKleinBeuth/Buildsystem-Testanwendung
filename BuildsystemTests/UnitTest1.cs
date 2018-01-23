using System;
using Xunit;
using Buildsystem_Testanwendung;

namespace BuildsystemTests
{
    public class UnitTest1
    {
        [Fact]
        public void SucceedingTest()
        {
            var testKlasse = new TestableCode();

            Assert.True(5 == testKlasse.Add(2, 3));
            Assert.False(5 == testKlasse.Add(3, 3));
        }

        public void FailingTest()
        {
            var testKlasse = new TestableCode();

            Assert.True(5 == testKlasse.Add(2, 3));
            Assert.False(5 == testKlasse.Add(3, 3));
        }
    }
}
