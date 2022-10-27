namespace OOPractice
{
    public class Car : Vehicle
    {
        public Car(string name, Engine engine) : base(name, engine.Speed)
        {
            this.Engine = engine;
        }

        public Engine Engine { get; }
    }
}