using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeSeriDemo.Model
{
    [Serializable]
    internal class Car
    {
        public int CarNo { get; set; }
        public string CarName { get; set; }
    }
}
