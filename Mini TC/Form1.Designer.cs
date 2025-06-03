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
            panelTCLeft = new PanelTC();
            panelTCRight = new PanelTC();
            copyButton = new Button();
            SuspendLayout();
            // 
            // panelTCLeft
            // 
            panelTCLeft.CurrentPath = "";
            panelTCLeft.Location = new Point(10, -2);
            panelTCLeft.Margin = new Padding(3, 2, 3, 2);
            panelTCLeft.Name = "panelTCLeft";
            panelTCLeft.Size = new Size(326, 384);
            panelTCLeft.TabIndex = 0;
            // 
            // panelTCRight
            // 
            panelTCRight.CurrentPath = "";
            panelTCRight.Location = new Point(342, -2);
            panelTCRight.Margin = new Padding(3, 2, 3, 2);
            panelTCRight.Name = "panelTCRight";
            panelTCRight.Size = new Size(330, 384);
            panelTCRight.TabIndex = 1;
            // 
            // copyButton
            // 
            copyButton.Location = new Point(301, 386);
            copyButton.Margin = new Padding(3, 2, 3, 2);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(82, 22);
            copyButton.TabIndex = 2;
            copyButton.Text = "Copy >>";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += btnCopy_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(684, 424);
            Controls.Add(copyButton);
            Controls.Add(panelTCRight);
            Controls.Add(panelTCLeft);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MiniTC";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private PanelTC panelTCLeft;
        private PanelTC panelTCRight;
        private Button copyButton;
    }
}
