namespace LeaveManagement
{
    partial class sendLRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendLRM));
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Location = new System.Drawing.Point(246, 422);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 43);
            this.button4.TabIndex = 75;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(59, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 43);
            this.button1.TabIndex = 72;
            this.button1.Text = "OKAY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 59);
            this.label1.TabIndex = 70;
            this.label1.Text = "Enter your NIC Number and Press OKAY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.Maroon;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.Maroon;
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.Lime;
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.White;
            this.bunifuTextBox1.BorderRadius = 1;
            this.bunifuTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTextBox1.BorderThickness = 1;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.Location = new System.Drawing.Point(18, 123);
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
            this.bunifuTextBox1.Size = new System.Drawing.Size(255, 39);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 69;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginLeft = 5;
            this.bunifuTextBox1.TextPlaceholder = "NIC Number";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            // 
            // sendLRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 458);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuTextBox1);
            this.Name = "sendLRM";
            this.Text = "sendLRM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox1;
    }
}