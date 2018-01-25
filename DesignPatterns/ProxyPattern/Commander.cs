using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Commander
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public Commander(string name, string pwd)
        {
            Name = name;
            Password = pwd;
        }
    }
}
