namespace proj3
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
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LeftLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RightLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ChartsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PictureLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LeftPictureBox = new System.Windows.Forms.PictureBox();
            this.RightPictureBox = new System.Windows.Forms.PictureBox();
            this.RedChartPictureBox = new System.Windows.Forms.PictureBox();
            this.GreenChartPictureBox = new System.Windows.Forms.PictureBox();
            this.BlueChartPictureBox = new System.Windows.Forms.PictureBox();
            this.FileGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenFIleButton = new System.Windows.Forms.Button();
            this.MainLayoutPanel.SuspendLayout();
            this.LeftLayoutPanel.SuspendLayout();
            this.RightLayoutPanel.SuspendLayout();
            this.ChartsLayoutPanel.SuspendLayout();
            this.PictureLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LeftPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedChartPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenChartPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueChartPictureBox)).BeginInit();
            this.FileGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.Controls.Add(this.LeftLayoutPanel, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.RightLayoutPanel, 1, 0);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 1;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(1582, 853);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // LeftLayoutPanel
            // 
            this.LeftLayoutPanel.ColumnCount = 1;
            this.LeftLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LeftLayoutPanel.Controls.Add(this.FileGroupBox, 0, 0);
            this.LeftLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.LeftLayoutPanel.Name = "LeftLayoutPanel";
            this.LeftLayoutPanel.RowCount = 8;
            this.LeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.LeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.LeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.LeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.LeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.LeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.LeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.LeftLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.LeftLayoutPanel.Size = new System.Drawing.Size(194, 847);
            this.LeftLayoutPanel.TabIndex = 0;
            // 
            // RightLayoutPanel
            // 
            this.RightLayoutPanel.ColumnCount = 1;
            this.RightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RightLayoutPanel.Controls.Add(this.ChartsLayoutPanel, 0, 1);
            this.RightLayoutPanel.Controls.Add(this.PictureLayoutPanel, 0, 0);
            this.RightLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightLayoutPanel.Location = new System.Drawing.Point(203, 3);
            this.RightLayoutPanel.Name = "RightLayoutPanel";
            this.RightLayoutPanel.RowCount = 2;
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RightLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.RightLayoutPanel.Size = new System.Drawing.Size(1376, 847);
            this.RightLayoutPanel.TabIndex = 1;
            // 
            // ChartsLayoutPanel
            // 
            this.ChartsLayoutPanel.ColumnCount = 3;
            this.ChartsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ChartsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ChartsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ChartsLayoutPanel.Controls.Add(this.RedChartPictureBox, 0, 0);
            this.ChartsLayoutPanel.Controls.Add(this.GreenChartPictureBox, 1, 0);
            this.ChartsLayoutPanel.Controls.Add(this.BlueChartPictureBox, 2, 0);
            this.ChartsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartsLayoutPanel.Location = new System.Drawing.Point(3, 650);
            this.ChartsLayoutPanel.Name = "ChartsLayoutPanel";
            this.ChartsLayoutPanel.RowCount = 1;
            this.ChartsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ChartsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ChartsLayoutPanel.Size = new System.Drawing.Size(1370, 194);
            this.ChartsLayoutPanel.TabIndex = 0;
            // 
            // PictureLayoutPanel
            // 
            this.PictureLayoutPanel.ColumnCount = 2;
            this.PictureLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PictureLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PictureLayoutPanel.Controls.Add(this.LeftPictureBox, 0, 0);
            this.PictureLayoutPanel.Controls.Add(this.RightPictureBox, 1, 0);
            this.PictureLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.PictureLayoutPanel.Name = "PictureLayoutPanel";
            this.PictureLayoutPanel.RowCount = 1;
            this.PictureLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PictureLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PictureLayoutPanel.Size = new System.Drawing.Size(1370, 641);
            this.PictureLayoutPanel.TabIndex = 1;
            // 
            // LeftPictureBox
            // 
            this.LeftPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftPictureBox.Location = new System.Drawing.Point(3, 3);
            this.LeftPictureBox.Name = "LeftPictureBox";
            this.LeftPictureBox.Size = new System.Drawing.Size(679, 635);
            this.LeftPictureBox.TabIndex = 0;
            this.LeftPictureBox.TabStop = false;
            // 
            // RightPictureBox
            // 
            this.RightPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RightPictureBox.Location = new System.Drawing.Point(688, 3);
            this.RightPictureBox.Name = "RightPictureBox";
            this.RightPictureBox.Size = new System.Drawing.Size(679, 635);
            this.RightPictureBox.TabIndex = 1;
            this.RightPictureBox.TabStop = false;
            // 
            // RedChartPictureBox
            // 
            this.RedChartPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RedChartPictureBox.Location = new System.Drawing.Point(100, 7);
            this.RedChartPictureBox.Name = "RedChartPictureBox";
            this.RedChartPictureBox.Size = new System.Drawing.Size(256, 180);
            this.RedChartPictureBox.TabIndex = 0;
            this.RedChartPictureBox.TabStop = false;
            // 
            // GreenChartPictureBox
            // 
            this.GreenChartPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GreenChartPictureBox.Location = new System.Drawing.Point(556, 7);
            this.GreenChartPictureBox.Name = "GreenChartPictureBox";
            this.GreenChartPictureBox.Size = new System.Drawing.Size(256, 180);
            this.GreenChartPictureBox.TabIndex = 1;
            this.GreenChartPictureBox.TabStop = false;
            // 
            // BlueChartPictureBox
            // 
            this.BlueChartPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BlueChartPictureBox.Location = new System.Drawing.Point(1013, 7);
            this.BlueChartPictureBox.Name = "BlueChartPictureBox";
            this.BlueChartPictureBox.Size = new System.Drawing.Size(256, 180);
            this.BlueChartPictureBox.TabIndex = 2;
            this.BlueChartPictureBox.TabStop = false;
            // 
            // FileGroupBox
            // 
            this.FileGroupBox.Controls.Add(this.OpenFIleButton);
            this.FileGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileGroupBox.Location = new System.Drawing.Point(3, 3);
            this.FileGroupBox.Name = "FileGroupBox";
            this.FileGroupBox.Size = new System.Drawing.Size(188, 99);
            this.FileGroupBox.TabIndex = 0;
            this.FileGroupBox.TabStop = false;
            this.FileGroupBox.Text = "Plik";
            // 
            // OpenFIleButton
            // 
            this.OpenFIleButton.Location = new System.Drawing.Point(6, 21);
            this.OpenFIleButton.Name = "OpenFIleButton";
            this.OpenFIleButton.Size = new System.Drawing.Size(75, 23);
            this.OpenFIleButton.TabIndex = 0;
            this.OpenFIleButton.Text = "Wczytaj";
            this.OpenFIleButton.UseVisualStyleBackColor = true;
            this.OpenFIleButton.Click += new System.EventHandler(this.OpenFIleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.MainLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "pro3";
            this.MainLayoutPanel.ResumeLayout(false);
            this.LeftLayoutPanel.ResumeLayout(false);
            this.RightLayoutPanel.ResumeLayout(false);
            this.ChartsLayoutPanel.ResumeLayout(false);
            this.PictureLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LeftPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedChartPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenChartPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlueChartPictureBox)).EndInit();
            this.FileGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel LeftLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel RightLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel ChartsLayoutPanel;
        private System.Windows.Forms.PictureBox RedChartPictureBox;
        private System.Windows.Forms.PictureBox GreenChartPictureBox;
        private System.Windows.Forms.PictureBox BlueChartPictureBox;
        private System.Windows.Forms.TableLayoutPanel PictureLayoutPanel;
        private System.Windows.Forms.PictureBox LeftPictureBox;
        private System.Windows.Forms.PictureBox RightPictureBox;
        private System.Windows.Forms.GroupBox FileGroupBox;
        private System.Windows.Forms.Button OpenFIleButton;
    }
}

