﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KittenPlayer
{

    class LocalData
    {
        private static LocalData Instance = null;
        private String Path;

        private LocalData()
        {
            Path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            Path += "\\KittenPlayer\\";

            Console.Out.WriteLine(Path);
        }

        public static LocalData NewLocalData()
        {
            if(Instance == null)
            {
                Instance = new LocalData();
            }
            return Instance;
        }

        private void CreateTempData()
        {
            Directory.CreateDirectory(Path);

        }
    }
}
