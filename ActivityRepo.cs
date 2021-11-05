using System;
using System.Collections.Generic;
using System.Text;

namespace LouisvilleFun
{
    class ActivityRepo
    {
        public static Dictionary<string, Activity>InitializeActivity()
        {
        Activity activity1 = new Activity("Idlewild", 10.00, "All ages");
        Activity activity2 = new Activity("Thirsty Pedaler", 70.00, "21+");
        Activity activity3 = new Activity("Activate Games", 25.00, "10+");
        Activity activity4 = new Activity("Slugger Museum", 16.00, "All ages");
        Activity activity5 = new Activity("Flying Axes", 20.00, "13+");
        
        
        
        Activity[] activites = new Activity[4];

        activites[0] = activity1;
            activites[1] = activity2;
            activites[2] = activity3;
            activites[3] = activity4;
            activites[4] = activity5;


    }
}
