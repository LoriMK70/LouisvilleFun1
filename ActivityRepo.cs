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


            Activity activity1 = new Activity("Idlewild", 10.00, "All ages");
            Activity activity2 = new Activity("Thirsty Pedaler", 70.00, "21+");
            Activity activity3 = new Activity("Activate Games", 25.00, "10+");
            Activity activity4 = new Activity("Slugger Museum", 16.00, "All ages");
            Activity activity5 = new Activity("Flying Axes", 20.00, "13+");
            MoreActivities activity6 = new MoreActivities("Louisville Zoo", 10.50, "All ages", "Food Available");
            MoreActivities activity7 = new MoreActivities("SLugger Museum", 16.00, "All ages", "Food Available");
            MoreActivities activity8 = new MoreActivities("The Caravan Comedy Club", 17.00, "18+", "Food Available");



        }

        public IDictionary<int, Activity> ActivityDictionary { get; set; } = new Dictionary<int, Activity>();


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
        
        
        

    
