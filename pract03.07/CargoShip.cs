using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract03._07
{
    internal class CargoShip : IShip, IFreightTransp, ICloneable, IComparable
    {
        string name;
        int loadCapacity;

        public string Name { get { return name; } set { name = value; } }
        public int LoadCapacity { get { return loadCapacity; } set { loadCapacity = value; } }

        public CargoShip()
        {
            name = " ";
            loadCapacity = 0;
        }

        public CargoShip(string name, int loadCapacity)
        {
            this.name = name;
            this.loadCapacity = loadCapacity;
        }

        public override string ToString()
        {
            return $"Корабль '{this.name}' имеет грузоподъёмность в {this.loadCapacity} кг.";
        }

        public object Clear()
        {
            this.name = null;
            this.loadCapacity = 0;
            return this;
        }

        public object Clone()
        {
            CargoShip cS = new CargoShip();
            cS.name = this.name;
            cS.loadCapacity = this.loadCapacity;
            return cS;
        }

        public string CompareTo(object obj)
        {
            CargoShip cS = (CargoShip)obj;
            int res = Math.Abs(this.loadCapacity - cS.loadCapacity);
            return $"Разница в грузоподъёмности: {res}.";
        }
    }
}
