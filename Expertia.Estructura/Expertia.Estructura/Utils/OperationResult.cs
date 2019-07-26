﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Expertia.Estructura.Utils
{
    public class OperationResult
    {
        private Dictionary<string, object> _values = new Dictionary<string, object>();

        public object this[string key]
        {
            get
            {
                return _values[key];
            }
            set
            {
                _values.Add(key, value);
            }
        }
    }
}