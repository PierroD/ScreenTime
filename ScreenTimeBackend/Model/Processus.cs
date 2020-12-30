using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenTimeBackend.Model
{
   public class Processus
    {
        public string Name { get; set; }
        public DateTime AddedAt { get; set; }
        public List<OpenTime> OpenTimes { get; set; }
    }
}
