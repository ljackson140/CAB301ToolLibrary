using System;

namespace CAB301TOOL_LIBRARY
{
    class Database
    {
        public static ToolCollection[] fetchData()
        {
            var lt = new ToolCollection("Line Trimmers");
            var lm = new ToolCollection("Lawn Mowers");
            var ght = new ToolCollection("Garden Hand Tools");
            var wb = new ToolCollection("Wheelbarrows");
            var gpt = new ToolCollection("Garden Power Tools");
            var s = new ToolCollection("Scrapers");
            var fl = new ToolCollection("Floor Lasers");
            var flt = new ToolCollection("Floor Levelling Tools");
            var flm = new ToolCollection("Floor Levelling Materials");
            var fht = new ToolCollection("Floor Hand Tools");
            var tt = new ToolCollection("Tiling Tools");
            var fhts = new ToolCollection("Hand Tools");
            var el = new ToolCollection("Electric Fencing");
            var sft = new ToolCollection("Steel Fencing Tools");
            var pt = new ToolCollection("Power Tools");
            var fa = new ToolCollection("Fencing Accessories");
            var dt = new ToolCollection("Distance Tools");
            var laserM = new ToolCollection("Laser Measurer");
            var mj = new ToolCollection("Measuring Jugs");
            var tht = new ToolCollection("Temperature & Humidity Tools");
            var mlt = new ToolCollection("Levelling Tools");
            var mks = new ToolCollection("Markers");
            var drain = new ToolCollection("Draining");
            var cc = new ToolCollection("Car Cleaning");
            var vCuum = new ToolCollection("Vacuum");
            var pcl = new ToolCollection("Pressure Cleaners");
            var pc = new ToolCollection("Pool Cleaning");
            var clean = new ToolCollection("Floor Cleaning");
            var sTls = new ToolCollection("Sanding Tools");
            var b = new ToolCollection("Brushes");
            var r = new ToolCollection("Rollers");
            var prTs = new ToolCollection("Paint Removal Tools");
            var pss = new ToolCollection("Paint Scrapers");
            var sPyres = new ToolCollection("Sprayers");
            var vt = new ToolCollection("Voltage Tester");
            var o = new ToolCollection("Oscilloscopes");
            var image = new ToolCollection("Thermal Imaging");
            var dtt = new ToolCollection("Data Test Tool");
            var it = new ToolCollection("Insulation Testers");
            var te = new ToolCollection("Test Equipment");
            var se = new ToolCollection("Safety Equipment");
            var bht = new ToolCollection("Basic Hand Tools");
            var cpt = new ToolCollection("Circuit Protection");
            var ctTs = new ToolCollection("Cable Tools");
            var j = new ToolCollection("Jacks");
            var ac = new ToolCollection("Air Compressors");
            var bCs = new ToolCollection("Battery Chargers");
            var soCtls = new ToolCollection("Socket Tools");
            var bks = new ToolCollection("Braking");
            var dtrn = new ToolCollection("Drivetrain");

            ToolCollection[] entireTC = new ToolCollection[] {
            lt, lm, ght, wb, gpt, s, fl,
            flt, flm, fht, tt, fhts, el, sft,
            pt, fa, dt, laserM, mj, tht, mlt,
            mks, drain, cc, vCuum, pcl, pc, clean, sTls, b,
            r, prTs, pss, sPyres, vt, o, image, dtt, it, te, se, bht,
            cpt, ctTs, j, ac, bCs, soCtls, bks, dtrn };

            return entireTC;
        }

