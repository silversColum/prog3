namespace LSiversSprint0
{
    abstract class AerialVehicle
    {
        public int CurrentAltitude { get; set; }
        public Engine Engine { get; set; }
        public bool IsFlying { get; set; }
        public int MaxAltitude { get; set; }

        public string About()
        {
            if (Engine.IsStarted)
            {
                return $"This OOPFlyingVehicle.Airplane has a max altitude of " + MaxAltitude + " ft." +
                "\nIt's current altitude is " + CurrentAltitude + " ft." + "\nOOPFlyingVehicle.Engine is started.";
            }
            else
            {
                return $"This OOPFlyingVehicle.Airplane has a max altitude of " + MaxAltitude + " ft." +
                "\nIt's current altitude is " + CurrentAltitude + " ft." + "\nOOPFlyingVehicle.Engine is not started.";
            }
            
        }
        public AerialVehicle()
        {
            MaxAltitude = 41000;
            Engine = new Engine();
            IsFlying = false;
            CurrentAltitude = 0;
        }

            public void FlyDown(int HowManyFeet)
        {
            if ((CurrentAltitude - HowManyFeet) >= 0)
            {
                CurrentAltitude -= HowManyFeet;
            }
            else
            {
                CurrentAltitude -= 0;
            }
        }

        public void FlyUp()
        {
            if ((CurrentAltitude + 1000) <= MaxAltitude)
            {
                CurrentAltitude += 1000;
            }
            else
            {
                CurrentAltitude += 0;
            }
        }

        public void FlyUp(int HowManyFeet)
        {
            if ((CurrentAltitude + HowManyFeet) <= MaxAltitude)
            {
                CurrentAltitude += HowManyFeet;
            }
            else
            {
                CurrentAltitude += 0;
            }
        }
        public string getEngineStartedString()
        {
            return "";
        }
        public void StartEngine()
        {
            Engine.Start();
        }
        public void StopEngine()
        {
            Engine.Stop();
        }

        public string TakeOff()
        {
            if (Engine.IsStarted) 
            {
                return "OOPFlyingVehicleMidterm.Airplane is flying";
            }
            else
            {
                return "\nOOPFlyingVehicleMidterm.Airplane can't fly it's engine is not started.";
            }
        }
    }
}