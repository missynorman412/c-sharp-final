	/*
	The purpose of this test is to evaluate your C# knowledge by gathering and displaying the information required in the Main method.
	Complete the provided questions by completing the two models and the repositories.

	Add fields to the Team and Player classes based on the information required from the problems in the 
	Main method. Also, create an instance of Table with at least three teams and at least three players each.
	
	An example of what a team could look like:
		Carolina Panthers
		[Cam Newton, Greg Olsen, Luke Kuechly, ...]
		
*/

using System.Collections.Generic;

public class Program
{	
	public static void Main()
	{
		//Create 3 teams with 3 players on each team
		//Team 1
		Table Teams = new Table();
		Team Panthers = new Team();
		Panthers.Name = "Panthers";
		Panthers.Location = "Charlotte";
		Panthers.player[0].Name = "Cam Newton";
		Panthers.player[0].Age = 28;
		Panthers.player[1].Name = "Joe Smith";
		Panthers.player[1].Age = 30;
		Panthers.player[2].Name = "Sam Sheppard";
		Panthers.player[2].Age = 35;
		Teams.AddTeam(Panthers);
		
		//Team 2
		Team Redskins = new Team();
		Redskins.Name = "Redskins";
		Redskins.Location = "Washington DC";
		Redskins.player[0].Name = "Jim Jones";
		Redskins.player[0].Age = 35;
		Redskins.player[1].Name = "Sal Yans";
		Redskins.player[1].Age = 30;
		Redskins.player[2].Name = "Barry Norman";
		Redskins.player[2].Age = 24;
		Teams.AddTeam(Redskins);
		
		//Team 3
		
		Team Bengals = new Team();
		Bengals.Name = "Bengals";
		Bengals.Location = "Cincinnati";
		Bengals.player[0].Name = "Larry Lawrence";
		Bengals.player[0].Age = 35;
		Bengals.player[1].Name = "Ben Harris";
		Bengals.player[1].Age = 30;
		Bengals.player[2].Name = "Uri Ives";
		Bengals.player[2].Age = 52;
		Teams.AddTeam(Bengals);
		// 1. List out the location and team name of all teams, sorted by location alphabetically, in the format "Name, Location"
		//Get the first team
		
		Console.WriteLine(Team=>Team(Orderby(Location)));
		
		
		// Your code here
		
		
		// 2. List all players under the age of 26 grouped by team.
		
		// Your code here
		
		// 3. Print the team name & first and last name of the oldest player on each team.
		
		// Your code here
	}
}

// The purpose of a repository is to get information stored in the Table class, which has been provided.  
// ITeamRepository should have a GetTeams method, which is implemented in the 
// TeamRepository class.

interface ITeamRepository {

	// Your code here 
	Team GetTeams(TeamRepository repo);
}

class TeamRepository : ITeamRepository
{
	private Table _table;
	
	public TeamRepository(Table table)
	{
		this._table = table;
	}
	
	public Team GetTeams(TeamRepository repo)
	{
		
		return repo._table.GetTeam(0);
		
	}
}

class Table {
	private readonly List<Team> _teams;
	private int _nextTeamId;
	
	public Table()
	{
		this._teams = new List<Team>();
		this._nextTeamId = 0;
	}
	
	public void AddTeam(Team team)
	{
		team.Id = ++this._nextTeamId;chrome://newtab/
		this._teams.Add(team);
	}
	
	public List<Team> QueryTeams() {
		return _teams;
	}
	
	public Team GetTeam(int Id){
		return _teams.Find(t => t.Id == Id);	
	}
}

class Team {
	public int Id {get;set;}
	// Your code here
	public string Name {get;set;}
	public string Location {get;set;}
	public Player[] player {get;set;}
}

class Player {
	// Your code here
	public string Name{get;set;}
	public int Age {get;set;}
	//public string PlayerTeam {get;set;}
}
