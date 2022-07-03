Model model = new();
model.Initial();

foreach (var e in model.listDrivers)
{
    Console.WriteLine(e);
}

foreach (var e in model.listLicenses)
{
    Console.WriteLine(e);
}
