using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_DZ
{
    internal interface ApiServic
    {
        public string res { get; set; }
        public async void Zapros(int num) { }
    }
}
