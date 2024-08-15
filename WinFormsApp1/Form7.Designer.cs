namespace WinFormsApp1
{
    partial class Form7
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
            btnAddElement = new Button();
            button1 = new Button();
            btnElementExist = new Button();
            SuspendLayout();
            // 
            // btnAddElement
            // 
            btnAddElement.Location = new Point(319, 21);
            btnAddElement.Name = "btnAddElement";
            btnAddElement.Size = new Size(153, 29);
            btnAddElement.TabIndex = 0;
            btnAddElement.Text = "Add Element";
            btnAddElement.UseVisualStyleBackColor = true;
            btnAddElement.Click += btnAddElement_Click;
            // 
            // button1
            // 
            button1.Location = new Point(324, 211);
            button1.Name = "button1";
            button1.Size = new Size(153, 29);
            button1.TabIndex = 1;
            button1.Text = "Sort";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnElementExist
            // 
            btnElementExist.Location = new Point(324, 409);
            btnElementExist.Name = "btnElementExist";
            btnElementExist.Size = new Size(153, 29);
            btnElementExist.TabIndex = 2;
            btnElementExist.Text = "Element Exists";
            btnElementExist.UseVisualStyleBackColor = true;
            btnElementExist.Click += btnElementExist_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnElementExist);
            Controls.Add(button1);
            Controls.Add(btnAddElement);
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddElement;
        private Button button1;
        private Button btnElementExist;
    }
}