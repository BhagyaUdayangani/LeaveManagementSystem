namespace LeaveManagement
{
    partial class sendLRF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendLRF));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuTextBox2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(151, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 43);
            this.button2.TabIndex = 73;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 43);
            this.button1.TabIndex = 72;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 59);
            this.label1.TabIndex = 70;
            this.label1.Text = "Please fill all fields";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Location = new System.Drawing.Point(261, 446);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 43);
            this.button4.TabIndex = 75;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.Maroon;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.Maroon;
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.Lime;
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.Empty;
            this.bunifuTextBox1.BorderRadius = 1;
            this.bunifuTextBox1.BorderThickness = 1;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.IconPadding = 5;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.Location = new System.Drawing.Point(16, 101);
            this.bunifuTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(248, 35);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.bunifuTextBox1.TabIndex = 69;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginLeft = 3;
            this.bunifuTextBox1.TextPlaceholder = "Description(Max 200 characters)";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            // 
            // bunifuTextBox2
            // 
            this.bunifuTextBox2.AcceptsReturn = false;
            this.bunifuTextBox2.AcceptsTab = false;
            this.bunifuTextBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.bunifuTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox2.BackgroundImage")));
            this.bunifuTextBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTextBox2.BorderColorActive = System.Drawing.Color.Maroon;
            this.bunifuTextBox2.BorderColorDisabled = System.Drawing.Color.Maroon;
            this.bunifuTextBox2.BorderColorHover = System.Drawing.Color.Lime;
            this.bunifuTextBox2.BorderColorIdle = System.Drawing.Color.Empty;
            this.bunifuTextBox2.BorderRadius = 1;
            this.bunifuTextBox2.BorderThickness = 1;
            this.bunifuTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox2.DefaultFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox2.DefaultText = "";
            this.bunifuTextBox2.FillColor = System.Drawing.Color.Empty;
            this.bunifuTextBox2.HideSelection = true;
            this.bunifuTextBox2.IconLeft = null;
            this.bunifuTextBox2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox2.IconPadding = 10;
            this.bunifuTextBox2.IconRight = null;
            this.bunifuTextBox2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox2.Location = new System.Drawing.Point(16, 136);
            this.bunifuTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuTextBox2.MaxLength = 32767;
            this.bunifuTextBox2.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox2.Modified = false;
            this.bunifuTextBox2.Name = "bunifuTextBox2";
            this.bunifuTextBox2.PasswordChar = '\0';
            this.bunifuTextBox2.ReadOnly = false;
            this.bunifuTextBox2.SelectedText = "";
            this.bunifuTextBox2.SelectionLength = 0;
            this.bunifuTextBox2.SelectionStart = 0;
            this.bunifuTextBox2.ShortcutsEnabled = true;
            this.bunifuTextBox2.Size = new System.Drawing.Size(248, 35);
            this.bunifuTextBox2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox2.TabIndex = 76;
            this.bunifuTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox2.TextMarginLeft = 5;
            this.bunifuTextBox2.TextPlaceholder = "Current state";
            this.bunifuTextBox2.UseSystemPasswordChar = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 62);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 26);
            this.dateTimePicker1.TabIndex = 77;
            // 
            // sendLRF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 489);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bunifuTextBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuTextBox1);
            this.Name = "sendLRF";
            this.Text = "sendLRF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}