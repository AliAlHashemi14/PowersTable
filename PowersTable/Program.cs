do
{

    //greet user and ask for number
    Console.WriteLine("Welcome to the Powers Table. Please enter a positive integer under 1290.");
    int response = int.Parse(Console.ReadLine());
    while (response <= 0 || response > 1290)
    {
        Console.WriteLine("Incorrect integer. Please enter a correct option.");
        response = int.Parse(Console.ReadLine());
    }


    

    //format of table
    Console.WriteLine("===================================");
    Console.WriteLine("  Number  | Squared  |  Cubed     ");
    Console.WriteLine("===================================");
    //loop
    for (int i = 1; i <= Math.Abs(response); i++)
        {
            //Console.WriteLine($"\tNumber: {i} \tSquare: {getSquared(i)} \tCube: {getCubed(i)}");
            Console.WriteLine(string.Format("{0,-10} | {1,-10} | {2,5}",i,getSquared(i),getCubed(i)));
        }
    

    //ask if they want to go again
    Console.WriteLine("Would you like to start again? (y/n)");
        if (Console.ReadLine().ToLower().Trim() == "y")
        {
            continue;
        }
        else
        {
            break;
        }

    //get squared method
    static double getSquared(int num)
        {
            return  num*num;
        }

        //get cubed method
        static double getCubed(int num)
        {
            return num*num*num;
        }

}
while (true);

