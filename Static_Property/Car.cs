namespace Static_Property
{
    internal class Car
    {
        private string name;
        private string engine;
        public static int numberOfCars;
        public Car(string name, string engine)
        {
            this.name = name;
            this.engine = engine;
            numberOfCars++;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }
        public void setEngine(string engine)
        {
            this.engine = engine;
        }
        public string getEngine()
        {
            return engine;
        }
    }
}