        public static string GardenCategoryTools()
        {
            Console.Clear();
            Console.WriteLine("=============Gardening Tools============" +
                "\n 1. Line Trimmers" +
                "\n 2. Lawn Mowers" +
                "\n 3. Gardening Hand Tools" +
                "\n 4. Wheelbarrows" +
                "\n 5. Garden Power Tools" +
                "\n 0. Return to Category" +
                "\n ========================================");
            Console.Write("\n\nSelect between (1 to 5) or 0 to return to Category menu: ");

            string selection = Console.ReadLine();

            while (selection != "0" && selection != "1" && selection != "2" && selection != "3" && selection != "4" &&
                   selection != "5")
            {
                Console.Write("Error! Please select between (1 to 5) or 0 to return to Category menu: ");
                selection = Console.ReadLine();
            }
               

            if (selection == "1")
            {
                return "Line Trimmers";
            }
            else if (selection == "2")
            {
                return "Lawn Mowers";
            }
            else if (selection == "3")
            {
                return "Gardening Hand Tools";

            }
            else if (selection == "4")
            {
                return "Wheelbarrows";
            }
            else if (selection == "5")
            {
                return "Garden Power Tools";
            }
            else if (selection == "0")
            {
                return "back";
            }
            else
            {
                return "Incorrect selection";
            }
        }

        public static string FlooringCategoryTools()
        {
            Console.Clear();
            Console.WriteLine("=============Flooring Tools============" +
                "\n 1. Scrapers" +
                "\n 2. Floor Lasers" +
                "\n 3. Floor Levelling Tools" +
                "\n 4. Floor Levelling Materials" +
                "\n 5. Floor Hand Tools" +
                "\n 6. Tiling Tools" +
                "\n 0. Return to Category menu" +
                "\n =======================================");
            Console.WriteLine("\n\nSelect between (1 to 6) or 0 to return to Category menu: ");
            string selection = Console.ReadLine();

            while (selection != "0" && selection != "1" && selection != "2" && selection != "3" && selection != "4" &&
                   selection != "5" && selection != "6")
            {
                Console.Write("Error! Please select between (1 to 6) or 0 to return to Category menu: ");
                selection = Console.ReadLine();
            }          
               

            if (selection == "1")
            {
                return "Scrapers";
            }
            else if (selection == "2")
            {
                return "Floor Lasers";
            }
            else if (selection == "3")
            {
                return "Floor Levelling Tools";
            }
            else if (selection == "4")
            {
                return "Floor Levelling Materials";
            }
            else if (selection == "5")
            {
                return "Floor Hand Tools";
            }
            else if (selection == "6")
            {
                return "Tiling Tools";
            }
            else if (selection == "0")
            {
                return "back";
            }
            else
            {
                return "Incorrect selection";
            }

        }

        public static string FencingCategoryTools()
        {
            Console.Clear();
            Console.WriteLine("=============Fencing Tools============" +
                "\n 1. Hand Tools" +
                "\n 2. Electric Fencing" +
                "\n 3. Steel Fencing Tools" +
                "\n 4. Power Tools" +
                "\n 5. Fencing Accessories" +
                "\n 0. Return to Category menu" +
                "\n ======================================");
            Console.WriteLine("\n\nSelect between (1 to 5) or 0 to return to Category menu: ");
            string selection = Console.ReadLine();


            while (selection != "0" && selection != "1" && selection != "2" && selection != "3" && selection != "4" &&
                   selection != "5")
            {
                Console.Write("Error! Please select between (1 to 5) or 0 to return to Category menu: ");
                selection = Console.ReadLine();
                
            }     
                
            


            if (selection == "1")
            {
                return "Hand Tools";
            }
            else if (selection == "2")
            {
                return "Electric Fencing";
            }
            else if (selection == "3")
            {
                return "Steel Fencing Tools";
            }
            else if (selection == "4")
            {
                return "Power Tools";
            }
            else if (selection == "5")
            {
                return "Fencing Accessories";
            }
            else if (selection == "0")
            {
                return "back";
            }
            else
            {
                return "Incorrect selection";
            }
        }

