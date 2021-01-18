namespace FileDirectory.Helpers
{
    public interface IFilehelper
    {
        bool IsAccessible(string path);
        string SearchDirectory(string path, uint depth);
    }
}