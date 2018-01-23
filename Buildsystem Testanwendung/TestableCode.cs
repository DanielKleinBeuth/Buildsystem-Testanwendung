using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buildsystem_Testanwendung
{
    public class TestableCode
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int? FeatureXA1(string s)
        {
            return s?.Length;
        }

        public int FeatureXA2(int a, int b)
        {
            return a - b;
        }
    }
}
