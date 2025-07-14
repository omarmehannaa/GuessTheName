using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Responses
{
    public class StartSpectate
    {
        public string[] Players {  get; set; }
        public List<Char> Word { get; set; } = new();
        public int IndexOfCurrentPlayer {  get; set; } = 0;
    }
}
