﻿using System;
using System.IO;

namespace FileDirectory.Helpers
{
    public static class Filehelper
    {
        public static string SearchDirectory(string path, uint depth)
        {
            var result = "";
            var space = "";


            for (uint i = 0; i < depth; i++)
                space += "\t";
            depth += 1;


            foreach (var item in Directory.GetDirectories(path))
            {
                result += $"{space} {Path.GetFileName(item)} {Environment.NewLine}";
                result += SearchDirectory(item, depth);
            }


            foreach (var item in Directory.GetFiles(path))
                result += $"{space} {Path.GetFileName(item)} {Environment.NewLine}";

            return result;
        }
    }
}