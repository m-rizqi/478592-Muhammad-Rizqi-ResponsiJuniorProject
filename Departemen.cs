﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi_2
{
    public class Departemen
    {
        private int id;
        private string name;

        public Departemen(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id { get { return id; } set { id = value;  } }
        public string Name { get { return name; } set { name = value; } }
    }
}
