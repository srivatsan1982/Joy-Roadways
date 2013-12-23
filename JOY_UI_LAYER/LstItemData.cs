using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
public class LstItemData
{

    public object Value;

    public string Description;

    public LstItemData(object NewValue, string NewDescription)
    {
        Value = NewValue;
        Description = NewDescription;

    }

    public override string ToString()
    {

        return Description;

    }

    public void ComboSet(ref ComboBox MyCbo, ref object  ItemD, ref string  TxtVal)
    {
        int I = 0;

        try
        {
            if ((TxtVal) == null)
            {
                for (I = 0; I <= MyCbo.Items.Count - 1; I++)
                {
                    if (MyCbo.Items[I] == ItemD)
                    {
                        MyCbo.SelectedIndex = I;
                        break; // TODO: might not be correct. Was : Exit For
                    }
                }
            }
            else
            {
                for (I = 0; I <= MyCbo.Items.Count - 1; I++)
                {
                    if (MyCbo.Items[I].ToString().Trim().ToUpper() == TxtVal.Trim().ToUpper())
                    {
                        MyCbo.SelectedIndex = I;
                        break; 
                    }
                }
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }
}
