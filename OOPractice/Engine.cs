namespace OOPractice
{
    public class Engine
    {
        public Engine(string type)
        {
            if (type == "gasoline")
            {
                this.Speed = 30;
            }
            else if (type == "electronic")
            {
                this.Speed = 25;
            }

            this.Type = type;
        }

        public int Speed { get; }
        public string Type { get; }
    }
}