namespace Practice.Devops.NugetRegistry;

public class NugetPackage : BasePackage
{
    public override void CompressPackage(int maxlength)
    {
        Console.WriteLine($"Compress package with {maxlength}");
    }

    public override void PackUp(string packagePath)
    {
        Console.WriteLine($"Packup package from location: {packagePath}");
    }
}
