using Enumerations;

namespace MotorizedVehicles
{
    interface IMotorizedVehicle
    {
        EngineType EngineType { get; set; }
        int NoOfTires { get; set; }
        string Brakes { get; set; }
        string Transmission { get; set; }

        bool Driving();
        bool Driving(bool isDriving);
    }
}
