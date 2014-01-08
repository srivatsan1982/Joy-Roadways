using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JOY_BUS_LAYER.SysAdmin
{
    public class ClsCompanyEntity
    {
        public int MODE { get; set; }
        public int COMPANYID { get; set; }
        public string COMPANYNAME { get; set; }
        public string COMPANYALIAS { get; set; }
        public string COMPANYADD1 { get; set; }
        public string COMPANYADD2 { get; set; }
        public string COMPANYCITY { get; set; }
        public string COMPANYPIN { get; set; }
        public string COMPANYPHONE { get; set; }
        public string COMPANYMOBPHONE { get; set; }
        public string COMPANYFAX { get; set; }
        public string COMPANYPRFX { get; set; }
        public string COMPANYEMAIL { get; set; }
        public string COMPANYCURRNAME { get; set; }
        public string COMPANYCURRCODE { get; set; }
        public string COMPANYCURRSYM { get; set; }
        public decimal COMPANYPAISE { get; set; }
        public decimal COMPANYEXCHGRATE { get; set; }
        public string COMPANYTINNO { get; set; }
        public string COMPANYTNGSTNO { get; set; }
        public string COMPANYPANNO { get; set; }
        public string COMPANYBANKACCOUNT { get; set; }
        public string COMPANYBANKNAME { get; set; }
        public string COMPANYBANKBRANCH { get; set; }
        public int ADDERID{get;set;}
        public DateTime ADDEDATE{get;set;}
        public int MODIFIERID{get;set;}
        public DateTime MODIFIEDDATE{get;set;}

    }
}
