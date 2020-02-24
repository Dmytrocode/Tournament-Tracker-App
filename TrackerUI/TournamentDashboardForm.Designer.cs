namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.tourndashboardlabel = new System.Windows.Forms.Label();
            this.placeexistnumberlabel = new System.Windows.Forms.Label();
            this.loadtournamentlabel = new System.Windows.Forms.ComboBox();
            this.loadTournlabel = new System.Windows.Forms.Button();
            this.createtournamentlabel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tourndashboardlabel
            // 
            this.tourndashboardlabel.AutoSize = true;
            this.tourndashboardlabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tourndashboardlabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.tourndashboardlabel.Location = new System.Drawing.Point(115, 43);
            this.tourndashboardlabel.Name = "tourndashboardlabel";
            this.tourndashboardlabel.Size = new System.Drawing.Size(426, 45);
            this.tourndashboardlabel.TabIndex = 3;
            this.tourndashboardlabel.Text = "TOURNAMENT DASHBOARD";
            // 
            // placeexistnumberlabel
            // 
            this.placeexistnumberlabel.AutoSize = true;
            this.placeexistnumberlabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeexistnumberlabel.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.placeexistnumberlabel.Location = new System.Drawing.Point(167, 113);
            this.placeexistnumberlabel.Name = "placeexistnumberlabel";
            this.placeexistnumberlabel.Size = new System.Drawing.Size(322, 37);
            this.placeexistnumberlabel.TabIndex = 15;
            this.placeexistnumberlabel.Text = "Load Existing Tournament";
            // 
            // loadtournamentlabel
            // 
            this.loadtournamentlabel.FormattingEnabled = true;
            this.loadtournamentlabel.Location = new System.Drawing.Point(136, 160);
            this.loadtournamentlabel.Name = "loadtournamentlabel";
            this.loadtournamentlabel.Size = new System.Drawing.Size(384, 38);
            this.loadtournamentlabel.TabIndex = 16;
            // 
            // loadTournlabel
            // 
            this.loadTournlabel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournlabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournlabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTournlabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.loadTournlabel.Location = new System.Drawing.Point(209, 223);
            this.loadTournlabel.Name = "loadTournlabel";
            this.loadTournlabel.Size = new System.Drawing.Size(239, 52);
            this.loadTournlabel.TabIndex = 27;
            this.loadTournlabel.Text = "LOAD TOURNAMENT";
            this.loadTournlabel.UseVisualStyleBackColor = true;
            // 
            // createtournamentlabel
            // 
            this.createtournamentlabel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createtournamentlabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createtournamentlabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createtournamentlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createtournamentlabel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createtournamentlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createtournamentlabel.Location = new System.Drawing.Point(169, 299);
            this.createtournamentlabel.Name = "createtournamentlabel";
            this.createtournamentlabel.Size = new System.Drawing.Size(318, 88);
            this.createtournamentlabel.TabIndex = 28;
            this.createtournamentlabel.Text = "CREATE TOURNAMENT";
            this.createtournamentlabel.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(665, 416);
            this.Controls.Add(this.createtournamentlabel);
            this.Controls.Add(this.loadTournlabel);
            this.Controls.Add(this.loadtournamentlabel);
            this.Controls.Add(this.placeexistnumberlabel);
            this.Controls.Add(this.tourndashboardlabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.Load += new System.EventHandler(this.TournamentDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tourndashboardlabel;
        private System.Windows.Forms.Label placeexistnumberlabel;
        private System.Windows.Forms.ComboBox loadtournamentlabel;
        private System.Windows.Forms.Button loadTournlabel;
        private System.Windows.Forms.Button createtournamentlabel;
    }
}