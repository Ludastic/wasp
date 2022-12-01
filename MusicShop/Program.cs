
using homework_oop2;

class main
{
    static void Main()
    {
        Store store = new Store("Бум-бум", "улица Пушкина, дом колотушкина");
        Audio disk1 = new Audio("Кровосток", "Реееп 2000 mlg", 1, "Цветы в вазе", "Чувак, это рэпчик");
        store = store + disk1;
        Audio disk2 = new Audio("Валентин Стрыкало", "Гараж и две по 0.5", 2, "Хиты - Стрыкало", "Для души)");
        store = store + disk2;
        DVD disk3 =new DVD("Светлана Баскова", "Любительский фильмец", 89, "Зеленный слоник",
            "Для семейного просмотра");
        store = store + disk3;
        DVD disk4 = new DVD("Олег Куваев", "Любительский фильмец", 2, "Масяня", "Детская комедия");
        store = store + disk4;
        Console.WriteLine(store);
        store.Audios[1].Burn("0", "1", "2", "3", "4");
        foreach (Audio dis in store.Audios)
        {
            Console.WriteLine($"название диска: {dis.Name}, размер диска: {dis.DiskSize}");
        }
        foreach (DVD dis in store.Dvds)
        {
            Console.WriteLine($"название диска: {dis.Name}, размер диска: {dis.DiskSize}");
        }
    }
}