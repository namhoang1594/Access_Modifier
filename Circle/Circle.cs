using System;
using System.Collections.Generic;
using System.Text;

namespace Circle
{
    class Circle
    {
        private double radius = 1.0;
        private string Color = "red";
        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        public string GetColor()
        {
            return Color;
        }
        public void SetColor(string Color)
        {
            this.Color = Color;
        }
    }
}
