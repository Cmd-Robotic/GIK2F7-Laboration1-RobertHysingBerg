using System;

namespace Laboration1
{
    public class Triangle : ParentShape, IShapeMethods
    {
        private float Side1;
        private float Side2;
        private float Side3;
        public Triangle()
        {
            Random RNG = new Random();
            bool loopin = true;
            while (loopin)
            {
                Side1 = (float)RNG.Next(0, 101);
                Side2 = (float)RNG.Next(0, 101);
                Side3 = (float)RNG.Next(0, 101);
                if (Side1 + Side2 > Side3 && Side2 + Side3 > Side1 && Side3 + Side1 > Side2)
                {   ///Triangle inequality theorem! Two sides added together must always be larger than the other side, otherwise it's not a triangle!
                    loopin = false;
                }
            }
        }
        public override float getArea()
        {   ///This method returns the area of the object, Darn tricky Triangles and their areas...

            float s = getCircumference() / 2;   ///s for semi-perimeter
            return (float)Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
            ///Above is Heron's formula, which uses the fact that the shape of a triangle is determined by the length of its sides and due to that the area can also be derived from that, apparently...

            /*  Leaving this in just because it took a while to write, even though I found an easier way to do this without having to check what kind of triangle it is and thus making it way more efficient...
            if (Side1 == Side2 && Side2 == Side3)
            {   ///This part is for calculating the area of an equilateral triangle, a triangle where all sides are equal
                float a = Side1;
                Area = (float)Math.Sqrt(3) / 4 * (a * a);
            }
            else if (Side1 == Side2 || Side2 == Side3 || Side3 == Side1)
            {   ///This part is for calculating the area of an isosceles triangle, a triangle where two sides are equal
                if (Side1 == Side2)
                {
                    float a = Side1;
                    float b = Side3;
                    Area = (float)Math.Sqrt((Math.Pow(a, 2) * Math.Pow(b, 2)) / 4 - Math.Pow(b, 4) / 16);
                }
                else if (Side2 == Side3)
                {
                    float a = Side2;
                    float b = Side1;
                    Area = (float)Math.Sqrt(Math.Pow(a, 2) * Math.Pow(b, 2) / 4 - Math.Pow(b, 4) / 16);
                }
                else
                {
                    float a = Side3;
                    float b = Side2;
                    Area = (float)Math.Sqrt(Math.Pow(a, 2) * Math.Pow(b, 2) / 4 - Math.Pow(b, 4) / 16);
                }
            }
            else
            {   ///And finally, this part is for calculating the area of an scalene triangle, a triangle where all the interior angles are different
                float a = Side1;
                float b = Side2;
                float c = Side3;
                Area = (float)Math.Sqrt(Math.Pow(Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2), 2) - 2 * (Math.Pow(a, 4) + Math.Pow(b, 4) + Math.Pow(c, 4))) / 4;
            }   */
        }
        public override float getCircumference()
        {   ///This method returns the circumference of the object
            return Side1 + Side2 + Side3;
        }
        public (string, float[], float[]) getInfo()
        {   ///This method returns a tuple with the type of shape, list of the sides and a list of area and circumference in that order
            float[] info1 = new float[3];
            info1[0] = Side1;
            info1[1] = Side2;
            info1[2] = Side3;
            float[] info2 = new float[2];
            info2[0] = getArea();
            info2[1] = getCircumference();
            return ("Triangle", info1, info2);
        }
    }
}
