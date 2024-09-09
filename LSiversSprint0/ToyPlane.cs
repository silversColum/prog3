namespace LSiversSprint0
{
    internal class ToyPlane : Airplane
    {
        public bool isWoundUP { get; set; }
        public ToyPlane() {
            MaxAltitude = 41000;
            Engine = new Engine();
            IsFlying = false;
            CurrentAltitude = 0;
        }
        public string About()
        {
            return "";
        }
        public string getWindUpString()
        {
            return "";
        }
        public void StartEngine()
        {
            Console.WriteLine("ENGINE STARTEDD");
        }
        public string TakeOff()
        {
            return "";
        }
        public void UnWind()
        {
            Console.WriteLine("ENGINE STARTEDD");
        }
        public void WindUp()
        {
            Console.WriteLine("ENGINE STARTEDD");
        }
    }
}