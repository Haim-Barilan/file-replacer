namespace file_replacer
{
    partial class Form1
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
            this.sourceTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.F = new MaterialSkin.Controls.MaterialLabel();
            this.destTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.loggerListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // sourceTextField
            // 
            this.sourceTextField.Depth = 0;
            this.sourceTextField.Hint = "";
            this.sourceTextField.Location = new System.Drawing.Point(205, 97);
            this.sourceTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.sourceTextField.Name = "sourceTextField";
            this.sourceTextField.PasswordChar = '\0';
            this.sourceTextField.SelectedText = "";
            this.sourceTextField.SelectionLength = 0;
            this.sourceTextField.SelectionStart = 0;
            this.sourceTextField.Size = new System.Drawing.Size(234, 23);
            this.sourceTextField.TabIndex = 1;
            this.sourceTextField.UseSystemPasswordChar = false;
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Depth = 0;
            this.F.Font = new System.Drawing.Font("Roboto", 11F);
            this.F.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.F.Location = new System.Drawing.Point(34, 98);
            this.F.MouseState = MaterialSkin.MouseState.HOVER;
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(100, 19);
            this.F.TabIndex = 98;
            this.F.Text = "Input file path";
            // 
            // destTextField
            // 
            this.destTextField.Depth = 0;
            this.destTextField.Hint = "";
            this.destTextField.Location = new System.Drawing.Point(205, 161);
            this.destTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.destTextField.Name = "destTextField";
            this.destTextField.PasswordChar = '\0';
            this.destTextField.SelectedText = "";
            this.destTextField.SelectionLength = 0;
            this.destTextField.SelectionStart = 0;
            this.destTextField.Size = new System.Drawing.Size(234, 23);
            this.destTextField.TabIndex = 2;
            this.destTextField.Text = "C:\\portalpms";
            this.destTextField.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(34, 163);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 19);
            this.materialLabel1.TabIndex = 99;
            this.materialLabel1.Text = "Root folder";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(152, 223);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(136, 36);
            this.materialFlatButton1.TabIndex = 3;
            this.materialFlatButton1.Text = "Replace all files";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // loggerListBox
            // 
            this.loggerListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loggerListBox.Enabled = false;
            this.loggerListBox.FormattingEnabled = true;
            this.loggerListBox.Location = new System.Drawing.Point(25, 278);
            this.loggerListBox.Name = "loggerListBox";
            this.loggerListBox.Size = new System.Drawing.Size(431, 143);
            this.loggerListBox.TabIndex = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 441);
            this.Controls.Add(this.loggerListBox);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.destTextField);
            this.Controls.Add(this.F);
            this.Controls.Add(this.sourceTextField);
            this.Name = "Form1";
            this.Text = "File Replacer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField sourceTextField;
        private MaterialSkin.Controls.MaterialLabel F;
        private MaterialSkin.Controls.MaterialSingleLineTextField destTextField;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.ListBox loggerListBox;
    }
}

