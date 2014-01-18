using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JOY_BUS_LAYER.SysAdmin
{
    public class ClsCustomerEntity : IDisposable
    {
        public int MODE { get; set; }
        public int BRANCHID { get; set; }
        public int CUSTID { get; set; }
        public string CUSTCODE { get; set; }
        public string CUSTFIRSTNAME { get; set; }
        public string CUSTLASTNAME { get; set; }
        public string CUSTADD1 { get; set; }
        public string CUSTADD2 { get; set; }
        public string CUSTCITY { get; set; }
        public string CUSTPINCODE { get; set; }
        public string CUSTCOUNTRY { get; set; }
        public string CUSTEMAIL { get; set; }
        public string CUSTPHONE { get; set; }
        public string CUSTMOBPHONE { get; set; }
        public int COMPANYID { get; set; }
        public bool CUSTACTIVE { get; set; }
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
