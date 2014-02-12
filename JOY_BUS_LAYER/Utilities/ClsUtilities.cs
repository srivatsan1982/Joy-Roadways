using Microsoft.VisualBasic;
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

namespace JOY_BUS_LAYER.Utilities
{
    public sealed class ClsUtilities : IDisposable
    {
        #region [Variables]
        public const int ERROR_SUCCESS = 0;
        public const short KEY_QUERY_VALUE = 0x1;
        public const short KEY_SET_VALUE = 0x2;
        public const short KEY_CREATE_SUB_KEY = 0x4;
        public const short KEY_ENUMERATE_SUB_KEYS = 0x8;
        public const short KEY_NOTIFY = 0x10;
        public const short KEY_CREATE_LINK = 0x20;
        private string SCODE;
        private int I, J;
        private string GroupbyColumns;
        static string Content;
        [DllImport("user32", EntryPoint = "SendMessageA")]
        private static extern long SendMessage(long hwnd, long wMsg, long wParam, long lParam);
        [DllImport("user32", EntryPoint = "SetForegroundWindow")]
        private static extern long SetForegroundWindow(IntPtr hwnd);
        [DllImport("inpout32.dll", EntryPoint = "Inp32")]
        private static extern byte Inp(int PortAddress);
        [DllImport("inpout32.dll", EntryPoint = "Out32")]
        private static extern long Out(int PortAddress, byte Value);
        [DllImport("advapi32", EntryPoint = "RegOpenKeyExA")]
        private static extern long RegOpenKeyEx(long hKey, string lpSubKey, long ulOptions, long samDesired, long phkResult);
        [DllImport("advapi32", EntryPoint = "RegQueryValueExA")]
        private static extern long RegQueryValueEx(long hKey, string lpValueName, long lpReserved, long lpType, string lpData, long lpcbData);
        [DllImport("advapi32")]
        private static extern long RegCloseKey(long hKey);
        [DllImport("kernel32", EntryPoint = "GetComputerNameA")]
        private static extern int GetComputerName(string lpBuffer, int nSize);
        [DllImport("kernel32")]
        private static extern void Sleep(int dwMilliseconds);
        [DllImport("advapi32", EntryPoint = "RegSetValueExA")]
        private static extern long RegSetValueEx(long hKey, string lpValueName, long lpReserved, long lpType, string lpData, long lpcbData);
        #endregion

        public static void PaintControl(Control cntrl)
        {
            Pen mypen = new Pen(Color.White, 1);
            cntrl.CreateGraphics().DrawLine(mypen, 0, 0, 0, cntrl.Height);
            cntrl.CreateGraphics().DrawLine(mypen, 0, 0, cntrl.Width, 0);
            mypen = new Pen(Color.Black, 3);
            cntrl.CreateGraphics().DrawLine(mypen, cntrl.Width, 0, cntrl.Width, cntrl.Height);
            cntrl.CreateGraphics().DrawLine(mypen, 0, cntrl.Height, cntrl.Width, cntrl.Height);
        }

        public static string GETPASS(string PWD)
        {
            string functionReturnValue = null;

            functionReturnValue = "";
            string SECPASS = null;
            string SKEY = null;
            int LSKEY = 0;
            int N = 0;
            int M = 0;
            int K = 0;
            SKEY = "MAHIS";
            LSKEY = Strings.Len(SKEY);
            SECPASS = "";
            N = 1;
            K = Strings.Len(PWD);
            for (M = 1; M <= K; M++)
            {
                SECPASS = SECPASS + Strings.Chr(Strings.Asc(Strings.Mid(PWD, M, 1)) - Strings.Asc(Strings.Mid(SKEY, N, 1)));
                N = N + 1;
                if (N > LSKEY)
                    N = 1;
            }
            functionReturnValue = SECPASS;
            return functionReturnValue;
        }

