using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb_proga_
{
    class TaskThree
    {
        public List<int> NoPairNumb(List<int> numb)
        {
            var noPairNumb = numb.Where(i => i % 2 != 0).ToList();
            
            return noPairNumb;
        }
        public List<int> NoReapeat(List<int>numb)
        {
            numb = numb.Distinct().ToList();
            return numb;
        }
    }
}
