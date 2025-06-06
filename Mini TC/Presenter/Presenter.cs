using Mini_TC.View;
using Mini_TC.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace Mini_TC.Presenter
{
    public class Presenter
    {
        private readonly View.View _view;

        public Presenter(View.View view)
        {
            _view = view;
        }

        public void LoadDrives()
        {
            var drives = Model.Model.GetDrives();
            var ready = new List<string>();
            foreach (var d in drives)
                if (d.IsReady)
                    ready.Add(d.Name);
            _view.SetDrives(ready.ToArray());
        }

        public void UpdateContent(string path)
        {
            if (!Directory.Exists(path)) return;

            var items = new List<string>();
            if (Directory.GetDirectoryRoot(path) != path)
                items.Add("..");

            foreach (var dir in Model.Model.GetDirectories(path))
                items.Add("<D> " + Path.GetFileName(dir));

            foreach (var file in Model.Model.GetFiles(path))
                items.Add(Path.GetFileName(file));

            _view.CurrentPath = path;
            _view.SetContent(items);
        }

        public string Navigate(string selected, string currentPath)
        {
            if (selected == "..")
            {
                var parent = Model.Model.GetParentDirectory(currentPath);
                return parent ?? currentPath;
            }

            if (selected.StartsWith("<D> "))
            {
                string dirName = selected.Substring(4);
                return Path.Combine(currentPath, dirName);
            }

            return currentPath;
        }
    }
}
