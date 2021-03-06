﻿using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using JOY_UI_LAYER.SysAdmin;
using JOY_UI_LAYER.Common;
using JOY_BUS_LAYER.SysAdmin;
using JOY_CONTROL_LAYER.SysAdmin;

namespace JOY_UI_LAYER
{
    public class ProgramModule
    {

        public string[] SET_SECURITY = new string[1];
        public const int ALLOWMULTICMP = 0;
        public const int ALLOWMULTICOUNTER = 0;
        public string ITEM_ENTRY_PWD = "";
        public static int Uid;
        public int POS;
        public byte TOTDISCNTASAMT;
        public bool kp;
        public int USRLVL;
        public static string USRNM;
        public static string APPDATE;
        public static string PERIOD;
        public static string SYSPATH;
        public string CURRYR;
        public byte FRMCONTCALL;
        public byte BKGTRANS;
        public byte IMPSBCALL;
        public byte FRMCPTCALL;
        public byte FRMBRCALL;
        public byte FRMVOYCALL;
        public byte FRMCARRIERCALL;
        public byte FRMPOFCALL;
        public byte FRMFORCALL;
        public byte FRMCFCALL;
        public byte FRMSPCALL;
        public byte FRMCSIGNCALL;
        public byte FRMNTFYCALL;
        public byte FRMFCSIGNCALL;
        public byte FRMPRODCALL;
        public static string MsgboxCaption = "Joy Roadways Logistics";
        public static string REP;
        public bool PRNTFLG;
        public byte BILLADJSTFLG;
        public int FLDTYPE;
        public int CDTYE;
        public string FRMCAP;
        public PictureBox LOGOPICT;
        private bool NOTOK;
        public bool CNTRLFLG;
        public bool EDITDS;
        public static dynamic FrmMdiMain;
        public bool ISITLITE;
        string AA;
        string EXIST;
        string SCODE;
        string Time;
        public bool MLSIAMOD;
        public static bool SAVED;
        public bool DELETED;
        public string LMsg;
        public LstItemData CLS = new LstItemData("", "");
        public static FrmMdiMain objFrmMdiMain = new FrmMdiMain();
        //public ManagementObjectSearcher objMOS;
        //public ManagementObjectCollection objMOC;
        //public ManagementObject objMO;
        public string DateFormat;
        public bool DateSetDt;
        public static dynamic ActiveChildForm;
        public FrmHlpGrd sFrmHlpGrd = new FrmHlpGrd();
        public OleDbTransaction Tran;
        public System.IO.TextReader TReader;
        public System.IO.TextWriter TWriter;
        public const int IS_MISSING_OPTIONAL_PARAM_INT = 0;
        public int MNUTAG;
        public long SELFY;
        public string RD;
        public string CMD;
        public byte IAUTOCBM;
        public byte IFREEDAYS;
        public byte IPDFREEDAYS;
        public byte EAUTOCBM;
        public byte IFRTSUM;
        public byte SEPRCPT;
        public byte EBLNO;
        public byte CCPRI;
        public byte CCSEC;
        public string LINECODE;
        public string SARNNO;
        public string CARNNO;
        public string SRVTAXNO;
        public byte IDORCPT;
        public byte DTNCALC;
        public byte ISFBILL;
        public string LOCALE;
        public byte ERNDAMT;
        public byte IRNDAMT;
        public byte IBNK;
        public byte EBNK;
        public byte IKEYPRESS;
        public byte EKEYPRESS;
        public string CCFNAME;
        public string CAFNAME;
        public byte CCFSTYLE;
        public byte CCFSIZE;
        public byte CAFSIZE;
        public byte CAFSTYLE;
        public bool CADDATBTM;
        public bool SHOWRPT;
        public static string CBM_SETTING;
        public static string CURRENCY_NAME;
        public static string CURRENCY_SYMBOL;
        public static string CURRENCY_CODE;
        public static string CURRENCY_PAISE;
        public static float EXCHANGE_RATE;
        public string CFNAME;
        public string AFNAME;
        public byte CFSIZE;
        public byte AFSIZE;
        public byte CFSTYLE;
        public byte AFSTYLE;
        public bool ADDATBTM;
        public string CollFrdt;
        public string CollTodt;
        public string CollCountr;
        public int CollCounter;
        public int Collbank;
        public const int ADD = 1;
        public const int MODIFY = 2;
        public const int DELETE = 3;
        public const int VIEW = 4;
        public static int CMPID;
        public string SELECTEDLOCATION;
        public Color INFOCUS = Color.Lavender;
        public Color OUTFOCUS = Color.White;
        public string MCS;
        public bool VALFLG;
        public string MsgData;
        public string LOCALIP;
        public string DB_FLDNAME;
        public string DB_FLDTYPE;
        public string TYPEMSG;
        public int DB_FLDPREC;
        public int DB_FLDSCALE;
        public int counter;
        public System.DateTime JBYR;
        public bool EOUSAM;
        public bool EOUIVV;
        public bool RESTRICT;
        public static bool CANFLG;
        // Key is preserved when system is rebooted
        public string RemoteHost;
        public int NOUSR;
        public byte OVERWRITE;
        public bool SendComplete;
        public static bool ISITOK;
        public static bool LOADED;
        public const string FIRSTTIME = "01";
        public const string SYSVALID = "02";
        public const string SYSNOTVALID = "03";
        public const string QUIT = "04";
        public const string MESSAGE = "05";
        public const string MYNAME = "06";
        public const string SYSDEMO = "07";
        public const string SYSCNTEXCD = "08";
        public const string SYSOVERWRITE = "09";
        public const string CHNGLICENCE = "10";
        public string APPPATH;
        public string APPNAME;
        public string PATCHDT;
        public struct FFLOC
        {
            public string LOCATION;
            public string DSN;
            public string LICENSE;
            public string SERVERNAME;
        }
        public dynamic HKEY_LOCAL_MACHINE = "&H80000002";
        public object LGM;
        public object Frm;
        public FFLOC[] LOCS;
        public byte COUNTERID;
        public byte BILLTYPE;
        public byte MINITMROWS;
        public string COUNTERTYPE;
        public string COUNTER_NAME;
        public string FOOTNOTE;
        public string NINES;
        public string SERVERIP;
        public string SCODE1;
        public string STATEDESC;
        public string STATEDESC1;
        public string NATURECONT;
        public string NATUREID;
        public bool MASFLG;
        public bool DBFLG;
        public bool ZEROCOL;
        public bool CLNTFLAG;
        public static bool TFLAG;
        public static bool RFLAG;
        public static bool SAVEFLAG;
        public string EXQRY;
        public string HLPOledb;
        public float GRDHEIGHT;
        public const string RPASS = "MAHIS";
        public string[] DATATYPES = new string[4];

