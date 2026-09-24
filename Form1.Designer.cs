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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
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
            // label3
            // 
            label3.BackColor = Color.SaddleBrown;
            label3.Location = new Point(39, 141);
            label3.Margin = new Padding(30);
            label3.Name = "label3";
            label3.Size = new Size(261, 53);
            label3.TabIndex = 0;
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.SaddleBrown;
            label4.Location = new Point(39, 59);
            label4.Margin = new Padding(30);
            label4.Name = "label4";
            label4.Size = new Size(261, 53);
            label4.TabIndex = 0;
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.SaddleBrown;
            label5.Location = new Point(39, 224);
            label5.Margin = new Padding(30);
            label5.Name = "label5";
            label5.Size = new Size(261, 53);
            label5.TabIndex = 0;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.BackColor = Color.SaddleBrown;
            label6.Location = new Point(39, 304);
            label6.Margin = new Padding(30);
            label6.Name = "label6";
            label6.Size = new Size(261, 53);
            label6.TabIndex = 0;
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(177, 390);
            button1.Name = "button1";
            button1.Size = new Size(123, 88);
            button1.TabIndex = 1;
            button1.Text = "kilépés";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(39, 390);
            button2.Name = "button2";
            button2.Size = new Size(132, 88);
            button2.TabIndex = 1;
            button2.Text = "alaphelyzet";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 501);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Coloring";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}
