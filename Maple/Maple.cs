using System;
using System.Windows.Forms;
using System.Media;

namespace Maple
{
    public partial class Maple : Form
    {
        public Maple()
        {
            InitializeComponent();
        }
        
        private void AddListBTN_Click(object sender, EventArgs e)  //Add Button 
        {
            if (ItemsCB.Text.Length > 0)  //if comboBox text length not zero
            {
                ToDoLB.Items.Add(ItemsCB.Text);  //add text to ToDo list
                ItemsCB.Text = null;  //clear combo box text
            }
            else 
            {
                SystemSounds.Exclamation.Play();  //play a sound effect 
            }
            UpdateProgress();
        }

        private void DeleteBTN_Click(object sender, EventArgs e)  //delete button
        {
            if (ToDoLB.SelectedIndex > -1)  //if listbox has a selected item
            {
                ToDoLB.Items.RemoveAt(ToDoLB.SelectedIndex);  //remove selected item from listbox
            }
            else
                SystemSounds.Exclamation.Play();  //play a sound
            UpdateProgress();
        }

        private void CompleteBTN_Click(object sender, EventArgs e)  //complete
        {
            if (ToDoLB.SelectedIndex > -1)  //if todo listbox has a selected item
            {
                CompleteLB.Items.Add(ToDoLB.SelectedItem);  //add selected ToDo item to Completed listbox
                ToDoLB.Items.RemoveAt((int)ToDoLB.SelectedIndex);  //remove selected item from to do list
            }
            else
                SystemSounds.Exclamation.Play();
            UpdateProgress();
        }

        void UpdateProgress ()  //update progress bar and textbox
        {
            if (CompleteLB.Items.Count > 0)  //if completed listbox has at least one item
            {
                Double TotalJobs = ToDoLB.Items.Count + CompleteLB.Items.Count;  //get total items in both listboxes
                Double Percent = (CompleteLB.Items.Count / TotalJobs) * 100;  //get percentage done
                int Ipercent = (int)Percent;  //an integer version of percent, goes to progress bar and textbox
                AllDonePB.Value = Ipercent;  //update progress bar value
                PercentDoneTB.Text = Ipercent.ToString();  //put percentage number in textbox
            }
        }
}  //end class
}  //end namespace