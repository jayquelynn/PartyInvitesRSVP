using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program
    {
        static void Components()
        {
            Console.WriteLine("\nEquipment");
            Equipment myEquipment = new Equipment();

            Console.WriteLine("Weapons");
            Weapons myWeapons = new Weapons();
            myWeapons.ShotSound("Pow Pow");
            myWeapons.m16();
            myWeapons.m1014();
            myWeapons.m240();
            Console.Read();

            Console.WriteLine("Vehicles");
            Vehicles myVehicles = new Vehicles();
            myVehicles.StartSound("Whirrrr");
            myVehicles.JLTV();
            myVehicles.MTVR();
            myVehicles.HMMWV();
            myVehicles.HEMTT();
            Console.Read();

            Console.WriteLine("Personnel");
            Personnel myPersonnel = new Personnel();
            myPersonnel.Pvt();
            myPersonnel.Lcpl();
            myPersonnel.Cpl();
            myPersonnel.Sgt();
            myPersonnel.SSgt();
            myPersonnel.GySgt();
            myPersonnel.MSgt();
            myPersonnel.ISgt();
            myPersonnel.MGysgt();
            myPersonnel.SgtMaj();
            Console.Read();
        }

        static void Main()
        {
            try
            {
                Components();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
