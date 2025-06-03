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
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 82);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(317, 289);
            listBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(245, 45);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(75, 23);
            comboBox1.TabIndex = 1;
            // 
            // driveLabel
            // 
            driveLabel.AutoSize = true;
            driveLabel.Location = new Point(203, 45);
            driveLabel.Name = "driveLabel";
            driveLabel.Size = new Size(36, 15);
            driveLabel.TabIndex = 2;
            driveLabel.Text = "drive:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 12);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(259, 23);
            textBox1.TabIndex = 3;
            // 
            // pathLabel
            // 
            pathLabel.AutoSize = true;
            pathLabel.Location = new Point(21, 15);
            pathLabel.Name = "pathLabel";
            pathLabel.Size = new Size(34, 15);
            pathLabel.TabIndex = 4;
            pathLabel.Text = "path:";
            // 
            // PanelTC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pathLabel);
            Controls.Add(textBox1);
            Controls.Add(driveLabel);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PanelTC";
            Size = new Size(323, 387);
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
