namespace HappySadNumberTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*There are said to be happy numbers and sad numbers.
            Happy numbers will reduce to 1 when the digits belonging to the numbers are squared and added together to produce another number and the process is repeated. e.g. when we take 19
            1 squared is 1 , 9 squared is 81. 81 +1 = 82
            8 squared is 64, 2 squared is 4.  64 + 4 = 68
            6 squared is 36, 8 squared is 64, 36 + 64 = 100 
            1 squared is 1, 0 squared is 0 and thus the original number is reduced to 1
            Sad numbers will not reduce to 1 and will loop endlessly. e.g. when we take 20
            2 squared is 4, 0 squared is 0, 4 + 0 = 4
            4 squared is 16, 0 squared is 0, 16 + 0 = 16
            1 squared is 1, 6 squared is 36, 1 + 36 = 37
            3 squared is 9, 7 squared is 49, 9 + 49 = 58
            5 squared is 25, 8 squared is 64, 25 + 64 = 89
            8 squared is 64, 9 squared is 81, 64 + 81 = 145
            1 squared is 1, 4 squared is 16, 5 squared is 25, 1 + 16 + 25 = 42
            4 squared is 16, 2 squared is 4, 16 + 4 = 20
            20 will loop endlessly
            */
            //write a program to determine if a number is happy or sad
            //The program should take a number as input and output whether the number is happy or sad
            //test your program with the inputs of 19 and 20
            //show your output in the readme file

            Console.Write("Please enter a number: ");
            string UserInput = Console.ReadLine(); //use this for outputs later
            int UserNum = Convert.ToInt32(UserInput); //use this for calculations
            
            for (int i = 0; i < 100; i++) //100 so there isn't an infinite loop but it still goes on for long enough
            {
                int sum = 0;
                while (UserNum > 0)
                {
                    int digit = UserNum % 10; //gives us the last digit
                    sum += digit * digit; //gets the square
                    UserNum /= 10; //removes the last digit from UserNum
                }
                UserNum = sum; //prepares for the next iteration
                if (UserNum == 1)
                {
                    Console.WriteLine(UserInput + " is a Happy Number!");
                    return; //prevents loop from going the 100-ish times
                }
            }
            Console.WriteLine(UserInput + " is a Sad Number.");
        }
    }
}
