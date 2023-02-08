namespace MarieA_Assign2
{
    partial class GroceryForm
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
            this.GroceryListBox = new System.Windows.Forms.ListBox();
            this.GroceryLabel = new System.Windows.Forms.Label();
            this.LoadDataGrpBox = new System.Windows.Forms.GroupBox();
            this.LoadDataButton = new System.Windows.Forms.Button();
            this.UpdateDataGrpBox = new System.Windows.Forms.GroupBox();
            this.SortItemBtn = new System.Windows.Forms.Button();
            this.UpdateRestockedBtn = new System.Windows.Forms.Button();
            this.DeleteItemBtn = new System.Windows.Forms.Button();
            this.UpdateSoldBtn = new System.Windows.Forms.Button();
            this.QuantityRestockedTxtBox = new System.Windows.Forms.TextBox();
            this.QuantitySoldTxtBox = new System.Windows.Forms.TextBox();
            this.QuantityRestockedLabel = new System.Windows.Forms.Label();
            this.QuantitySoldLabel = new System.Windows.Forms.Label();
            this.SaveDataGrpBox = new System.Windows.Forms.GroupBox();
            this.SaveRstckBtn = new System.Windows.Forms.Button();
            this.SaveSalesRprtBtn = new System.Windows.Forms.Button();
            this.SaveGroceryDataBtn = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LoadDataGrpBox.SuspendLayout();
            this.UpdateDataGrpBox.SuspendLayout();
            this.SaveDataGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroceryListBox
            // 
            this.GroceryListBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroceryListBox.FormattingEnabled = true;
            this.GroceryListBox.ItemHeight = 18;
            this.GroceryListBox.Location = new System.Drawing.Point(12, 76);
            this.GroceryListBox.Name = "GroceryListBox";
            this.GroceryListBox.Size = new System.Drawing.Size(1458, 220);
            this.GroceryListBox.TabIndex = 0;
            this.GroceryListBox.SelectedIndexChanged += new System.EventHandler(this.GroceryListBox_SelectedIndexChanged);
            // 
            // GroceryLabel
            // 
            this.GroceryLabel.AutoSize = true;
            this.GroceryLabel.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroceryLabel.Location = new System.Drawing.Point(482, 21);
            this.GroceryLabel.Name = "GroceryLabel";
            this.GroceryLabel.Size = new System.Drawing.Size(570, 33);
            this.GroceryLabel.TabIndex = 1;
            this.GroceryLabel.Text = "Super Store Grocery Management System";
            // 
            // LoadDataGrpBox
            // 
            this.LoadDataGrpBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LoadDataGrpBox.Controls.Add(this.LoadDataButton);
            this.LoadDataGrpBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadDataGrpBox.Location = new System.Drawing.Point(39, 320);
            this.LoadDataGrpBox.Name = "LoadDataGrpBox";
            this.LoadDataGrpBox.Size = new System.Drawing.Size(296, 210);
            this.LoadDataGrpBox.TabIndex = 2;
            this.LoadDataGrpBox.TabStop = false;
            this.LoadDataGrpBox.Text = "Load Data";
            // 
            // LoadDataButton
            // 
            this.LoadDataButton.Location = new System.Drawing.Point(54, 42);
            this.LoadDataButton.Name = "LoadDataButton";
            this.LoadDataButton.Size = new System.Drawing.Size(179, 48);
            this.LoadDataButton.TabIndex = 0;
            this.LoadDataButton.Text = "Load Grocery Data";
            this.LoadDataButton.UseVisualStyleBackColor = true;
            this.LoadDataButton.Click += new System.EventHandler(this.LoadDataButton_Click);
            // 
            // UpdateDataGrpBox
            // 
            this.UpdateDataGrpBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UpdateDataGrpBox.Controls.Add(this.SortItemBtn);
            this.UpdateDataGrpBox.Controls.Add(this.UpdateRestockedBtn);
            this.UpdateDataGrpBox.Controls.Add(this.DeleteItemBtn);
            this.UpdateDataGrpBox.Controls.Add(this.UpdateSoldBtn);
            this.UpdateDataGrpBox.Controls.Add(this.QuantityRestockedTxtBox);
            this.UpdateDataGrpBox.Controls.Add(this.QuantitySoldTxtBox);
            this.UpdateDataGrpBox.Controls.Add(this.QuantityRestockedLabel);
            this.UpdateDataGrpBox.Controls.Add(this.QuantitySoldLabel);
            this.UpdateDataGrpBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDataGrpBox.Location = new System.Drawing.Point(341, 320);
            this.UpdateDataGrpBox.Name = "UpdateDataGrpBox";
            this.UpdateDataGrpBox.Size = new System.Drawing.Size(749, 210);
            this.UpdateDataGrpBox.TabIndex = 3;
            this.UpdateDataGrpBox.TabStop = false;
            this.UpdateDataGrpBox.Text = "Update Data";
            // 
            // SortItemBtn
            // 
            this.SortItemBtn.Location = new System.Drawing.Point(498, 132);
            this.SortItemBtn.Name = "SortItemBtn";
            this.SortItemBtn.Size = new System.Drawing.Size(160, 46);
            this.SortItemBtn.TabIndex = 7;
            this.SortItemBtn.Text = "Sort Items Based on Sale";
            this.SortItemBtn.UseVisualStyleBackColor = true;
            this.SortItemBtn.Click += new System.EventHandler(this.SortItemBtn_Click);
            // 
            // UpdateRestockedBtn
            // 
            this.UpdateRestockedBtn.Location = new System.Drawing.Point(498, 73);
            this.UpdateRestockedBtn.Name = "UpdateRestockedBtn";
            this.UpdateRestockedBtn.Size = new System.Drawing.Size(160, 46);
            this.UpdateRestockedBtn.TabIndex = 6;
            this.UpdateRestockedBtn.Text = "Update Restocked Qty for Selected Item";
            this.UpdateRestockedBtn.UseVisualStyleBackColor = true;
            this.UpdateRestockedBtn.Click += new System.EventHandler(this.UpdateRestockedBtn_Click);
            // 
            // DeleteItemBtn
            // 
            this.DeleteItemBtn.Location = new System.Drawing.Point(101, 132);
            this.DeleteItemBtn.Name = "DeleteItemBtn";
            this.DeleteItemBtn.Size = new System.Drawing.Size(165, 46);
            this.DeleteItemBtn.TabIndex = 5;
            this.DeleteItemBtn.Text = "Delete Selected Grocery Item";
            this.DeleteItemBtn.UseVisualStyleBackColor = true;
            this.DeleteItemBtn.Click += new System.EventHandler(this.DeleteItemBtn_Click);
            // 
            // UpdateSoldBtn
            // 
            this.UpdateSoldBtn.Location = new System.Drawing.Point(101, 73);
            this.UpdateSoldBtn.Name = "UpdateSoldBtn";
            this.UpdateSoldBtn.Size = new System.Drawing.Size(165, 46);
            this.UpdateSoldBtn.TabIndex = 4;
            this.UpdateSoldBtn.Text = "Update Sold Qty for Selected Item";
            this.UpdateSoldBtn.UseVisualStyleBackColor = true;
            this.UpdateSoldBtn.Click += new System.EventHandler(this.UpdateSoldBtn_Click);
            // 
            // QuantityRestockedTxtBox
            // 
            this.QuantityRestockedTxtBox.Location = new System.Drawing.Point(558, 38);
            this.QuantityRestockedTxtBox.Name = "QuantityRestockedTxtBox";
            this.QuantityRestockedTxtBox.Size = new System.Drawing.Size(100, 23);
            this.QuantityRestockedTxtBox.TabIndex = 3;
            // 
            // QuantitySoldTxtBox
            // 
            this.QuantitySoldTxtBox.Location = new System.Drawing.Point(166, 38);
            this.QuantitySoldTxtBox.Name = "QuantitySoldTxtBox";
            this.QuantitySoldTxtBox.Size = new System.Drawing.Size(100, 23);
            this.QuantitySoldTxtBox.TabIndex = 2;
            // 
            // QuantityRestockedLabel
            // 
            this.QuantityRestockedLabel.AutoSize = true;
            this.QuantityRestockedLabel.Location = new System.Drawing.Point(383, 42);
            this.QuantityRestockedLabel.Name = "QuantityRestockedLabel";
            this.QuantityRestockedLabel.Size = new System.Drawing.Size(147, 15);
            this.QuantityRestockedLabel.TabIndex = 1;
            this.QuantityRestockedLabel.Text = "Quantity Restocked: ";
            // 
            // QuantitySoldLabel
            // 
            this.QuantitySoldLabel.AutoSize = true;
            this.QuantitySoldLabel.Location = new System.Drawing.Point(31, 42);
            this.QuantitySoldLabel.Name = "QuantitySoldLabel";
            this.QuantitySoldLabel.Size = new System.Drawing.Size(112, 15);
            this.QuantitySoldLabel.TabIndex = 0;
            this.QuantitySoldLabel.Text = "Quantity Sold: ";
            // 
            // SaveDataGrpBox
            // 
            this.SaveDataGrpBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SaveDataGrpBox.Controls.Add(this.SaveRstckBtn);
            this.SaveDataGrpBox.Controls.Add(this.SaveSalesRprtBtn);
            this.SaveDataGrpBox.Controls.Add(this.SaveGroceryDataBtn);
            this.SaveDataGrpBox.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveDataGrpBox.Location = new System.Drawing.Point(1096, 320);
            this.SaveDataGrpBox.Name = "SaveDataGrpBox";
            this.SaveDataGrpBox.Size = new System.Drawing.Size(309, 210);
            this.SaveDataGrpBox.TabIndex = 4;
            this.SaveDataGrpBox.TabStop = false;
            this.SaveDataGrpBox.Text = "Save Data";
            // 
            // SaveRstckBtn
            // 
            this.SaveRstckBtn.Location = new System.Drawing.Point(68, 125);
            this.SaveRstckBtn.Name = "SaveRstckBtn";
            this.SaveRstckBtn.Size = new System.Drawing.Size(172, 42);
            this.SaveRstckBtn.TabIndex = 2;
            this.SaveRstckBtn.Text = "Save Restock Needs Report";
            this.SaveRstckBtn.UseVisualStyleBackColor = true;
            this.SaveRstckBtn.Click += new System.EventHandler(this.SaveRstckBtn_Click);
            // 
            // SaveSalesRprtBtn
            // 
            this.SaveSalesRprtBtn.Location = new System.Drawing.Point(68, 75);
            this.SaveSalesRprtBtn.Name = "SaveSalesRprtBtn";
            this.SaveSalesRprtBtn.Size = new System.Drawing.Size(172, 44);
            this.SaveSalesRprtBtn.TabIndex = 1;
            this.SaveSalesRprtBtn.Text = "Save Sales Report";
            this.SaveSalesRprtBtn.UseVisualStyleBackColor = true;
            this.SaveSalesRprtBtn.Click += new System.EventHandler(this.SaveSalesRprtBtn_Click);
            // 
            // SaveGroceryDataBtn
            // 
            this.SaveGroceryDataBtn.Location = new System.Drawing.Point(68, 29);
            this.SaveGroceryDataBtn.Name = "SaveGroceryDataBtn";
            this.SaveGroceryDataBtn.Size = new System.Drawing.Size(172, 40);
            this.SaveGroceryDataBtn.TabIndex = 0;
            this.SaveGroceryDataBtn.Text = "Save Grocery Data";
            this.SaveGroceryDataBtn.UseVisualStyleBackColor = true;
            this.SaveGroceryDataBtn.Click += new System.EventHandler(this.SaveGroceryDataBtn_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StatusLabel.Location = new System.Drawing.Point(532, 550);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(493, 89);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Operation Status Update Displayed Here";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroceryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 680);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SaveDataGrpBox);
            this.Controls.Add(this.UpdateDataGrpBox);
            this.Controls.Add(this.LoadDataGrpBox);
            this.Controls.Add(this.GroceryLabel);
            this.Controls.Add(this.GroceryListBox);
            this.Name = "GroceryForm";
            this.Text = "Grocery Management System";
            this.LoadDataGrpBox.ResumeLayout(false);
            this.UpdateDataGrpBox.ResumeLayout(false);
            this.UpdateDataGrpBox.PerformLayout();
            this.SaveDataGrpBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GroceryListBox;
        private System.Windows.Forms.Label GroceryLabel;
        private System.Windows.Forms.GroupBox LoadDataGrpBox;
        private System.Windows.Forms.Button LoadDataButton;
        private System.Windows.Forms.GroupBox UpdateDataGrpBox;
        private System.Windows.Forms.Button SortItemBtn;
        private System.Windows.Forms.Button UpdateRestockedBtn;
        private System.Windows.Forms.Button DeleteItemBtn;
        private System.Windows.Forms.Button UpdateSoldBtn;
        private System.Windows.Forms.TextBox QuantityRestockedTxtBox;
        private System.Windows.Forms.TextBox QuantitySoldTxtBox;
        private System.Windows.Forms.Label QuantityRestockedLabel;
        private System.Windows.Forms.Label QuantitySoldLabel;
        private System.Windows.Forms.GroupBox SaveDataGrpBox;
        private System.Windows.Forms.Button SaveRstckBtn;
        private System.Windows.Forms.Button SaveSalesRprtBtn;
        private System.Windows.Forms.Button SaveGroceryDataBtn;
        private System.Windows.Forms.Label StatusLabel;
    }
}

