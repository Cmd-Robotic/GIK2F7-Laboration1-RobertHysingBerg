using System;

namespace Laboration1
{
    public class Rectangle : ParentShape, IShapeMethods
    {
        private float Side1;
        private float Side2;
        public Rectangle()
        {
            Random RNG = new Random();
            Side1 = (float)RNG.Next(0, 101);
            Side2 = (float)RNG.Next(0, 101);
        }
        public override float getArea()
        {   ///This method returns the area of the object
            return Side1 * Side2;
        }
        public override float getCircumference()
        {   ///This method returns the circumference of the object
            return Side1 * 2 + Side2 * 2;
        }
        public (string, float[], float[]) getInfo()
        {   ///This method returns a tuple with the type of shape, list of the sides and a list of area and circumference in that order
            float[] info1 = new float[4];
            info1[0] = Side1;
            info1[1] = Side2;
            info1[2] = Side1;
            info1[3] = Side2;
            float[] info2 = new float[2];
            info2[0] = getArea();
            info2[1] = getCircumference();
            return ("Rectangle", info1, info2);
        }
    }
}
