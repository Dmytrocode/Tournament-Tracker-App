namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.components = new System.ComponentModel.Container();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.unplayedOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.teamOneScoreL = new System.Windows.Forms.Label();
            this.teamOneScoreTxt = new System.Windows.Forms.TextBox();
            this.teamTwoScoreTxt = new System.Windows.Forms.TextBox();
            this.labteamTwoScoreLel1 = new System.Windows.Forms.Label();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.VersusLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.HeaderLabel.Location = new System.Drawing.Point(32, 37);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(224, 38);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Tournament:";
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tournamentName.Location = new System.Drawing.Point(251, 37);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(147, 38);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.roundLabel.Location = new System.Drawing.Point(33, 123);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(100, 32);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            // 
            // roundDropdown
            // 
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(139, 122);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(205, 33);
            this.roundDropdown.TabIndex = 3;
            this.roundDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // unplayedOnlyCheckbox
            // 
            this.unplayedOnlyCheckbox.AutoSize = true;
            this.unplayedOnlyCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.unplayedOnlyCheckbox.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedOnlyCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.unplayedOnlyCheckbox.Location = new System.Drawing.Point(139, 174);
            this.unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            this.unplayedOnlyCheckbox.Size = new System.Drawing.Size(181, 29);
            this.unplayedOnlyCheckbox.TabIndex = 4;
            this.unplayedOnlyCheckbox.Text = "Unplayed Only";
            this.unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 25;
            this.matchupListBox.Location = new System.Drawing.Point(39, 244);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(305, 252);
            this.matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teamOneName.Location = new System.Drawing.Point(390, 244);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(187, 32);
            this.teamOneName.TabIndex = 6;
            this.teamOneName.Text = "<team one>";
            // 
            // teamOneScoreL
            // 
            this.teamOneScoreL.AutoSize = true;
            this.teamOneScoreL.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneScoreL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teamOneScoreL.Location = new System.Drawing.Point(390, 302);
            this.teamOneScoreL.Name = "teamOneScoreL";
            this.teamOneScoreL.Size = new System.Drawing.Size(118, 29);
            this.teamOneScoreL.TabIndex = 7;
            this.teamOneScoreL.Text = "<score>";
            // 
            // teamOneScoreTxt
            // 
            this.teamOneScoreTxt.Location = new System.Drawing.Point(514, 298);
            this.teamOneScoreTxt.Name = "teamOneScoreTxt";
            this.teamOneScoreTxt.Size = new System.Drawing.Size(100, 33);
            this.teamOneScoreTxt.TabIndex = 8;
            // 
            // teamTwoScoreTxt
            // 
            this.teamTwoScoreTxt.Location = new System.Drawing.Point(514, 452);
            this.teamTwoScoreTxt.Name = "teamTwoScoreTxt";
            this.teamTwoScoreTxt.Size = new System.Drawing.Size(100, 33);
            this.teamTwoScoreTxt.TabIndex = 11;
            // 
            // labteamTwoScoreLel1
            // 
            this.labteamTwoScoreLel1.AutoSize = true;
            this.labteamTwoScoreLel1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labteamTwoScoreLel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labteamTwoScoreLel1.Location = new System.Drawing.Point(390, 456);
            this.labteamTwoScoreLel1.Name = "labteamTwoScoreLel1";
            this.labteamTwoScoreLel1.Size = new System.Drawing.Size(118, 29);
            this.labteamTwoScoreLel1.TabIndex = 10;
            this.labteamTwoScoreLel1.Text = "<score>";
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.teamTwoName.Location = new System.Drawing.Point(390, 398);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(187, 32);
            this.teamTwoName.TabIndex = 9;
            this.teamTwoName.Text = "<team two>";
            // 
            // VersusLabel
            // 
            this.VersusLabel.AutoSize = true;
            this.VersusLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersusLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.VersusLabel.Location = new System.Drawing.Point(484, 358);
            this.VersusLabel.Name = "VersusLabel";
            this.VersusLabel.Size = new System.Drawing.Size(59, 25);
            this.VersusLabel.TabIndex = 12;
            this.VersusLabel.Text = "-VS-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(863, 647);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VersusLabel);
            this.Controls.Add(this.teamTwoScoreTxt);
            this.Controls.Add(this.labteamTwoScoreLel1);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.teamOneScoreTxt);
            this.Controls.Add(this.teamOneScoreL);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.unplayedOnlyCheckbox);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "TournamentViewerForm";
            this.Text = "TournamentViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropdown;
        private System.Windows.Forms.CheckBox unplayedOnlyCheckbox;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label teamOneScoreL;
        private System.Windows.Forms.TextBox teamOneScoreTxt;
        private System.Windows.Forms.TextBox teamTwoScoreTxt;
        private System.Windows.Forms.Label labteamTwoScoreLel1;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label VersusLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

