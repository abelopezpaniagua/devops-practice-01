namespace Practice.Devops.NugetRegistry;

public interface IBindable
{
    void CompressPackage(int maxlength);
    void PackUp(string packagePath);
}
