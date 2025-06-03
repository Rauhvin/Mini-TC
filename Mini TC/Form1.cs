using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_TC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            var source = panelTCLeft.HasSelectedItem() ? panelTCLeft : panelTCRight;
            var target = source == panelTCLeft ? panelTCRight : panelTCLeft;

            string sourcePath = Path.Combine(source.CurrentPath, source.SelectedItem);
            string targetPath = Path.Combine(target.CurrentPath, source.SelectedItem);

            try
            {
                File.Copy(sourcePath, targetPath, overwrite: true);
                MessageBox.Show("Skopiowano.");
                target.RefreshContent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d kopiowania: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
