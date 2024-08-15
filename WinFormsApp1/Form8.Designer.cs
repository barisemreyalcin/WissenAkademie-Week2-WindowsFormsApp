namespace WinFormsApp1
{
    partial class Form8
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
            btnAddButton = new Button();
            SuspendLayout();
            // 
            // btnAddButton
            // 
            btnAddButton.Location = new Point(359, 106);
            btnAddButton.Name = "btnAddButton";
            btnAddButton.Size = new Size(94, 29);
            btnAddButton.TabIndex = 0;
            btnAddButton.Text = "Add Button";
            btnAddButton.UseVisualStyleBackColor = true;
            btnAddButton.Click += btnAddButton_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddButton);
            Name = "Form8";
            Text = "Form8";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddButton;
    }
}