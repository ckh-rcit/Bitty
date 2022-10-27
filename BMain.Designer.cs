namespace Bitty
{
    partial class BMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMain));
            this.domainTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwrdTB = new System.Windows.Forms.TextBox();
            this.domainlbl = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.recoverylbl = new System.Windows.Forms.Label();
            this.bitguidTB = new System.Windows.Forms.TextBox();
            this.bitguidlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBTN = new System.Windows.Forms.Button();
            this.recpassTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // domainTB
            // 
            this.domainTB.Location = new System.Drawing.Point(12, 31);
            this.domainTB.Name = "domainTB";
            this.domainTB.Size = new System.Drawing.Size(343, 23);
            this.domainTB.TabIndex = 0;
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(12, 78);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(343, 23);
            this.usernameTB.TabIndex = 1;
            // 
            // passwrdTB
            // 
            this.passwrdTB.Location = new System.Drawing.Point(12, 125);
            this.passwrdTB.Name = "passwrdTB";
            this.passwrdTB.PasswordChar = '*';
            this.passwrdTB.Size = new System.Drawing.Size(343, 23);
            this.passwrdTB.TabIndex = 2;
            this.passwrdTB.UseSystemPasswordChar = true;
            // 
            // domainlbl
            // 
            this.domainlbl.AutoSize = true;
            this.domainlbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.domainlbl.Location = new System.Drawing.Point(12, 10);
            this.domainlbl.Name = "domainlbl";
            this.domainlbl.Size = new System.Drawing.Size(67, 18);
            this.domainlbl.TabIndex = 3;
            this.domainlbl.Text = "DOMAIN:";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernamelbl.Location = new System.Drawing.Point(12, 57);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(83, 18);
            this.usernamelbl.TabIndex = 4;
            this.usernamelbl.Text = "USERNAME:";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passlbl.Location = new System.Drawing.Point(12, 104);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(79, 18);
            this.passlbl.TabIndex = 5;
            this.passlbl.Text = "PASSWORD";
            // 
            // recoverylbl
            // 
            this.recoverylbl.AutoSize = true;
            this.recoverylbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.recoverylbl.Location = new System.Drawing.Point(12, 216);
            this.recoverylbl.Name = "recoverylbl";
            this.recoverylbl.Size = new System.Drawing.Size(147, 18);
            this.recoverylbl.TabIndex = 7;
            this.recoverylbl.Text = "RECOVERY PASSWORD";
            // 
            // bitguidTB
            // 
            this.bitguidTB.Location = new System.Drawing.Point(12, 172);
            this.bitguidTB.Name = "bitguidTB";
            this.bitguidTB.Size = new System.Drawing.Size(343, 23);
            this.bitguidTB.TabIndex = 8;
            // 
            // bitguidlbl
            // 
            this.bitguidlbl.AutoSize = true;
            this.bitguidlbl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bitguidlbl.Location = new System.Drawing.Point(12, 151);
            this.bitguidlbl.Name = "bitguidlbl";
            this.bitguidlbl.Size = new System.Drawing.Size(198, 18);
            this.bitguidlbl.TabIndex = 9;
            this.bitguidlbl.Text = "BITLOCKER GUID (First 8 Digits)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(176, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "DEVELOPED BY CHRIS K. HARRIS";
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.DimGray;
            this.searchBTN.FlatAppearance.BorderSize = 0;
            this.searchBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.searchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBTN.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchBTN.ForeColor = System.Drawing.Color.White;
            this.searchBTN.Location = new System.Drawing.Point(263, 201);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(92, 28);
            this.searchBTN.TabIndex = 11;
            this.searchBTN.Text = "SEARCH";
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // recpassTB
            // 
            this.recpassTB.BackColor = System.Drawing.Color.White;
            this.recpassTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recpassTB.ForeColor = System.Drawing.Color.Black;
            this.recpassTB.Location = new System.Drawing.Point(12, 237);
            this.recpassTB.Name = "recpassTB";
            this.recpassTB.Size = new System.Drawing.Size(343, 23);
            this.recpassTB.TabIndex = 12;
            this.recpassTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(367, 279);
            this.Controls.Add(this.recpassTB);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bitguidlbl);
            this.Controls.Add(this.bitguidTB);
            this.Controls.Add(this.recoverylbl);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.domainlbl);
            this.Controls.Add(this.passwrdTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.domainTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BITTY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox domainTB;
        private TextBox usernameTB;
        private TextBox passwrdTB;
        private Label domainlbl;
        private Label usernamelbl;
        private Label passlbl;
        private Label recoverylbl;
        private TextBox bitguidTB;
        private Label bitguidlbl;
        private Label label1;
        private Button searchBTN;
        private TextBox recpassTB;
    }
}