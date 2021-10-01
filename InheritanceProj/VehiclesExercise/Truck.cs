using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProj.VehiclesExercise
{
    sealed class Truck : Vehicle
    {
        public double loadWeight { get; set; }
        public bool refridgerated { get; set; }
    }
}
