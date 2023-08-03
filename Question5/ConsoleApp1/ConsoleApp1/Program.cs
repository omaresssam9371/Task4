class Program {


    public static void User_guess(int input_number ,int hidden_num)
    {
        if(Math.Abs(input_number - hidden_num)>=50)
        {
            Console.WriteLine("The answer is very far");       
                }
        else if(Math.Abs(input_number - hidden_num) >= 30)
        {
            Console.WriteLine("The answer is a little far");
        }
        else if(Math.Abs(input_number - hidden_num) >= 10)
        {
            Console.WriteLine("Number is not far");
        }
        else if(Math.Abs(input_number - hidden_num) >= 5)
        {
            Console.WriteLine("Number is near to the right");
        }
        else { Console.WriteLine("You almost got it"); }
        
    }
    static void Main(String[] args)
    {
        int hidden_num = 62;
        int right_guess = 0;
        Console.WriteLine("Please enter number between 0 and 100 to guess the right number");
        while (right_guess == 0)
        {
            
            try
            {
                int input_number = Convert.ToInt32(Console.ReadLine());
                if (input_number >= 0 && input_number <= 100)
                {
                    if (input_number == hidden_num)
                    {

                        right_guess = hidden_num;
                        Console.WriteLine($"Hidden number is {input_number}");
                        Console.WriteLine("YOUR GUESS IS RIGHT!");
                    }
                    else
                    {
                        User_guess(input_number, hidden_num);
                    }
                    Console.WriteLine("Please guess again");
                }
                else
                {
                    Console.WriteLine("The number is out of range (0,100) please re enter");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}

