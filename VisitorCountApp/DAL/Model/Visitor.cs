using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorCountApp.DAL.Model
{
    class Visitor
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string ContactNumber { set; get; }
        public Zone AZon { set; get; }

    }
}
