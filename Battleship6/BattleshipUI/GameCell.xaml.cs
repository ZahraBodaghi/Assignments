using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

/*
 * Zahra Bodaghi
 */

namespace BattleshipUI
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

        /*
         * ProfReynolds
         * this method is incomplete. Here is the start of the switch statement:
                switch (_shipSegment)
                {
                    case ShipCellSegment.Unknown:
                        {
                            var uri = _shipCellSegmentUri[ShipCellSegment.Unknown];
                            var bitmapImage = new BitmapImage(uri);
                            var brush = new ImageBrush();
                            brush.ImageSource = bitmapImage;
                            brush.Stretch = Stretch.Fill;
                            BtnCellSegment.Background = brush;
                            break;
                        }
                ...
         */
        private void DisplayButtonBackground()
        {
            if (_shipSegmentShown)
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

        private void BtnCellSegment_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }
    }
}
