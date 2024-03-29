﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Polygons.Library;
using Polygons;

namespace PeopleViewerWinForm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnTriangle_Click(object sender, RoutedEventArgs e)
        {
            /*
             * ProfReynolds
             * you must implement this
             */


        }

        private void BtnSquare_Click(object sender, RoutedEventArgs e)
        {
            var square = new Square(5);
            UpdateTextBlock("Square", square);
        }

        private void BtnPentagon_Click(object sender, RoutedEventArgs e)
        {
            /*
             * ProfReynolds
             * you must implement this
             */
            throw new NotImplementedException();
        }

        private void BtnOctagon_Click(object sender, RoutedEventArgs e)
        {
            /*
             * ProfReynolds
             * you must implement this
             */
            throw new NotImplementedException();
        }

        private void UpdateTextBlock(string polygonType, dynamic polygon)
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{polygonType} Number of Sides: {polygon.NumberOfSides}");
            stringBuilder.AppendLine($"{polygonType} Side Length: {polygon.SideLength}");
            /*
             * ProfReynolds
             * we changed from the GetPerimeter property to the Perimeter() method
             */
            stringBuilder.AppendLine($"{polygonType} Perimeter: {polygon.GetPerimeter}");
            stringBuilder.AppendLine($"{polygonType} Area: {Math.Round(polygon.GetArea(), 2)}");
            TxtBlock.Text = stringBuilder.ToString();
        }
    }
}
