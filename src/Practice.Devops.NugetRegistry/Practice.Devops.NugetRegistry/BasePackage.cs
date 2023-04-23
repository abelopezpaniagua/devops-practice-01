namespace Practice.Devops.NugetRegistry;

public abstract class BasePackage : IBindable
{
    public abstract void CompressPackage(int maxlength);
    public abstract void PackUp(string packagePath);
}