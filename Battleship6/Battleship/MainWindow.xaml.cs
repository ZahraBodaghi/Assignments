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
using System.Windows.Shapes;
/*
 * Zahra Bodaghi
 */

namespace Battleship
{
    public enum ShipCellSegment
    {
        Water,
        Single,
        Left,
        Right,
        Top,
        Bottom,
        Vertical,
        Horizaontal
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnRestGame_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(messageBoxText: "BtnRestGame_Click Event");
            InitializedAndSetupNewGame();
        }

        private void BtnShowOneCell_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(messageBoxText: "BtnShowOneCell_Click Event");
        }

        private void BtnShowSolution_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(messageBoxText: "BtnShowSolution_Click Event");
        }

        private void BtnAboutBattleship_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(messageBoxText: "BtnAboutBattleship_Click Event");
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InitializedAndSetupNewGame()
        {
            foreach(var uc in ButtonCanvas.Children)
            {
                if(uc is GameCell gc)
                {
                    gc.ShipSegment = ShipCellSegment.Water;
                    gc.ShipSeqmentShown = false;
                }
            }
            GameCell00.ShipSegment = ShipCellSegment.Left;
            GameCell01.ShipSegment = ShipCellSegment.Horizaontal;
            GameCell02.ShipSegment = ShipCellSegment.Horizaontal;
            GameCell03.ShipSegment = ShipCellSegment.Right;
            GameCell14.ShipSegment = ShipCellSegment.Top;
            GameCell24.ShipSegment = ShipCellSegment.Vertical;
            GameCell34.ShipSegment = ShipCellSegment.Bottom;
            GameCell41.ShipSegment = ShipCellSegment.Single;
            /*GameCell00.ShipSegment = ShipCellSegment.Left;
            GameCell01.ShipSegment = ShipCellSegment.Horizaontal;
            GameCell02.ShipSegment = ShipCellSegment.Horizaontal;
            GameCell03.ShipSegment = ShipCellSegment.Right;
            GameCell04.ShipSegment = ShipCellSegment.Water;
            GameCell10.ShipSegment = ShipCellSegment.Water;
            GameCell11.ShipSegment = ShipCellSegment.Water;
            GameCell12.ShipSegment = ShipCellSegment.Water;
            GameCell13.ShipSegment = ShipCellSegment.Water;
            GameCell14.ShipSegment = ShipCellSegment.Top;
            GameCell20.ShipSegment = ShipCellSegment.Water;
            GameCell21.ShipSegment = ShipCellSegment.Water;
            GameCell22.ShipSegment = ShipCellSegment.Water;
            GameCell23.ShipSegment = ShipCellSegment.Water;
            GameCell24.ShipSegment = ShipCellSegment.Vertical;
            GameCell30.ShipSegment = ShipCellSegment.Water;
            GameCell31.ShipSegment = ShipCellSegment.Water;
            GameCell32.ShipSegment = ShipCellSegment.Water;
            GameCell33.ShipSegment = ShipCellSegment.Water;
            GameCell34.ShipSegment = ShipCellSegment.Bottom;
            GameCell40.ShipSegment = ShipCellSegment.Water;
            GameCell41.ShipSegment = ShipCellSegment.Single;
            GameCell42.ShipSegment = ShipCellSegment.Water;
            GameCell43.ShipSegment = ShipCellSegment.Water;
            GameCell44.ShipSegment = ShipCellSegment.Water;*/
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            InitializedAndSetupNewGame();
        }
    }
}
