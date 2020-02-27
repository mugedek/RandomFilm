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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panelMediaSubMenu.Visible = false;
            panelToolsSubMenu.Visible = false;
            panelHistorySubMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelMediaSubMenu.Visible == true)
                panelMediaSubMenu.Visible = false;
            if (panelHistorySubMenu.Visible == true)
                panelHistorySubMenu.Visible = false;
            if (panelToolsSubMenu.Visible == true)
                panelToolsSubMenu.Visible = false;
        }
        private void showSubMenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMediaSubMenu);
        }
        #region MediaSubMenu
        //вызов окна выбора папки при нажатии по кнопке
        private void button2_Click(object sender, EventArgs e)
        {


            /*FolderBrowserDialog DirDialog = new FolderBrowserDialog();
            DirDialog.Description = "Выбор директории ZBS";
            DirDialog.SelectedPath = @"D:\Game\SteamLibrary";

            if (DirDialog.ShowDialog() == DialogResult.OK)
            {
                TextBoxPath.Text = DirDialog.SelectedPath;
            }*/
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }
#endregion
        private void btnHistory_Click(object sender, EventArgs e)
        {
            showSubMenu(panelHistorySubMenu);
        }
        #region HistorySubMenu
        private void button9_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }
#endregion
        private void btnTools_Click(object sender, EventArgs e)
        {
            showSubMenu(panelToolsSubMenu);
        }
        #region ToolsSubMenu
        private void button14_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }
        #endregion
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            //..
            //Your code
            //..
            hideSubMenu();
        }
    }
}
