﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassExample
{
    public class Car
    {
        private float _gasLevel;
        public float GasLevel
        {
            get
            {
                return _gasLevel;
            }
            set
            {
                if (value < 0 )
                {
                    throw new FormatException();
                }
                else
                {
                    _gasLevel = value;
                }
            }
        }
    }
}