        public static string MeasuringCategoryTools()
        {
            Console.Clear();
            Console.WriteLine("=============Measuring Tools============" +
                "\n 1. Distance Tools" +
                "\n 2. Laser Measurer" +
                "\n 3. Measuring Jugs" +
                "\n 4. Temperature & Humidity Tools" +
                "\n 5. Levelling Tools" +
                "\n 6. Markers" +
                "\n 0. Return to Category menu" +
                "\n ========================================");
            Console.WriteLine("\n\nSelect between (1 to 6) or 0 to return to Category menu: ");
            string selection = Console.ReadLine();

            while (selection != "0" && selection != "1" && selection != "2" && selection != "3" && selection != "4" &&
                   selection != "5" && selection != "6")
            {
                Console.Write("Error! Please select between (1 to 6) or 0 to return to Category menu: ");
                selection = Console.ReadLine();
                
            }       
               
            
            if (selection == "1")
            {
                return "Distance Tools";
            }
            else if (selection == "2")
            {
                return "Laser Measurer";
            }
            else if (selection == "3")
            {
                return "Measuring Jugs";
            }
            else if (selection == "4")
            {
                return "Temperature & Humidity Tools";
            }
            else if (selection == "5")
            {
                return "Levelling Tools";
            }
            else if (selection == "6")
            {
                return "Markers";
            }
            else if (selection == "0")
            {
                return "back";
            }
            else
            {
                return "Incorrect selection";
            }

        }

        public static string CleaningCategoryTools()
        {
            Console.Clear();
            Console.WriteLine("=============Cleaning Tools============" +
                "\n 1. Draining" +
                "\n 2. Car Cleaning" +
                "\n 3. Vacuum" +
                "\n 4. Pressure Cleaners" +
                "\n 5. Pool Cleaning" +
                "\n 6. Floor Cleaning" +
                "\n 0. Return to Category menu" +
                "\n =======================================");
            Console.WriteLine("\n\nSelect between (1 to 6) or 0 to return to Category menu: ");
            string selection = Console.ReadLine();

            while (selection != "0" && selection != "1" && selection != "2" && selection != "3" && selection != "4" &&
                   selection != "5" && selection != "6")
            {
                Console.Write("Error! Please select between (1 to 6) or 0 to return to Category menu: ");
                selection = Console.ReadLine();
            }        
                          

            if (selection == "1")
            {
                return "Draining";
            }
            else if (selection == "2")
            {
                return "Car Cleaning";
            }
            else if (selection == "3")
            {
                return "Vacuum";
            }
            else if (selection == "4")
            {
                return "Pressure Cleaners";
            }
            else if (selection == "5")
            {
                return "Pool Cleaning";
            }
            else if (selection == "6")
            {
                return "Floor Cleaning";
            }
            else if (selection == "0")
            {
                return "back";
            }
            else
            {
                return "Incorrect selection";
            }
        }

        public static string PaintingCategoryTools()
        {
            Console.Clear();
            Console.WriteLine("=============Painting Tools============" +
                "\n 1. Sanding Tools" +
                "\n 2. Brushes" +
                "\n 3. Rollers" +
                "\n 4. Paint Removal Tools" +
                "\n 5. Paint Scrapers" +
                "\n 6. Sprayers" +
                "\n 0. Return to Category menu" +
                "\n =======================================");
            Console.WriteLine("\n\nSelect between (1 to 6) or 0 to return to Category menu: ");
            string selection = Console.ReadLine();

            while (selection != "0" && selection != "1" && selection != "2" && selection != "3" && selection != "4" &&
                   selection != "5" && selection != "6")
            {
                Console.Write("Error! Please select between (1 to 6) or 0 to return to Category menu: ");
                selection = Console.ReadLine();
            }        
                

            if (selection == "1")
            {
                return "Sanding Tools";
            }
            else if (selection == "2")
            {
                return "Brushes";
            }
            else if (selection == "3")
            {
                return "Rollers";
            }
            else if (selection == "4")
            {
                return "Paint Removal Tools";
            }
            else if (selection == "5")
            {
                return "Paint Scrapers";
            }
            else if (selection == "6")
            {
                return "Sprayers";
            }
            else if (selection == "0")
            {
                return "back";
            }
            else
            {
                return "Incorrect selection";
            }           
        }

