void DeterminingPositiveOrNegative()
{
    Console.Write("Plase enter a number: ");
    var number = Convert.ToInt32(Console.ReadLine());
    
    if(number > 0)
        Console.WriteLine("You entered positive number");
    else if(number == 0)
        Console.WriteLine("You entered zero");
    else
        Console.WriteLine("You entered a negative number");
}

void DeterminingDayName()
{
    Console.Write("Enter the order of a day in the week:");
    var dayIndex = Convert.ToInt32(Console.ReadLine());

    switch (dayIndex)
    {
        case 1:
            Console.WriteLine("It's means Monday");
            break; 
        case 2:
            Console.WriteLine("It's Tuesday");
            break;
        case 3:
            Console.WriteLine("It's Wednesday");
            break;
        case 4:
            Console.WriteLine("It's Thursday");
            break;
        case 5:
            Console.WriteLine("It's Friday");
            break;
        case 6:
            Console.WriteLine("It's Saturday");
            break;
        case 7:
            Console.WriteLine("It's Sunday");
            break;
        default:
            Console.WriteLine("You entered an invalid number");
            break;
    }
}

void SimpleCalculator()
{
    Console.Write("Enter your first number: ");
    var number1 = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter your second number: ");
    var number2 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine($"1) Addition {number1} (+) {number2} = ?");
    Console.WriteLine($"2) Subtraction  {number1} (-) {number2} = ?");
    Console.WriteLine($"3) Multiplication  {number1} (x) {number2} = ?");
    Console.WriteLine($"4) Division  {number1} (/) {number2} = ?");
    Console.Write("Choice your operation: ");
    var choice = Convert.ToInt32(Console.ReadLine());

    double result;
    switch (choice)
    {
        
        case 1:
            result = number1 + number2;
            Console.WriteLine($" {number1} + {number2} = {result}");
            break;
        case 2:
            result = number1 - number2;
            Console.WriteLine($" {number1} - {number2} = {result}");
            break;
        case 3:
            result = number1 * number2;
            Console.WriteLine($" {number1} * {number2} = {result}");
            break;
        case 4:
            
            if(number2 == 0)
                Console.WriteLine($"undefined");
            else
            {
                result = Convert.ToDouble(Convert.ToDouble(number1) / Convert.ToDouble(number2));
                Console.WriteLine($" {number1} / {number2} = {result}");
            }
            break;
        default:
            Console.WriteLine("You entered an invalid number");
            break;
            
    }
}

void FindingLargesNumber()
{
    Console.Write("Enter your first number: ");
    var number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter your second number: ");
    var number2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter your third number: ");
    var number3 = Convert.ToInt32(Console.ReadLine());
    
    if(number1 >= number2 && number1 >= number3)
        Console.WriteLine($"{number1} is bigger than {number2} and {number3}");
    else if(number2 >= number1 && number2 >= number3)
        Console.WriteLine($"{number2} is bigger than {number1} and {number3}");
    else
        Console.WriteLine($"{number3} is bigger than {number2} and {number1}");       
}

bool IsStrength(string password)
{
    if (password.Length < 8)
        return false;

    bool largestCharacter = false;
    bool specialCharacter = false;
    string specialCharacters = "@#$%*";

    foreach (char c in password)
    {
        if (char.IsUpper(c))
            largestCharacter = true;

        if (specialCharacters.Contains(c))
            specialCharacter = true;
    }

    return largestCharacter && specialCharacter;
}

void CheckingPasswordStrength()
{
    Console.Write("Enter a password: ");
    var password = Console.ReadLine();
    
    var response = password != null && IsStrength(password);
    
    if(response)
        Console.WriteLine("Your password is strong enough");
    else
        Console.WriteLine("Your password is not strong enough");
}

void ProgramRunOrExit()
{
    Console.WriteLine("Do you want to continue browsing the program? y/n");
    var input = Console.ReadLine();

    if (input == "y" || input == "Y")
    {
        Console.Clear();
        Console.WriteLine("Program running...");
    }
    else
    {
        Environment.Exit(0);
    }  
}

while (true)
{
    Console.WriteLine("Welcome to the Odev1 Console App, plase select your operation:");
    Console.WriteLine("1) Determining positive negative number");
    Console.WriteLine("2) Determining Day Name");
    Console.WriteLine("3) Simple Calculator");
    Console.WriteLine("4) Finding the Largest of Three Numbers");
    Console.WriteLine("5) Checking Password Strength");
    Console.Write("Your choice: ");
    
    var choice = 6;
    
    try
    {
        choice = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception e)
    {
        continue;
    }
    
    
    Console.Clear();
    
    switch (choice)
    {
        case 1:
            DeterminingPositiveOrNegative();
            break;
        case 2:
            DeterminingDayName();
            break;
        case 3:
            SimpleCalculator();
            break;
        case 4:
            FindingLargesNumber();
            break;
        case 5:
            CheckingPasswordStrength();
            break;
        default:
            Console.WriteLine("You entered an invalid number");
            break;
    }

    ProgramRunOrExit();
}
