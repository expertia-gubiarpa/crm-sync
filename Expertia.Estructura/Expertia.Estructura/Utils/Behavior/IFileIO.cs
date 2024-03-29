﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expertia.Estructura.Utils.Behavior
{
    public interface IFileIO
    {
        string FullName { get; }
        void WriteContent(string content);
        void WriteContent(string[] contents);
        string ReadContent();
    }
}
