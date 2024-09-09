namespace LSiversSprint0
{
    public class Engine
    {
        public bool IsStarted = false;
        public string About()
        {
            return "\n";
        }
        public Engine() { 
            IsStarted = false;
        }

        public void Start()
        {
            IsStarted = true;
        }
        public void Stop()
        {
            IsStarted = false;
        }
    }
}