        public static string ElectronicCategoryTools()
        {
            Console.Clear();
            Console.WriteLine("=============Electronic Tools============" +
                "\n 1. Voltage Tester" +
                "\n 2. Oscilloscopes" +
                "\n 3. Thermal Imaging" +
                "\n 4. Data Test Tool" +
                "\n 5. Insulation Testers" +
                "\n 0. Return to Category menu" +
                "\n =========================================");
            Console.WriteLine("\n\nSelect between (1 to 5) or 0 to return to Category menu: ");
            string selection = Console.ReadLine();

            while (selection != "0" && selection != "1" && selection != "2" && selection != "3" && selection != "4" &&
                   selection != "5")
            {
                Console.Write("Error! Please select between (1 to 5) or 0 to return to Category menu: ");
                selection = Console.ReadLine();
            }

            if (selection == "1")
            {
                return "Voltage Tester";
            }
            else if (selection == "2")
            {
                return "Oscilloscopes";
            }
            else if (selection == "3")
            {
                return "Thermal Imaging";
            }
            else if (selection == "4")
            {
                return "Data Test Tool";
            }
            else if (selection == "5")
            {
                return "Insulation Testers";
            }
            else if (selection == "0")
            {
                return "back";
            }
            else
            {
                return "Incorrect selection";
            }
        }

        public static string ElectricityCategoryTools()
        {
            Console.Clear();
            Console.WriteLine("=============Electricity Tools============" +
                "\n 1. Test Equipment" +
                "\n 2. Safety Equipment" +
                "\n 3. Basic Hand Tools" +
                "\n 4. Circuit Protection" +
                "\n 5. Cable Tools" +
                "\n 0. Return to Category menu" +
                "\n ==========================================");
            Console.Write("\n\nSelect between (1 to 5) or 0 to return to Category menu: ");
            string selection = Console.ReadLine();


            while (selection != "0" && selection != "1" && selection != "2" && selection != "3" && selection != "4" &&
                   selection != "5")
            {
                Console.Write("Error! Please select between (1 to 5) or 0 to return to Category menu: ");
                selection = Console.ReadLine();
            }        
            
            if (selection == "1")
            {
                return "Test Equipment";
            }
            else if (selection == "2")
            {
                return "Safety Equipment";
            }
            else if (selection == "3")
            {
                return "Basic Hand Tools";
            }
            else if (selection == "4")
            {
                return "Circuit Protection";
            }
            else if (selection == "5")
            {
                return "Cable Tools";
            }
            else if (selection == "0")
            {
                return "back";
            }
            else
            {
                return "Incorrect selection";
            }
        }

        public static string AutomotiveCategoryTools()
        {
            Console.Clear();
            Console.WriteLine("=============Tool Types============" +
                "\n 1. Jacks" +
                "\n 2. Air Compressors" +
                "\n 3. Battery Chargers" +
                "\n 4. Socket Tools" +
                "\n 5. Braking" +
                "\n 6. Drivetrain" +
                "\n 0. Return to Category menu" +
                "\n ===================================");
            Console.WriteLine("\n\nSelect between (1 to 6) or 0 to return to Category menu: ");
            string selection = Console.ReadLine();

            while (selection != "0" && selection != "1" && selection != "2" && selection != "3" && selection != "4" &&
                   selection != "5" && selection != "6")
            {
                Console.Write("Error! Please select between (1 to 6) or 0 to return to Category menu: ");
                selection = Console.ReadLine();
            }

            if (selection == "1")
            {
                return "Jacks";
            }
            else if (selection == "2")
            {
                return "Air Compressors";
            }
            else if (selection == "3")
            {
                return "Battery Chargers";
            }
            else if (selection == "4")
            {
                return "Socket Tools";
            }
            else if (selection == "5")
            {
                return "Braking";
            }
            else if (selection == "6")
            {
                return "Drivetrain";
            }
            else if (selection == "0")
            {
                return "back";
            }
            else
            {
                return "Incorrect selection";
            }
           
        }
    }
}