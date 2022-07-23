using Microsoft.VisualBasic.FileIO;

//array values of availabilities
const int fridayAM1 = 0;
const int fridayPM1 = 1;
const int saturdayAM1 = 2;
const int saturdayPM1 = 3;
const int sunday1 = 4;
const int mondayAM1 = 5;
const int mondayPM1 = 6;
const int tuesdayAM1 = 7;
const int tuesdayPM1 = 8;
const int wednesdayAM1 = 9;
const int wednesdayPM1 = 10;
const int thursdayAM1 = 11;
const int thursdayPM1 = 12;
/*
const int fridayAM2 = 13;
const int fridayPM2 = 14;
const int saturdayAM2 = 15;
const int saturdayPM2 = 16;
const int sunday2 = 17;
const int mondayAM2 = 18;
const int mondayPM2 = 19;
const int tuesdayAM2 = 20;
const int tuesdayPM2 = 21;
const int wednesdayAM2 = 22;
const int wednesdayPM2 = 23;
const int thursdayAM2 = 24;
const int thursdayPM2 = 25;
*/

namespace ScheduleMaker
{
	class Program
	{
		static void Main(string[] args)
		{
			FileHandlers handlers = new FileHandlers();
			List<Employee> employees = new List<Employee>();
			
			employees = handlers.getEmployeeDetails();

			foreach(Employee employee in employees) {
				Console.WriteLine(employee);
			}
		}
	}

	
}