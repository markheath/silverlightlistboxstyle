using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace SilverlightListBoxStyle
{
    public partial class Page : UserControl
    {
        public Page()
        {
            this.DataContext = new List<string>() { "Hello", "World", "Item 3", "Item 4 with a really long name", "Item 5", "Item 6", "Item 7", "Item 8" };
            // Required to initialize variables
            InitializeComponent();
        }
    }
}