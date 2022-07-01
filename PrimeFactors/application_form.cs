namespace PrimeFactors
{
    public partial class application_form : Form
    {
        public application_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            int number = int.Parse(number_textbox.Text.Trim());
            result_label.Text = calculate_prime_factors(number);
        }

        private string calculate_prime_factors(int number)
        {
            string result = "";
            List<int> primes = new List<int>();
            List<int> prime_factors = new List<int>();
            primes.Add(2);
            for (int i = 3; i <= number; i++)
            {
                bool prime = true;
               for(int j = 2; j < i; j++)
                {
                    if(i % j == 0)
                    {
                        prime = false;
                    }
                }
                if (prime)
                {
                    primes.Add(i);
                }
            }
            foreach(var i in primes)
            {
                if(number % i == 0)
                {
                    prime_factors.Add(i);
                }
            }
            int n = 1;

            foreach (int i in prime_factors)
            {
                n *= i;
            }
            if (number / n > 1)
            {
                foreach (int i in prime_factors)
                {
                    int counter_of_prime_factor = 0;
                    int number_copy = number;
                    while(number_copy % i == 0)
                    {
                        counter_of_prime_factor++;
                        number_copy /= i;
                    }
                    for(int j = 0; j < counter_of_prime_factor; j++)
                    {
                        result += i + " x ";
                    }

                }
            }
 
            else
            {
                foreach (int i in prime_factors)
                {
                    result += i + " x ";
                }
            }

            return result.Substring(0, result.Length - 2);
        }
    }
}