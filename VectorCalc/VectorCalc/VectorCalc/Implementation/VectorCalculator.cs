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

        public double SubTwoVectors(Cartesian2DVector vec1, Cartesian2DVector vec2)
        {
            return (Math.Pow(vec1.x, 2) + Math.Pow(vec1.y, 2)) - (Math.Pow(vec2.x, 2) + Math.Pow(vec2.y, 2));
        }

        public Cartesian2DVector Scale(Cartesian2DVector vec1, double i)
        {
            Cartesian2DVector vec2 = new Cartesian2DVector() {y = vec1.y*i,x= vec1.x*i};    
            return vec2;
        }

        public double Dot(Cartesian2DVector vec1, Cartesian2DVector vec2)
        {
            return (vec1.x*vec2.x) + (vec1.y*vec2.y);
        }

        public double AngleBetween(Cartesian2DVector vec1, Cartesian2DVector vec2)
        {
            var dotproduct = Dot(vec1, vec2);
            var length = Math.Sqrt((Math.Pow(vec1.x, 2) + Math.Pow(vec1.y, 2)))*
                         Math.Sqrt((Math.Pow(vec2.x, 2) + Math.Pow(vec2.y, 2)));

            var angle = dotproduct/length;
            return Math.Acos(angle);
        }
    }
}