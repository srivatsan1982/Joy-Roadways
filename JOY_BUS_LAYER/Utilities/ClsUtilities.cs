using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace JOY_BUS_LAYER.Utilities
{
    public class ClsUtilities:IDisposable
    {
        public void PaintControl(Control cntrl)
        {
            Pen mypen = new Pen(Color.White, 1);
            cntrl.CreateGraphics().DrawLine(mypen, 0, 0, 0, cntrl.Height);
            cntrl.CreateGraphics().DrawLine(mypen, 0, 0, cntrl.Width, 0);
            mypen = new Pen(Color.Black, 3);
            cntrl.CreateGraphics().DrawLine(mypen, cntrl.Width, 0, cntrl.Width, cntrl.Height);
            cntrl.CreateGraphics().DrawLine(mypen, 0, cntrl.Height, cntrl.Width, cntrl.Height);
        }

        public char? ValidateCharacter(char ch ,out char res)
        {
            int Ascii = (int)ch;
            int AsciOpt = Convert.ToInt32(char.ToUpper(ch));

            if ((Ascii == (int)ClsCommonVariables.KEY_ENTER) || (AsciOpt == (int)ClsCommonVariables.KEY_OPTION) || (Ascii == 8))
            {
                res=' ';
            }
            else
            {
                res = char.ToUpper(ch);
            }
            return res;
        }

        public bool Validatekeys(Keys key,Control activecontrol)
        {
            if (key == ClsCommonVariables.KEY_ENTER)
            {
                if (activecontrol.GetType().Name.ToUpper() == "TEXTBOX")
                {
                    TextBox T = activecontrol as TextBox;
                    if (!T.Multiline)
                    {
                        return true;
                    }
                }
                else if (activecontrol.GetType().Name.ToUpper() == "RADIOBUTTON")
                {
                    return true ;
                }
            }
            return false;
        }
        public void Dispose()
        {
            this.Dispose();
        }
    }
}
