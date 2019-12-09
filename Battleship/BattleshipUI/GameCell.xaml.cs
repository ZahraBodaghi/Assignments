using System;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Collections.Generic;

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
        private readonly IDictionary<ShipCellSegment, Uri> _shipCellSegmentUri = new Dictionary<ShipCellSegment, Uri>
        {
            {ShipCellSegment.Unknown,  new Uri("Images/battleship_unknown.png", UriKind.Relative)},
            {ShipCellSegment.Water,  new Uri("Images/battleship_tile.png", UriKind.Relative)},
            {ShipCellSegment.Single,  new Uri("Images/battleship_single.png", UriKind.Relative)},
            {ShipCellSegment.Left,  new Uri("Images/battleship_left.png", UriKind.Relative)},
            {ShipCellSegment.Right,  new Uri("Images/battleship_right.png", UriKind.Relative)},
            {ShipCellSegment.Top,  new Uri("Images/battleship_top.png", UriKind.Relative)},
            {ShipCellSegment.Bottom,  new Uri("Images/battleship_bottom.png", UriKind.Relative)},
            {ShipCellSegment.Vertical,  new Uri("Images/battleship_vert.png", UriKind.Relative)},
            {ShipCellSegment.Horizontal, new Uri("Images/battleship_horz.png",UriKind.Relative) },
        };

        public bool _shipSegmentShown;
        /*
         * ProfReynolds
         * Is this how you spell ShipSegmentShown? (-3)
         * (you have a q)
         */
        public bool ShipSeqmentShown
        {
            get => _shipSegmentShown;
            set
            {
                _shipSegmentShown = value;
                DisplayButtonBackground();
            }
        }
        private ShipCellSegment _shipSegment = ShipCellSegment.Unknown;
        public ShipCellSegment ShipSegment
        {
            get => _shipSegment;
            set
            {
                _shipSegment = value;
                DisplayButtonBackground();
            }
        }

        private void DisplayButtonBackground()
        {
            if (_shipSegmentShown)
            {
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
                    case ShipCellSegment.Horizontal:
                        {
                            var uri = _shipCellSegmentUri[ShipCellSegment.Horizontal];
                            var bitmapImage = new BitmapImage(uri);
                            var brush = new ImageBrush();
                            brush.ImageSource = bitmapImage;
                            brush.Stretch = Stretch.Fill;
                            BtnCellSegment.Background = brush;
                            break;
                        }
                    case ShipCellSegment.Vertical:
                        {
                            var uri = _shipCellSegmentUri[ShipCellSegment.Vertical];
                            var bitmapImage = new BitmapImage(uri);
                            var brush = new ImageBrush();
                            brush.ImageSource = bitmapImage;
                            brush.Stretch = Stretch.Fill;
                            BtnCellSegment.Background = brush;
                            break;
                        }
                    case ShipCellSegment.Bottom:
                        {
                            var uri = _shipCellSegmentUri[ShipCellSegment.Bottom];
                            var bitmapImage = new BitmapImage(uri);
                            var brush = new ImageBrush();
                            brush.ImageSource = bitmapImage;
                            brush.Stretch = Stretch.Fill;
                            BtnCellSegment.Background = brush;
                            break;
                        }
                    case ShipCellSegment.Top:
                        {
                            var uri = _shipCellSegmentUri[ShipCellSegment.Top];
                            var bitmapImage = new BitmapImage(uri);
                            var brush = new ImageBrush();
                            brush.ImageSource = bitmapImage;
                            brush.Stretch = Stretch.Fill;
                            BtnCellSegment.Background = brush;
                            break;
                        }
                    case ShipCellSegment.Right:
                        {
                            var uri = _shipCellSegmentUri[ShipCellSegment.Right];
                            var bitmapImage = new BitmapImage(uri);
                            var brush = new ImageBrush();
                            brush.ImageSource = bitmapImage;
                            brush.Stretch = Stretch.Fill;
                            BtnCellSegment.Background = brush;
                            break;
                        }
                    case ShipCellSegment.Left:
                        {
                            var uri = _shipCellSegmentUri[ShipCellSegment.Left];
                            var bitmapImage = new BitmapImage(uri);
                            var brush = new ImageBrush();
                            brush.ImageSource = bitmapImage;
                            brush.Stretch = Stretch.Fill;
                            BtnCellSegment.Background = brush;
                            break;
                        }
                    case ShipCellSegment.Single:
                        {
                            var uri = _shipCellSegmentUri[ShipCellSegment.Single];
                            var bitmapImage = new BitmapImage(uri);
                            var brush = new ImageBrush();
                            brush.ImageSource = bitmapImage;
                            brush.Stretch = Stretch.Fill;
                            BtnCellSegment.Background = brush;
                            break;
                        }
                    case ShipCellSegment.Water:
                        {
                            var uri = _shipCellSegmentUri[ShipCellSegment.Water];
                            var bitmapImage = new BitmapImage(uri);
                            var brush = new ImageBrush();
                            brush.ImageSource = bitmapImage;
                            brush.Stretch = Stretch.Fill;
                            BtnCellSegment.Background = brush;
                            break;
                        }

                }
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