        // Unicode nul terminated string
        const int REG_SZ = 1;
        // 32-bit number
        const int REG_DWORD = 4;

        const string gREGKEYSYSINFOLOC = "SOFTWARE\\Microsoft\\Shared Tools Location";
        const string gREGVALSYSINFOLOC = "MSINFO";
        const string gREGKEYSYSINFO = "SOFTWARE\\Microsoft\\Shared Tools\\MSINFO";
        const string gREGVALSYSINFO = "PATH";

        public struct Critter
        {
            public int Xp;
            public int Yp;
            public int Width;
            public int Height;
            public int Xmove;
            public int Ymove;
        }
        // ERROR: Not supported in C#: DeclareDeclaration
        public static string COMPANY_NAME;
        public static int COMPANYID;
        public static string UPLS_STATE;
        public static string ADDRESS;
        public static string PH;
        public static string FAX;
        public static string EMAIL;
        public static string REGCODE;
        public static string AGENTCODE;
        string TT;
        string[] RR;
        public string OraService;
        public string OraUser;
        public string OraPass;
        public int ContBLNo;
        public string ContBlName;
        public string ContType;
        public float ContChrg;
        public byte CONTSAVE;
        public string BLNOVAL;
        public string CARGOFLG;
        public object Fso;
        public string HLPDATA1;
        public string HLPDATA2;
        public static string USRNAME;
        public string HLPDATA3;
        public string ostr;
        public string FRMRIGHTS;
        public string RIGHTS;
        public string LSTR;
        public string RT;
        public string[] SLOC;
        public static string MM;
        public static string YY;
        public string CRDID;
        public string FLD2;
        public string FLD3;
        public string subkey_name;
        public string REPLACESERVER;
        public string HLPWHERE;
        public string HLPORDER;
        public string MODFRM;
        TextReader EL;
        int I;
        int J;
        //Use in Flat Error
        public byte ErrCall;
        public object BR;
        public bool chnf;
        public string txtcat;
        public string txtrbi;
        public string txtrbidt;
        public const int STANDARD_RIGHTS_ALL = 0x1f0000;
        //******************** From Keys**************************** 'V.Senthil
        //113
        public const Keys KEY_OPTION = Keys.F2;
        public const Keys KEY_FYPRD = Keys.F9;
        public const Keys KEY_OPENDT = Keys.F10;
        public const Keys KEY_INSERT = Keys.Insert;
        public const Keys KEY_HISTORY = Keys.F12;
        public const Keys KEY_QUIT = Keys.F4;
        public const Keys KEY_DELETE = Keys.Delete;
        public const Keys KEY_MASTER = Keys.Insert;
        public const Keys KEY_REC_INSERT = Keys.F6;
        public const Keys KEY_REC_DELETE = Keys.F7;
        //13
        public const Keys KEY_ENTER = Keys.Enter;
        public const Keys KEY_ESC = Keys.Escape;

        //todo public const string SYNCHRONIZE = "0x100000";
        //public const bool KEY_ALL_ACCESS = ((STANDARD_RIGHTS_ALL | KEY_QUERY_VALUE | KEY_SET_VALUE | KEY_CREATE_SUB_KEY | KEY_ENUMERATE_SUB_KEYS | KEY_NOTIFY | KEY_CREATE_LINK) & (!SYNCHRONIZE));
        //***********************************    
        //FOR GETMACADD98
        public string USERMANAGER;
        public byte CALLBYSETTING;
        private const int NCBASTAT = 0x33;
        private const int NCBNAMSZ = 16;
        private const int HEAP_ZERO_MEMORY = 0x8;
        private const int HEAP_GENERATE_EXCEPTIONS = 0x4;
        private const int NCBRESET = 0x32;
        public struct ShowForms
        {
            // Form Object
            public dynamic ObjFrm;
            // Form Name
            public string FrmName;
            // Form Tag
            public string frmTag;
        }
        public static ShowForms[] ShwFrm;
        public static int FrmNo;
        //FrmNo-count of form child's ,CurFrmNo-Current From Number
        public static int CurFrmNo;

        public bool SkeySt;
        // using Shortcutkeys 
        public bool skey;
        //*********************************************** 'D.Senthil
        public string ERRMSG;
        public string FLD;
        public string str;
        public string SS;
        public string TEMPSTR;
        public static DialogResult ch;
        public string BLID;

