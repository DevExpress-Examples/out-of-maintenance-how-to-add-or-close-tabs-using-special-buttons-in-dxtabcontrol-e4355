using System;
using System.Linq;
using System.Windows;
using DevExpress.Xpf.Core;
using System.Windows.Input;
using System.Collections.Generic;

namespace DxSample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitDXTabControlItems(dXTabControl1);
            InitAdditionItem(dXTabControl1);
        }

        private void InitDXTabControlItems(DXTabControl dXTabControl)
        {
            for (int i = 0; i < 15; i++)
            {
                dXTabControl.Items.Add("Page");
            }
        }

        private void InitAdditionItem(DXTabControl dXTabControl)
        {
            DXTabItem item = new DXTabItem();
            item.Header = "+";
            item.PreviewMouseDown +=new MouseButtonEventHandler(AddItem_PreviewMouseDown);
            item.ToolTip = "Open a new tab";
            dXTabControl.Items.Add(item);
        }

        private void AddItem_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            dXTabControl1.Items.Insert(dXTabControl1.Items.Count-1,"New Page");
            dXTabControl1.SelectedTabItem = dXTabControl1.GetTabItem(dXTabControl1.Items.Count - 2);
            e.Handled = true;
        }
    }
}
