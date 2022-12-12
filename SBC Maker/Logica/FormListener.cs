using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBC_Maker.Logica
{
    internal static class FormListener
    {
        static int i = 0;
        
        public static void addForm()
        {
            i++;
            Debug.Print(i.ToString());
        }
        
        public static void delForm(object sender, FormClosedEventArgs e)
        {
            i--;
            Debug.Print(i.ToString());
            if (i == 0) Application.Exit();
        }
    }
}
