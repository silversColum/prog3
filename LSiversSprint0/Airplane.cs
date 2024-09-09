
namespace LSiversSprint0
{
    internal class Airplane : AerialVehicle
    {
        public Airplane()
        {
            MaxAltitude = 41000;
            Engine = new Engine();
            IsFlying = false;
            CurrentAltitude = 0;
            //Engine.IsStarted = false;
        }
    }
}