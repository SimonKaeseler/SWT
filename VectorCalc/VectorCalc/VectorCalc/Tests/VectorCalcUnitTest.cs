using NUnit.Framework;
using VectorCalc.Implementation;

namespace Testsuite
    {
        [TestFixture]
        public class VectorCalcUnitTest
        {
            private VectorCalculator _calculator;
            [SetUp]
            public void SetUp_for_tests()
            {
                _calculator = new VectorCalculator();
            }


        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void AddToVectors_NoCondition_ResultIsCorrect()
        {
            var vec1 = new Cartesian2DVector()
            {
                y = 3,
                x = 3
            };

            var vec2 = new Cartesian2DVector()
            {
                y = 3,
                x = 3
            };

            Assert.That(_calculator.AddToVectors(vec1,vec2),Is.EqualTo(36));
        }

        }
    }
