namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.createtournamentlabel = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.CreateTournamentNameLabel = new System.Windows.Forms.Label();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.teamOneScoreL = new System.Windows.Forms.Label();
            this.selectteamdrop = new System.Windows.Forms.ComboBox();
            this.SelectTeamlabel = new System.Windows.Forms.Label();
            this.createnewTeamlabel = new System.Windows.Forms.LinkLabel();
            this.AddTeambutton = new System.Windows.Forms.Button();
            this.Createprizebutton = new System.Windows.Forms.Button();
            this.TournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.TournamentPlayersLabel = new System.Windows.Forms.Label();
            this.Deleteselectedprizes = new System.Windows.Forms.Button();
            this.deleteselectedplayers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.createtournbut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createtournamentlabel
            // 
            this.createtournamentlabel.AutoSize = true;
            this.createtournamentlabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createtournamentlabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.createtournamentlabel.Location = new System.Drawing.Point(27, 35);
            this.createtournamentlabel.Name = "createtournamentlabel";
            this.createtournamentlabel.Size = new System.Drawing.Size(348, 45);
            this.createtournamentlabel.TabIndex = 1;
            this.createtournamentlabel.Text = "CREATE TOURNAMENT";
            this.createtournamentlabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(58, 156);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(271, 33);
            this.TournamentNameValue.TabIndex = 10;
            // 
            // CreateTournamentNameLabel
            // 
            this.CreateTournamentNameLabel.AutoSize = true;
            this.CreateTournamentNameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateTournamentNameLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.CreateTournamentNameLabel.Location = new System.Drawing.Point(51, 116);
            this.CreateTournamentNameLabel.Name = "CreateTournamentNameLabel";
            this.CreateTournamentNameLabel.Size = new System.Drawing.Size(215, 32);
            this.CreateTournamentNameLabel.TabIndex = 9;
            this.CreateTournamentNameLabel.Text = "Tournament Name";
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Font = new System.Drawing.Font("Franklin Gothic Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryFeeValue.Location = new System.Drawing.Point(171, 218);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(158, 31);
            this.EntryFeeValue.TabIndex = 12;
            this.EntryFeeValue.Tag = "";
            this.EntryFeeValue.Text = "0";
            // 
            // teamOneScoreL
            // 
            this.teamOneScoreL.AutoSize = true;
            this.teamOneScoreL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneScoreL.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.teamOneScoreL.Location = new System.Drawing.Point(51, 216);
            this.teamOneScoreL.Name = "teamOneScoreL";
            this.teamOneScoreL.Size = new System.Drawing.Size(114, 32);
            this.teamOneScoreL.TabIndex = 11;
            this.teamOneScoreL.Text = "Entry Fee";
            this.teamOneScoreL.Click += new System.EventHandler(this.teamOneScoreL_Click);
            // 
            // selectteamdrop
            // 
            this.selectteamdrop.FormattingEnabled = true;
            this.selectteamdrop.Location = new System.Drawing.Point(58, 309);
            this.selectteamdrop.Name = "selectteamdrop";
            this.selectteamdrop.Size = new System.Drawing.Size(271, 34);
            this.selectteamdrop.TabIndex = 14;
            // 
            // SelectTeamlabel
            // 
            this.SelectTeamlabel.AutoSize = true;
            this.SelectTeamlabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeamlabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.SelectTeamlabel.Location = new System.Drawing.Point(52, 271);
            this.SelectTeamlabel.Name = "SelectTeamlabel";
            this.SelectTeamlabel.Size = new System.Drawing.Size(143, 32);
            this.SelectTeamlabel.TabIndex = 13;
            this.SelectTeamlabel.Text = "Select Team";
            // 
            // createnewTeamlabel
            // 
            this.createnewTeamlabel.AutoSize = true;
            this.createnewTeamlabel.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createnewTeamlabel.Location = new System.Drawing.Point(215, 285);
            this.createnewTeamlabel.Name = "createnewTeamlabel";
            this.createnewTeamlabel.Size = new System.Drawing.Size(114, 18);
            this.createnewTeamlabel.TabIndex = 15;
            this.createnewTeamlabel.TabStop = true;
            this.createnewTeamlabel.Text = "Create New Team";
            // 
            // AddTeambutton
            // 
            this.AddTeambutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AddTeambutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddTeambutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AddTeambutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTeambutton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTeambutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddTeambutton.Location = new System.Drawing.Point(98, 363);
            this.AddTeambutton.Name = "AddTeambutton";
            this.AddTeambutton.Size = new System.Drawing.Size(184, 45);
            this.AddTeambutton.TabIndex = 16;
            this.AddTeambutton.Text = "Add Team";
            this.AddTeambutton.UseVisualStyleBackColor = true;
            // 
            // Createprizebutton
            // 
            this.Createprizebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Createprizebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Createprizebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Createprizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Createprizebutton.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createprizebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Createprizebutton.Location = new System.Drawing.Point(98, 426);
            this.Createprizebutton.Name = "Createprizebutton";
            this.Createprizebutton.Size = new System.Drawing.Size(184, 45);
            this.Createprizebutton.TabIndex = 17;
            this.Createprizebutton.Text = "Create Prize";
            this.Createprizebutton.UseVisualStyleBackColor = true;
            this.Createprizebutton.Click += new System.EventHandler(this.Createprizebutton_Click);
            // 
            // TournamentPlayersListBox
            // 
            this.TournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TournamentPlayersListBox.FormattingEnabled = true;
            this.TournamentPlayersListBox.ItemHeight = 26;
            this.TournamentPlayersListBox.Location = new System.Drawing.Point(454, 156);
            this.TournamentPlayersListBox.Name = "TournamentPlayersListBox";
            this.TournamentPlayersListBox.Size = new System.Drawing.Size(291, 132);
            this.TournamentPlayersListBox.TabIndex = 18;
            // 
            // TournamentPlayersLabel
            // 
            this.TournamentPlayersLabel.AutoSize = true;
            this.TournamentPlayersLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TournamentPlayersLabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.TournamentPlayersLabel.Location = new System.Drawing.Point(448, 116);
            this.TournamentPlayersLabel.Name = "TournamentPlayersLabel";
            this.TournamentPlayersLabel.Size = new System.Drawing.Size(169, 32);
            this.TournamentPlayersLabel.TabIndex = 19;
            this.TournamentPlayersLabel.Text = "Team / Players";
            // 
            // Deleteselectedprizes
            // 
            this.Deleteselectedprizes.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Deleteselectedprizes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Deleteselectedprizes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Deleteselectedprizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deleteselectedprizes.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deleteselectedprizes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.Deleteselectedprizes.Location = new System.Drawing.Point(785, 363);
            this.Deleteselectedprizes.Name = "Deleteselectedprizes";
            this.Deleteselectedprizes.Size = new System.Drawing.Size(130, 80);
            this.Deleteselectedprizes.TabIndex = 20;
            this.Deleteselectedprizes.Text = "Delete Selected";
            this.Deleteselectedprizes.UseVisualStyleBackColor = true;
            // 
            // deleteselectedplayers
            // 
            this.deleteselectedplayers.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteselectedplayers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteselectedplayers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteselectedplayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteselectedplayers.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteselectedplayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteselectedplayers.Location = new System.Drawing.Point(785, 185);
            this.deleteselectedplayers.Name = "deleteselectedplayers";
            this.deleteselectedplayers.Size = new System.Drawing.Size(130, 80);
            this.deleteselectedplayers.TabIndex = 23;
            this.deleteselectedplayers.Text = "Delete Selected";
            this.deleteselectedplayers.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(448, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Team / Players";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(454, 339);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(291, 132);
            this.listBox1.TabIndex = 24;
            // 
            // createtournbut
            // 
            this.createtournbut.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createtournbut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createtournbut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createtournbut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createtournbut.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createtournbut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createtournbut.Location = new System.Drawing.Point(330, 520);
            this.createtournbut.Name = "createtournbut";
            this.createtournbut.Size = new System.Drawing.Size(258, 68);
            this.createtournbut.TabIndex = 25;
            this.createtournbut.Text = "CREATE TOURNAMENT";
            this.createtournbut.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 663);
            this.Controls.Add(this.createtournbut);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.deleteselectedplayers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deleteselectedprizes);
            this.Controls.Add(this.TournamentPlayersLabel);
            this.Controls.Add(this.TournamentPlayersListBox);
            this.Controls.Add(this.Createprizebutton);
            this.Controls.Add(this.AddTeambutton);
            this.Controls.Add(this.createnewTeamlabel);
            this.Controls.Add(this.selectteamdrop);
            this.Controls.Add(this.SelectTeamlabel);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.teamOneScoreL);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.CreateTournamentNameLabel);
            this.Controls.Add(this.createtournamentlabel);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label createtournamentlabel;
        private System.Windows.Forms.TextBox TournamentNameValue;
        private System.Windows.Forms.Label CreateTournamentNameLabel;
        private System.Windows.Forms.TextBox EntryFeeValue;
        private System.Windows.Forms.Label teamOneScoreL;
        private System.Windows.Forms.ComboBox selectteamdrop;
        private System.Windows.Forms.Label SelectTeamlabel;
        private System.Windows.Forms.LinkLabel createnewTeamlabel;
        private System.Windows.Forms.Button AddTeambutton;
        private System.Windows.Forms.Button Createprizebutton;
        private System.Windows.Forms.ListBox TournamentPlayersListBox;
        private System.Windows.Forms.Label TournamentPlayersLabel;
        private System.Windows.Forms.Button Deleteselectedprizes;
        private System.Windows.Forms.Button deleteselectedplayers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button createtournbut;
    }
}