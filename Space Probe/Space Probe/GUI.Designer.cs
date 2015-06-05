namespace Space_Probe
{
    partial class GUI
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
            this.ConfigBox = new System.Windows.Forms.GroupBox();
            this.gravDLabel = new System.Windows.Forms.Label();
            this.SpaceDNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AstroidDensityPercentLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spaceBar = new System.Windows.Forms.TrackBar();
            this.gravityBar = new System.Windows.Forms.TrackBar();
            this.astroidBar = new System.Windows.Forms.TrackBar();
            this.Start = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.universePanel = new System.Windows.Forms.Panel();
            this.ConfigBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaceBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.astroidBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfigBox
            // 
            this.ConfigBox.Controls.Add(this.gravDLabel);
            this.ConfigBox.Controls.Add(this.SpaceDNum);
            this.ConfigBox.Controls.Add(this.label5);
            this.ConfigBox.Controls.Add(this.AstroidDensityPercentLabel);
            this.ConfigBox.Controls.Add(this.label3);
            this.ConfigBox.Controls.Add(this.label2);
            this.ConfigBox.Controls.Add(this.label1);
            this.ConfigBox.Controls.Add(this.spaceBar);
            this.ConfigBox.Controls.Add(this.gravityBar);
            this.ConfigBox.Controls.Add(this.astroidBar);
            this.ConfigBox.Controls.Add(this.Start);
            this.ConfigBox.Controls.Add(this.Close);
            this.ConfigBox.Location = new System.Drawing.Point(3, 12);
            this.ConfigBox.Name = "ConfigBox";
            this.ConfigBox.Size = new System.Drawing.Size(243, 522);
            this.ConfigBox.TabIndex = 0;
            this.ConfigBox.TabStop = false;
            this.ConfigBox.Text = "ConfigBox";
            this.ConfigBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gravDLabel
            // 
            this.gravDLabel.AutoSize = true;
            this.gravDLabel.Location = new System.Drawing.Point(194, 90);
            this.gravDLabel.Name = "gravDLabel";
            this.gravDLabel.Size = new System.Drawing.Size(13, 13);
            this.gravDLabel.TabIndex = 0;
            this.gravDLabel.Text = "0";
            this.gravDLabel.Click += new System.EventHandler(this.gravDLabel_Click);
            // 
            // SpaceDNum
            // 
            this.SpaceDNum.AutoSize = true;
            this.SpaceDNum.Location = new System.Drawing.Point(194, 141);
            this.SpaceDNum.Name = "SpaceDNum";
            this.SpaceDNum.Size = new System.Drawing.Size(13, 13);
            this.SpaceDNum.TabIndex = 8;
            this.SpaceDNum.Text = "0";
            this.SpaceDNum.Click += new System.EventHandler(this.SpaceDNum_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 7;
            // 
            // AstroidDensityPercentLabel
            // 
            this.AstroidDensityPercentLabel.AutoSize = true;
            this.AstroidDensityPercentLabel.Location = new System.Drawing.Point(194, 13);
            this.AstroidDensityPercentLabel.Name = "AstroidDensityPercentLabel";
            this.AstroidDensityPercentLabel.Size = new System.Drawing.Size(13, 39);
            this.AstroidDensityPercentLabel.TabIndex = 6;
            this.AstroidDensityPercentLabel.Text = "\r\n\r\n0";
            this.AstroidDensityPercentLabel.Click += new System.EventHandler(this.AstroidDensityPercentLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Space Density";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gravity Density";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Astroid Density";
            // 
            // spaceBar
            // 
            this.spaceBar.Location = new System.Drawing.Point(86, 141);
            this.spaceBar.Name = "spaceBar";
            this.spaceBar.Size = new System.Drawing.Size(104, 45);
            this.spaceBar.TabIndex = 2;
            this.spaceBar.Scroll += new System.EventHandler(this.spaceBar_Scroll);
            // 
            // gravityBar
            // 
            this.gravityBar.Location = new System.Drawing.Point(86, 90);
            this.gravityBar.Name = "gravityBar";
            this.gravityBar.Size = new System.Drawing.Size(104, 45);
            this.gravityBar.TabIndex = 1;
            this.gravityBar.Scroll += new System.EventHandler(this.gravityBar_Scroll);
            // 
            // astroidBar
            // 
            this.astroidBar.Location = new System.Drawing.Point(86, 30);
            this.astroidBar.Name = "astroidBar";
            this.astroidBar.Size = new System.Drawing.Size(104, 45);
            this.astroidBar.TabIndex = 0;
            this.astroidBar.Scroll += new System.EventHandler(this.astroidBar_Scroll);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(38, 265);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(125, 71);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(7, 493);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 0;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.button1_Click);
            // 
            // universePanel
            // 
            this.universePanel.BackColor = System.Drawing.Color.Black;
            this.universePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.universePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.universePanel.ForeColor = System.Drawing.Color.White;
            this.universePanel.Location = new System.Drawing.Point(261, 12);
            this.universePanel.Name = "universePanel";
            this.universePanel.Size = new System.Drawing.Size(605, 516);
            this.universePanel.TabIndex = 1;
            this.universePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.universePanel_Paint);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 534);
            this.Controls.Add(this.universePanel);
            this.Controls.Add(this.ConfigBox);
            this.Name = "GUI";
            this.Text = "GUI";
            this.ConfigBox.ResumeLayout(false);
            this.ConfigBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spaceBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravityBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.astroidBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ConfigBox;
        private System.Windows.Forms.Panel universePanel;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TrackBar spaceBar;
        private System.Windows.Forms.TrackBar gravityBar;
        private System.Windows.Forms.TrackBar astroidBar;
        private System.Windows.Forms.Label SpaceDNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AstroidDensityPercentLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gravDLabel;
        private System.Windows.Forms.DataGridView dataGrid;
    }
}