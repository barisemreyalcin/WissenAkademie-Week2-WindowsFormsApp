namespace WinFormsApp1
{
    partial class Form3
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
            txtEntered = new TextBox();
            labelRemainingChar = new Label();
            SuspendLayout();
            // 
            // txtEntered
            // 
            txtEntered.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtEntered.Location = new Point(104, 39);
            txtEntered.Multiline = true;
            txtEntered.Name = "txtEntered";
            txtEntered.Size = new Size(634, 176);
            txtEntered.TabIndex = 0;
            txtEntered.TextChanged += textBox1_TextChanged;
            // 
            // labelRemainingChar
            // 
            labelRemainingChar.AutoSize = true;
            labelRemainingChar.Location = new Point(387, 257);
            labelRemainingChar.Name = "labelRemainingChar";
            labelRemainingChar.Size = new Size(50, 20);
            labelRemainingChar.TabIndex = 1;
            labelRemainingChar.Text = "label1";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelRemainingChar);
            Controls.Add(txtEntered);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEntered;
        private Label labelRemainingChar;
    }
}