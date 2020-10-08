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
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.loadExistingTournamentsDropDown = new System.Windows.Forms.ComboBox();
            this.loadExistingTournamentsLabel = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(129, 44);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(295, 37);
            this.tournamentDashboardLabel.TabIndex = 3;
            this.tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadExistingTournamentsDropDown
            // 
            this.loadExistingTournamentsDropDown.FormattingEnabled = true;
            this.loadExistingTournamentsDropDown.Location = new System.Drawing.Point(88, 148);
            this.loadExistingTournamentsDropDown.Name = "loadExistingTournamentsDropDown";
            this.loadExistingTournamentsDropDown.Size = new System.Drawing.Size(377, 38);
            this.loadExistingTournamentsDropDown.TabIndex = 18;
            // 
            // loadExistingTournamentsLabel
            // 
            this.loadExistingTournamentsLabel.AutoSize = true;
            this.loadExistingTournamentsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadExistingTournamentsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loadExistingTournamentsLabel.Location = new System.Drawing.Point(146, 115);
            this.loadExistingTournamentsLabel.Name = "loadExistingTournamentsLabel";
            this.loadExistingTournamentsLabel.Size = new System.Drawing.Size(261, 30);
            this.loadExistingTournamentsLabel.TabIndex = 17;
            this.loadExistingTournamentsLabel.Text = "Load Existing Tournaments";
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loadTournamentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loadTournamentButton.Location = new System.Drawing.Point(194, 228);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(165, 36);
            this.loadTournamentButton.TabIndex = 19;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.createTournamentButton.Location = new System.Drawing.Point(141, 301);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(271, 36);
            this.createTournamentButton.TabIndex = 20;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 392);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.loadExistingTournamentsDropDown);
            this.Controls.Add(this.loadExistingTournamentsLabel);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentDashboardLabel;
        private System.Windows.Forms.ComboBox loadExistingTournamentsDropDown;
        private System.Windows.Forms.Label loadExistingTournamentsLabel;
        private System.Windows.Forms.Button loadTournamentButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}