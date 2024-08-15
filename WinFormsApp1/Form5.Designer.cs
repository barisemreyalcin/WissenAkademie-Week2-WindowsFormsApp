namespace WinFormsApp1
{
    partial class Form5
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
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            button3 = new Button();
            listCars = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(31, 35);
            button1.Name = "button1";
            button1.Size = new Size(148, 59);
            button1.TabIndex = 0;
            button1.Text = "Last Car";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(31, 115);
            button2.Name = "button2";
            button2.Size = new Size(148, 59);
            button2.TabIndex = 1;
            button2.Text = "Random Car";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(listCars);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(227, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 453);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.Location = new Point(216, 15);
            button3.Name = "button3";
            button3.Size = new Size(118, 59);
            button3.TabIndex = 0;
            button3.Text = "Add Car";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listCars
            // 
            listCars.Dock = DockStyle.Bottom;
            listCars.FormattingEnabled = true;
            listCars.Location = new Point(0, 89);
            listCars.Name = "listCars";
            listCars.Size = new Size(537, 364);
            listCars.TabIndex = 1;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form5";
            Text = "Form5";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panel1;
        private ListBox listCars;
        private Button button3;
    }
}