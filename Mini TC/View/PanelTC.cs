using Mini_TC.Presenter;
using Mini_TC.View;
using Mini_TC.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Mini_TC
{
    public partial class PanelTC : UserControl, IPanelTCView
    {
        private readonly PanelPresenter _presenter;

        public PanelTC()
        {
            InitializeComponent();
            _presenter = new PanelPresenter(this);

            comboBox1.DropDown += ComboBox1_DropDown;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            listBox1.DoubleClick += ListBox1_DoubleClick;
        }


        public string SelectedItem => listBox1.SelectedItem?.ToString() ?? "";

        public string CurrentPath
        {
            get => textBox1.Text;
            set => textBox1.Text = value;
        }

        public string SelectedDrive => comboBox1.SelectedItem?.ToString() ?? "";

        public void SetDrives(string[] drives)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(drives);
        }

        public void SetContent(List<string> items)
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(items.ToArray());
        }

        public void RefreshContent()
        {
            _presenter.UpdateContent(CurrentPath);
        }

        public bool HasSelectedItem()
        {
            return listBox1.SelectedItem != null && !SelectedItem.StartsWith("<D>") && SelectedItem != "..";
        }


        private void ComboBox1_DropDown(object sender, EventArgs e)
        {
            _presenter.LoadDrives();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedDrive != null)
            {
                _presenter.UpdateContent(SelectedDrive);
            }
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedItem)) return;

            var newPath = _presenter.Navigate(SelectedItem, CurrentPath);
            _presenter.UpdateContent(newPath);
        }
    }
}
