﻿using ChartDemoVisualization.ViewModels.Pages;
using Wpf.Ui.Controls;

namespace ChartDemoVisualization.Views.Pages
{
    public partial class DashboardPage : INavigableView<DashboardViewModel>
    {
        public DashboardViewModel ViewModel { get; }

        public DashboardPage(DashboardViewModel viewModel)
        {
            ViewModel = viewModel;
            DataContext = this;

            InitializeComponent();
        }
    }
}
