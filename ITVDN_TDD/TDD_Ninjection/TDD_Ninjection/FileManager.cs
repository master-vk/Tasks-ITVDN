﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDD_Ninjection
{
    class FileManager
    {
        IDataAccessObject dataAccessObject;

        public FileManager()
        {

        }

        public FileManager(IDataAccessObject dataAccessObject)
        {
            this.dataAccessObject = dataAccessObject;
        }

        public bool FindLogFile(string fileName)
        {
            List<string> files = dataAccessObject.GetFiles();

            foreach (var file in files)
            {
                if (file.Contains(fileName))
                {
                    return true;
                }
            }

            return false;
        }
    }

}
