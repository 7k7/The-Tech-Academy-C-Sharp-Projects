using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    // Employee generic class
    public class Employee<T>
    {
        // Generic List<T> property takes in a generic type
        public List<T> things {  get; set; }
    }
}
