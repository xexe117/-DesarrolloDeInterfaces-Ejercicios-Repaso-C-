﻿namespace TextFileChallenge
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listNames = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addUs = new System.Windows.Forms.Button();
            this.liveCheck = new System.Windows.Forms.CheckBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.saveList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            this.SuspendLayout();
            // 
            // listNames
            // 
            this.listNames.FormattingEnabled = true;
            this.listNames.ItemHeight = 20;
            this.listNames.Location = new System.Drawing.Point(416, 83);
            this.listNames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listNames.Name = "listNames";
            this.listNames.Size = new System.Drawing.Size(361, 364);
            this.listNames.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text File Challenge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(14, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(14, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Is Alive:";
            // 
            // addUs
            // 
            this.addUs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addUs.Location = new System.Drawing.Point(62, 409);
            this.addUs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addUs.Name = "addUs";
            this.addUs.Size = new System.Drawing.Size(315, 61);
            this.addUs.TabIndex = 2;
            this.addUs.Text = "Add User";
            this.addUs.UseVisualStyleBackColor = true;
            this.addUs.Click += new System.EventHandler(this.addUs_Click);
            // 
            // liveCheck
            // 
            this.liveCheck.AutoSize = true;
            this.liveCheck.Location = new System.Drawing.Point(121, 356);
            this.liveCheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.liveCheck.Name = "liveCheck";
            this.liveCheck.Size = new System.Drawing.Size(18, 17);
            this.liveCheck.TabIndex = 4;
            this.liveCheck.UseVisualStyleBackColor = true;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(121, 275);
            this.numAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(64, 27);
            this.numAge.TabIndex = 5;
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(121, 88);
            this.firstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(266, 27);
            this.firstName.TabIndex = 6;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(121, 182);
            this.lastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(266, 27);
            this.lastName.TabIndex = 6;
            // 
            // saveList
            // 
            this.saveList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveList.Location = new System.Drawing.Point(62, 496);
            this.saveList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveList.Name = "saveList";
            this.saveList.Size = new System.Drawing.Size(315, 56);
            this.saveList.TabIndex = 2;
            this.saveList.Text = "Save List";
            this.saveList.UseVisualStyleBackColor = true;
            this.saveList.Click += new System.EventHandler(this.saveList_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 555);
            this.Controls.Add(this.saveList);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.liveCheck);
            this.Controls.Add(this.addUs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listNames);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addUs;
        private System.Windows.Forms.CheckBox liveCheck;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Button saveList;
    }
}

