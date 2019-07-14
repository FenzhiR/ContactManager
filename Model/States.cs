﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Model
{
    public static class States
    {
        private static readonly List<string> _names;

        static States()
        {
            _names = new List<string>(50);
            _names.Add("Alabama");
            _names.Add("Alaska");

        }

        public static List<string> GetNames()
        {
            return _names;
        }
    }
}
