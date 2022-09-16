using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp2.Models
{
    public class Node
    {
        public Node(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public List<Node> Children { get; set; }
    }
}
