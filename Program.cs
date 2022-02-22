{ 

    float percentageMales;
    float percentageFemales;
    float maleFemale;

    Console.WriteLine("Hello, how many female cats are there?");
    int femaleCats = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("How many male cats are there?");
    int maleCats = Convert.ToInt32(Console.ReadLine());

// Equation to get prcentage
    maleFemale = (maleCats + femaleCats);
    percentageMales = (maleCats / maleFemale);
    percentageFemales = (femaleCats / maleFemale);

    System.Console.WriteLine("The precentage of male cats in the shelter is " + percentageMales);
    System.Console.WriteLine("The percentage of female cats in the shelter is " + percentageFemales);
}
