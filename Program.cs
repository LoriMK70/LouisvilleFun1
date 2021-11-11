using System;

namespace LouisvilleFun
{
     internal class Program
    {
        static void Main(string[] args)
        {

            Activity activity1 = new Activity("Idlewild", 10.00, "All Ages");
            Activity activity2 = new Activity("Thirsty Pedaler", 70.00, "21+");
            Activity activity3 = new Activity("Activate Games", 25.00, "10+");
            Activity activity4 = new Activity("Slugger Museum", 16.00, "All ages");
            Activity activity5 = new Activity("Flying Axes", 20.00, "13+");
            MoreActivities activity6 = new MoreActivities("Louisville Zoo", 10.50, "All ages", "Food Available");
            MoreActivities activity7 = new MoreActivities("SLugger Museum", 16.00, "All ages", "Food Available");
            MoreActivities activity8 = new MoreActivities("The Comedy Caravan Club", 17.00, "18+", "Food Available");


            ActivityRepo activityrepo = new ActivityRepo();


            activityrepo.ActivityDictionary.Add(1, activity1);
            activityrepo.ActivityDictionary.Add(2, activity2);
            activityrepo.ActivityDictionary.Add(3, activity3);
            activityrepo.ActivityDictionary.Add(4, activity4);
            activityrepo.ActivityDictionary.Add(5, activity5);
            activityrepo.ActivityDictionary.Add(6, activity6);
            activityrepo.ActivityDictionary.Add(7, activity7);
            activityrepo.ActivityDictionary.Add(8, activity8);

            var allAgeFoodActivies = activityrepo.ActivityDictionary
                .Select(s => s.Value)
                .Cast<MoreActivities>()
                .Where(act => act.Age.Equals("All ages") &&
                       act.FoodAvailable.Equals("Food Available"))
                       .ToArray();

            Console.WriteLine("Activities for all ages that serve food are:");
            foreach(var activity in allAgeFoodActivies)
            {
                Console.WriteLine(activity.Name);

            }


            


        }

        
           
    }
}



