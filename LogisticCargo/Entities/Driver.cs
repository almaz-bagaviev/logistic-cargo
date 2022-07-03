namespace LogisticСargo.Entities;

public class Driver
{
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public DateTime Date { get; set; }
    public List<DriverLicense> DriverLicenses { get; set; }
    public List<MainCargoInfo> MainCargo { get; set; }

    public Driver(string lastName, string firstName, string middleName, DateTime date)
    {
        this.LastName = lastName;
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.Date = date;
        this.DriverLicenses = new();
        this.MainCargo = new();
    }

    public override string ToString()
    {
        return $"{LastName} {FirstName} {MiddleName} {Date}";
    }
}