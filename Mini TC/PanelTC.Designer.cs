namespace Mini_TC
{
    partial class PanelTC
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            driveLabel = new Label();
            textBox1 = new TextBox();
            pathLabel = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(3, 104);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(238, 264);
            listBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(156, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(85, 28);
            comboBox1.TabIndex = 1;
            // 
            // driveLabel
            // 
            driveLabel.AutoSize = true;
            driveLabel.Location = new Point(105, 64);
            driveLabel.Name = "driveLabel";
            driveLabel.Size = new Size(45, 20);
            driveLabel.TabIndex = 2;
            driveLabel.Text = "drive:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 27);
            textBox1.TabIndex = 3;
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new Point(24, 20);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(42, 20);
            pathLabel.TabIndex = 4;
            pathLabel.Text = "path:";
            // 
            // PanelTC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pathLabel);
            Controls.Add(textBox1);
            Controls.Add(driveLabel);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Name = "PanelTC";
            Size = new Size(244, 381);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ComboBox comboBox1;
        private Label driveLabel;
        private TextBox textBox1;
        private Label pathLabel;
    }
}
