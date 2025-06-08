using System.Threading.Tasks;
namespace FactorialandIncomeTax
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

       private void CalculateFactorial_Clicked(object sender, EventArgs e)
        {
            if(int.TryParse(txtNumberEntry.Text, out int number))
            {
                if(number < 0)
                {
                    lblResult.Text = "Please enter a positive number.";
                }
                else if (number == 0)
                {
                    lblResult.Text = "The factorial of 0 is 1";
                }
                else
                {
                    long factorial = 1;
                       for (int i = 0; i <= number; i++)
                    {
                        factorial *= i;
                    }
                    lblResult.Text = $"The factorial of {number} is {factorial}.";
                }
            }
            else
            {
                lblResult.Text = "Invalid Input. Please enter a whole number.";
            }
        }


        private async void GoToIncomeTaxPage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IncomeTaxPage());        
        }

    }
}
