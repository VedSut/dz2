namespace WinFormsApp1
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
            button1 = new Button();
            count = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(247, 103);
            label1.Name = "label1";
            label1.Size = new Size(129, 30);
            label1.TabIndex = 1;
            label1.Text = "Лiчильник: ";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LawnGreen;
            button1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(247, 225);
            button1.Name = "button1";
            button1.Size = new Size(297, 83);
            button1.TabIndex = 2;
            button1.Text = "Клик";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // count
            // 
            count.AutoSize = true;
            count.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            count.Location = new Point(427, 107);
            count.Name = "count";
            count.Size = new Size(23, 25);
            count.TabIndex = 1;
            count.Text = "0";
            count.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(count);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Slava Ukraini";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
        private Label count;
    }
}
