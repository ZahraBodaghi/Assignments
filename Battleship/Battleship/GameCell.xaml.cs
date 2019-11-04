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


    }
}
