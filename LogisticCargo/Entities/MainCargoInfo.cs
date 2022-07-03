namespace LogisticСargo.Entities;

public class MainCargoInfo
{
    public int DriverId { get; set; }
    public int LicenseId { get; set; }
    public Driver Drivers { get; set; }
    public DriverLicense Licenses { get; set; }

}
