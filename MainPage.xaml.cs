namespace Module2LabB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            mDatePicker.Date = new DateTime(2005, 1, 1);
            mDatePicker.DateSelected += Calculate_Years;
        }

        private void Calculate_Years(object sender, DateChangedEventArgs e)
        {
            DateTime selectedDate = mDatePicker.Date;          
            DateTime currentDate = DateTime.Today;
            int yearsUntilLegalAge = 21 - (currentDate.Year - selectedDate.Year);
            YearsUntilLegal.Text = $"Years until legal drinking age: {yearsUntilLegalAge}";
        }
    }
}