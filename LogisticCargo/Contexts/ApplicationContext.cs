namespace LogisticСargo.Contexts;

public class ApplicationContext : DbContext
{
    public DbSet<Driver> DriverTable { get; set; }
    public DbSet<DriverLicense> LicenseTable { get; set; }

    public ApplicationContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server = (LocalDB)\MSSQLLocalDB;
                                    DataBase = LogisticCargoDB;
                                    Trusted_Connection = True;");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Driver>()
            .HasMany(d => d.DriverLicenses)
            .WithMany(l => l.Drivers)
            .UsingEntity<MainCargoInfo>(
            j => j
            .HasOne(mci => mci.Licenses)
            .WithMany(l => l.MainCargo)
            .HasForeignKey(mci => mci.LicenseId), // связь с таблицей License через LicenseId
            j => j
            .HasOne(j => j.Drivers)
            .WithMany(mci => mci.MainCargo)
            .HasForeignKey(mci => mci.DriverId), // связь с таблицей Driver через DriverId
            j =>
            {
                j.HasKey(k => new
                { k.DriverId, k.LicenseId }
            );
                j.ToTable("Main");
            });
    }


}