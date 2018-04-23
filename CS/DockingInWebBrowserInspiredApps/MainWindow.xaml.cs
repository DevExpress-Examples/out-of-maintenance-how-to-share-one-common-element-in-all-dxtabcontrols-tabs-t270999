using System.Collections.ObjectModel;

namespace DockingInWebBrowserInspiredApps {
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();
            System.Windows.Style p;
            
        }
    }
    public class ItemVM {
        public string Header { get; set; }
        public string Body { get; set; }
        public ItemVM() {
            Header = string.Format("New Document{0}", i);
            Body = string.Format("Document{0} Body", i);
            i++;
        }
        static int i = 1;
    }
    public class VM {
        public ObservableCollection<ItemVM> Source { get; set; }
        public VM() {
            Source = new ObservableCollection<ItemVM>();
            Source.Add(new ItemVM());
            Source.Add(new ItemVM());
        }
    }
}