        public OleDbDataReader ShippersRs;
        public struct REPOBJ
        {
            public Form[] ITEMS;
            public string[] PEXQRY;
            public string[] RIGHTS;
        }
        //'************************************************ 
        //Public Structure FormsCollection

        //End Structure

        //Public Forms As FormsCollection
        public string HLPDATA4;
        public int JOBNO;
        public int INVSRNo;
        public int ACTINVNO;
        public int LID;
        public int ITEMSRNO;
        public int PMV;
        public string SCHEMECODE;
        public string RITCCODE;
        public decimal ITMTOTAL;
        public string RITCODE;
        public int CLNTID;
        public string CLNTNAME;
        public string CLNTADD1;
        public string CLNTADD2;
        public string CLNTBR1;
        public string CLNTADD3;
        public string CLNTCITY;
        public string CLNTPIN;
        public int ITEMSRNO1;
        public int PMV1;
        public string SCHEMECODE1;
        public string RITCCODE1;
        public static string[] ones = new string[10];
        public static string[] abones = new string[10];
        public static string[] tens = new string[10];
        public static string[] ext = new string[5];
        public static string[] cons = new string[5];



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            APPDATE = DateTime.Now.ToString();
            if (GETUSRLST(ref Uid, ref USRNAME))
            {
                FrmMdiMain objFrmMdiMain = new FrmMdiMain();
                objFrmMdiMain.Uid = Uid;
                FrmNo = 1;
                if (Uid == 0)
                {
                    Application.Exit();
                }
                GCD(ref COMPANY_NAME, ref ADDRESS, ref PH, ref FAX, ref EMAIL, ref REGCODE);
                objFrmMdiMain.ShowDialog();
            }

            //Application.Run(new FrmVendorMaster());
        }

        /// <summary>
        /// To get the command part of a string
        /// </summary>
        /// Created On : 22/12/2013
        /// Created by : Srivatsan.S
        /// <returns></returns>
        public string GetCmd(string DataStr)
        {
            string MsgCmd = null;
            MsgCmd = DataStr.Substring(0, 1);
            if (DataStr.Length > 3)
            {
                MsgData = DataStr.Substring(4, (DataStr.Length) - 1);
            }
            return MsgCmd;
        }

