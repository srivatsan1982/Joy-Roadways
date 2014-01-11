using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JOY_DAL_LAYER.DataAccessComponent;
using System.Data;

namespace JOY_DAL_LAYER
{
    sealed class DALModule
    {
        public static DataProvider DPFactory;
        public static string Connection;
        public static String[] ConnName;
        public static Dictionary<string, Object> PARAMS;
        public static DataSet DSRESULT;
        public static DataTable DTRESULT;
        public static log4net.ILog DALlogger;
        public static int EXECRESULT;
    }
}
