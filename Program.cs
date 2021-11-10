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
            MoreActivities activity6 = new Activity("Louisville Zoo", 10.50, "All ages", "Food Available");
            MoreActivities activity7 = new Activity("SLugger Museum", 16.00, "All ages", "Food Available");


            ActivityRepo activityrepo = new ActivityRepo();


            activityrepo.ActivityDictionary.Add(1, activity1);
            activityrepo.ActivityDictionary.Add(2, activity2);
            activityrepo.ActivityDictionary.Add(3, activity3);
            activityrepo.ActivityDictionary.Add(4, activity4);
            activityrepo.ActivityDictionary.Add(5, activity5);
            activityrepo.ActivityDictionary.Add(6, activity6);
            activityrepo.ActivityDictionary.Add(7, activity7);

            foreach (var item in activityrepo.ActivityDictionary)
            {
                //do something here 
            }

        }

        
           
    }
}



