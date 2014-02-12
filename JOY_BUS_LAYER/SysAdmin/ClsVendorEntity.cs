using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JOY_BUS_LAYER.SysAdmin
{
    public class ClsVendorEntity:IDisposable
    {
        public int MODE { get; set; }
        public int VNDID { get; set; }
        public string VNDCODE { get; set; }
        public string VNDNAME { get; set; }
        public string VNDADD1 { get; set; }
        public string VNDADD2 { get; set; }
        public string VNDCITY { get; set; }
        public string VNDPINCODE { get; set; }
        public string VNDCOUNTRY { get; set; }
        public string VNDEMAIL { get; set; }
        public string VNDMOBPHONE { get; set; }
        public string VNDPHONE { get; set; }
        public string VNDTINNO { get; set; }
        public string VNDBANKNAME { get; set; }
        public string VNDBANKBRANCH { get; set; }
        public string VNDBANKACCNO { get; set; }
        public string VNDIFSCODE { get; set; }
        public int COMPANYID { get; set; }
        public bool VNDACTIVE { get; set; }
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
