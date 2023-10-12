using System;

public class GoalManager
{
    private List<Goal> _goalList;
    private int _score;

    public GoalManager()
    {
        _goalList = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int end = -1;
         while (!(end == 6))
         {
            Console.WriteLine("\nMenu Options: \n");
            Console.Write("1. Create New Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n"+
                                    "5. Record Events\n6. Quit\nSelect a choice from the menu: ");
            string userInput = Console.ReadLine();
            int choice = int.Parse(userInput);

            if (choice == 1)
            {
                Console.WriteLine("The types of Goals are:  \n  1. Simple Goals \n  2. Eternal Goals\n  3. Checklist Goals ");
                Console.Write("Which type of Goal would yo like to create? ");
                string g = Console.ReadLine();
                int goal = int.Parse(g);

                if  (goal == 1)
                {
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this Goal? ");
                    string p = Console.ReadLine();
                    int points = int.Parse(p);

                    CreateSimpleGoal(name, description, points);
                }

                else if (goal == 2)
                {
                     Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();

                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();

                    Console.Write("What is the amount of points associated with this Goal? ");
                    string p = Console.ReadLine();
                    int points = int.Parse(p);

                    CreateEternalGoal(name, description, points);
                }
                
                // else if (goal == 3)
                // {
                //      Console.Write("What is the name of your goal? ");
                //     string name = Console.ReadLine();

                //     Console.Write("What is a short description of it? ");
                //     string description = Console.ReadLine();

                //     Console.Write("What is the amount of points associated with this Goal? ");
                //     string p = Console.ReadLine();
                //     int points = int.Parse(p);

                //     Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                //     string t = Console.ReadLine();
                //     int target = int.Parse(t);

                //     Console.Write("What is the bonus for accomplishing it that many times? ");
                //     string b = Console.ReadLine();
                //     int bonus = int.Parse(b);

                //     CreateCheckListGoal(name, description, points, target, bonus);
                // }
            }

            else if ( choice == 2)
            {
                ListGoalDetails();
            }
         }

    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player's Score: {_score}");
    }

    // public void ListGoalNames()
    // {
    //     Console.WriteLine("List of Goals:");
    //     foreach (Goal goal in _goalList)
    //     {
    //         Console.WriteLine(goal.GetName());
    //     }
    // }

    public void ListGoalDetails()
    {
        Console.WriteLine("The Goals are:");
        for (int i = 0; i < _goalList.Count; i++)
        {
            Console.WriteLine($"{i+1}."+_goalList[i].GetDetailsString());
        }
    }

    public void CreateCheckListGoal(string name, string desc, int points, int target, int bonus)
    {
        // Goal goal = new Check(name, desc, points, target, bonus);
    }

    public void CreateEternalGoal(string name, string description, int points)
    {

    }

    public void CreateSimpleGoal(string name, string description, int points)
    {
        Goal goal = new SimpleGoal(name, description, points);
        _goalList.Add(goal);
    }

    public void RecordEvent()
    {

    }

    public void SaveGoals()
    {

    }

    public void LoadGoals()
    {
    }

}