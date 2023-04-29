using LinkedList.Logic;
static void Main(string[] args)
{
    // Crear la lista de carros
    LinkedList<Car> carList = new LinkedList<Car>();

    // Agregar 12 carros diferentes
    var ford = new Car { Brand = "Ford", Model = "Ranger", Year = 2023, Color = "Negra", Price = 235000000 };
    var nissan = new Car { Brand = "Nissan", Model = "Frontier", Year = 2023, Color = "Gris", Price = 260000000 };
    var renault = new Car { Brand = "Renault", Model = "Beat", Year = 2019, Color = "Rojo", Price = 40000000 };
    var chevrolet = new Car { Brand = "Chevrolet", Model = "Spark", Year = 2022, Color = "Azul", Price = 50000000 };
    var toyota = new Car { Brand = "Toyota", Model = "Corolla", Year = 2021, Color = "Azul", Price = 120000000 };
    var mazda = new Car { Brand = "Mazda", Model = "CX-5", Year = 2023, Color = "Azul", Price = 200000000 };
    var honda = new Car { Brand = "Honda", Model = "Civic", Year = 2022, Color = "Azul", Price = 90000000 };
    var fordFiesta = new Car { Brand = "Ford", Model = "Fiesta", Year = 2018, Color = "Azul", Price = 35000000 };
    var nissanSentra = new Car { Brand = "Nissan", Model = "Sentra", Year = 2020, Color = "Azul", Price = 80000000 };
    var renaultDuster = new Car { Brand = "Renault", Model = "Duster", Year = 2023, Color = "Azul", Price = 160000000 };
    var chevroletEquinox = new Car { Brand = "Chevrolet", Model = "Equinox", Year = 2022, Color = "Azul", Price = 220000000 };
    var toyotaYaris = new Car { Brand = "Toyota", Model = "Yaris", Year = 2022, Color = "Rojo", Price = 110000000 };
    
    var cars = new DoubleList<Car>();
    cars.Add(ford);
    cars.Add(nissan);
    cars.Add(renault);
    cars.Add(chevrolet);
    cars.Add(toyota);
    cars.Add(mazda);
    cars.Add(honda);
    cars.Add(fordFiesta);
    cars.Add(nissanSentra);
    cars.Add(renaultDuster);
    cars.Add(chevroletEquinox);
    cars.Add(toyotaYaris);

    // Probar el método GetBrand
    LinkedList<Car> fordList = cars.GetBrand("Ford");
    Console.WriteLine("Carros de la marca Ford:");
    PrintCars(fordList);

    // Probar el método GetYear
    LinkedList<Car> yearList = cars.GetYear(2020, 2023);
    Console.WriteLine("Carros entre 2020 y 2023:");
    PrintCars(yearList);

    // Probar el método GetPrice
    LinkedList<Car> priceList = cars.GetPrice(60000000, 120000000);
    Console.WriteLine("Carros entre $60,000,000 y $120,000,000:");
    PrintCars(priceList);

    // Probar el método GetSeveralFilters
    LinkedList<Car> filterList = cars.GetSeveralFilters("*", "Corolla", "Blanco", 2019, 200000000);
    Console.WriteLine("Carros que cumplen con varios filtros:");
    PrintCars(filterList);

    // Probar el método GetMinMax
    Car[] minMax = cars.GetMinMax();
    Console.WriteLine("Carro con menor precio: " + minMax[0]);
    Console.WriteLine("Carro con mayor precio: " + minMax[1]);

    Console.ReadLine();
}

static void PrintCars(LinkedList<Car> carList)
{
    Node<Car> current = carList.first;

    while (current != null)
    {
        Console.WriteLine(current.Data);
        current = current.Right;
    }
}






   