namespace Mini_TC
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
            paneltc1 = new PanelTC();
            paneltc2 = new PanelTC();
            copyButton = new Button();
            SuspendLayout();
            // 
            // paneltc1
            // 
            paneltc1.Location = new Point(12, -2);
            paneltc1.Name = "paneltc1";
            paneltc1.Size = new Size(305, 476);
            paneltc1.TabIndex = 0;
            // 
            // paneltc2
            // 
            paneltc2.Location = new Point(263, -2);
            paneltc2.Name = "paneltc2";
            paneltc2.Size = new Size(305, 476);
            paneltc2.TabIndex = 1;
            // 
            // copyButton
            // 
            copyButton.Location = new Point(211, 380);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(94, 29);
            copyButton.TabIndex = 2;
            copyButton.Text = "Copy >>";
            copyButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 450);
            Controls.Add(copyButton);
            Controls.Add(paneltc2);
            Controls.Add(paneltc1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniTC";
            ResumeLayout(false);
        }

        #endregion

        private PanelTC paneltc1;
        private PanelTC paneltc2;
        private Button copyButton;
    }
}
