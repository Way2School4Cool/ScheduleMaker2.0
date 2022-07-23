namespace ScheduleMaker {

	public class FileHandlers {

		string employeeDataFile = "WorkerData.csv";
		string scheduleFile = "";

		public List<Employee> getEmployeeDetails() {

			List<Employee> employees = new List<Employee>();
			bool[] availability = new bool[26];
			bool bistro;

			using (StreamReader reader = new StreamReader(employeeDataFile)) {
				string line;
				while ((line = reader.ReadLine()) != null) {

					string[] employeeData = line.Split(',');

					/* Do something with X */
					if (employeeData[3].ToUpper() == "Y") {

						for (int i = 6; i < employeeData.Length; i++) {
							if (employeeData[i].ToUpper() == "Y") {
								availability.Append(true);
							}
							else {
								availability.Append(false);
							}
						}

						if (employeeData[5].ToUpper() == "Y") {
							bistro = true;
						}
						else {
							bistro = false;
						}

						Lead lead = new Lead(employeeData[0], employeeData[1], int.Parse(employeeData[2]), availability, bistro);

						employees.Add(lead);
					}

					else if (employeeData[4].ToUpper() == "Y") {
						if (employeeData[5].ToUpper() == "Y") {
							bistro = true;
						}
						else {
							bistro = false;
						}

						Server server = new Server(employeeData[0], employeeData[1], int.Parse(employeeData[2]), availability, bistro);
						employees.Add(server);
					}

					else {
						if (employeeData[5].ToUpper() == "Y") {
							bistro = true;
						}
						else {
							bistro = false;
						}

						Server server = new Server(employeeData[0], employeeData[1], int.Parse(employeeData[2]), availability, bistro);
						employees.Add(server);
					}
				}
				return employees;

			}
		}
	}
}