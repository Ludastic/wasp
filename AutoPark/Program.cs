using homework_oop;

static class main
{
    public static void Main(String[] args)
    {
        Dictionary<int, string> carrgolist = new Dictionary<int, string>();
        carrgolist.Add(0, "еда");
        carrgolist.Add(1, "не еда");
        carrgolist.Add(2, "что-то еще");
        carrgolist.Add(3, "фантазия");
        carrgolist.Add(4, "очень нужна");
        Autopark uwu = new Autopark("uwu", new List<Car>());
        uwu.AddCar(new Truck("BRRRR", 1000, 1980, 1000,"max", carrgolist));
        uwu.AddCar(new Car("BRRRR поменьше", 600, 1980));
        uwu.AddCar(new PassengerCar("BRRRR для народа", 1337, 2000, 2020));
        Console.WriteLine(uwu.ToString());
    }
}