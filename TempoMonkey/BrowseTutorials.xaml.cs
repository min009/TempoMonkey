﻿using System;
using System.Collections.Generic;
using System.Linq;
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

namespace TempoMonkey
{
    /// <summary>
    /// Interaction logic for BrowseTutorials.xaml
    /// </summary>
    public partial class BrowseTutorials : Page
    {

        public BrowseTutorials()
        {
            InitializeComponent();
            //this.slidingMenu.initializeMenu("TutorialVideos");
        }

        public string getAddr()
        {
            return "";
            //return slidingMenu.getAddress();
        }

        #region Button Handlers
        void Mouse_Enter(object sender, MouseEventArgs e)
        {
            MainWindow.Mouse_Enter(sender, e);
        }

        void Mouse_Leave(object sender, MouseEventArgs e)
        {
            MainWindow.Mouse_Leave(sender, e);
        }

        void Back_Click(object sender, MouseEventArgs e)
        {
            MainWindow.currentPage = new HomePage();
            NavigationService.Navigate(MainWindow.currentPage);
        }

        void Done_Click(object sender, MouseEventArgs e)
        {
            //Page nextPage = new FreeFormMode();
            //MainWindow.GetParent<Frame>(this).Navigate(nextPage);
            throw new Exception();
        }

        void Delete_Click(object sender, MouseEventArgs e)
        {

        }
        #endregion

    }
}
