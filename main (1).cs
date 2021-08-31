using System;




namespace internship
{
 
    public class dataset{
      public static double mean(double []r,int g)

        {
            //loop to find mean
            double me = 0;
            for (int s = 0; s < r.Length; s++)
            {
                me = (me + r[s]) / g ;

            }
            Console.WriteLine("How would you like to round the mean");
                Console.WriteLine("1) round to whole number");
                 Console.WriteLine("2) round to tenth decimal place");
                Console.WriteLine("3) round to hundreth decimal place ");
                Console.WriteLine("4) round to Thousandth decimal place ");
                Console.WriteLine("5) to not round");
            int m=Convert.ToInt32(Console.ReadLine()); 
            switch (m) {
                case 1:
                    me = Math.Floor(me * 1 + .5) / 1;
                    break;
                case 2:me=Math.Floor(me * 10 + .5) / 10;
                    break;
                case 3:
                    me = Math.Floor(me * 100 + .5) / 100;
                    break;
                case 4:
                    me = Math.Floor(me * 1000 + .5) / 1000;
                    break;
                default: me = me;
                    break;
                }
            

            return me;
        }
      public static double median(double[] r) {
            //loop to find median
            double med = 0;
            for (int ka = 0; ka < 1; ka++)
            {
                //if set is even divide middle 2 numbers by 2
                if (r.Length % 2 == 0)
                {
                    med = ((double)r[r.Length / 2] + (double)r[r.Length / 2 - 1]) / 2;
                }
                //if it's odd median is center number
                else
                {
                    med = (double)r[r.Length / 2];
                }
            }
            return med;

            
        }
          public static double small(double [] r) {
            double max = r[0];
            double min = r[0];
            //loop to find max in min of dataset 
            for (int ha = 0; ha < r.Length; ha++)
            {

                // replaces min if new number is less
                if (r[ha] < min)
                {
                    min = r[ha];
                }
                // replaces max if new number is greater
                else if (r[ha] > max)
                {
                    max = r[ha];
                }
            }
            return min; }
          public static double greatest(double [] r) {
            double max = r[0];
            double min = r[0];
            //loop to find max in min of dataset 
            for (int ha = 0; ha < r.Length; ha++)
            {

                // replaces min if new number is less
                if (r[ha] < min)
                {
                    min = r[ha];
                }
                // replaces max if new number is greater
                else if (r[ha] > max)
                {
                    max = r[ha];
                }
            }
            return max;
        }
  
      public static double Mode( double [] r,int g)
        {
          double max = r[0];
            //loop to find max in min of dataset 
            for (int ha = 0; ha < r.Length; ha++)
            {
                // replaces max if new number is greater
                if (r[ha] > max)
                {
                    max = r[ha];
                }
            }
            //stores max number
            double max2 = max;
            //sets size of count array
            double t = max2 + 1;
            double [] count = new double [(int)t];
            for (int m=0; m<t; m++)
            { count[m] = 0; }
            // stores the count of each element in each array
            for (int i = 0; i < g; i++)
                count[(int)r[i]]++;
            // takes the highest count and returns that number as the highest  
            double mode = 0;
            double k = count[0];
            for (int i =1;i<g; i++)
            {
                if (count[i] > k)
                { k = count[i];
                    mode = i; }
            }

            return mode;
        }}

        //-----------------------------------
        //-----------------------------------
        //-----------------------------------
   public class Atm{

        //attributes
        private string classification;
        private string fname;
        private string lname;
        private int[] digitpw;
        private string characterpw;
        private double balance;
          //account
        public void account(string classify, string firstname, string lastname)
        {
            this.fname = firstname;
            this.lname = lastname;
            this.classification = classify;
            this.digitpw = new int[0];

            this.characterpw = null;
            this.balance = 0;

        }
            //password
        public void digitPw(int[] digits)
        {
            digitpw = digits;


        }
        //password
        public void characterPw(string chapw)
        {
            characterpw = chapw;
        }
        //money
        public void balanceintake(double bal)
        {
            balance += bal;

        }
        //-----



