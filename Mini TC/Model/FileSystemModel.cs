using System.IO;

namespace Mini_TC.Model
{
    public static class FileSystemModel
    {
        public static DriveInfo[] GetDrives() => DriveInfo.GetDrives();

        public static string[] GetDirectories(string path)
        {
            if (!Directory.Exists(path)) return new string[0];
            return Directory.GetDirectories(path);
        }

        public static string[] GetFiles(string path)
        {
            if (!Directory.Exists(path)) return new string[0];
            return Directory.GetFiles(path);
        }

        public static string? GetParentDirectory(string path) => Directory.GetParent(path)?.FullName;
    }
}
