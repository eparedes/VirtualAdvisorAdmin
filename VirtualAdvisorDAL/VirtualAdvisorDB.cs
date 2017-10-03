using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAdvisorDAL
{
    public class VirtualAdvisorDB
    {
        private static VirtualAdvisor2Entities edmx = null;
        private static readonly object padlock = new object();

        private VirtualAdvisorDB() { }

        public static VirtualAdvisor2Entities GetInstance
        {
            get
            {
                lock (padlock)
                {
                    if (edmx == null)
                    {
                        edmx = new VirtualAdvisor2Entities();
                    }
                    return edmx;
                }
            }
        }
    }
}
