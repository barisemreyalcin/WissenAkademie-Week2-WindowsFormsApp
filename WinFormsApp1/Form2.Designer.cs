namespace WinFormsApp1
{
    partial class Form2
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
            labelInput = new Label();
            txtInput = new TextBox();
            SuspendLayout();
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(120, 99);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(50, 20);
            labelInput.TabIndex = 0;
            labelInput.Text = "label1";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(120, 41);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(646, 27);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += txtInput_TextChanged;
            txtInput.MouseEnter += txtInput_MouseEnter;
            txtInput.MouseLeave += txtInput_MouseLeave;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtInput);
            Controls.Add(labelInput);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInput;
        private TextBox txtInput;
    }
}