        //--------
        //security
        public void atmSecurity(int[] newdigits)
          {
            int count = 5;




            bool flag = true;


            while (digitpw != newdigits)
            {
                count--;
                Console.WriteLine("password inccorect");
                Console.WriteLine("you have " + count + " attempts left");
                for (int i = 0; i < digitpw.Length; i++)
                {
                    newdigits[i] = Convert.ToInt32(Console.ReadLine());
                }
                if (count == 0)
                {
                    Console.WriteLine("Too many incorrect attempts");
                    flag = false;
                    break;



                }

            }

            if (flag)
            {

                int choice;
                Console.WriteLine("Welcome " + classification + " " + fname + " " + lname + ",");
                Console.WriteLine("");


                do
                {
                    Console.WriteLine("Click 1 for Deposit");
                    Console.WriteLine("Click 2 for Withdraw");
                    Console.WriteLine("click 3 for Check current balance");
                    Console.WriteLine("Click 4 to exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Please insert how much you would like to Deposit");
                            double addamount = Convert.ToDouble(Console.ReadLine());
                            balance += addamount;
                            break;
                        case 2:
                            Console.WriteLine("How much would you like to withdraw?");
                            double minusamount = Convert.ToDouble(Console.ReadLine());
                            balance -= minusamount;
                            break;
                        case 3:
                            Console.WriteLine("Your current balance is " + balance);

                            break;
                    }
                } while (choice != 4);





            }
        }

        public void atmSecurity2(string cpw){
            int count = 5;
          
          bool flag = true;
          //attempt 
            //loop until 5 has been exceeded locked out

            while (!characterpw.Equals(cpw, StringComparison.OrdinalIgnoreCase))
            {

                count--;
                Console.WriteLine("password inccorect");
                Console.WriteLine("you have " + count + " attempts left");

                cpw = Console.ReadLine();

                if (count == 0)
                {
                    Console.WriteLine("Too many incorrect attempts");
                    flag = false;
                    break;



                }

            }
            if (flag)
            {

                int choice;
                Console.WriteLine("Welcome " + classification + " " + fname + " " + lname + ",");
                Console.WriteLine("");


                do
                {
                    Console.WriteLine("Click 1 for Deposit");
                    Console.WriteLine("Click 2 for Withdraw");
                    Console.WriteLine("click 3 for Check current balance");
                    Console.WriteLine("Click 4 to exit");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Please insert how much you would like to Deposit");
                            double addamount = Convert.ToDouble(Console.ReadLine());
                            balance += addamount;
                            break;
                        case 2:
                            Console.WriteLine("How much would you like to withdraw?");
                            double minusamount = Convert.ToDouble(Console.ReadLine());
                            balance -= minusamount;
                            break;
                        case 3:
                            Console.WriteLine("Your current balance is " + balance);

                            break;
                    }
                } while (choice != 4);




            }
        }

   


        
   
  

  //----------------------------------------------------------
  //-----------------------------------
  //-----------------------------------
  
