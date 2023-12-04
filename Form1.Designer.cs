namespace WinForms_OwnTimer
{
    partial class OwnTimer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTime = new Label();
            shapyButtonStart = new ShapyButton();
            shapyButtonStop = new ShapyButton();
            shapyButtonReset = new ShapyButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTime.Font = new Font("Unispace", 60F, FontStyle.Bold, GraphicsUnit.Point);
            labelTime.ForeColor = Color.White;
            labelTime.Location = new Point(0, 0);
            labelTime.Name = "labelTime";
            labelTime.Padding = new Padding(25, 0, 0, 0);
            labelTime.Size = new Size(661, 114);
            labelTime.TabIndex = 0;
            labelTime.Text = "00:00:00:000";
            labelTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // shapyButtonStart
            // 
            shapyButtonStart.BackColor = Color.LimeGreen;
            shapyButtonStart.BackgroundColor = Color.LimeGreen;
            shapyButtonStart.BorderColor = Color.Red;
            shapyButtonStart.BorderRadius = 30;
            shapyButtonStart.BorderSize = 0;
            shapyButtonStart.Dock = DockStyle.Fill;
            shapyButtonStart.FlatAppearance.BorderSize = 0;
            shapyButtonStart.FlatStyle = FlatStyle.Flat;
            shapyButtonStart.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            shapyButtonStart.ForeColor = Color.White;
            shapyButtonStart.Location = new Point(3, 3);
            shapyButtonStart.Name = "shapyButtonStart";
            shapyButtonStart.Size = new Size(198, 82);
            shapyButtonStart.TabIndex = 1;
            shapyButtonStart.Text = "Start";
            shapyButtonStart.TextColor = Color.White;
            shapyButtonStart.UseVisualStyleBackColor = false;
            shapyButtonStart.Click += shapyButtonStart_Click;
            // 
            // shapyButtonStop
            // 
            shapyButtonStop.BackColor = Color.OrangeRed;
            shapyButtonStop.BackgroundColor = Color.OrangeRed;
            shapyButtonStop.BorderColor = Color.Red;
            shapyButtonStop.BorderRadius = 30;
            shapyButtonStop.BorderSize = 0;
            shapyButtonStop.Dock = DockStyle.Fill;
            shapyButtonStop.FlatAppearance.BorderSize = 0;
            shapyButtonStop.FlatStyle = FlatStyle.Flat;
            shapyButtonStop.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            shapyButtonStop.ForeColor = Color.White;
            shapyButtonStop.Location = new Point(207, 3);
            shapyButtonStop.Name = "shapyButtonStop";
            shapyButtonStop.Size = new Size(266, 82);
            shapyButtonStop.TabIndex = 2;
            shapyButtonStop.Text = "Stop";
            shapyButtonStop.TextColor = Color.White;
            shapyButtonStop.UseVisualStyleBackColor = false;
            shapyButtonStop.Click += shapyButtonStop_Click;
            // 
            // shapyButtonReset
            // 
            shapyButtonReset.BackColor = Color.DarkTurquoise;
            shapyButtonReset.BackgroundColor = Color.DarkTurquoise;
            shapyButtonReset.BorderColor = Color.Red;
            shapyButtonReset.BorderRadius = 30;
            shapyButtonReset.BorderSize = 0;
            shapyButtonReset.Dock = DockStyle.Fill;
            shapyButtonReset.FlatAppearance.BorderSize = 0;
            shapyButtonReset.FlatStyle = FlatStyle.Flat;
            shapyButtonReset.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point);
            shapyButtonReset.ForeColor = Color.White;
            shapyButtonReset.Location = new Point(479, 3);
            shapyButtonReset.Name = "shapyButtonReset";
            shapyButtonReset.Size = new Size(199, 82);
            shapyButtonReset.TabIndex = 3;
            shapyButtonReset.Text = "Reset";
            shapyButtonReset.TextColor = Color.White;
            shapyButtonReset.UseVisualStyleBackColor = false;
            shapyButtonReset.Click += shapyButtonReset_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.Controls.Add(shapyButtonStart, 0, 0);
            tableLayoutPanel1.Controls.Add(shapyButtonReset, 2, 0);
            tableLayoutPanel1.Controls.Add(shapyButtonStop, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 117);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(681, 88);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // OwnTimer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(684, 211);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(labelTime);
            MinimumSize = new Size(700, 250);
            Name = "OwnTimer";
            Text = "Stopwatch";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelTime;
        private ShapyButton shapyButtonStart;
        private ShapyButton shapyButtonStop;
        private ShapyButton shapyButtonReset;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
