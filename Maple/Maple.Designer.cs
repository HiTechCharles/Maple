namespace Maple
{
    partial class Maple
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToDoLB = new System.Windows.Forms.ListBox();
            this.CompleteLB = new System.Windows.Forms.ListBox();
            this.AllDonePB = new System.Windows.Forms.ProgressBar();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.actionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speakListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompleteLBL = new System.Windows.Forms.Label();
            this.ToDoLBL = new System.Windows.Forms.Label();
            this.ItemsCB = new System.Windows.Forms.ComboBox();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToDoLB
            // 
            this.ToDoLB.AccessibleName = "Tasks to Do";
            this.ToDoLB.FormattingEnabled = true;
            this.ToDoLB.ItemHeight = 29;
            this.ToDoLB.Location = new System.Drawing.Point(9, 180);
            this.ToDoLB.Margin = new System.Windows.Forms.Padding(2);
            this.ToDoLB.Name = "ToDoLB";
            this.ToDoLB.Size = new System.Drawing.Size(381, 381);
            this.ToDoLB.Sorted = true;
            this.ToDoLB.TabIndex = 3;
            // 
            // CompleteLB
            // 
            this.CompleteLB.AccessibleName = "Tasks Completed";
            this.CompleteLB.FormattingEnabled = true;
            this.CompleteLB.ItemHeight = 29;
            this.CompleteLB.Location = new System.Drawing.Point(391, 180);
            this.CompleteLB.Margin = new System.Windows.Forms.Padding(2);
            this.CompleteLB.Name = "CompleteLB";
            this.CompleteLB.Size = new System.Drawing.Size(381, 381);
            this.CompleteLB.Sorted = true;
            this.CompleteLB.TabIndex = 5;
            // 
            // AllDonePB
            // 
            this.AllDonePB.AccessibleName = "Percent Complete";
            this.AllDonePB.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.AllDonePB.Location = new System.Drawing.Point(402, 63);
            this.AllDonePB.Margin = new System.Windows.Forms.Padding(2);
            this.AllDonePB.MarqueeAnimationSpeed = 50;
            this.AllDonePB.Name = "AllDonePB";
            this.AllDonePB.Size = new System.Drawing.Size(370, 42);
            this.AllDonePB.TabIndex = 1;
            // 
            // mainMenu
            // 
            this.mainMenu.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(784, 37);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // actionsMenu
            // 
            this.actionsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItem,
            this.completeMenuItem,
            this.deleteMenuItem,
            this.resetMenuItem,
            this.speakListsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.actionsMenu.Name = "actionsMenu";
            this.actionsMenu.Size = new System.Drawing.Size(113, 33);
            this.actionsMenu.Text = "Actions";
            // 
            // addMenuItem
            // 
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.addMenuItem.Size = new System.Drawing.Size(311, 34);
            this.addMenuItem.Text = "Add";
            this.addMenuItem.Click += new System.EventHandler(this.AddListBTN_Click);
            // 
            // completeMenuItem
            // 
            this.completeMenuItem.Name = "completeMenuItem";
            this.completeMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.completeMenuItem.Size = new System.Drawing.Size(311, 34);
            this.completeMenuItem.Text = "Complete";
            this.completeMenuItem.Click += new System.EventHandler(this.CompleteBTN_Click);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteMenuItem.Size = new System.Drawing.Size(311, 34);
            this.deleteMenuItem.Text = "Delete";
            this.deleteMenuItem.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // resetMenuItem
            // 
            this.resetMenuItem.Name = "resetMenuItem";
            this.resetMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetMenuItem.Size = new System.Drawing.Size(311, 34);
            this.resetMenuItem.Text = "Reset";
            this.resetMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // speakListsToolStripMenuItem
            // 
            this.speakListsToolStripMenuItem.Name = "speakListsToolStripMenuItem";
            this.speakListsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.speakListsToolStripMenuItem.Size = new System.Drawing.Size(311, 34);
            this.speakListsToolStripMenuItem.Text = "&Speak Lists";
            this.speakListsToolStripMenuItem.Click += new System.EventHandler(this.speakListsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(311, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // CompleteLBL
            // 
            this.CompleteLBL.AutoSize = true;
            this.CompleteLBL.Location = new System.Drawing.Point(396, 131);
            this.CompleteLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CompleteLBL.Name = "CompleteLBL";
            this.CompleteLBL.Size = new System.Drawing.Size(216, 29);
            this.CompleteLBL.TabIndex = 4;
            this.CompleteLBL.Text = "Tasks &Completed";
            // 
            // ToDoLBL
            // 
            this.ToDoLBL.AutoSize = true;
            this.ToDoLBL.Location = new System.Drawing.Point(11, 131);
            this.ToDoLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ToDoLBL.Name = "ToDoLBL";
            this.ToDoLBL.Size = new System.Drawing.Size(152, 29);
            this.ToDoLBL.TabIndex = 2;
            this.ToDoLBL.Text = "Tasks to &Do";
            // 
            // ItemsCB
            // 
            this.ItemsCB.AccessibleName = "Type in a task, use Actions->Add or Ctrl+N to add to list";
            this.ItemsCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ItemsCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ItemsCB.FormattingEnabled = true;
            this.ItemsCB.Items.AddRange(new object[] {
            "Brew Coffee",
            "Brush Teeth",
            "Change Sheets",
            "Clean Bathroom",
            "Clean Litter Box",
            "Clean Out Refrigerator",
            "Complete Homework",
            "Cook Breakfast",
            "Cook Dinner",
            "Create Shopping List",
            "Dust",
            "Exercise",
            "Feed Animals",
            "Fold Clothes",
            "Get Dressed",
            "List Items on eBay",
            "Make Lunch",
            "Plan a menu",
            "Put Away Clean Dishes",
            "Put Away Groceries",
            "Organize Pantry",
            "Refill Pill Box",
            "Schedule Transportation",
            "Shop for food",
            "Study",
            "Sweep Floor",
            "Take Medication",
            "Take a Shower",
            "Vacuum Carpet",
            "Wash Clothes",
            "Wash Dishes"});
            this.ItemsCB.Location = new System.Drawing.Point(9, 61);
            this.ItemsCB.Margin = new System.Windows.Forms.Padding(2);
            this.ItemsCB.Name = "ItemsCB";
            this.ItemsCB.Size = new System.Drawing.Size(381, 37);
            this.ItemsCB.TabIndex = 0;
            // 
            // Maple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(784, 578);
            this.Controls.Add(this.ItemsCB);
            this.Controls.Add(this.CompleteLBL);
            this.Controls.Add(this.ToDoLBL);
            this.Controls.Add(this.AllDonePB);
            this.Controls.Add(this.CompleteLB);
            this.Controls.Add(this.ToDoLB);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MainMenuStrip = this.mainMenu;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Maple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magnified Automatic Progress List Editor";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ToDoLB;
        private System.Windows.Forms.ListBox CompleteLB;
        public System.Windows.Forms.ProgressBar AllDonePB;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem actionsMenu;
        private System.Windows.Forms.ToolStripMenuItem addMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speakListsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label CompleteLBL;
        private System.Windows.Forms.Label ToDoLBL;
        private System.Windows.Forms.ComboBox ItemsCB;
    }
}

