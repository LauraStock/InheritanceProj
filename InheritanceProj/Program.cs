using System;
using InheritanceProj.VehiclesExercise;

namespace InheritanceProj
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int h = 5;
            int w = 4;

            Triangle pythagTriple = new Triangle();
            pythagTriple.setHeight(h);
            pythagTriple.setWidth(w);

            Console.WriteLine(pythagTriple.getArea());
            */

            Vehicle c1 = new Car();
            c1.setReg("BU52 PUW");
            c1.setModel("Ford Focus");
            Vehicle m1 = new Motorbike();
            m1.setReg("YH16 NUD");
        }
    }
}