        public static string SETPASS(string PWD)
        {
            string functionReturnValue = null;

            functionReturnValue = "";
            string SECPASS = null;
            string SKEY = null;
            int LSKEY = 0;
            int N = 0;
            int M = 0;
            int K = 0;
            SKEY = "MAHIS";
            LSKEY = SKEY.Length;
            SECPASS = "";
            N = 1;
            K = PWD.Length;
            for (M = 1; M <= K; M++)
            {
                SECPASS = SECPASS + Strings.Chr(Strings.Asc(Strings.Mid(PWD, M, 1)) + Strings.Asc(Strings.Mid(SKEY, N, 1)));
                N = N + 1;
                if (N > LSKEY)
                    N = 1;
            }
            functionReturnValue = SECPASS;
            return functionReturnValue;

        }

        public static string FunPubGetFileContents(string File_name)
        {
            try
            {
                using (StreamReader reader = new StreamReader(File_name))
                {
                    Content = reader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Content;
        }

        public void SetKeyValue(long key_root, string key_name, string subkey_name, string Value)
        {
            long hKey = 0;
            long length = 0;
            long value_type = 0;

            //Dim key_num As Integer

            // open the key


            if (RegOpenKeyEx(key_root, key_name, 0L, KEY_QUERY_VALUE, hKey) != ERROR_SUCCESS)
            {
                return;

            }
            length = Value.Length;
            value_type = 1;
            if (RegSetValueEx(hKey, subkey_name, 0, value_type, Value, length) != ERROR_SUCCESS)
            {
                return;
            }
            RegCloseKey(hKey);
        }

        public object SPLITSTR(object STRVAL, byte NOCHR)
        {
            string RESULT = null;
            RESULT = "";
            for (int I = 1; I <= Strings.Len(STRVAL); I++)
            {
                RESULT = RESULT + Strings.Mid(STRVAL.ToString(), I, 1) + Strings.Space(NOCHR);
            }
            return Strings.Trim(RESULT);
        }
        //public bool CONTVALID(string S1, string S2, ref object S3)
        //{
        //    bool functionReturnValue = false;

        //    functionReturnValue = false;
        //    int[] NAMEVAL = new int[26];
        //    dynamic TOTVAL = null;
        //    dynamic K = null;
        //    dynamic I = null;
        //    dynamic LASTVAL = null;
        //    dynamic JJ = null;
        //    TOTVAL = 0;
        //    K = 0;
        //    JJ = 10;
        //    for (I = 0; I <= Information.UBound(NAMEVAL); I++)
        //    {
        //        NAMEVAL[I] = JJ;
        //        JJ = JJ + 1;
        //        if (JJ % 11 == 0)
        //            JJ = JJ + 1;
        //    }
        //    S1 = Strings.Trim(S1);
        //    S2 = Strings.Replace(Strings.Trim(S2), "-", "");
        //    for (I = 1; I <= 4; I++)
        //    {
        //        TOTVAL = TOTVAL + NAMEVAL[Strings.Asc(Strings.Mid(S1, I, 1)) - 65] * (Math.Pow(2, K));
        //        K = K + 1;
        //    }
        //    for (I = 1; I <= 6; I++)
        //    {
        //        TOTVAL = TOTVAL + Conversion.Val(Strings.Mid(S2, I, 1)) * (Math.Pow(2, K));
        //        K = K + 1;
        //    }
        //    LASTVAL = TOTVAL % 11;
        //    if (LASTVAL == 10)
        //        LASTVAL = 0;
        //    S3 = Strings.Trim(LASTVAL);
        //    if (LASTVAL == Conversion.Val(Strings.Trim(Strings.Right(S2, 1))))
        //        functionReturnValue = true;
        //    return functionReturnValue;

        //}
        public string ENSTR(string FSTR)
        {
            string functionReturnValue = null;
            functionReturnValue = "";

            byte[] RCHR = null;
            byte rc = 0;
            byte EXIST = 0;
            string RSTR = null;
            RCHR = new byte[Strings.Len(FSTR) + 1];
            RSTR = "";
            for (I = 1; I <= Strings.Len(FSTR); I++)
            {
                do
                {
                    EXIST = 0;
                    VBMath.Randomize();
                    rc = Convert.ToByte(VBMath.Rnd() * (255 - Strings.Asc(Strings.Mid(FSTR, I, 1))));
                    for (J = 1; J <= Information.UBound(RCHR); J++)
                    {
                        if (RCHR[J] == rc)
                        {
                            EXIST = 1;
                            break; // TODO: might not be correct. Was : Exit For
                        }
                    }
                } while (EXIST == 1);
                RSTR = RSTR + Strings.Chr(rc) + Strings.Chr(Strings.Asc(Strings.Mid(FSTR, I, 1)) + rc);
                RCHR[I] = rc;
            }
            functionReturnValue = RSTR;
            return functionReturnValue;

        }
        public string DESTR(string FSTR)
        {
            string functionReturnValue = null;
            functionReturnValue = "";
            string RSTR = "0";
            byte rc = 0;
            for (I = 1; I <= Strings.Len(FSTR); I += 2)
            {
                rc = Convert.ToByte(Strings.Asc(Strings.Mid(FSTR, I, 1)));
                RSTR = Convert.ToString(RSTR + Strings.Chr(Strings.Asc(Strings.Mid(FSTR, I + 1, 1)) - rc));
            }
            functionReturnValue = RSTR;
            return functionReturnValue;

        }
        public string SETRCD(string A)
        {
            string functionReturnValue = null;
            //set reg code
            functionReturnValue = "";
            for (int I = 1; I <= Strings.Len(A); I++)
            {
                SCODE = SCODE + Strings.Trim(Strings.Mid(A, I, 1));
            }
            dynamic LL = null;
            dynamic ESTR = null;
            string FSTR = "0";
            ESTR = "MAHIS";
            LL = Strings.Len(ESTR);
            J = 1;
            for (I = 1; I <= Strings.Len(SCODE); I++)
            {
                FSTR = FSTR + Strings.Chr(Strings.Asc(Strings.Mid(SCODE, I, 1)) + Strings.Asc(Strings.Mid(ESTR, J, 1)));
                J = J + 1;
                if (J > LL)
                    J = 1;
            }
            SCODE = FSTR;
            FSTR = "";
            for (I = 1; I <= Strings.Len(SCODE); I++)
            {
                FSTR = FSTR + Conversion.Hex(Strings.Asc(Strings.Mid(SCODE, I, 1)));
            }
            functionReturnValue = FSTR;
            return functionReturnValue;

        }
        public string GETRCD(string A)
        {
            string functionReturnValue = null;
            //get reg code
            functionReturnValue = "";

            for (int I = 1; I <= Strings.Len(A); I += 2)
            {
                SCODE = SCODE + Strings.Chr(Convert.ToInt32("&H" + Strings.Mid(A, I, 2)));
            }
            string FSTR = "0";
            dynamic LL = null;
            dynamic ESTR = null;
            string[] AA = null;
            ESTR = "MAHIS";
            LL = Strings.Len(ESTR);
            J = 1;
            for (I = 1; I <= Strings.Len(SCODE); I++)
            {
                FSTR = FSTR + Strings.Chr(Strings.Asc(Strings.Mid(SCODE, I, 1)) - Strings.Asc(Strings.Mid(ESTR, J, 1)));
                J = J + 1;
                if (J > LL)
                    J = 1;
            }
            A = FSTR;
            SCODE = "";
            AA = Strings.Split(FSTR, "-");
            for (I = 1; I <= Information.UBound(AA); I++)
            {
                SCODE = SCODE + Strings.Trim(("-" + AA[I]));
            }
            //For I = 1 To Len(A) Step 2
            //    Scode = Scode + Trim(Not Mid(A, I, 2))
            //Next
            functionReturnValue = SCODE;
            return functionReturnValue;
        }
        public DataSet ImportExcelXLS(string FileName, string hasHeaders)
        {
            System.Data.OleDb.OleDbConnection MyConnection = null;
            System.Data.DataSet DtSet = null;
            System.Data.OleDb.OleDbDataAdapter MyCommand = null;
            try
            {
                MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + FileName + ";Extended Properties=Excel 8.0;");
                MyCommand = new System.Data.OleDb.OleDbDataAdapter("select * from [Table1$]", MyConnection);
                MyCommand.TableMappings.Add("Table", "TestTable");
                DtSet = new System.Data.DataSet();
                MyCommand.Fill(DtSet);
                MyConnection.Close();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
            return DtSet;
        }
        public void ExportDatasetToExcel(DataSet ds, string strExcelFile)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + strExcelFile + ";Extended Properties=Excel 8.0;");
            conn.Open();
            string[] strTableQ = new string[ds.Tables.Count + 1];
            int i = 0;
            //making table query
            for (i = 0; i <= ds.Tables.Count - 1; i++)
            {
                strTableQ[i] = "CREATE TABLE [" + ds.Tables[i].TableName + "](";
                int j = 0;
                for (j = 0; j <= ds.Tables[i].Columns.Count - 1; j++)
                {
                    DataColumn dCol = null;
                    dCol = ds.Tables[i].Columns[j];
                    strTableQ[i] += " [" + dCol.ColumnName + "] varchar(255) , ";
                }
                strTableQ[i] = strTableQ[i].Substring(0, strTableQ[i].Length - 2);
                strTableQ[i] += ")";
                OleDbCommand cmd = new OleDbCommand(strTableQ[i], conn);
                cmd.ExecuteNonQuery();
            }
            //making insert query
            string[] strInsertQ = new string[ds.Tables.Count];
            for (i = 0; i <= ds.Tables.Count - 1; i++)
            {
                strInsertQ[i] = "Insert Into " + ds.Tables[i].TableName + " Values (";
                for (int k = 0; k <= ds.Tables[i].Columns.Count - 1; k++)
                {
                    strInsertQ[i] += "@" + ds.Tables[i].Columns[k].ColumnName + " , ";
                }
                strInsertQ[i] = strInsertQ[i].Substring(0, strInsertQ[i].Length - 2);
                strInsertQ[i] += ")";
            }
            //Now inserting data
            for (i = 0; i <= ds.Tables.Count - 1; i++)
            {
                for (int j = 0; j <= ds.Tables[i].Rows.Count - 1; j++)
                {
                    OleDbCommand cmd = new OleDbCommand(strInsertQ[i], conn);
                    for (int k = 0; k <= ds.Tables[i].Columns.Count - 1; k++)
                    {
                        cmd.Parameters.AddWithValue("@" + ds.Tables[i].Columns[k].ColumnName.ToString(), ds.Tables[i].Rows[j][k].ToString());
                    }
                    cmd.ExecuteNonQuery();
                    cmd.Parameters.Clear();
                }
            }
            conn.Close();
        }
        public object ICase(object STRVAL)
        {
            object functionReturnValue = null;
            //INIT CASE

            functionReturnValue = "";
            string C = null;
            //* 1
            int FLG = 0;
            STRVAL = Strings.UCase(Strings.Trim(STRVAL.ToString()));
            FLG = 1;
            for (int I = 2; I <= Strings.Len(STRVAL); I++)
            {
                C = Strings.Mid(STRVAL.ToString(), I, 1);
                if (FLG == 1)
                    C = Strings.LCase(C);
                if (C == " ")
                    FLG = 0;
                else
                    FLG = 1;
            }
            functionReturnValue = STRVAL;
            return functionReturnValue;

        }
        public void Dispose()
        {

        }
    }
}
