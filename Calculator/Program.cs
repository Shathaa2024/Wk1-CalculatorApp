//This integar variable stores the first number
//int firstNumber = 7;

//This integar variablee stores the second number
//int secondNumber = 29;

//the result variable contains addition of 1st num and 2nd num

//int result = firstNumber + secondNumber;

//Console.WriteLine("The addition of both numbers is {0}", result);
//Console.ReadKey();

//accepting user
//Ask user to input the 1st number, This integar variable stores the 1st number

Console.WriteLine("Enter the first number: ");
// We have to convert string (Console.ReadLine) to an integar:
//The code converts the string to a 32 bit integer value
//and then stores this 32 bit value in the integer variable
//called firstNumber.

int firstNumber = Convert.ToInt32(Console.ReadLine());

//Repeat the same for the 2nd number:

Console.WriteLine("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//Perform the calculation
int Result = firstNumber + secondNumber;

//Output answer to the console
Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNumber, secondNumber, Result);

