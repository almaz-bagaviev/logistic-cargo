namespace LogisticСargo.Entities;

public class DriverLicense
{
    public int Id { get; set; }
    public int No { get; set; }
    public string CarModel { get; set; }
    public string Mark { get; set; }
    public double Engine { get; set; }
    public List<Driver> Drivers { get; set; }
    public List<MainCargoInfo> MainCargo { get; set; }

    public DriverLicense(int no, string mark, string carModel, double engine)
    {
        this.No = no;
        this.Mark = mark;
        this.CarModel = carModel;
        this.Engine = engine;
        this.Drivers = new();
        this.MainCargo = new();
    }

    public override string ToString()
    {
        return $"{No} {Mark} {CarModel}";
    }
}