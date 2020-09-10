using System;

namespace Laboration1
{
    public class Circle : ParentShape, IShapeMethods
    {
        private float Radius;
        public Circle()
        {
            Random RNG = new Random();
            Radius = (float)RNG.Next(0, 101);
        }
        public override float getArea()
        {   ///This method returns the area of the object
            return (float)(Radius * Radius * Math.PI);
        }
        public override float getCircumference()
        {   ///This method returns the circumference of the object
            return (float)(Radius * 2 * Math.PI);
        }
        public (string, float[], float[]) getInfo()
        {   ///This method returns a tuple with the type of shape, list of radius and diameter and a list of area and circumference in that order
            float[] Info1 = new float[2];
            Info1[0] = Radius;
            Info1[1] = Radius + Radius;
            float[] Info2 = new float[2];
            Info2[0] = getArea();
            Info2[1] = getCircumference();
            return ("Circle", Info1, Info2);
        }
    }
}
