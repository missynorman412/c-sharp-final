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
		Teams = ITeamRepository.GetTeams();
		// 1. List out the location and team name of all teams, sorted by location alphabetically, in the format "Name, Location"
			foreach((List<Team>Sort(Name(Location))
		
		
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
	Teams = GetTeams();
}

class TeamRepository : ITeamRepository {
	private Table _table;
	
	public TeamRepository(Table table) {
		this._table = table;
	}
	
	public List GetTeams() {
		return this._table;
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
		team.Id = ++this._nextTeamId;
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
	private string Name {get;set;}
	private string Location {get;set}
}

class Player {
	// Your code here
	private string FirstName{get;set;}
	private string LastName {get;set;}
	private int PlayerAge {get;set}
	private string PlayerTeam {get;set}
}
