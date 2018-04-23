using DevExpress.UI.Xaml.Grid.Native;
using System;
using Windows.UI.Xaml.Controls;

namespace App6
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        private void GridControl_ValidateRow(object sender, GridRowValidationEventArgs e)
        {
            DateTime startDate = ((Task)e.Row).StartDate;
            DateTime endDate = ((Task)e.Row).EndDate;
            e.IsValid = startDate < endDate;
        }

        private void GridControl_InvalidRowException(object sender, DevExpress.UI.Xaml.Grid.InvalidRowExceptionEventArgs e)
        {
            e.ErrorText = "StartDate must be less than EndDate.\nEither StartDate or EndDate should be corrected.";
        }
    }
}
