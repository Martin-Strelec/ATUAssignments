namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ford", "Focus", 56, 1.6);
            Car car2 = new Car("Opel", "Astra", 32, 1.4);

            car1.DisplayCarInfo();
            for (int i = 0; i < 6; i++)
            {
                car1.Accelerate();
            }
            car1.DisplayCarInfo();
            car2.DisplayCarInfo();
        }
    }
}
