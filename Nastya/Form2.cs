using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nastya
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //вызов окна выбора папки при нажатии по кнопке
        private void button2_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog DirDialog = new FolderBrowserDialog();
            DirDialog.Description = "Выбор директории ZBS";
            DirDialog.SelectedPath = @"D:\Game\SteamLibrary";

            if (DirDialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxPath.Text = DirDialog.SelectedPath;
            }
        }
    }
}
