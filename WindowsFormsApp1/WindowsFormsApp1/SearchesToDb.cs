using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SearchesToDb
    {
        private RishonimEntities context = new RishonimEntities();
        private Search search;
        
        internal void AddSearch(string number, string gormim, DateTime now)
        {
            search = new Search() { Number = Convert.ToInt64(number), Gormim = gormim, Timestamp = now };
            context.Searches.Add(search);
            context.SaveChanges();
          //  throw new NotImplementedException();
        }
    }
}
