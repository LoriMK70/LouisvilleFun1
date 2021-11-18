using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LouisvilleFun
{
    public class ActivityRepo
    {
        public ActivityRepo()
        {
            ActivityDictionary = new Dictionary<int, Activity>();


            Activity activity1 = new Activity("Idlewild", 10.00, "All ages", "Experience the bug tour!");
            Activity activity2 = new Activity("Thirsty Pedaler", 70.00, "21+", "Teetotalers beware!");
            Activity activity3 = new Activity("Activate Games", 25.00, "10+", "Activate Games is for gamers looking for a challenge!");
            Activity activity4 = new Activity("Slugger Museum", 16.00, "All ages", "The Slugger Museum offers up some baseball history!");
            Activity activity5 = new Activity("Flying Axes", 20.00, "13+", "You can hurl your cares away at Flying Axes!");
            MoreActivities activity6 = new MoreActivities("Louisville Zoo", 10.50, "All ages", "Explore your animal insticts at the Louisville Zoo!", "Food Available");
            MoreActivities activity7 = new MoreActivities("SLugger Field", 16.00, "All ages", "Enjoy peanuts and Crakcer Jacks at Louisville Slugger Field!", "Food Available");
            MoreActivities activity8 = new MoreActivities("The Caravan Comedy Club", 17.00, "18+", "Laugh the night away at The Comedy Caravan Club!", "Food Available");



        }

        public void AddItem(int id, Activity activity)
        {

            ActivityDictionary.Add(id, activity);
        }

        private IDictionary<int, Activity> ActivityDictionary { get; set; } = new Dictionary<int, Activity>();


        public List<MoreActivities> GetQuery()
        {

            List<MoreActivities> allActivities = new List<MoreActivities>();
            foreach (var activity in ActivityDictionary.Select(s => s.Value))
            {
                var moreActivity = Nelibur.ObjectMapper.TinyMapper.Map<MoreActivities>(activity);
                allActivities.Add(moreActivity);
            }

            return allActivities;
        }



    }

}           
        
        
        

    
