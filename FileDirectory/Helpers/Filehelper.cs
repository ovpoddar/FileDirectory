using System;
using System.IO;
using System.Linq;

namespace FileDirectory.Helpers
{
    public static class Filehelper
    {
        public static string SearchDirectory(string path, uint depth)
        {
            try
            {
                var result = "";
                var space = "";

                for (uint i = 0; i < depth; i++)
                    space += "\t";
                depth++;

                foreach (var item in Directory.GetDirectories(path))
                {
                    result += $"{space} {Path.GetFileName(item)} {Environment.NewLine}";
                    result += SearchDirectory(item, depth);
                }

                foreach (var item in Directory.GetFiles(path))
                {
                    //result.Aggregate((e1, e2) => space + 
                    result += $"{space} {Path.GetFileName(item)} {Environment.NewLine}";
                }

                return result;
            }
            catch(Exception ex)
            {
                if (ex.GetType().Name == "UnauthorizedAccessException")
                    return "";
                return ex.Message;
            }
        }
    }
}
