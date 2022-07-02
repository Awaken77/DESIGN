﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabryka
{
   public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract void Render();
    }
}
