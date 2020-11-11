using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    public class ShapeFactory
    {
        private static Dictionary<string, IShape> ShapeMap = new Dictionary<string, IShape>();

        public static IShape GetShape(string ShapeType)
        {
            IShape shape = null;
            if (ShapeType.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
            {
                if (ShapeMap.TryGetValue("circle", out shape))
                {
                }
                else
                {
                    shape = new Circle();
                    ShapeMap.Add("circle", shape);
                    Console.WriteLine(" Creating circle object with out any color in shapefactory \n");
                }
            }
            return shape;
        }
    }
}
