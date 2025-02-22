namespace Maple
{
    partial class Maple
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.AddListBTN = new System.Windows.Forms.Button();
            this.ItemsCB = new System.Windows.Forms.ComboBox();
            this.ToDoLB = new System.Windows.Forms.ListBox();
            this.CompleteLB = new System.Windows.Forms.ListBox();
            this.CompleteBTN = new System.Windows.Forms.Button();
            this.ToDoLBL = new System.Windows.Forms.Label();
            this.CompleteLBL = new System.Windows.Forms.Label();
            this.AllDonePB = new System.Windows.Forms.ProgressBar();
            this.PercentDoneTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.AccessibleName = "Removes a job from To Do List";
            this.DeleteBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteBTN.Location = new System.Drawing.Point(814, 12);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(225, 50);
            this.DeleteBTN.TabIndex = 3;
            this.DeleteBTN.Text = "&Delete";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // AddListBTN
            // 
            this.AddListBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddListBTN.Location = new System.Drawing.Point(429, 9);
            this.AddListBTN.Name = "AddListBTN";
            this.AddListBTN.Size = new System.Drawing.Size(90, 50);
            this.AddListBTN.TabIndex = 1;
            this.AddListBTN.Text = "&Add";
            this.AddListBTN.UseVisualStyleBackColor = true;
            this.AddListBTN.Click += new System.EventHandler(this.AddListBTN_Click);
            // 
            // ItemsCB
            // 
            this.ItemsCB.AccessibleName = "Type in a task, hit Enter to add to list";
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
            "Cook  Dinner",
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
            this.ItemsCB.Location = new System.Drawing.Point(12, 13);
            this.ItemsCB.Name = "ItemsCB";
            this.ItemsCB.Size = new System.Drawing.Size(404, 47);
            this.ItemsCB.TabIndex = 0;
            // 
            // ToDoLB
            // 
            this.ToDoLB.AccessibleName = "Jobs to do";
            this.ToDoLB.FormattingEnabled = true;
            this.ToDoLB.ItemHeight = 39;
            this.ToDoLB.Location = new System.Drawing.Point(12, 78);
            this.ToDoLB.Name = "ToDoLB";
            this.ToDoLB.Size = new System.Drawing.Size(500, 589);
            this.ToDoLB.Sorted = true;
            this.ToDoLB.TabIndex = 4;
            // 
            // CompleteLB
            // 
            this.CompleteLB.AccessibleName = "Jobs Completed";
            this.CompleteLB.FormattingEnabled = true;
            this.CompleteLB.ItemHeight = 39;
            this.CompleteLB.Location = new System.Drawing.Point(539, 78);
            this.CompleteLB.Name = "CompleteLB";
            this.CompleteLB.Size = new System.Drawing.Size(500, 589);
            this.CompleteLB.Sorted = true;
            this.CompleteLB.TabIndex = 5;
            // 
            // CompleteBTN
            // 
            this.CompleteBTN.AccessibleName = "Moves selected job to completed list";
            this.CompleteBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CompleteBTN.Location = new System.Drawing.Point(539, 9);
            this.CompleteBTN.Name = "CompleteBTN";
            this.CompleteBTN.Size = new System.Drawing.Size(225, 50);
            this.CompleteBTN.TabIndex = 2;
            this.CompleteBTN.Text = "&Complete";
            this.CompleteBTN.UseVisualStyleBackColor = true;
            this.CompleteBTN.Click += new System.EventHandler(this.CompleteBTN_Click);
            // 
            // ToDoLBL
            // 
            this.ToDoLBL.AutoSize = true;
            this.ToDoLBL.Location = new System.Drawing.Point(12, 682);
            this.ToDoLBL.Name = "ToDoLBL";
            this.ToDoLBL.Size = new System.Drawing.Size(191, 39);
            this.ToDoLBL.TabIndex = 6;
            this.ToDoLBL.Text = "Jobs To Do";
            // 
            // CompleteLBL
            // 
            this.CompleteLBL.AutoSize = true;
            this.CompleteLBL.Location = new System.Drawing.Point(532, 682);
            this.CompleteLBL.Name = "CompleteLBL";
            this.CompleteLBL.Size = new System.Drawing.Size(271, 39);
            this.CompleteLBL.TabIndex = 7;
            this.CompleteLBL.Text = "Jobs Completed";
            // 
            // AllDonePB
            // 
            this.AllDonePB.AccessibleName = "Percent Complete";
            this.AllDonePB.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.AllDonePB.Location = new System.Drawing.Point(19, 724);
            this.AllDonePB.MarqueeAnimationSpeed = 50;
            this.AllDonePB.Name = "AllDonePB";
            this.AllDonePB.Size = new System.Drawing.Size(943, 45);
            this.AllDonePB.TabIndex = 8;
            // 
            // PercentDoneTB
            // 
            this.PercentDoneTB.AccessibleName = "Percentage of Jobs Completed";
            this.PercentDoneTB.Location = new System.Drawing.Point(968, 722);
            this.PercentDoneTB.Name = "PercentDoneTB";
            this.PercentDoneTB.ReadOnly = true;
            this.PercentDoneTB.Size = new System.Drawing.Size(71, 46);
            this.PercentDoneTB.TabIndex = 9;
            this.PercentDoneTB.Text = "0";
            this.PercentDoneTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Maple
            // 
            this.AcceptButton = this.AddListBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1045, 788);
            this.Controls.Add(this.PercentDoneTB);
            this.Controls.Add(this.AllDonePB);
            this.Controls.Add(this.CompleteLBL);
            this.Controls.Add(this.ToDoLBL);
            this.Controls.Add(this.CompleteBTN);
            this.Controls.Add(this.CompleteLB);
            this.Controls.Add(this.ToDoLB);
            this.Controls.Add(this.ItemsCB);
            this.Controls.Add(this.AddListBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Maple";
            this.Text = "Magnified  Automatic Progress List Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button AddListBTN;
        private System.Windows.Forms.ComboBox ItemsCB;
        private System.Windows.Forms.ListBox ToDoLB;
        private System.Windows.Forms.ListBox CompleteLB;
        private System.Windows.Forms.Button CompleteBTN;
        private System.Windows.Forms.Label ToDoLBL;
        private System.Windows.Forms.Label CompleteLBL;
        public System.Windows.Forms.ProgressBar AllDonePB;
        private System.Windows.Forms.TextBox PercentDoneTB;
    }
}

