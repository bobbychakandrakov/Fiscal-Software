using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscal_Software.Helpers
{
    public static class DocumentNumber
    {
        public static int number = 0;
        public static int svidetelstvo = 0;
        public static void ReadSettings()
        {
            if (File.Exists("nomer_dogovor.txt"))
            {
                string line = File.ReadAllText("nomer_dogovor.txt");
                string[] values = line.Split(';');
                number = int.Parse(values[0]);
                svidetelstvo = int.Parse(values[1]);
            }
        }

        public static void SetSettings(int nomer , int svidetelstvo)
        {
            string text = nomer.ToString() + ';' + svidetelstvo.ToString();
            File.WriteAllText("nomer_dogovor.txt", text);
        }
    }
}
