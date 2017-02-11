using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyKTV
{
    /// <summary>
    /// 改变字体大小
    /// </summary>
    public class ClassSetControlFontSize
    {
        //记录窗体中所有控件信息以及控件对应字体大小信息
        public static ArrayList listInfor = new ArrayList();
        //记录控件字体大小缩变float
        public static float fAdd { get; set; }
        //循环listInfor控件信息，改变字体大小
        public static void SetControlFontStyle(float fSize)
        {
            for (int nC = 0; nC < listInfor.Count; nC += 2)
            {
                Control control = listInfor[nC] as Control;
                float fFontS = float.Parse(listInfor[nC + 1].ToString());
               // control.Font = new Font(control.Font.Name, fFontS + fSize);
            }
        }
    }
}
