using System.Collections.Generic;

namespace Mini_TC.View
{
    public interface View
    {
        string SelectedItem { get; }
        string CurrentPath { get; set; }
        void SetDrives(string[] drives);
        void SetContent(List<string> items);
        string SelectedDrive { get; }
    }
}
