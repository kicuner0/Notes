namespace Notes.Core
{
    public class Deleter
    {
        public static void DeleteFile(string path)
        {
            File.Delete(path);
        }
    }
}
