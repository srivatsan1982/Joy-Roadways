using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JOY_BUS_LAYER.SysAdmin
{
    public class ClsBranchEntity:IDisposable
    {
        public int MODE { get; set; }
        public int BRANCHID { get; set; }
        public string BRANCHCODE { get; set; }
        public string BRANCHNAME { get; set; }
        public string BRANCHCONTACTNAME { get; set; }
        public string BRANCHPHONE { get; set; }
        public string BRANCHMOBILEPHONE { get; set; }
        public string BRANCHADD1 { get; set; }
        public string BRANCHADD2 { get; set; }
        public string BRANCHCITY { get; set; }
        public string BRANCHPINCODE { get; set; }
        public string BRANCHCOUNTRY { get; set; }
        public int COMPANYID { get; set; }
        public int BRANCHACTIVE { get; set; }
        public int ADDERID { get; set; }
        public DateTime ADDEDDATE { get; set; }
        public int MODIFIERID { get; set; }
        public DateTime MODIFIEDDATE { get; set; }
        public int ALLFIELDSTAT { get; set; }
        public void Dispose()
        {
            
        }
    }
}
