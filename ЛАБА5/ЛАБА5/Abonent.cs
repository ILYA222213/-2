

public class Abonent
{
    string FullName = "Unknow";
    double Address = 0;
    double Number = 0;
    int duration_city = 0;
    int duration_intercity = 0;



    public Abonent(string FullName, double Address, double Number, int duration_city, int duration_intercity)
    {
        this.FullName = FullName;
        this.Address = Address;
        this.Number = Number;
        this.duration_city = duration_city;
        this.duration_intercity = duration_intercity;
    }

    public void toString(string FullName, double Address, double Number, int duration_city, int duration_intercity)

    {
        Console.WriteLine("ФИО: " + FullName + "Адресс: " + Address + "Номер: " + Number + "Времени внутригородских разговоров: " + duration_city + "Пользование междугородней связи" + duration_intercity);
    }
}