        ///// <summary>
        ///// To check if the Application is already running
        ///// </summary>
        ///// Created On : 22/12/2013
        ///// Created by : Srivatsan.S
        ///// <returns></returns>
        //public bool AppIsAlreadyRunning()
        //{
        //    Process c = Process.GetCurrentProcess();
        //    foreach (Process p in Process.GetProcessesByName(c.ProcessName))
        //    {
        //        if (p.Id != c.Id)
        //        {
        //            if (p.MainModule.FileName.ToLower().Equals(c.MainModule.FileName.ToLower()))
        //            {
        //                SetForegroundWindow(p.MainWindowHandle);
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}

        /// <summary>
        /// Initializes the array variables for string formation. The Connect() function in Fastbilling has been named as InitializeVariables
        /// </summary>
        /// Created On : 22/12/2013
        /// Created by : Srivatsan.S
        /// <returns></returns>
        public bool InitializeVariables()
        {
            bool functionReturnValue = false;
            string STR = null;
            string FSTR = null;
            string ENCSTR = null;
            dynamic ADD1 = null;
            dynamic ADD2 = null;
            dynamic ADD3 = null;
            dynamic PH = null;
            dynamic FAX = null;
            dynamic EMAIL = null;
            int I = 0;
            int J = 0;
            int L = 0;
            int POS = 0;
            try
            {

                ENCSTR = "SRIVASINI INFOTECH";
                L = ENCSTR.Length;
                functionReturnValue = true;
                ones[1] = " One ";
                ones[2] = " Two ";
                ones[3] = " Three ";
                ones[4] = " Four ";
                ones[5] = " Five ";
                ones[6] = " Six ";
                ones[7] = " Seven ";
                ones[8] = " Eight ";
                ones[9] = " Nine ";


                abones[1] = " Eleven ";
                abones[2] = " Twelve ";
                abones[3] = " Thirteen ";
                abones[4] = " Fourteen ";
                abones[5] = " Fifteen ";
                abones[6] = " Sixteen ";
                abones[7] = " Seventeen ";
                abones[8] = " Eighteen ";
                abones[9] = " Nineteen ";

                tens[1] = " Ten ";
                tens[2] = " Twenty ";
                tens[3] = " Thirty ";
                tens[4] = " Fourty ";
                tens[5] = " Fifty ";
                tens[6] = " Sixty ";
                tens[7] = " Seventy ";
                tens[8] = " Eighty ";
                tens[9] = " Ninety ";

                ext[1] = " Hundred ";
                ext[2] = " Thousand ";
                ext[3] = " Lakh ";
                ext[4] = " Crore ";

                cons[1] = " and ";
                cons[2] = " Paise ";
                cons[3] = " Only ";
                cons[4] = " Rupees ";

                MINITMROWS = 5;
                return functionReturnValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to initialize the variables", MsgboxCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                functionReturnValue = false;
            }
            return functionReturnValue;
        }

        //  todo      public void DATAHLP(string Title, string Oledb, string WHEREFLD, string FILTERFLD, string ORDERFLD, ref int? NEWVAL, ref byte? UNIONFLG)
        //{
        //            NEWVAL=1;
        //            UNIONFLG=0;
        //    Array.Resize(ref RR, 22);
        //    sFrmHlpGrd = new FrmHlpGrd();
        //    Oledb =Oledb.Trim();
        //    TT = Oledb.Replace(Oledb, "SELECT", "SELECT TOP 200", , 1);
        //    TT = TT.Replace(TT, "SELECT TOP 200 DISTINCT", "SELECT DISTINCT TOP 200", , 1);
        //    Oledb = TT;
        //    if (!string.IsNullOrEmpty(WHEREFLD.Trim()))
        //        WHEREFLD = WHEREFLD + " AND ";
        //    HLPOledb = Oledb.Trim() + " WHERE " + WHEREFLD.Trim();
        //    HLPORDER = ORDERFLD;
        //    sFrmHlpGrd.UnionFlag = UNIONFLG;
        //    sFrmHlpGrd.NEWVAL = NEWVAL;
        //    sFrmHlpGrd.GRDHT = sFrmHlpGrd.DBGrid.Height;
        //    string[] ss = null;
        //    int i = 0;
        //    ss = Title.Split('|');
        //    for (i = 0; i <= ss.GetUpperBound(ss.Length); i++) {
        //        if (i == 0) {
        //            sFrmHlpGrd.Text = ss[0];
        //        } else if (i == 1) {
        //            sFrmHlpGrd.LblFld1.Text = ss[1];
        //        } else if (i == 2) {
        //            sFrmHlpGrd.LblFld2.Text = ss[2];
        //        } else if (i == 3) {
        //            sFrmHlpGrd.LblFld3.Text = ss[3];
        //        }
        //    }

        //    long RECCNT = 0;

        //    EXQRY = HLPOledb + " " + FILTERFLD.Trim() + " " + ORDERFLD.Trim();
        //    OledbDA = new OleDbDataAdapter(EXQRY, OledbCon);
        //    sFrmHlpGrd.HlpRs = new DataSet();
        //    try {
        //        OledbDA.Fill(sFrmHlpGrd.HlpRs);
        //    } catch (Exception ex) {
        //    }

        //    sFrmHlpGrd.DBGrid.DataSource = sFrmHlpGrd.HlpRs.Tables(0);
        //    RECCNT = sFrmHlpGrd.HlpRs.Tables(0).Rows.Count;
        //    //RECCNT = sFrmHlpGrd.DBGrid.RowCount
        //    if (!(RECCNT == 0)) {
        //        //FrmHlpGrd.DBGrid.a= 0
        //        //FrmHlpGrd.DBGrid.Col = 0
        //        //FrmHlpGrd.TxtHCell.Text = FrmHlpGrd.DBGrid.Columns(0).Text
        //        //FrmHlpGrd.TxtHCell.Text = FrmHlpGrd.DBGrid.Columns(0).Selected.ToString
        //    }

        //    //FrmHlpGrd.DBGrid.RecordSelectors = False
        //    //FrmHlpGrd.DBGrid.AllowUpdate = False
        //    sFrmHlpGrd.DBGrid.AllowUserToAddRows = false;
        //    sFrmHlpGrd.DBGrid.AllowUserToDeleteRows = false;
        //    sFrmHlpGrd.DBGrid.AllowUserToResizeRows = false;
        //    //FrmHlpGrd.DBGrid.Splits(0).AllowSizing = False
        //    //FrmHlpGrd.DBGrid.Columns(0).AllowSizing = False
        //    //FrmHlpGrd.DBGrid.Columns(1).AllowSizing = False
        //    sFrmHlpGrd.DBGrid.ScrollBars = ScrollBars.Vertical;
        //    //sFrmHlpGrd.DBGrid.ScrollBars = dbgVertical
        //    if (NEWVAL == 3) {
        //        if (sFrmHlpGrd.DBGrid.RowCount <= 16) {
        //            sFrmHlpGrd.DBGrid.Columns(2).Width = sFrmHlpGrd.TxtFld3.Width - 5;
        //        } else {
        //            sFrmHlpGrd.DBGrid.Columns(2).Width = sFrmHlpGrd.TxtFld3.Width - 12;
        //        }
        //        sFrmHlpGrd.DBGrid.Columns(1).Width = sFrmHlpGrd.TxtFld2.Width;
        //        sFrmHlpGrd.DBGrid.Columns(0).Width = sFrmHlpGrd.TxtFld1.Width;
        //        sFrmHlpGrd.DBGrid.Columns(3).Visible = false;
        //        sFrmHlpGrd.DBGrid.Width = sFrmHlpGrd.TxtFld1.Width + sFrmHlpGrd.TxtFld2.Width + sFrmHlpGrd.TxtFld3.Width - 1;
        //        //+ 5
        //        sFrmHlpGrd.windFrame.Width = sFrmHlpGrd.DBGrid.Width + 20 + 5;
        //        sFrmHlpGrd.TxtFld2.Visible = true;
        //        sFrmHlpGrd.LblFld2.Visible = true;
        //        sFrmHlpGrd.TxtFld3.Visible = true;
        //        sFrmHlpGrd.LblFld3.Visible = true;
        //        sFrmHlpGrd.Width = sFrmHlpGrd.DBGrid.Width + 30 + 5;
        //    } else if (NEWVAL == 2) {
        //        if (sFrmHlpGrd.DBGrid.RowCount <= 16) {
        //            sFrmHlpGrd.DBGrid.Columns(1).Width = sFrmHlpGrd.TxtFld2.Width - 5;
        //        } else {
        //            sFrmHlpGrd.DBGrid.Columns(1).Width = sFrmHlpGrd.TxtFld2.Width - 12;
        //        }
        //        //sFrmHlpGrd.DBGrid.Columns(1).Width = sFrmHlpGrd.TxtFld2.Width - 5
        //        sFrmHlpGrd.DBGrid.Columns(0).Width = sFrmHlpGrd.TxtFld1.Width;
        //        sFrmHlpGrd.DBGrid.Columns(2).Visible = false;
        //        //FrmHlpGrd.DBGrid.Columns(3).Visible = False
        //        sFrmHlpGrd.DBGrid.Width = sFrmHlpGrd.TxtFld1.Width + sFrmHlpGrd.TxtFld2.Width - 1;
        //        //+ 5
        //        sFrmHlpGrd.windFrame.Width = sFrmHlpGrd.DBGrid.Width + 20 + 5;
        //        sFrmHlpGrd.TxtFld2.Visible = true;
        //        sFrmHlpGrd.LblFld2.Visible = true;
        //        sFrmHlpGrd.TxtFld3.Visible = false;
        //        sFrmHlpGrd.LblFld3.Visible = false;
        //        sFrmHlpGrd.Width = sFrmHlpGrd.DBGrid.Width + 30 + 5;
        //    } else {
        //        if (sFrmHlpGrd.DBGrid.RowCount <= 16) {
        //            sFrmHlpGrd.DBGrid.Columns(0).Width = sFrmHlpGrd.TxtFld1.Width;
        //        } else {
        //            sFrmHlpGrd.DBGrid.Columns(0).Width = sFrmHlpGrd.TxtFld1.Width - 7;
        //        }
        //        sFrmHlpGrd.TxtFld2.Visible = false;
        //        sFrmHlpGrd.LblFld2.Visible = false;
        //        sFrmHlpGrd.TxtFld3.Visible = false;
        //        sFrmHlpGrd.LblFld3.Visible = false;
        //        sFrmHlpGrd.DBGrid.Width = sFrmHlpGrd.TxtFld1.Width - 1;
        //        sFrmHlpGrd.windFrame.Width = sFrmHlpGrd.DBGrid.Width + 20 + 5;
        //        sFrmHlpGrd.DBGrid.Columns(1).Visible = false;
        //        //sFrmHlpGrd.DBGrid.Columns(0).Width = sFrmHlpGrd.TxtFld1.Width
        //        sFrmHlpGrd.Width = sFrmHlpGrd.DBGrid.Width + 30 + 5;
        //        sFrmHlpGrd.TOTREC.Width = sFrmHlpGrd.TxtFld1.Width + 5;
        //    }
        //    //FrmHlpGrd.TxtHCell.Visible = False
        //    //FrmHlpGrd.TxtHCell.Width = FrmHlpGrd.DBGrid.Columns(0).Width
        //    //        FrmHlpGrd.TxtHCell.Left = FrmHlpGrd.DBGrid.Columns(0).Left + 85
        //    //FrmHlpGrd.TxtHCell.Left = FrmHlpGrd.DBGrid.Columns(0)
        //    int ADJ = 0;
        //    if (RECCNT == 1) {
        //        ADJ = 50;
        //    } else {
        //        ADJ = 100;
        //    }
        //    try {
        //        GRDHEIGHT = (sFrmHlpGrd.DBGrid.RowCount * RECCNT) + ADJ;
        //        if (GRDHEIGHT < sFrmHlpGrd.GRDHT) {
        //            sFrmHlpGrd.DBGrid.Height = 300;
        //            //GRDHEIGHT
        //        //FrmHlpGrd.DBGrid.ScrollBars = dbgNone
        //        } else {
        //            sFrmHlpGrd.DBGrid.Height = sFrmHlpGrd.GRDHT;
        //        }

        //        sFrmHlpGrd.TOTREC.Text = Strings.Trim(sFrmHlpGrd.DBGrid.RowCount) + "  Record(s) Found";
        //        int POS = 0;
        //        POS = Strings.InStr(1, Strings.Trim(FILTERFLD), "LIKE '", 1) + 6;

        //        sFrmHlpGrd.TxtFld1.Text = Strings.UCase(Strings.Mid(Strings.Trim(FILTERFLD), POS, Strings.InStr(1, Strings.Trim(FILTERFLD), "%", 1) - POS));
        //        sFrmHlpGrd.TxtFld1.SelectionStart = Strings.Len(sFrmHlpGrd.TxtFld1.Text);

        //        if (RECCNT == 0) {
        //            HLPDATA1 = "";
        //            HLPDATA2 = "";
        //            HLPDATA3 = "";
        //            HLPDATA4 = "";
        //            Interaction.MsgBox("No Records Found ! ", Constants.vbInformation);
        //        } else {
        //            sFrmHlpGrd.ShowDialog();
        //        }
        //    } catch (Exception ex) {
        //        Interaction.MsgBox(ex.Message);
        //    }

        //}

        /// <summary>
        /// To validate the values which are sent to the database
        /// </summary>
        /// <param name="FLDVALUE"></param>
        /// <returns></returns>
        public bool FVALIDATE(string FLDVALUE)
        {
            int valueParsed;
            bool functionReturnValue = false;

            functionReturnValue = true;
            if (DB_FLDTYPE.ToUpper() == "SMALLINT")
            {
                if (!string.IsNullOrEmpty(FLDVALUE.Trim()))
                    if (int.TryParse(FLDVALUE, out valueParsed) == false) { TYPEMSG = " should be Numeric Value ! "; functionReturnValue = false; return functionReturnValue; }
                if (Convert.ToInt32(FLDVALUE) > Convert.ToInt32(DATATYPES[0])) { TYPEMSG = " must be less than " + DATATYPES[0]; functionReturnValue = false; return functionReturnValue; }
            }
            else if (DB_FLDTYPE.ToUpper() == "INT")
            {
                if (!string.IsNullOrEmpty(FLDVALUE.Trim()))
                    if (int.TryParse(FLDVALUE, out valueParsed) == false) { TYPEMSG = " should be Numeric Value ! "; functionReturnValue = false; return functionReturnValue; }
                if (Convert.ToInt32(FLDVALUE) > Convert.ToInt32(DATATYPES[1])) { TYPEMSG = " must be less than " + DATATYPES[1]; functionReturnValue = false; return functionReturnValue; }
            }
            else if (DB_FLDTYPE.ToUpper() == "BIGNINT")
            {
                if (!string.IsNullOrEmpty(FLDVALUE.Trim()))
                    if (int.TryParse(FLDVALUE, out valueParsed) == false) { TYPEMSG = " should be Numeric Value ! "; functionReturnValue = false; return functionReturnValue; }
                if (Convert.ToInt32(DB_FLDTYPE) > Convert.ToInt32(DATATYPES[2])) { TYPEMSG = " must be less than " + DATATYPES[2]; functionReturnValue = false; return functionReturnValue; }
            }
            else if (DB_FLDTYPE.ToUpper() == "TINYINT")
            {
                if (!string.IsNullOrEmpty(FLDVALUE.Trim()))
                    if (int.TryParse(FLDVALUE, out valueParsed) == false) { TYPEMSG = " should be Numeric Value ! "; functionReturnValue = false; return functionReturnValue; }
                if (Convert.ToInt32(FLDVALUE) > Convert.ToInt32(DATATYPES[3])) { TYPEMSG = " must be less than " + DATATYPES[3]; functionReturnValue = false; return functionReturnValue; }
            }
            else if (DB_FLDTYPE.ToUpper() == "VARCHAR" | DB_FLDTYPE.ToUpper() == "NVARCHAR" | DB_FLDTYPE.ToUpper() == "CHAR")
            {
                if (FLDVALUE.Length > DB_FLDPREC) { TYPEMSG = " must be less than " + DB_FLDPREC + 1 + " Characters !"; functionReturnValue = false; return functionReturnValue; }
            }
            else if (DB_FLDTYPE.ToUpper() == "NUMERIC")
            {
                if (!string.IsNullOrEmpty(FLDVALUE.Trim()))
                    if (int.TryParse(FLDVALUE, out valueParsed) == false) { TYPEMSG = " should be Numeric Value ! "; functionReturnValue = false; return functionReturnValue; }
                if (Convert.ToInt32(FLDVALUE) > Convert.ToInt32(NINES.Substring(0, DB_FLDPREC - DB_FLDSCALE))) { TYPEMSG = " must be less than " + NINES.Substring(0, DB_FLDPREC - DB_FLDSCALE) + "." + NINES.Substring(0, DB_FLDSCALE); functionReturnValue = false; return functionReturnValue; }
            }
            TYPEMSG = "";
            return functionReturnValue;
        }

        public static  bool FindFrm(string frmName, string frmTag = "")
        {
            bool functionReturnValue = false;

            // ERROR: Not supported in C#: OnErrorStatement

            functionReturnValue = false;
            int i = 0;

            for (i = 1; i <= ShwFrm.GetUpperBound(ShwFrm.Length); i++)
            {
                if (ShwFrm[i].FrmName.ToUpper() == frmName.ToUpper())
                {
                    if (ShwFrm[i].frmTag.ToUpper() != frmTag.ToUpper())
                    {
                        if (ShwFrm[i].ObjFrm.SAVEFLAG == true & TFLAG == false)
                        {
                            SAVED = true;
                            RFLAG = false;
                            //objFrmMdiMain.Image1.SendToBack();
                            ShwFrm[i].ObjFrm.BringToFront();
                            ch = MessageBox.Show("Do You Want To Save ?", MsgboxCaption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                            if (ch == DialogResult.Yes)
                            {
                                ShwFrm[i].ObjFrm.CmdSave_Click(ShwFrm[i].ObjFrm, new System.EventArgs());
                                if (!SAVED)
                                {
                                    //objFrmMdiMain.Image1.SendToBack();
                                    ShwFrm[i].ObjFrm.BringToFront();
                                    return functionReturnValue;
                                }
                            }
                            else if (ch == DialogResult.Cancel)
                            {
                                CANFLG = true;
                                return functionReturnValue;
                            }
                            else if (ch == DialogResult.No)
                            {
                                return functionReturnValue;
                            }
                        }

                        ShwFrm[i].ObjFrm.Close();
                        ShwFrm[i].ObjFrm = null;
                        ShwFrm[i].ObjFrm.Dispose();
                        if (FrmNo > 1)
                            FrmNo = FrmNo - 1;
                        functionReturnValue = true;
                        break; // TODO: might not be correct. Was : Exit For
                    }
                    else
                    {
                        CurFrmNo = i;
                        return functionReturnValue;
                    }
                }
            }
            if (functionReturnValue)
            {
                if (FrmNo == ShwFrm.GetUpperBound(ShwFrm.Length) & i == ShwFrm.GetUpperBound(ShwFrm.Length))
                {
                    Array.Resize(ref ShwFrm, FrmNo);
                }
                else if (i < ShwFrm.GetUpperBound(ShwFrm.Length))
                {
                    for (int j = i; j <= ShwFrm.GetUpperBound(ShwFrm.Length) - 1; j++)
                    {
                        ShwFrm[j].ObjFrm = ShwFrm[j + 1].ObjFrm;
                        ShwFrm[j].FrmName = ShwFrm[j + 1].FrmName;
                    }
                    Array.Resize(ref ShwFrm, FrmNo);
                }
            }
            return functionReturnValue;
        }



        //public bool CHKSEC(object S1, object S2, ref string[] SS)
        //{
        //    bool functionReturnValue = false;
        //    string[] TT = null;
        //    functionReturnValue = false;
        //    if (NOTOK) { ACCESSDENIED(); return functionReturnValue; }
        //    dynamic FLD2 = null;
        //    dynamic FLD3 = null;
        //    dynamic FLD5 = null;
        //    FLD2 = S1;
        //    FLD3 = S2;
        //    REC = null;
        //    // REC.Open("SELECT * FROM SECURITY WHERE FLD2 = '" & FLD2 & "' AND FLD3 = '" & FLD3 & "'", DB, adOpenDynamic, adLockOptimistic)

        //    ostr = "SELECT * FROM SECURITY WHERE FLD2 = '" + FLD2 + "' AND FLD3 = '" + FLD3 + "'";
        //    OleDbConnection DB2 = default(OleDbConnection);
        //    DataSet ds1 = new DataSet();
        //    DB2 = LGM.DB;
        //    OledbAdp = new OleDbDataAdapter(ostr, DB2);
        //    OledbAdp.Fill(ds1, "SECURITY");
        //    DB2 = null;
        //    for (I = 0; I <= Information.UBound(SS); I++)
        //    {
        //        TT = Strings.Split(SS[I], "|");
        //        if (I == 0)
        //            FRMRIGHTS = TT[3];
        //        if (TT[4] != "NULL")
        //            FLD5 = SETPASS(Convert.ToString(TT[4]));
        //        else
        //            FLD5 = "";
        //        //  REC.Find("FLD5='" & FLD5 & "'")
        //        if (ds1.Tables[0].Rows.Count == 0)
        //        {
        //            ostr = "insert into SECURITY values('" + TT[0] + "','" + FLD2 + "','" + FLD3 + "','" + SETPASS(Convert.ToString(TT[3])) + "','" + FLD5 + "')";
        //            OledbCMD = new OleDbCommand(ostr, LGM.db);
        //            OledbCMD.ExecuteNonQuery();
        //        }
        //        else
        //        {
        //            if (!Information.IsDBNull(ds1.Tables[0].Rows[0][3].ToString()))
        //            {
        //                if (ds1.Tables[0].Rows[0][3].ToString() != SETPASS(Convert.ToString(TT[3])) | ds1.Tables[0].Rows[0][0].ToString() != TT[0])
        //                {
        //                    ostr = "Update security set FLD1='" + TT[0] + "',FLD4='" + SETPASS(Convert.ToString(TT[3])) + "' WHERE FLD2 = '" + FLD2 + "' AND FLD3 = '" + FLD3 + "' ";
        //                    OledbCMD = new OleDbCommand(ostr, LGM.DB);
        //                    OledbCMD.ExecuteNonQuery();

        //                }
        //            }
        //            else
        //            {
        //                ostr = "Update security set FLD1='" + TT[0] + "',FLD4='" + SETPASS(Convert.ToString(TT[3])) + "' WHERE FLD2 = '" + FLD2 + "' AND FLD3 = '" + FLD3 + "' ";
        //                OledbCMD = new OleDbCommand(ostr, LGM.DB);
        //                OledbCMD.ExecuteNonQuery();

        //            }
        //        }
        //    }

        //    functionReturnValue = true;
        //    return functionReturnValue;


        //}

        public static bool GETUSRLST(ref int S1, ref string S2, byte S3 = 0)
        {
            bool functionReturnValue = false;

            functionReturnValue = false;
            FrmLogin Frm = new FrmLogin();
            Frm.ShowDialog();

            S1 = Uid;
            S2 = USRNAME;

            try
            {
                MM = Convert.ToDateTime(APPDATE).Month.ToString();

            }
            catch (Exception ex)
            {
            }


            if (Convert.ToInt32(MM) >= 1 & Convert.ToInt32(MM) <= 9)
            {
                YY = Convert.ToDateTime(APPDATE).Year.ToString();
            }
            else
            {
                YY = Convert.ToDateTime(APPDATE).Year.ToString();
            }
            string s = "";
            s = @"01/04/" + YY;
            PERIOD = Convert.ToDateTime(s).ToString("dd/MM/yyyy");
            functionReturnValue = true;
            return functionReturnValue;

        }

        public static void GCD(ref string S1, ref string S2, ref string S3, ref string S4, ref string S5, ref string S6)
        {
            FrmSCompany OBJFrmSCompany = new FrmSCompany();
            OBJFrmSCompany.Show();

            using (ClsCompanyController objCompanyControl = new ClsCompanyController())
            {
                using (ClsCompanyEntity objcompanyEntity = new ClsCompanyEntity())
                {
                    objcompanyEntity.COMPANYID = CMPID;
                    objcompanyEntity.ALLFIELDSTAT = 1;
                    DataTable DTCompany = objCompanyControl.FunPubFetchCompany(objcompanyEntity);
                    CMPID = Convert.ToInt32(DTCompany.Rows[0]["CMPID"]);
                    COMPANY_NAME = Convert.ToString(DTCompany.Rows[0]["CMPNAME"]);
                    ADDRESS = Convert.ToString(DTCompany.Rows[0]["CMPADD1"]) + " " + Convert.ToString(DTCompany.Rows[0]["CMPADD2"]) + " " + Convert.ToString(DTCompany.Rows[0]["CMPCITY"]);
                    PH = Convert.ToString(DTCompany.Rows[0]["CMPPHONE"]);
                    FAX = Convert.ToString(DTCompany.Rows[0]["CMPFAX"]);
                    EMAIL = Convert.ToString(DTCompany.Rows[0]["CMPEMAIL"]);
                    CURRENCY_NAME = Convert.ToString(DTCompany.Rows[0]["CMPCURRNAME"]);
                    CURRENCY_SYMBOL = Convert.ToString(DTCompany.Rows[0]["CMPCURRSYM"]);
                    CURRENCY_CODE = Convert.ToString(DTCompany.Rows[0]["CMPCURRCODE"]);
                    CURRENCY_PAISE = Convert.ToString(DTCompany.Rows[0]["CMPCURRPAISE"]);
                    REGCODE = Convert.ToString(DTCompany.Rows[0]["CMPTINNO"]);
                }
            }


            //intialisation for variables used for amt to text
            ones[1] = " One ";
            ones[2] = " Two ";
            ones[3] = " Three ";
            ones[4] = " Four ";
            ones[5] = " Five ";
            ones[6] = " Six ";
            ones[7] = " Seven ";
            ones[8] = " Eight ";
            ones[9] = " Nine ";

            abones[1] = " Eleven ";
            abones[2] = " Twelve ";
            abones[3] = " Thirteen ";
            abones[4] = " Fourteen ";
            abones[5] = " Fifteen ";
            abones[6] = " Sixteen ";
            abones[7] = " Seventeen ";
            abones[8] = " Eighteen ";
            abones[9] = " Nineteen ";

            tens[1] = " Ten ";
            tens[2] = " Twenty ";
            tens[3] = " Thirty ";
            tens[4] = " Forty ";
            tens[5] = " Fifty ";
            tens[6] = " Sixty ";
            tens[7] = " Seventy ";
            tens[8] = " Eighty ";
            tens[9] = " Ninty ";

            ext[1] = " Hundred ";
            ext[2] = " Thousand ";
            ext[3] = " Lakh ";
            ext[4] = " Crore ";

            cons[1] = " and ";
            //cons[2] = ICase(CURRENCY_PAISE).ToString();
            //" Sents " '" Paise "
            cons[3] = " Only ";
            cons[4] = "";
            //Rupees

        }

        //private string CHKAFRM(string FRM)
        //{
        //    string functionReturnValue = null;

        //    functionReturnValue = "";
        //    if (NOTOK) { ACCESSDENIED(); return functionReturnValue; }
        //    if (ISITLITE)
        //    {
        //        functionReturnValue = FRMRIGHTS;
        //        return functionReturnValue;
        //    }
        //    if (string.IsNullOrEmpty(Strings.Trim(FRM)))
        //        return functionReturnValue;
        //    string GETFRM = "";
        //    int POS = 0;

        //    try
        //    {
        //        GETFRM = DATACHK("SELECT FORMS FROM USRDTL WHERE USRID=" + Uid + " AND CMPID=" + CMPID, true);
        //    }
        //    catch (Exception ex)
        //    {
        //        Interaction.MsgBox(ex.Message);
        //    }
        //    if (string.IsNullOrEmpty(GETFRM))
        //        GETFRM = DATACHK("SELECT G.FORMS FROM GROUPS G, USRMGR U WHERE G.GROUPID = U.GROUPID AND U.USRID = " + Uid, true);

        //    if (!string.IsNullOrEmpty(Strings.Trim(GETFRM)))
        //    {
        //        POS = Strings.InStr(1, GETFRM, FRM, Constants.vbTextCompare);
        //        if (!(POS == 0))
        //        {
        //            GETFRM = Strings.Mid(GETFRM, POS);
        //            GETFRM = Strings.Mid(GETFRM, 1, Strings.InStr(1, GETFRM, "@", Constants.vbTextCompare) - 1);
        //            RR = Strings.Split(GETFRM, "~");
        //            for (I = 0; I <= Information.UBound(RR); I++)
        //            {
        //                if (Strings.InStr(RR[I], FRM) == 1)
        //                {
        //                    RT = Strings.Mid(RR[I], Strings.InStr(1, RR[I], FRM) + Strings.Len(FRM) + 1);
        //                    break; // TODO: might not be correct. Was : Exit For
        //                }
        //            }
        //            functionReturnValue = RT;
        //        }
        //    }
        //    return functionReturnValue;

        //}

        public static void SETPOS(dynamic WFrame, dynamic ObjFrm = null)
        {
            // ERROR: Not supported in C#: OnErrorStatement

            FrmMdiMain = new FrmMdiMain();
            if (Information.IsDBNull(WFrame))
            {
                FrmMdiMain.ActiveMdiChild.WIND.Left = (FrmMdiMain.ActiveMdiChild.ScaleWidth - FrmMdiMain.ActiveMdiChild.WIND.Width) / 2;
                FrmMdiMain.ActiveMdiChild.WIND.Top = (FrmMdiMain.ActiveMdiChild.ScaleHeight - FrmMdiMain.ActiveMdiChild.WIND.Height) / 2;
            }
            else
            {
                if (ObjFrm == null)
                {
                    WFrame.Left = (objFrmMdiMain.ActiveMdiChild.Width - WFrame.Width) / 2;
                    WFrame.Top = (objFrmMdiMain.ActiveMdiChild.Height - WFrame.Height) / 2;
                }
                else
                {
                    WFrame.Left = (objFrmMdiMain.Width - WFrame.Width) / 2;
                    WFrame.Top = (objFrmMdiMain.Height - (WFrame.Height + 50)) / 2;
                }
            }


        }




    }
}
