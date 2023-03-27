using probaKvartira2;

namespace z1
{
    class Program
    {
        static void Main()
        {
            Apartment apartment = new Apartment("Бураня", 60, 100);
            Console.WriteLine("Базовый класс: ");
            Console.WriteLine($"Название: {apartment.Name}");
            Console.WriteLine($"Площадь: {apartment.Squre}");
            Console.WriteLine($"Стоимость 1-го метра квадратного: {apartment.Price}");


            ApartmentInTheCenter apartmentInTheCenter = new ApartmentInTheCenter("Октябрьский", "38", 100, 300);
            Console.WriteLine("Наследник класса Apartment: ");
            Console.WriteLine($"Название: {apartmentInTheCenter.Name}");
            Console.WriteLine($"Площадь: {apartmentInTheCenter.Squre}");
            Console.WriteLine($"Стоимость: {apartmentInTheCenter.Price}");
            Console.WriteLine($"Cтоимость с учетом надбавки за расположение:" +
                $" {apartmentInTheCenter.PriceIncludingLocationSurcharge()}");
        }
    }
}