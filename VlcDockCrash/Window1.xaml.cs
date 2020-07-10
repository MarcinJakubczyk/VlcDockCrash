using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LibVLCSharp.Shared;

namespace VlcDockCrash
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private LibVLC _libVlc;
        public Window1()
        {
            InitializeComponent();

            Core.Initialize();
            _libVlc = new LibVLC();
            VideoView.MediaPlayer = new MediaPlayer(_libVlc);
        }

        private void Window1_OnClosed(object sender, EventArgs e)
        {
            _libVlc.Dispose();
            VideoView.Dispose();
            VideoView.MediaPlayer.Dispose();
        }
    }
}
