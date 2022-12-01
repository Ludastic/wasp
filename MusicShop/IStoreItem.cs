namespace homework_oop2;

public interface IStoreItem
{
    double Price { set; get; }

    void DiscountPrice(int perecent);
}