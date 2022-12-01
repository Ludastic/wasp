namespace homework_oop2;

public class Disk : IStoreItem
{

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Genre
    {
        get { return genre; }
        set { genre = value; }
    }

    private string name, genre;
    private int burnCount;

    public int BurnCount
    {
        get { return burnCount; }
        
        set => burnCount = value;
    }

    public double Price { get; set; }

    public void DiscountPrice(int perecent)
    {
        Price = Price * perecent * 0.01;
    }

    protected Disk(string nm, string genre)
    {
        Name = nm;
        Genre = genre;
    }

    virtual public int DiskSize { get; set; }

    virtual public void Burn(params string[] values) {}
}

public class Audio : Disk
{
    private string? artist;
    private string? recordingStudio;

    public string? Artist
    {
        get
        {
            return artist;
        }
        set
        {
            if (value == null)
            {
                artist = "default";
            }
            else
            {
                artist = value;
            }
        }
    }

    public string? RecordingStudio
    {
        get
        {
            return recordingStudio;
        }
        set
        {
            if (value == null)
            {
                artist = "default";
            }
            else
            {
                artist = value;
            }
        }
    }
    private int songsNumber;

    public int? SongsNumber
    {
        get
        {
            return songsNumber;
        }
        set
        {
            if (value == null)
            {
                songsNumber = 0;
            }
            else
            {
                songsNumber = Convert.ToInt32(value);
            }
        }
    }
    public Audio(string? arti, string? studio, int count, string nm, string genre) : base(nm, genre)
    {
        Artist = arti;
        RecordingStudio = studio;
        SongsNumber = count;
    }

    public override int DiskSize
    {
        get
        {
            return songsNumber * 8;
        }
    }

    public override void Burn(params string[] values)
    {
        BurnCount++;
        Name = values[0];
        Genre = values[1];
        Artist = values[2];
        RecordingStudio = values[3];
        SongsNumber = Convert.ToInt32(values[4]);
    }

    public override string ToString()
    {
        return $"Название: {Name}, жанр: {Genre}, исполнитель: {Artist}, студия звукозаписи: {RecordingStudio}, количество песен: {SongsNumber}, количество прожигов: {BurnCount}";
    }
    
}

class DVD : Disk
{
    private string producer, filmCompany;
    private int minutesCount;

    public string? Producer
    {
        set
        {
            if (value == null)
            {
                producer = "default";
            }
            else
            {
                producer = value;
            }
        }
        get
        {
            return producer;
        }
    }

    public string? FilmCompany
    {
        set
        {
            if (value == null)
            {
                filmCompany = "default";
            }
            else
            {
                filmCompany = value;
            }
        }
        get
        {
            return filmCompany;
        }
    }

    public int MinutesCount
    {
        set
        {
            if (value < 0)
            {
                minutesCount = 0;
            }
            else
            {
                minutesCount = value;
            }
        }
        get
        {
            return minutesCount;
        }
    }

    public DVD(string producer, string company, int count,string nm, string genre) : base(nm, genre)
    {
        Producer = producer;
        FilmCompany = company;
        MinutesCount = count;
    }

    public override int DiskSize {
        get
        {
            return (MinutesCount / 64) * 2;
        }
    }

    public override void Burn(params string[] values)
    {
        BurnCount++;
        Name = values[0];
        Genre = values[1];
        Producer = values[2];
        FilmCompany = values[3];
        MinutesCount = Convert.ToInt32(values[4]);
    }

    public override string ToString()
    {
        return $"Название: {Name}, жанр: {Genre}, продюсер: {Producer}, кинокомпанию: {FilmCompany}, количество минут: {MinutesCount}, количество прожигов: {BurnCount}";
    }
    
    public static List<DVD> operator +(DVD obj, List<DVD> list)
    {
        list.Add(obj);
        return list;
    }

    public static List<DVD> operator -(DVD obj, List<DVD> list)
    {
        if (list.IndexOf(obj) != -1)
        {
            list.RemoveAt(list.IndexOf(obj));
        }
        else
        {
            Console.WriteLine("Такого диска нет");
        }

        return list;
    }
}

class Store
{
    private string storeName, address;

    public string StoreName { set ; get; } = "default";
    public string Address { set; get; } = "default";
    protected List<Audio> audios = new List<Audio>();
    protected List<DVD> dvds = new List<DVD>();

    public List<Audio>Audios
    {
        get
        {
            return audios;
        }
    }

    public List<DVD> Dvds
    {
        get
        {
            return dvds;
        }
    }
    public Store(string nm, string ad)
    {
        StoreName = nm;
        Address = ad;
    }

    public override string ToString()
    {   
        Console.WriteLine("Список аудио дисков:");
        foreach (Audio dis in audios)
        {
            Console.WriteLine(dis.ToString());
        }
        Console.WriteLine("Список дисков с фильмами:");
        foreach (DVD dis in dvds)
        {
            Console.WriteLine(dis.ToString());
        }

        return "Ну как-то так!";
    }

    public static Store operator +(Store store, Audio obj)
    {
        store.audios.Add(obj);
        return store;
    }

    public static Store operator -(Store store, Audio obj)
    {
        
        if (store.audios.IndexOf(obj) != -1)
        {
            store.audios.RemoveAt(store.audios.IndexOf(obj));
        }
        else
        {
            Console.WriteLine("Такого аудио нет магазине");
        }

        return store;
    }

    public static Store operator +(Store store, DVD obj)
    {
        store.dvds.Add(obj);
        return store;
    }

    public static Store operator -(Store store, DVD obj)
    {
        if (store.dvds.IndexOf(obj) != -1)
        {
            store.dvds.RemoveAt(store.dvds.IndexOf(obj));
        }
        else
        {
            Console.WriteLine("Упс, в магазине нет такого двдишника(");
        }

        return store;
    }
}