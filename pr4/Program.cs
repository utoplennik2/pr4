
class Bicycle
{
    public string brand;                                      //поля -властивості
    public string model;
    public string type;
    public double wheelSize;
    public string frameMaterial;
    public double weight;
    public double price;
    public string color;

    public string getBicycleCategory()                      //метод преміумності
    {
        if (price < 5000)
            return "економ клас";
        else if (price >= 5000 && price < 15000)
            return "cередній клас";
        else
            return "преміум клас";
    }

    static void Main(string[] args)
    {
        Console.Write("марка велосипеда:"); 
        string brand = Console.ReadLine();

        Console.Write("модель:");
        string model = Console.ReadLine();

        Console.Write("введіть тип (гірський, шосейний і т.д):");
        string type = Console.ReadLine();

        Console.Write("введіть розмір колеса (в дюймах):");
        string sWheelSize = Console.ReadLine();

        Console.Write("матеріал рами:");
        string frameMaterial = Console.ReadLine();

        Console.Write("вагу (кг):");
        string sWeight = Console.ReadLine();

        Console.Write("ціна (грн):");
        string sPrice = Console.ReadLine();

        Console.Write("колір:");
        string color = Console.ReadLine();

        Bicycle bike = new Bicycle();

        bike.brand = brand;                                    //запис даних у поля
        bike.model = model;
        bike.type = type;
        bike.wheelSize = double.Parse(sWheelSize);
        bike.frameMaterial = frameMaterial;
        bike.weight = double.Parse(sWeight);
        bike.price = double.Parse(sPrice);
        bike.color = color;

        Console.WriteLine("\n===========================");

        Console.WriteLine("\nДані про велосипед:");

        Console.WriteLine($"марка: {bike.brand}");
        Console.WriteLine($"модель: {bike.model}");
        Console.WriteLine($"тип: {bike.type}");
        Console.WriteLine($"розмір колеса: {bike.wheelSize}\"");
        Console.WriteLine($"ватеріал рами: {bike.frameMaterial}");
        Console.WriteLine($"вага: {bike.weight} кг");
        Console.WriteLine($"ціна: {bike.price} грн");
        Console.WriteLine($"колір: {bike.color}");
        Console.WriteLine($"категорія велосипеда: {bike.getBicycleCategory()}");          //метод преміум вел
    }
}
