using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Battleship
{
    /// <summary>
    /// Interaction logic for GameCell.xaml
    /// </summary>
    public partial class GameCell : UserControl
    {
        public GameCell()
        {
            InitializeComponent();
        }
        public int GameCellRow { get; set; }
        public int GameCellColumn { get; set; }
        public ShipCellSegment ShipSegment { get; set; }
        public bool _shipSegmentShown;
        public bool ShipSeqmentShown
        {
            get => _shipSegmentShown;
            set
            {
                _shipSegmentShown = value;
                DisplayButtonBackground();
            }
        }
        private void DisplayButtonBackground()
        {
            if(_shipSegmentShown)
            {
              /*  switch (_shipSegmentShown)
                {

                }*/

            }
           else
            {
                var uri = new Uri(uriString: "Images/battleship_unknown.png", UriKind.Relative);
                var bitmapImage = new BitmapImage(uri);
                var brush = new ImageBrush();
                brush.ImageSource = bitmapImage;
                brush.Stretch = Stretch.Fill;
                BtnCellSegment.Background = brush;
            }
        }
        
    }
}
