namespace PWDGEN
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            button1 = new Button();
            trackBar1 = new TrackBar();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(18, 16);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(542, 29);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(18, 54);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(159, 36);
            button1.TabIndex = 1;
            button1.Text = "Generate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(184, 52);
            trackBar1.Maximum = 3;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(104, 45);
            trackBar1.TabIndex = 2;
            trackBar1.Value = 2;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Location = new Point(294, 62);
            label1.Name = "label1";
            label1.Size = new Size(266, 21);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(label1, "Password strength:\r\nLow (60 bits) - short password, for unimportant accounts\r\nMedium (80 bits) - for normal accounts\r\nHigh (100 bits) - for important accounts (recommended)\r\nVery High (128 bits) - maximum security\r\n\r\nMore bits = longer password = harder to guess.\r\nEvery password contains upper- and lowercase letters, numbers and special characters.");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 103);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Font = new Font("MesloLGMDZ Nerd Font", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Password Generator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TrackBar trackBar1;
        private Label label1;
        private ToolTip toolTip1;
    }
}
