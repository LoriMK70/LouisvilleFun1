using System;
using System.Linq;

namespace LouisvilleFun
{
     internal class Program
    {
        static void Main(string[] args)
        {

            //Activity activity1 = new Activity("Idlewild", 10.00, "All Ages");
            //Activity activity2 = new Activity("Thirsty Pedaler", 70.00, "21+");
            //Activity activity3 = new Activity("Activate Games", 25.00, "10+");
            //Activity activity4 = new Activity("Slugger Museum", 16.00, "All ages");
            //Activity activity5 = new Activity("Flying Axes", 20.00, "13+");
            //MoreActivities activity6 = new MoreActivities("Louisville Zoo", 10.50, "All ages", "Food Available");
            //MoreActivities activity7 = new MoreActivities("SLugger Field", 16.00, "All ages", "Food Available");
            //MoreActivities activity8 = new MoreActivities("The Comedy Caravan Club", 17.00, "18+", "Food Available");


            ActivityRepo activityrepo = new ActivityRepo();


            //activityrepo.AddItem(1, activity1);
            //activityrepo.AddItem(2, activity2);
            //activityrepo.AddItem(3, activity3);
            //activityrepo.AddItem(4, activity4);
            //activityrepo.AddItem(5, activity5);
            //activityrepo.AddItem(6, activity6);
            //activityrepo.AddItem(7, activity7);
            //activityrepo.AddItem(8, activity8);

            Nelibur.ObjectMapper.TinyMapper.Bind<Activity, MoreActivities>();
            Nelibur.ObjectMapper.TinyMapper.Bind<MoreActivities, MoreActivities>();

            Activity activity1 = new Activity
            {

                Name = "Idlewild",
                Price = 10.00,
                Age = "All ages",
                Description = "Experience the bug tour!"
            };

            Activity activity2 = new Activity
            {
                Name = "Thirsty Pedaler",
                Price = 70.00,
                Age = "21+",
                Description = "Teetotalers beware!" 

            };

            Activity activity3 = new Activity
            {
                Name = "Activate Games",
                Price = 25.00,
                Age = "10+",
                Description = "Activate Games is for gamers looking for a challenge!"

            };

            Activity activity4 = new Activity
            {
                Name = "Slugger Museum",
                Price = 16.00,
                Age = "All ages",
                Description = "The Slugger Museum offers up some baseball history!"

            };

            Activity activity5 = new Activity
            {
                Name = "Flying Axes",
                Price = 20.00,
                Age = "13+",
                Description = "You can hurl your cares away at Flying Axes!"

            };

            MoreActivities activity6 = new MoreActivities
            {
                Name = "Louisville Zoo",
                Price = 10.50,
                Age = "All ages",
                Description = "Explore your animal insticts at the Louisville Zoo!",
                FoodAvailable = "Food Avaliable"

            };

            MoreActivities activity7 = new MoreActivities
            {
                Name = "Slugger Field",
                Price = 16.00,
                Age = "All ages",
                Description = "Enjoy peanuts and Crakcer Jacks at Louisville Slugger Field!",
                FoodAvailable = "Food Available"

            };

            MoreActivities activity8 = new MoreActivities
            {
                Name = "The Comedy Caravan Club",
                Price = 17.00,
                Age = "18+",
                Description = "Laugh the night away at The Comedy Caravan Club!",
                FoodAvailable = "Food Available"

            };
            

            Console.WriteLine("Find fun in Louisville");

            Console.WriteLine("What fun Louisville activities would you like information?");
            Console.WriteLine("\ta - Activites for all ages?");
            Console.WriteLine("\tb - Activities with age restrictions?");
            Console.WriteLine("\tc - Activities for all ages where food is available?");
            Console.WriteLine("\td - Activites with age restrictions where food is available?");
            Console.Write("Tell me more about");
            bool isMenuActive = true;

            while (isMenuActive)

            //switch (Console.ReadLine())

                //{
                //    case "a":
                //        Console.WriteLine;
                //        break;
                //    case "b":
                //        Console.WriteLine;
                //        break;
                //    case "c":
                //        Console.WriteLine;
                //        break;
                //    case "d":
                //        Console.WriteLine;
                //        break;
                //    case "e":
                //        Console.WriteLine;
                //        break;
                //    case "f":
                //        Console.WriteLine;
                //        break;
                //    case "g":
                //        Console.WriteLine;
                //        break;
                //    case "h":
                //        Console.WriteLine;
                //        break;
                //    case "i": isMenuActive = false;




                //}

                //Console.WriteLine("Press any key to close");
                //Console.ReadKey();


        

            
            ActivityRepo.AddItem()
            {

                private static void NewMethod3(ActivityRepo activityrepo)
                {
                    var notAllAgeNoFoodActivies = activityrepo.GetQuery()
                                .Where(act => act.Age.Equals("18+") || act.Age.Equals("21+") &&
                                !string.IsNullOrEmpty(act.FoodAvailable) &&
                                    act.FoodAvailable.Equals("Food AVailable"))
                                    .ToArray();


                    foreach (var activity in notAllAgeNoFoodActivies)
                    {
                        Console.WriteLine("Activities for ages 18+ that do not serve food are" + activity.Name);

                    }
                }

                private static void NewMethod2(ActivityRepo activityrepo)
                {
                    var allAgeNoFoodActivies = activityrepo.GetQuery()
                                        .Where(act => act.Age.Equals("All ages") &&
                                        !string.IsNullOrEmpty(act.FoodAvailable) &&
                                            act.FoodAvailable.Equals("Food Available"))
                                            .ToArray();


                    foreach (var activity in allAgeNoFoodActivies)
                    {
                        Console.WriteLine("Activities for all ages that do not serve food are" + activity.Name);

                    }
                }

                private static void NewMethod1(ActivityRepo activityrepo)
                {
                    var notAllAgeFoodActivies = activityrepo.GetQuery()
                                       .Where(act => act.Age.Equals("18+") || act.Age.Equals("21+") &&
                                       !string.IsNullOrEmpty(act.FoodAvailable) &&
                                           act.FoodAvailable.Equals("Food Available"))
                                           .ToArray();



                    foreach (var activity in notAllAgeFoodActivies)
                    {
                        Console.WriteLine("Activities for ages 18+ and 21+ that serve food are" + activity.Name);

                    }
                }

                private static void NewMethod(ActivityRepo activityrepo)
                {

                    var allAgeFoodActivies = activityrepo.GetQuery()
                                    .Where(act => act.Age.Equals("All ages") &&
                                    !string.IsNullOrEmpty(act.FoodAvailable) &&
                                        act.FoodAvailable.Equals("Food Available"))
                                        .ToArray();



                    foreach (var activity in allAgeFoodActivies)
                    {

                        Console.WriteLine("Activities for all ages that serve food are" + activity.Name);

                    }
                }


            }

    }
}



