using System;
using System.IO;

namespace FileDirectory.Helpers
{
    public class Filehelper : IFilehelper
    {
        public string SearchDirectory(string path, uint depth)
        {
            var result = "";
            var space = "";

            for (var i = 0; i < depth; i++)
                space += "\t";
            depth++;

            foreach (var item in Directory.GetDirectories(path))
            {
                if (!IsAccessible(item)) continue;
                result += $"{space} {Path.GetFileName(item)} {Environment.NewLine}";
                result += SearchDirectory(item, depth);
            }

            foreach (var item in Directory.GetFiles(path))
                result += $"{space} {Path.GetFileName(item)} {Environment.NewLine}";

            return result;
        }

        public bool IsAccessible(string path)
        {
            try
            {
                Directory.GetDirectories(path);
                return Path.GetFileName(path).Trim().ToLower() != "$RECYCLE.BIN".ToLower();
            }
            catch
            {
                return false;
            }
        }
    }
}
