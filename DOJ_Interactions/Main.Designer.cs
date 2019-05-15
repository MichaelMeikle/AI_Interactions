namespace DOJ_Interactions
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vehicleButton = new System.Windows.Forms.Button();
            this.personButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.connectionTime = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(38)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.vehicleButton);
            this.panel1.Controls.Add(this.personButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 358);
            this.panel1.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(76)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 117);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 72);
            this.sidePanel.TabIndex = 2;
            this.sidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // vehicleButton
            // 
            this.vehicleButton.FlatAppearance.BorderSize = 0;
            this.vehicleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehicleButton.Location = new System.Drawing.Point(0, 273);
            this.vehicleButton.Name = "vehicleButton";
            this.vehicleButton.Size = new System.Drawing.Size(128, 72);
            this.vehicleButton.TabIndex = 5;
            this.vehicleButton.Text = "Vehicle";
            this.vehicleButton.UseVisualStyleBackColor = true;
            this.vehicleButton.Click += new System.EventHandler(this.vehicleButton_Click);
            // 
            // personButton
            // 
            this.personButton.FlatAppearance.BorderSize = 0;
            this.personButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personButton.Location = new System.Drawing.Point(0, 195);
            this.personButton.Name = "personButton";
            this.personButton.Size = new System.Drawing.Size(128, 72);
            this.personButton.TabIndex = 4;
            this.personButton.Text = "Person";
            this.personButton.UseVisualStyleBackColor = true;
            this.personButton.Click += new System.EventHandler(this.personButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Location = new System.Drawing.Point(0, 117);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(128, 72);
            this.homeButton.TabIndex = 3;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.Title);
            this.panel4.Location = new System.Drawing.Point(12, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(108, 21);
            this.panel4.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(9, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(90, 21);
            this.Title.TabIndex = 0;
            this.Title.Text = "State MDT";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Location = new System.Drawing.Point(131, 321);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(138, 13);
            this.connectionStatusLabel.TabIndex = 23;
            this.connectionStatusLabel.Text = "Status: Awaiting Connecton";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(134, 337);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(135, 14);
            this.progressBar1.Step = 25;
            this.progressBar1.TabIndex = 22;
            // 
            // connectionTime
            // 
            this.connectionTime.Enabled = true;
            this.connectionTime.Interval = 500;
            this.connectionTime.Tick += new System.EventHandler(this.connectionTime_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Developed by Michael M.";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(746, 358);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectionStatusLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "State MDT System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button personButton;
        private System.Windows.Forms.Button vehicleButton;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer connectionTime;
        private System.Windows.Forms.Label label1;
    }
}

