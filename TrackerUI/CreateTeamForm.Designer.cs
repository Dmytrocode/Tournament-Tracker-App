namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.Createteamlabel = new System.Windows.Forms.Label();
            this.selectteamlmemberlabel = new System.Windows.Forms.Label();
            this.Addmemberlabel = new System.Windows.Forms.Button();
            this.AddNewMemberboxlabel = new System.Windows.Forms.GroupBox();
            this.creatememberlabel = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.celllabel = new System.Windows.Forms.Label();
            this.emailabel = new System.Windows.Forms.Label();
            this.lastnamelabel = new System.Windows.Forms.Label();
            this.firstnamelabel = new System.Windows.Forms.Label();
            this.teammembersListBox = new System.Windows.Forms.ListBox();
            this.deleteselectedmemberlabel = new System.Windows.Forms.Button();
            this.createTournlabel = new System.Windows.Forms.Button();
            this.selectteamdrop = new System.Windows.Forms.ComboBox();
            this.AddNewMemberboxlabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Location = new System.Drawing.Point(48, 158);
            this.TeamNameValue.Multiline = true;
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(344, 33);
            this.TeamNameValue.TabIndex = 13;
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.TeamNameLabel.Location = new System.Drawing.Point(44, 119);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(151, 32);
            this.TeamNameLabel.TabIndex = 12;
            this.TeamNameLabel.Text = "TEAM NAME";
            // 
            // Createteamlabel
            // 
            this.Createteamlabel.AutoSize = true;
            this.Createteamlabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createteamlabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Createteamlabel.Location = new System.Drawing.Point(39, 41);
            this.Createteamlabel.Name = "Createteamlabel";
            this.Createteamlabel.Size = new System.Drawing.Size(237, 47);
            this.Createteamlabel.TabIndex = 11;
            this.Createteamlabel.Text = "CREATE TEAM";
            // 
            // selectteamlmemberlabel
            // 
            this.selectteamlmemberlabel.AutoSize = true;
            this.selectteamlmemberlabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectteamlmemberlabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.selectteamlmemberlabel.Location = new System.Drawing.Point(43, 207);
            this.selectteamlmemberlabel.Name = "selectteamlmemberlabel";
            this.selectteamlmemberlabel.Size = new System.Drawing.Size(263, 32);
            this.selectteamlmemberlabel.TabIndex = 14;
            this.selectteamlmemberlabel.Text = "SELECT TEAM MEMBER";
            this.selectteamlmemberlabel.Click += new System.EventHandler(this.selectteamlmemberlabel_Click);
            // 
            // Addmemberlabel
            // 
            this.Addmemberlabel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Addmemberlabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Addmemberlabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Addmemberlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addmemberlabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addmemberlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Addmemberlabel.Location = new System.Drawing.Point(124, 298);
            this.Addmemberlabel.Name = "Addmemberlabel";
            this.Addmemberlabel.Size = new System.Drawing.Size(184, 45);
            this.Addmemberlabel.TabIndex = 17;
            this.Addmemberlabel.Text = "Add Member";
            this.Addmemberlabel.UseVisualStyleBackColor = true;
            // 
            // AddNewMemberboxlabel
            // 
            this.AddNewMemberboxlabel.Controls.Add(this.creatememberlabel);
            this.AddNewMemberboxlabel.Controls.Add(this.textBox3);
            this.AddNewMemberboxlabel.Controls.Add(this.textBox2);
            this.AddNewMemberboxlabel.Controls.Add(this.textBox1);
            this.AddNewMemberboxlabel.Controls.Add(this.TournamentNameValue);
            this.AddNewMemberboxlabel.Controls.Add(this.celllabel);
            this.AddNewMemberboxlabel.Controls.Add(this.emailabel);
            this.AddNewMemberboxlabel.Controls.Add(this.lastnamelabel);
            this.AddNewMemberboxlabel.Controls.Add(this.firstnamelabel);
            this.AddNewMemberboxlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewMemberboxlabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.AddNewMemberboxlabel.Location = new System.Drawing.Point(47, 369);
            this.AddNewMemberboxlabel.Name = "AddNewMemberboxlabel";
            this.AddNewMemberboxlabel.Size = new System.Drawing.Size(364, 338);
            this.AddNewMemberboxlabel.TabIndex = 18;
            this.AddNewMemberboxlabel.TabStop = false;
            this.AddNewMemberboxlabel.Text = "Add New Member";
            // 
            // creatememberlabel
            // 
            this.creatememberlabel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.creatememberlabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.creatememberlabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.creatememberlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creatememberlabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatememberlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.creatememberlabel.Location = new System.Drawing.Point(90, 272);
            this.creatememberlabel.Name = "creatememberlabel";
            this.creatememberlabel.Size = new System.Drawing.Size(184, 45);
            this.creatememberlabel.TabIndex = 19;
            this.creatememberlabel.Text = "Create Member";
            this.creatememberlabel.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(156, 222);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(202, 33);
            this.textBox3.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(156, 173);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 33);
            this.textBox2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(156, 122);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 33);
            this.textBox1.TabIndex = 23;
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(156, 68);
            this.TournamentNameValue.Multiline = true;
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(202, 33);
            this.TournamentNameValue.TabIndex = 19;
            // 
            // celllabel
            // 
            this.celllabel.AutoSize = true;
            this.celllabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celllabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.celllabel.Location = new System.Drawing.Point(20, 222);
            this.celllabel.Name = "celllabel";
            this.celllabel.Size = new System.Drawing.Size(124, 32);
            this.celllabel.TabIndex = 22;
            this.celllabel.Text = "Cellphone";
            // 
            // emailabel
            // 
            this.emailabel.AutoSize = true;
            this.emailabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.emailabel.Location = new System.Drawing.Point(20, 173);
            this.emailabel.Name = "emailabel";
            this.emailabel.Size = new System.Drawing.Size(72, 32);
            this.emailabel.TabIndex = 21;
            this.emailabel.Text = "Email";
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.AutoSize = true;
            this.lastnamelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnamelabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lastnamelabel.Location = new System.Drawing.Point(20, 122);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(127, 32);
            this.lastnamelabel.TabIndex = 19;
            this.lastnamelabel.Text = "Last Name";
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.AutoSize = true;
            this.firstnamelabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnamelabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.firstnamelabel.Location = new System.Drawing.Point(20, 68);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(130, 32);
            this.firstnamelabel.TabIndex = 20;
            this.firstnamelabel.Text = "First Name";
            // 
            // teammembersListBox
            // 
            this.teammembersListBox.FormattingEnabled = true;
            this.teammembersListBox.Location = new System.Drawing.Point(468, 157);
            this.teammembersListBox.Name = "teammembersListBox";
            this.teammembersListBox.Size = new System.Drawing.Size(299, 550);
            this.teammembersListBox.TabIndex = 19;
            // 
            // deleteselectedmemberlabel
            // 
            this.deleteselectedmemberlabel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteselectedmemberlabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteselectedmemberlabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteselectedmemberlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteselectedmemberlabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteselectedmemberlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteselectedmemberlabel.Location = new System.Drawing.Point(793, 390);
            this.deleteselectedmemberlabel.Name = "deleteselectedmemberlabel";
            this.deleteselectedmemberlabel.Size = new System.Drawing.Size(130, 80);
            this.deleteselectedmemberlabel.TabIndex = 24;
            this.deleteselectedmemberlabel.Text = "Delete Selected";
            this.deleteselectedmemberlabel.UseVisualStyleBackColor = true;
            // 
            // createTournlabel
            // 
            this.createTournlabel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournlabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournlabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournlabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournlabel.Location = new System.Drawing.Point(370, 724);
            this.createTournlabel.Name = "createTournlabel";
            this.createTournlabel.Size = new System.Drawing.Size(227, 73);
            this.createTournlabel.TabIndex = 25;
            this.createTournlabel.Text = "CREATE TEAM";
            this.createTournlabel.UseVisualStyleBackColor = true;
            // 
            // selectteamdrop
            // 
            this.selectteamdrop.FormattingEnabled = true;
            this.selectteamdrop.Location = new System.Drawing.Point(47, 249);
            this.selectteamdrop.Name = "selectteamdrop";
            this.selectteamdrop.Size = new System.Drawing.Size(345, 21);
            this.selectteamdrop.TabIndex = 15;
            this.selectteamdrop.SelectedIndexChanged += new System.EventHandler(this.selectteamdrop_SelectedIndexChanged);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(971, 812);
            this.Controls.Add(this.createTournlabel);
            this.Controls.Add(this.deleteselectedmemberlabel);
            this.Controls.Add(this.teammembersListBox);
            this.Controls.Add(this.AddNewMemberboxlabel);
            this.Controls.Add(this.Addmemberlabel);
            this.Controls.Add(this.selectteamdrop);
            this.Controls.Add(this.selectteamlmemberlabel);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.Createteamlabel);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CreateTeamForm";
            this.Text = "Create Team Form";
            this.AddNewMemberboxlabel.ResumeLayout(false);
            this.AddNewMemberboxlabel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label Createteamlabel;
        private System.Windows.Forms.Label selectteamlmemberlabel;
        private System.Windows.Forms.Button Addmemberlabel;
        private System.Windows.Forms.GroupBox AddNewMemberboxlabel;
        private System.Windows.Forms.Label celllabel;
        private System.Windows.Forms.Label emailabel;
        private System.Windows.Forms.Label lastnamelabel;
        private System.Windows.Forms.Label firstnamelabel;
        private System.Windows.Forms.TextBox TournamentNameValue;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button creatememberlabel;
        private System.Windows.Forms.ListBox teammembersListBox;
        private System.Windows.Forms.Button deleteselectedmemberlabel;
        private System.Windows.Forms.Button createTournlabel;
        private System.Windows.Forms.ComboBox selectteamdrop;
    }
}