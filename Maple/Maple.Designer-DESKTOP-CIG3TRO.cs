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
            this.SuspendLayout();
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DeleteBTN.Location = new System.Drawing.Point(294, 715);
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
            this.AddListBTN.Location = new System.Drawing.Point(19, 715);
            this.AddListBTN.Name = "AddListBTN";
            this.AddListBTN.Size = new System.Drawing.Size(225, 50);
            this.AddListBTN.TabIndex = 2;
            this.AddListBTN.Text = "&Add to Lisst";
            this.AddListBTN.UseVisualStyleBackColor = true;
            this.AddListBTN.Click += new System.EventHandler(this.AddListBTN_Click);
            // 
            // ItemsCB
            // 
            this.ItemsCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ItemsCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ItemsCB.FormattingEnabled = true;
            this.ItemsCB.Items.AddRange(new object[] {
            "Wash Dishes",
            "Change Sheets",
            "Vacuum Carpet",
            "Feed Animals",
            "Take a Shower",
            "Get Dressed",
            "Shop for food",
            "Clean Bathroom",
            "Wash Clothes",
            "Clean Litter Box",
            "Make Coffee",
            "Schedule Transportation",
            "Refill Pill Box",
            "Take Medication",
            "Make Breakfast",
            "Make Lunch",
            "Make Dinner",
            "Create Shopping List",
            "Fold Clothes",
            "Clean Out Refrigerator",
            "Put Away Groceries",
            "Complete Homework",
            "Study",
            "Plan a menu",
            "Exercise"});
            this.ItemsCB.Location = new System.Drawing.Point(19, 41);
            this.ItemsCB.Name = "ItemsCB";
            this.ItemsCB.Size = new System.Drawing.Size(500, 47);
            this.ItemsCB.TabIndex = 0;
            // 
            // ToDoLB
            // 
            this.ToDoLB.FormattingEnabled = true;
            this.ToDoLB.ItemHeight = 39;
            this.ToDoLB.Location = new System.Drawing.Point(19, 117);
            this.ToDoLB.Name = "ToDoLB";
            this.ToDoLB.Size = new System.Drawing.Size(500, 589);
            this.ToDoLB.TabIndex = 4;
            // 
            // Maple
            // 
            this.AcceptButton = this.AddListBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1484, 788);
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

        }

        #endregion
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button AddListBTN;
        private System.Windows.Forms.ComboBox ItemsCB;
        private System.Windows.Forms.ListBox ToDoLB;
    }
}

