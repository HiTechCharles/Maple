using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Media;

namespace Maple
{
    public partial class Maple : Form
    {
        public Maple()
        {
            InitializeComponent();
        }
        
        private void AddListBTN_Click(object sender, EventArgs e)
        {
            if (ItemsCB.Text.Length > 0)
                {
                    ToDoLB.Items.Add(ItemsCB.Text);
                ItemsCB.Text = "";
                }
            else
            {
                SystemSounds.Exclamation.Play();
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (ToDoLB.SelectedIndex > -1)
            {
                ToDoLB.Items.RemoveAt(ToDoLB.SelectedIndex);
            }
            else
                SystemSounds.Exclamation.Play();
        }
    }  //end class
}  //end namespace
