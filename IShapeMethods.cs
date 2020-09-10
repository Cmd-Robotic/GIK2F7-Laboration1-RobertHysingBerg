using System;

namespace Laboration1
{
    public interface IShapeMethods
    {
        float getArea();
        float getCircumference();
        (string, float[], float[]) getInfo();
    }
}