class MainClass {
   public static void set()
        {
            
            int g;
            double l;
            Console.Write("Enter in the amount of numbers in the data set: ");
            g = Convert.ToInt32(Console.ReadLine());
            double[] r = new double[g];
            Console.WriteLine("Enter in the numbers from the data set ");
           
            //loop to get data values
            for (int m = 0; m < r.Length; m++)
            {

                l = Convert.ToDouble(Console.ReadLine());
                r[m] = l;
            }
            //loop to sort data
            for (int j = 0; j < r.Length - 1; j++)
            {
                for (int c = 0; c < r.Length - j - 1; c++)
                {
                    //compares the values form left to right 
                    if (r[c] > r[c + 1])
                    {
                        // swaps the values  
                        double jim = r[c];       //setting the values aside 
                        r[c] = r[c + 1];
                        r[c + 1] = jim;
                    }
                }
            }

            foreach (int p in r )
                Console.Write(p + ",");
            Console.WriteLine();

        Console.WriteLine("Mean of data set is: " + dataset.mean(r, g));
            Console.WriteLine(" to get the mean we take the total number" + g+"and divide it by the sum of all the integers and round if need be.");
           Console.WriteLine("Median of the data set is: " +dataset.median(r));
            Console.WriteLine("To get the median you must sort the data from least to greatest than take the number in the middle (if dataset is odd)");
            Console.WriteLine("if the dataset is an even number take the two number in the middle an divide by 2 ");
           Console.WriteLine("Mode of data set is: " + dataset.Mode(r,g));
            Console.WriteLine("To get the mode you take the number that appears the most");
            Console.WriteLine("Biggest number in data set: " + dataset.greatest(r));
            Console.WriteLine("Smallest number in data set: " + dataset.small(r));}
        //-----------
        //------------
        //------------
  public static void atm(){
            
            
            string l, f, choice, r, cla, q;
           
            //object
          Atm person = new Atm();
            Console.WriteLine("Welcome to the atm");
            Console.WriteLine("Please create an account");
            Console.WriteLine("Please select M for male or F for female");
            cla = Console.ReadLine();
            //determines how to address user
            if (cla.Equals("M", StringComparison.OrdinalIgnoreCase))
            {
                cla = "Mr.";
               
            }
            else if (cla.Equals("F", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Are you married? type y or n");
                if (cla.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    cla = "Ms.";
                }
                else if (cla.Equals("y", StringComparison.OrdinalIgnoreCase)) { }
                cla = "Mrs.";
            }
            //stores user first name 
            Console.WriteLine("What is your first name ");
            f = Console.ReadLine();
            //stores user last name 
            Console.WriteLine("What is your last name ");
            l = Console.ReadLine();
            Console.WriteLine("");
            //storing info
            person.account(cla,f,l);

            // ask user prefrence of passcode to account
            Console.WriteLine("Type Y or N to the following Questions");
            
            Console.WriteLine("Do you want to have a 4 digit security code ?");
            Console.WriteLine("If not, you'll type in a 12 charater passcode.");
            choice = Console.ReadLine();

           int [] m= new int[4];
            
            if (choice.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Please type in 4 digits: ");
                Console.WriteLine("Hit enter after each one.");

                for (int i = 0; i < m.Length;i++) {
                    m[i] = Convert.ToInt32(Console.ReadLine()); }
                person.digitPw(m);
            }
            else if (choice.Equals("N", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("please enter in 12 characters");

                r = Console.ReadLine();
                
                person.characterPw(r);
            }
            else
            {
                Console.WriteLine("please press y or n");
            }
            double amount;
            Console.WriteLine("Please insert a minimum of $100");
             amount = Convert.ToDouble(Console.ReadLine());
            person.balanceintake(amount);
            Console.WriteLine("Thank you! ");
            Console.WriteLine("your account creation is now complete");
            Console.WriteLine("");
            //login into account
            int[] newdigit = new int[4];
            Console.WriteLine("Which passscode did you use for your account?");

            Console.WriteLine("Press D for digit code ");
            Console.Write(" Press C for character code");
            q = Console.ReadLine();
            if (q.Equals("d", StringComparison.OrdinalIgnoreCase))
            {


                Console.WriteLine("Enter in 4 digits");
                Console.WriteLine("Hit enter after each one.");
                for (int i = 0; i < m.Length; i++)
                {
                    newdigit[i] = Convert.ToInt32(Console.ReadLine());
                }
                
                person.atmSecurity(newdigit);
            }
    else if (q.Equals("c", StringComparison.OrdinalIgnoreCase)){

                 
                string ch;
                Console.WriteLine("Enter in 12 Characters ");
                ch = Console.ReadLine();
              
                person.atmSecurity2(ch);


            } 
        }
        
  public static void Main (string[] args){
            int v;
            Console.WriteLine("Hello!");
            Console.WriteLine("Click 1 to take a trip to the ATM!");
            Console.WriteLine("Click 2 to analyze your data set!");
            v = Convert.ToInt32(Console.ReadLine());
            switch (v)
            {
                case 1:
                    atm();
                    break;
                case 2:
                    set();
                    break;

                default:
                    Console.WriteLine("Please select  number 1 or 2");
                    break;

            }
            
            
            
        }
  
     
    }

  }

}


