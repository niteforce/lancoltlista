using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesztfeladat
{
    class Node
    {
        public Node(string value)
        {
            this.Value = value;
        }

        public string Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

    }
}
