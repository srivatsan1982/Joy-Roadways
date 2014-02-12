using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JOY_BUS_LAYER.SysAdmin
{
    public class ClsLorryEntity : IDisposable
    {
        public int MODE { get; set; }
        public int LRYID { get; set; }
        public string LRYNAME { get; set; }
        public int LRYOWNER { get; set; }
        public string LRYNUMBER { get; set; }
        public string LRYDESC { get; set; }
        public int COMPANYID { get; set; }
        public bool LORRYACTIVE { get; set; }
        public int ADDERID { get; set; }
        public DateTime? ADDEDDATE { get; set; }
        public int MODIFIERID { get; set; }
        public DateTime? MODIFIEDDATE { get; set; }
        public int ALLFIELDSTAT { get; set; }

        public void Dispose()
        {
            
        }
    }
}
