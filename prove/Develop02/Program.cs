
//What is version control and why is it important?

// version control is basically keeping track of changes made to source code
// of a program we can think of it as a checkpoint, if in the future our program stops working
// we can always go back to an old version of our code where everything was fine, it is very important to use
// version control and even more when we work as a team, to make this practice easier there are software
// version control systems that record all modifications made to a program and make it available
// for all the people who work with that code, one of them is git that keeps an exact history of each modification
// within a repository that is where each new modification is stored

// version control helps developers and teams to be efficient, agile and coordinate efforts well
// from each developer to the same code when using version control software, conflicts between
// developers to make a change while another developer makes another change, it is useful when we lose our
// files and we need to recover them since backups are created of each program that we upload to a repository
// for example, in git we use the "$ git pull" command to push our new modifications to the repository
// along with a note describing the changes we made.
using System;
using System.IO;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;
using System.Text;
class Program
{
    static void Main()
    {
        string text = "";
        string hour = DateTime.Now.ToString("HH:mm:ss");
        
        
 
            DateTime today = DateTime.Now;
            
            CultureInfo culture = new CultureInfo("es-MX");
            
            string todayAsStr = today.ToString(culture);
            
            string[] fechaYHoraHoy = todayAsStr.Split(" ");
            
            string fechaHoy = fechaYHoraHoy[0];
            
            

    string fechaParaDiario = fechaHoy.Replace("/", "-"); 
    

 

List<string> questions = new List<string>() { "Who was the most interesting person I interacted with today?", 
                                              "What was the best part of my day?", 
                                              "How did I see the hand of the Lord in my life today?", 
                                              "What was the strongest emotion I felt today?", 
                                              "If I had one thing I could do over today, what would it be?" };




 bool running = true;
        while (running){
Console.WriteLine("Please select an option:");
Console.WriteLine("1. Write");
Console.WriteLine("2. Display");
Console.WriteLine("3. Save");
Console.WriteLine("4. Load");
Console.WriteLine("5. Quit");





int userSelection = int.Parse(Console.ReadLine());

switch (userSelection)
{
    case 1:
        Console.WriteLine("You selected write.");
        
        Random rnd = new Random();
        int randomIndex = rnd.Next(questions.Count);
        Console.WriteLine(questions[randomIndex]);
        ///
        
            
            Console.WriteLine("");
            Console.WriteLine("Write the text:");
            text = Console.ReadLine();
            Console.WriteLine("");
            
            

            

        break;
    case 2:
    Console.WriteLine("Your text is");
            Console.WriteLine(text);

    break;    
    case 3:
        Console.WriteLine("You selected save.");
        
              using (StreamWriter sw = new StreamWriter(fechaParaDiario + ".txt"))
            {
                
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Save in the current directory ");
               
                





                    int userSelection2 = int.Parse(Console.ReadLine());
                                    switch (userSelection2){
                                    case 1:
                                    Console.WriteLine("You selected Save in the current directory");
                                    
                                    
                                           
                                           sw.WriteLine(text);


                                  

                                    break;
                                    case 2:
                                    Console.WriteLine("quit");
                                    break;
                                    }
                
                
                

            }


        break;
    case 4:
        Console.WriteLine("You selected load.");
        
        Console.WriteLine("Enter the path of the file to be loaded:");
                string pathLoad = Console.ReadLine();
                text = File.ReadAllText(pathLoad);
                Console.WriteLine("Text from file: " + text);
                break;
    case 5:
            Console.WriteLine("Quit");
            break;


    default:
        Console.WriteLine("Invalid selection. Please enter 1, 2, or 3.");
        break;
}
}
    }}

