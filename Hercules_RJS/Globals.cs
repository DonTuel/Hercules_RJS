using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using ExpTreeLib;

namespace Hercules_RJS
{
    class Globals
    {
        #region Global Variables
        public StringBuilder DisplayText = null;

        public Int32 TransmissionsReceived = 0;
        public Int32 TransmissionsPassed = 0;
        public Int32 TransmissionsFailed = 0;

        private Boolean bMutexOwned = false;
        #endregion

        public void LimitSingleInstance(ref String name)
        {
        //    sMutex = new Mutex(true, name, out bMutexOwned);
            bMutexOwned = !bMutexOwned;
        }

        public Boolean IsAnotherInstanceRunning()
        {
            return bMutexOwned;
        }

        public Char[] ByteArrayToCharArray(Byte[] b)
        {
            return Encoding.Default.GetChars(b);
        }

        public String StringArrayToDottedString(String[] str, Char dot = '.')
        {
            String outStr = String.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != "")
                {
                    outStr += str[i] + dot;
                }
            }

            return outStr.TrimEnd(dot);
        }

        public Boolean FillListView(ListView lv, String[] cols)
        {
            try
            {
                //String o;
                int n;

                ListViewItem item1 = new ListViewItem(cols[0], 0);

                for (n = 1; n < cols.Length; n++)
                {
                    if (n < lv.Columns.Count)
                    {
                        item1.SubItems.Add(cols[n]);
                    }
                }

                lv.Items.Add(item1);

                return true;
            }
            catch (Exception ex)
            {
                if (ex.HResult != 94)
                {
                    MessageBox.Show("Error: " + ex.HResult + "\n" + ex.Message);
                }
                return false;
            }
        }

        public String GetEnvironmentVariable(String envVar)
        {
            String str = envVar.ToUpper();

            if (str.StartsWith("%"))
            {
                str = str.Substring(1, str.Length - 2);
            }

            return Environment.GetEnvironmentVariable(str).ToUpper();
        }

        public String StandardizeFileName(String inFileName)
        {
            Char[] splitStrs = "\\?=+%&*~".ToCharArray();
            String tempName = inFileName.Replace(":", ".");
            tempName = tempName.Replace("//", "/");

            foreach (Char ch in splitStrs)
            {
                tempName = tempName.Replace(ch.ToString() + ch.ToString(), ch.ToString());
                tempName = tempName.Replace("/" + ch, "/");
                tempName = tempName.Replace(ch + "/", "/");
                tempName = tempName.Replace("." + ch, ".");
                tempName = tempName.Replace(ch + ".", ".");
            }

            //'   http://www.mamma.com/result.php?type=web&q=LPD+LPR+%22abc%22
            //'   http://www.mobilehandsetdesignline.com/encyclopedia/defineterm.jhtml?term=**RANDOM**
            //'   http://www.ex.biwa.ne.jp/~kuri65536/streao2/linux-psc1210.html

            string[] subParts = tempName.Split(splitStrs);

            return StringArrayToDottedString(subParts);
        }
    }
}
