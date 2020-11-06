namespace WinFormsToDoList
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
            this.ListaLabel = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.newItemLabel = new System.Windows.Forms.Label();
            this.newItemBox = new System.Windows.Forms.TextBox();
            this.todoListBox = new System.Windows.Forms.ListBox();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.AddItemButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaLabel
            // 
            this.ListaLabel.AutoSize = true;
            this.ListaLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ListaLabel.Location = new System.Drawing.Point(12, 28);
            this.ListaLabel.Name = "ListaLabel";
            this.ListaLabel.Size = new System.Drawing.Size(53, 28);
            this.ListaLabel.TabIndex = 0;
            this.ListaLabel.Text = "Lista";
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Edit.Location = new System.Drawing.Point(366, 219);
            this.Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(78, 44);
            this.Edit.TabIndex = 2;
            this.Edit.Text = "Editar";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // newItemLabel
            // 
            this.newItemLabel.AutoSize = true;
            this.newItemLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newItemLabel.Location = new System.Drawing.Point(462, 187);
            this.newItemLabel.Name = "newItemLabel";
            this.newItemLabel.Size = new System.Drawing.Size(120, 28);
            this.newItemLabel.TabIndex = 5;
            this.newItemLabel.Text = "Nuevo Item";
            // 
            // newItemBox
            // 
            this.newItemBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newItemBox.Location = new System.Drawing.Point(462, 219);
            this.newItemBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newItemBox.Name = "newItemBox";
            this.newItemBox.Size = new System.Drawing.Size(227, 29);
            this.newItemBox.TabIndex = 6;
            // 
            // todoListBox
            // 
            this.todoListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.todoListBox.FormattingEnabled = true;
            this.todoListBox.ItemHeight = 21;
            this.todoListBox.Location = new System.Drawing.Point(12, 87);
            this.todoListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.todoListBox.Name = "todoListBox";
            this.todoListBox.Size = new System.Drawing.Size(348, 403);
            this.todoListBox.TabIndex = 7;
            this.todoListBox.DoubleClick += new System.EventHandler(this.todoListBox_DoubleClick);
            // 
            // DeleteBut
            // 
            this.DeleteBut.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteBut.Location = new System.Drawing.Point(366, 285);
            this.DeleteBut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(78, 44);
            this.DeleteBut.TabIndex = 2;
            this.DeleteBut.Text = "Delete";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // AddItemButt
            // 
            this.AddItemButt.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddItemButt.Location = new System.Drawing.Point(462, 256);
            this.AddItemButt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddItemButt.Name = "AddItemButt";
            this.AddItemButt.Size = new System.Drawing.Size(227, 41);
            this.AddItemButt.TabIndex = 2;
            this.AddItemButt.Text = "Añadir Item";
            this.AddItemButt.UseVisualStyleBackColor = true;
            this.AddItemButt.Click += new System.EventHandler(this.AddItemButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 529);
            this.Controls.Add(this.AddItemButt);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.todoListBox);
            this.Controls.Add(this.newItemBox);
            this.Controls.Add(this.newItemLabel);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.ListaLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ListaLabel;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label newItemLabel;
        private System.Windows.Forms.TextBox newItemBox;
        private System.Windows.Forms.ListBox todoListBox;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button AddItemButt;
    }
}

