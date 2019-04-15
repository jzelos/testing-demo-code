using System.Collections.Generic;
using System.Linq;

namespace UnitTestDemo
{
    public class Greek
    {
        public List<string> Sort(ICollection<string> words)
        {            
            return words.OrderBy(o => o).ToList();
        }
    }
}
