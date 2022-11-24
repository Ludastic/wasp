namespace homework_oop;

public class Car
{
    private string _name;
    private int _power, _prodY;

    public string Name
    {
        set
        {
            _name = Convert.ToString(value);
        }
        get
        {
            return _name;
        }
    }

    public int Power
    {
        set
        {
            if (value < 1)
            {
                _power = 1;
            }
            else
            {
                _power = value;
            }
        }
        get
        {
            return _power;
        }
    }

    public int ProdY
    {
        set
        {
            if (value < 1900)
            {
                _prodY = 1900;
            }
            else
            {
                _prodY = value;
            }
        }
        get
        {
            return _prodY;
        }
    }

    public Car(string n, int p, int pY)
    {
        Name = n;
        Power = p;
        ProdY = pY;
    }

    public override string ToString()
    {
        return "Марка - " + _name.ToString() + " мощность - " + _power.ToString() + " год выпуска - " + _prodY.ToString();
    }
}

public class PassengerCar : Car
{
    private int _numOfPass;
    private Dictionary<string, int> _book = new Dictionary<string, int>();

    public int NumOfPass
    {
        set
        {
            if (value < 2)
            {
                _numOfPass = 2;
            }
            else
            {
                _numOfPass = value;
            }
        }
        get
        {
            return _numOfPass;
        }
    }

    public PassengerCar(string n, int p, int pY, int num) : base(n, p, pY)
    {
        NumOfPass = num;
    }

    public void AddDetail(string name, int y)
    {
        _book[name] = y;
    }

    public int GetYearOfReplace(string name)
    {
        return _book[name];
    }

    public void PrintAllReplace()
    {
        foreach (KeyValuePair<string, int> pair in _book)
        {
            Console.WriteLine($"Деталь - {pair.Key} была заменена в - {pair.Value} - году");
        }
    }

    public override string ToString()
    {
        return
            $"Марка - {Name.ToString()}, мощность - {Power.ToString()}, год выпуска - {ProdY.ToString()}, количество сидячих мест в авто - {NumOfPass}";
    }
}

public class Truck : Car
{
    private int _maxCap;
    private string _driverName;
    private Dictionary<int, string> _cargo;

    public int MaxCap
    {
        set
        {
            if (value<1)
            {
                _maxCap = 1;
            }
            else
            {
                _maxCap = value;
            }
        }
        get
        {
            return _maxCap;
        }
    }

    public string DriverName
    {
        set
        {
            _driverName = value.ToString();
        }
        get
        {
            return _driverName;
        }
    }

    public Dictionary<int, string> Cargo {get { return _cargo;} }

    public Truck(string n, int p, int pY, int max, string driver, Dictionary<int, string> car) : base(n, p, pY)
    {
        DriverName = driver;
        MaxCap = max;
        _cargo = car;
    }

    public void DeleteCargo(int num)
    {
        if (_cargo.ContainsKey(num))
        {
            _cargo.Remove(num);
        }
        else
        {
            Console.WriteLine("Груза с таким порядковым номером нет");
        }
    }
    public void AddCargo(string name, int num)
    {
        if (_cargo.ContainsKey(num))
        {
            _cargo.Add(num, name);
        }
        else
        {
            _cargo.Remove(num);
            _cargo.Add(num, name);
        }
    }

    public void PrintCargo()
    {
        foreach (KeyValuePair<int, string> currCargo in _cargo)
        {
            Console.WriteLine($"груз {currCargo.Value} с порядковым номером - {currCargo.Key}");
        }
    }

    public override string ToString()
    {
        return $"Марка - {Name.ToString()}, мощность - {Power.ToString()}, год выпуска - {ProdY.ToString()}, максимальная грузоподъемность - {MaxCap}, ФИ водителя - {DriverName}";
    }
}

class Autopark
{
    private string _parkName;
    private List<Car> _autopark;

    public string ParkName { set; get; }
    public Autopark(string nm, List<Car> list)
    {
        ParkName = nm;
        _autopark = list;
    }

    public void AddCar(Car obj)
    {
        _autopark.Add(obj);
    }

    public void DeleteCar(Car obj)
    {
        if (_autopark.Contains(obj))
        {
            _autopark.Remove(obj);
        }
        else
        {
            Console.WriteLine($"Извините, {obj} нельзя убрать, т.к ее несуществует");
        }
    }

    public override string ToString()
    {
        string carsInfo = "";
        foreach (Car obj in _autopark)
        {
            carsInfo += obj.ToString();
            carsInfo += "\n";
        }
        return carsInfo;
    }
}