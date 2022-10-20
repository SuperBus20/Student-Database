int studentChoice = 0;
string[] studentName = new string[3]
    {"John", "Mary", "Connor"};
string[] studentHometown = new string[3]
    {"Akron", "Philidalphia", "Hudson"};
string[] studentFavFood = new string[3]
    {"Duck", "Olives", "Pickles"};


MainProgram();






int IsValidNumber()
{
    Console.WriteLine("what student would you like to know about? (1-3)");

    while ((!int.TryParse(Console.ReadLine(), out studentChoice)) || studentChoice > studentName.Length + 1 || studentChoice < 1)
    {
        Console.WriteLine("sorry i was not able to look up a student with that number please try again");
    }
    return studentChoice;
}

string PrintName(int studentChoice)
{
    return $"Student {studentChoice} is {studentName[studentChoice - 1]}";
}


string IsValidCategory()
{
    Console.WriteLine("What category would you like to display? (hometown/favorite food)");
    string userCategory = Console.ReadLine();
    while (userCategory.ToLower() != "hometown" && userCategory.ToLower() != "favorite food" && userCategory.ToLower() != "home" && userCategory.ToLower() != "food")
    {
        Console.WriteLine("im sorry that is not a valid category. please enter again and be sure to look at the prompt for the two options to choose from");
        userCategory = Console.ReadLine();
    }
    return userCategory;
}

string PrintCategory(string userCategory)
{
    if (userCategory == "hometown" || userCategory == "home")
    {
        return $"{studentName[studentChoice - 1]}'s hometown is {studentHometown[studentChoice - 1]}";
    }
    else
    {
        return $"{studentName[studentChoice - 1]}'s favorite food is {studentFavFood[studentChoice - 1]}";
    }
}

string GoAgain()
{
    Console.WriteLine("Would you like to look up another student? (y/n)");
    return Console.ReadLine();
}

void MainProgram()
{
    string goAgain = "y";
    while (goAgain == "y")
    {
        Console.WriteLine(PrintName(IsValidNumber()));

        Console.WriteLine(PrintCategory(IsValidCategory()));

        goAgain = GoAgain();
    }

}