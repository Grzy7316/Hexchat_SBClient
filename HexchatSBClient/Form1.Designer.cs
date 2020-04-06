namespace HexchatSBClient
{
    partial class Form1
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
            this.FolderPathBox = new System.Windows.Forms.TextBox();
            this.ScanStartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ResultsGrid = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // FolderPathBox
            // 
            this.FolderPathBox.Location = new System.Drawing.Point(16, 29);
            this.FolderPathBox.Name = "FolderPathBox";
            this.FolderPathBox.Size = new System.Drawing.Size(245, 20);
            this.FolderPathBox.TabIndex = 0;
            // 
            // ScanStartButton
            // 
            this.ScanStartButton.Location = new System.Drawing.Point(267, 27);
            this.ScanStartButton.Name = "ScanStartButton";
            this.ScanStartButton.Size = new System.Drawing.Size(75, 23);
            this.ScanStartButton.TabIndex = 1;
            this.ScanStartButton.Text = "Start Scanning";
            this.ScanStartButton.UseVisualStyleBackColor = true;
            this.ScanStartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Path to IRC Downloads";
            // 
            // FilterBox
            // 
            this.FilterBox.Location = new System.Drawing.Point(16, 70);
            this.FilterBox.Name = "FilterBox";
            this.FilterBox.Size = new System.Drawing.Size(245, 20);
            this.FilterBox.TabIndex = 3;
            this.FilterBox.TextChanged += new System.EventHandler(this.FilterBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter Search Results";
            // 
            // ResultsGrid
            // 
            this.ResultsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsGrid.Location = new System.Drawing.Point(-2, 105);
            this.ResultsGrid.Name = "ResultsGrid";
            this.ResultsGrid.Size = new System.Drawing.Size(802, 435);
            this.ResultsGrid.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.ResultsGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FilterBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScanStartButton);
            this.Controls.Add(this.FolderPathBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FolderPathBox;
        private System.Windows.Forms.Button ScanStartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilterBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ResultsGrid;
        private System.Windows.Forms.Timer timer1;
    }
}

