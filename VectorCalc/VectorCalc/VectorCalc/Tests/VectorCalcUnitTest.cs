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


        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void SubTwoVectors()
        {
            var vec1 = new Cartesian2DVector()
            {
                y = 0,
                x = 0
            };

            var vec2 = new Cartesian2DVector()
            {
                y = 0,
                x = 0
            };
            Assert.That(_calculator.SubTwoVectors(vec1,vec2),Is.EqualTo(0));
        }


        /// <summary>
        /// 
       // / </summary>
        [Test]
        public void ScaleVector()
        {
            double factor = 3;
            var vec1 = new Cartesian2DVector()
            {
                y = 3,
                x = 3
            };

            var vec2 = new Cartesian2DVector()
            {
                y = 9,
                x = 9
            };
            Assert.That(_calculator.Scale(vec1,factor),Is.EqualTo(vec2));
        }


        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void DotProcuctOfTwoVectors_NoCondition_CorrectREsult()
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
            
            Assert.That(_calculator.Dot(vec1,vec2),Is.EqualTo(18));
        }


        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void AngleBetween_NoCondition_CorrectAngle()
        {
            var vec1 = new Cartesian2DVector()
            {
                y = 3,
                x = 3
            };
            var vec2 = new Cartesian2DVector()
            {
                y = -3,
                x = -3
            };
            Assert.That(_calculator.AngleBetween(vec1,vec2),Is.EqualTo(180.0));
        }

    }
    }
