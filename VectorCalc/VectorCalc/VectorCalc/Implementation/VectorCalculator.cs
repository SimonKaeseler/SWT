using System;
using NUnit.Framework.Constraints;

namespace VectorCalc.Implementation
{
    public class VectorCalculator
    {
        private Cartesian2DVector _vec;

        public double AddToVectors(Cartesian2DVector vec1, Cartesian2DVector vec2)
        {
            var result = Math.Pow(vec1.x, 2) + Math.Pow(vec1.y, 2) + Math.Pow(vec2.x, 2) + Math.Pow(vec2.y, 2);
            return result;
        }
    }
}