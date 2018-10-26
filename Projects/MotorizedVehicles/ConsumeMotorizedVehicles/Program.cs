using Enumerations;
using MotorizedVehicles;
using Structures;
using System;

namespace ConsumeMotorizedVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Coupe coupe = new Coupe
                {
                    Brakes = "disc",
                    EngineType = EngineType.V8,
                    NoOfTires = 4
                };


                Automobile auto = new Automobile
                {
                        Brakes = "disc",
                        EngineType = EngineType.V8,
                        NoOfTires = 4
                };

                Coupe coupeTwin = coupe;
                coupeTwin.EngineType = EngineType.V6;

                Console.WriteLine($"coupe has enginetype {coupe.EngineType.ToString()}");
                Console.WriteLine($"coupeTwin has enginetype {coupeTwin.EngineType.ToString()}");

                Automobile autoTwin = auto;
                autoTwin.EngineType = EngineType.V6;

                Console.WriteLine($"auto has enginetype {auto.EngineType.ToString()}");

                Console.WriteLine($"autoTwin has enginetype {autoTwin.EngineType.ToString()}");
                Console.ReadLine();

            }
            catch (Exception e)
            { throw e; }


        }
    }
}
