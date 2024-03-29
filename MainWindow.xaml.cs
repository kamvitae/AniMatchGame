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

namespace HFIV_1_MatchGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpGame();
        }

        private void SetUpGame()
        {
            Random random = new Random();
            List<string> animalEmoji = new List<string>()
            {
                "🐺", "🐺",
                "🦝", "🦝",
                "🦁", "🦁",
                "🦊", "🦊",
                "🐶", "🐶",
                "🐨", "🐨",
                "🐯", "🐯",
                "🐱", "🐱",
                "🐻", "🐻",
                "🐵", "🐵"
            };
            foreach (TextBlock txtBlock in mainGrid.Children.OfType<TextBlock>())
            {
                int index = random.Next(animalEmoji.Count);
                string nextEmoji = animalEmoji[index];
                txtBlock.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
            }
        }
    }
}
