using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorV1
{
	class Program
	{
		static void Main(string[] args)
		{
			//-;Sets The Value of the Initital Variables
			int Terms = 0;
			double Total = 0;
			double Number = 0;
			int Updater = 0;
			string Account;
			Beginning();
			a();
			//;-
			//-;Resets the value of all the variables in case they already have been messed with,
			//writes all the UI of the Calculator about asking which operation will be made and
			//compares the value the user typed to see which operation will be made
			void Beginning()
			{
				Terms = 0; Total = 0; Total = 0; Updater = 0; Account = "";

				Console.WriteLine("======Calculator======");
				Console.WriteLine("");
				Console.WriteLine("Which mathematical account do you wish to have resolved?");
				Console.WriteLine("");
				Console.WriteLine("Type <1> for an Addition");
				Console.WriteLine("Type <2> for a Subtraction");
				Console.WriteLine("Type <3> for a Multiplication");
				Console.WriteLine("Type <4> for a Division");

				Account = Console.ReadLine();

				if (Account == "1") MainMathLogic("Addiction");
				if (Account == "2") MainMathLogic("Subtraction");
				if (Account == "3") MainMathLogic("Multiplication");
				if (Account == "4") MainMathLogic("Division");
				//;-
				//-;Makes with if the user typed nothing, it will do nothing.
				else { Console.Clear(); Beginning(); }
				//;-
			}

			//-; Asks how many numbers you want for the operation, analises it and choose an operation
			//depending on what the user typed, using the for condition statement, to keep looping
			//until it the variable "i" reaches how many numbers the user chose, it also shows the value
			//and keeps on the the next method for the user choose if he wants to repeat or leave
			void MainMathLogic(string SpecificAccount)
			{
				Console.Clear(); Console.WriteLine("===" + SpecificAccount + "===");
				Console.WriteLine("How many numbers do you want to use in your calculation?");

				string StringNumbers = Console.ReadLine();
				int IntNumbers = Int32.Parse(StringNumbers);

				for (int i = 0; i < IntNumbers; i++)
				{
					if (Account == "1") { SecondaryMath(); Addiction(); }
					if (Account == "2") { SecondaryMath(); Subtraction(); }
					if (Account == "3") { SecondaryMath(); Multiplication(); }
					if (Account == "4") { SecondaryMath(); Division(); }
					//-; The updater serves to say when all the Operations methods, except for the addiction
					//can change the way they work (look to methods downside SecondaryMath() to understand
					//it also to say when the "Far now" values should be output
					Updater++;
					if (Updater != IntNumbers && Updater != 1) Console.WriteLine("The Total is " + Total + " far now");
					//;-
				}
				Console.WriteLine("The final total is " + Total);
				Console.WriteLine("Press Enter to Continue");
				Console.ReadLine();
				DYWTGB();
				//;-
			}

			//-;Is the method which increaes variable terms, so it can define the place where the numbers is
			//and that asks for the number which the person will be using
			void SecondaryMath()
			{
				Terms++;
				Console.WriteLine("Type the " + Terms + "º number");
				string StringNumber = Console.ReadLine();
				Number = double.Parse(StringNumber);
			}

			//-;All of those downhead realizes operations according to the name of the method, using the variable
			//Updater to define how to calculate it
			void Addiction() { Total = Total + Number; }

			void Subtraction()
			{
				if (Updater == 0) Total = Number;
				else
				if (Updater >= 1) Total = Total - Number;
			}

			void Multiplication()
			{
				if (Updater == 0) Total = Number;
				else
				if (Updater >= 1) Total = Total * Number;
			}

			void Division()
			{
				if (Updater == 0) Total = Number;
				else
				if (Updater >= 1) Total = Total / Number;
			}
			//;-

			//-;This one asks if you want to go back to the beggining, or leave, if you press 1 you get
			//back to the beggining, and if press the application closes
			void DYWTGB()
			{
				Console.Clear();
				Console.WriteLine("Do you Wish to go back to try some more accounts?");
				Console.WriteLine("");
				Console.WriteLine("<1> Yes");
				Console.WriteLine("<2> No");
				string Answer = Console.ReadLine();

				if (Answer == "1") { Console.Clear(); Beginning(); }
				else
				if (Answer == "2") Environment.Exit(0);
				else
					DYWTGB();

				Console.ReadLine();
			}//;-
		}
		void a() { }



	}
	}


	


