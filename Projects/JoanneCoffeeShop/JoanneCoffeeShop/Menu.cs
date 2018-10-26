using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseOfCoffee
{
    public class Menu
    {
        public enum MenuOptions
        {
            Small = 1,
            Medium = 2,
            Large = 3,
            EggSandwich = 4,
            ChickenBiscuit = 5,
        }

        private readonly MenuOptions value;

        public static Menu Small { get { return new Menu(MenuOptions.Small); } }
        public static Menu Medium { get { return new Menu(MenuOptions.Medium); } }
        public static Menu Large { get { return new Menu(MenuOptions.Large); } }
        public static Menu EggSandwich { get { return new Menu(MenuOptions.EggSandwich); } }
        public static Menu ChickenBiscuit { get { return new Menu(MenuOptions.ChickenBiscuit); } }

        public Menu(MenuOptions value)
        {
            this.value = value;
        }
        public Menu()
        {
        }

        public override string ToString()
        {
            switch (value)
            {
                case MenuOptions.Small:
                    return ".10";
                case MenuOptions.Medium:
                    return ".15";
                case MenuOptions.Large:
                    return ".20";
                case MenuOptions.EggSandwich:
                    return ".95";
                case MenuOptions.ChickenBiscuit:
                    return "1.20";
                default:
                    throw new InvalidOperationException("Can't convert 0 value");
            }
        }
    }
}
