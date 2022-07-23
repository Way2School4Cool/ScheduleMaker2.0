
//construct employee data as an interface
public class Employee {
	private String fullName = "none";
	private String phoneNumber = "-1";
	private int numOfShifts = -1;
	private bool[] availability = new bool[26];
	private bool lead = false;
	private bool server = false;
	private bool bistro = false;

	public string FullName { get => fullName; set => fullName = value; }
	public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
	public int NumOfShifts { get => numOfShifts; set => numOfShifts = value; }
	public bool[] Availability { get => availability; set => availability = value; }
	public bool Lead { get => lead; set => lead = value; }
	public bool Server { get => server; set => server = value; }
	public bool Bistro { get => bistro; set => bistro = value; }
	public bool getAvailableAt(int day) {
		return Availability[day];
	}
	public void setAvailableAt(int day, bool canWork) {
		Availability[day] = canWork;
	}

}

//abstracted class for people who are leads
public class Lead : Employee {
	
	Lead(bool[] availability, bool bistro) {
		Lead = true;
		Server = true;
		Availability = availability;
		Bistro = bistro;
	}
}

//abstracted class for people who are non-lead servers 
public class Server : Employee {
	Server(bool[] availability, bool bistro) {
		Server = true;
		Availability = availability;
		Bistro = bistro;
	}
}

//abstracted class for people who are non-lead non-servers
public class Assistant : Employee {
	Assistant(bool[] availability, bool bistro) {
		Availability = availability;
		Availability = availability;
		Bistro = bistro;
	}
}