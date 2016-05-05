using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace szavazasa
{
    public partial class Form1 : Form
    {
        public CheckBox[] cbTomb = new CheckBox[36];
       
        string file = @"szav.txt";
        string feltolt = @"feltolt.bat";

        public Form1()
        {
            

            InitializeComponent();

            cbTomb[1] = checkBox1;
            cbTomb[2] = checkBox2;
            cbTomb[3] = checkBox3;
            cbTomb[4] = checkBox4;
            cbTomb[5] = checkBox5;
            cbTomb[6] = checkBox6;
            cbTomb[7] = checkBox7;
            cbTomb[8] = checkBox8;
            cbTomb[9] = checkBox9;
            cbTomb[10] = checkBox10;
            cbTomb[11] = checkBox11;
            cbTomb[12] = checkBox12;
            cbTomb[13] = checkBox13;
            cbTomb[14] = checkBox14;
            cbTomb[15] = checkBox15;
            cbTomb[16] = checkBox16;
            cbTomb[17] = checkBox17;
            cbTomb[18] = checkBox18;
            cbTomb[19] = checkBox19;
            cbTomb[20] = checkBox20;
            cbTomb[21] = checkBox21;
            cbTomb[22] = checkBox22;
            cbTomb[23] = checkBox23;
            cbTomb[24] = checkBox24;
            cbTomb[25] = checkBox25;
            cbTomb[26] = checkBox26;
            cbTomb[27] = checkBox27;
            cbTomb[28] = checkBox28;
            cbTomb[29] = checkBox29;
            cbTomb[30] = checkBox30;
            cbTomb[31] = checkBox31;
            cbTomb[32] = checkBox32;
            cbTomb[33] = checkBox33;
            cbTomb[34] = checkBox34;
            cbTomb[35] = checkBox35;

            for (int cv = 1;  cv < 36; cv++)
                cbTomb[cv].Checked = true;


            try
            {
                StreamReader sr = new StreamReader(file,Encoding.Default);
                string s = sr.ReadLine();

                while (s != null)
                {
                    cbTomb[Convert.ToUInt16(s)].Checked = false;

                    s = sr.ReadLine();

                }

                sr.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show("Error: {0}" + e, "Hiba!");
            }
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            UInt16 cv2 = 1;

            try
            {
                StreamWriter sw = new StreamWriter(file, false, Encoding.Default);
                

                for (; cv2 < 36; cv2++)
                    if (cbTomb[cv2].Checked == false)
                        sw.WriteLine("{0}", cv2);

                sw.Close();
                System.Diagnostics.Process.Start(feltolt);
                this.Close();
                
            }
            catch(Exception ef)
            {
                MessageBox.Show("Error: {0}"+ ef, "Hiba!");
            }
                         
        }


    }
}
