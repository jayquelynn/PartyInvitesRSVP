using Enumerations;

namespace MotorizedVehicles
{
    public class BaseMotorizedVehicle
    {
        private bool isDriving;
        public BaseMotorizedVehicle()
        {
            isDriving = false;
        }
        public EngineType EngineType { get;set;}
        public int NoOfTires { get; set; } 
        public string Brakes { get; set; }
        public string Transmission { get; set; }

        public virtual bool IsDriving()
        {
            return this.isDriving;
        }
        public virtual void SetDriving(bool isDriving)
        {
            this.isDriving = isDriving;
        }
    }
}
