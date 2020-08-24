using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomas_DLL;
using System.Windows.Forms;
using System.Data.Sql;
using System.IO;

namespace Compasploit
{
    public partial class Form1 : Form
    {
        Main Dll = new Main();
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void licensing1_Load(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Dll.SendLuaScript(fastColoredTextBox1.Text);
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Clear();
        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            Dll.LaunchExploit();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fastColoredTextBox1.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fastColoredTextBox1_Load_1(object sender, EventArgs e)
        {

        }

        private void gunaPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Users.GetNames(textBox1.Text))
            {
                gunaPanel2.SendToBack();
                gunaPanel1.BringToFront();
            }
            else
            {
                MessageBox.Show("Incorrect User", "Compasploit");
            }
        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton5_Click(object sender, EventArgs e)
        {
                    }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, fastColoredTextBox1.Text);
            }
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Txt Files (*.txt)|*.txt|Lua Files (*.lua)|*.lua";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Dll.SendLuaScript(File.ReadAllText(ofd.FileName));
            }
        }
    }
}
