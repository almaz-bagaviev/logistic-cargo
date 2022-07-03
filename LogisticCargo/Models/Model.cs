namespace LogisticСargo.Models;

public class Model
{
    Driver driver;
    DriverLicense license;
    public List<Driver> listDrivers;
    public List<DriverLicense> listLicenses;
    ApplicationContext context;

    public Model()
    {
        context = new();
    }

    private void AddDriver()
    {
        listDrivers = new()
        {
            new Driver("Вагапов", "Александр", "Александрович", new DateTime(1977,02,08)),
            new Driver("Гордеев", "Пётр", "Иванович", new DateTime(1996,11,09)),
            new Driver("Евдокимов", "Максим", "Владимирович", new DateTime(1988,04,30)),
            new Driver("Соколов", "Марс", "Геннадьевич", new DateTime(1999,08,22)),
            new Driver("Новиков", "Роман", "Иванович", new DateTime(1981,12,02)),
        };
    }

    private void AddLicense()
    {
        listLicenses = new()
        {
            new DriverLicense(4500102, "Volvo", "FH", 13),
            new DriverLicense(6180199, "Mercedes-Benz", "Actros", 12.8),
            new DriverLicense(1145874, "Renault", "T-Series", 12.8),
            new DriverLicense(1000598, "MAN", "TGX", 12.4),
            new DriverLicense(1789645, "Scania", "G440", 12.7),
        };
    }

    private void Add2DriverTable()
    {
        foreach (var e in listDrivers)
        {
            context.DriverTable.Add(e);
        }
    }

    private void Add2LicenseTable()
    {
        foreach (var e in listLicenses)
        {
            context.LicenseTable.Add(e);
        }
    }

    private void Save()
    {
        context.SaveChanges();
    }

    public void Initial()
    {
        AddDriver();
        AddLicense();
        Add2DriverTable();
        Add2LicenseTable();
        Save();
    }
}