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
            this.HeaderLabel = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.HeaderLabel.Location = new System.Drawing.Point(21, 33);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(291, 45);
            this.HeaderLabel.TabIndex = 1;
            this.HeaderLabel.Text = "Create Tournament";
            this.HeaderLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
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
            this.AddTeambutton.Location = new System.Drawing.Point(98, 361);
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
            this.Createprizebutton.Location = new System.Drawing.Point(98, 419);
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
            this.TournamentPlayersListBox.Size = new System.Drawing.Size(305, 158);
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
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 531);
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
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
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
    }
}