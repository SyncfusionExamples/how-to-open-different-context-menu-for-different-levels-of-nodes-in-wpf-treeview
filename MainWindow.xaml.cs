using Syncfusion.UI.Xaml.TreeView.Engine;
using Syncfusion.UI.Xaml.TreeView;
using Syncfusion.UI.Xaml.TreeView.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

            this.treeView.ItemContextMenuOpening += OnTreeView_ItemContextMenuOpening;
        }

        private void OnTreeView_ItemContextMenuOpening(object sender, ItemContextMenuOpeningEventArgs e)
        {
            if (e.MenuInfo.Node.Level == 1)
            {
                MenuItem item1 = new MenuItem();
                item1.Header = "Level 1";
                e.ContextMenu.Items.Clear();
                e.ContextMenu.Items.Add(item1);
            }

            else if (e.MenuInfo.Node.Level == 0)
            {
                MenuItem item1 = new MenuItem();
                item1.Header = "Level 0";
                e.ContextMenu.Items.Clear();
                e.ContextMenu.Items.Add(item1);
            }
        }
    }
}
