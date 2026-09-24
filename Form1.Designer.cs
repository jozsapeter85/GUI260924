namespace GUI260924
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
            label1 = new Label();
            label2 = new Label();
            lblsalmon = new Label();
            lblbrown = new Label();
            lbllyellow = new Label();
            lblolivegreen = new Label();
            btnexit = new Button();
            btnreset = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SaddleBrown;
            label1.Location = new Point(39, 141);
            label1.Margin = new Padding(30, 50, 30, 50);
            label1.Name = "label1";
            label1.Size = new Size(261, 53);
            label1.TabIndex = 0;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.SaddleBrown;
            label2.Location = new Point(39, 59);
            label2.Margin = new Padding(30, 50, 30, 50);
            label2.Name = "label2";
            label2.Size = new Size(261, 53);
            label2.TabIndex = 0;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblsalmon
            // 
            lblsalmon.BackColor = Color.Salmon;
            lblsalmon.Location = new Point(39, 141);
            lblsalmon.Margin = new Padding(30);
            lblsalmon.Name = "lblsalmon";
            lblsalmon.Size = new Size(261, 53);
            lblsalmon.TabIndex = 0;
            lblsalmon.TextAlign = ContentAlignment.MiddleCenter;
            lblsalmon.Click += label3_Click;
            // 
            // lblbrown
            // 
            lblbrown.BackColor = Color.SaddleBrown;
            lblbrown.Location = new Point(39, 59);
            lblbrown.Margin = new Padding(30);
            lblbrown.Name = "lblbrown";
            lblbrown.Size = new Size(261, 53);
            lblbrown.TabIndex = 0;
            lblbrown.TextAlign = ContentAlignment.MiddleCenter;
            lblbrown.Click += label4_Click;
            // 
            // lbllyellow
            // 
            lbllyellow.BackColor = Color.LightYellow;
            lbllyellow.Location = new Point(39, 224);
            lbllyellow.Margin = new Padding(30);
            lbllyellow.Name = "lbllyellow";
            lbllyellow.Size = new Size(261, 53);
            lbllyellow.TabIndex = 0;
            lbllyellow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblolivegreen
            // 
            lblolivegreen.BackColor = Color.DarkOliveGreen;
            lblolivegreen.Location = new Point(39, 304);
            lblolivegreen.Margin = new Padding(30);
            lblolivegreen.Name = "lblolivegreen";
            lblolivegreen.Size = new Size(261, 53);
            lblolivegreen.TabIndex = 0;
            lblolivegreen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnexit
            // 
            btnexit.Location = new Point(177, 390);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(123, 88);
            btnexit.TabIndex = 1;
            btnexit.Text = "kilépés";
            btnexit.UseVisualStyleBackColor = true;
            // 
            // btnreset
            // 
            btnreset.Location = new Point(39, 390);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(132, 88);
            btnreset.TabIndex = 1;
            btnreset.Text = "alaphelyzet";
            btnreset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(344, 501);
            Controls.Add(btnreset);
            Controls.Add(btnexit);
            Controls.Add(lblbrown);
            Controls.Add(lblolivegreen);
            Controls.Add(lbllyellow);
            Controls.Add(lblsalmon);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Coloring";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblsalmon;
        private Label lblbrown;
        private Label lbllyellow;
        private Label lblolivegreen;
        private Button btnexit;
        private Button btnreset;
    }
}
