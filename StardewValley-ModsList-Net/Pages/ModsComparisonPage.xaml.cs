﻿using StardewValleyModList.DataModels;
using StardewValleyModList.Events;
using StardewValleyModList.Helper;
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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StardewValleyModList.Pages
{
    /// <summary>
    /// Interaction logic for ModsComparisonPage.xaml
    /// </summary>
    public partial class ModsComparisonPage : Page
    {
        public ModsComparisonPage()
        {
            InitializeComponent();
            EventSubs();
        }

        private void EventSubs()
        {
            GlobalEvents.OnListPopulated += OnListPopulated;
        }

        private void OnListPopulated()
        {
            List<ModsDataModel> data = new();

        }
    }
}
