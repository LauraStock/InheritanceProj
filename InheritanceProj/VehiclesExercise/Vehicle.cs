using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProj.VehiclesExercise
{
    public class Vehicle
    {
        private string registrationNumber;
        private string model;
        private string owner;
        public string colour { get; set; }
        public int numberOfSeats { get; set; }

        public Vehicle() : this("XX00 XXX", "Unknown","No owner")
        { 
        }
        public Vehicle(string reg, string model, string owner)
        {
            this.registrationNumber = reg;
            this.model = model;
            this.owner = owner;
        }

        public void setReg(string reg)
        {
            this.registrationNumber = reg;
        }
        public string getReg()
        {
            return registrationNumber;
        }

        public void setModel(string model)
        {
            this.model = model;
        }
        public string getModel()
        {
            return model;
        }

        public void setOwner(string name)
        {
            this.owner = name;
        }
        public string getOwner()
        {
            return owner;
        }
        
    }
}
