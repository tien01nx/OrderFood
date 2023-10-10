﻿using DevExpress.Office;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model
{
    
    public class RandomString
    {
        private readonly Random _random = new Random();
        private const string _characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public string NextString(int length)
        {
            return new string(Enumerable.Repeat(_characters, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }

}
