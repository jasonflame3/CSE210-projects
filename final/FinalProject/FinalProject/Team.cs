using System.Drawing;

class Team {
    private String _jcTeamName;
    private List<Player> _jcPlayers;
    private int _jcPoints;
    private bool _jcIsTurn;

    public Team(string jcTeamName, List<Player> jcPlayers, int jcPoints = 0, bool jcIsTurn = false){
        _jcTeamName = jcTeamName;
        _jcPlayers = jcPlayers;
        _jcPoints = jcPoints;
        _jcIsTurn = jcIsTurn;
    }

    public void addPoints(int jcPoints){
        _jcPoints =+ jcPoints;
    }
    public string jcDisplayTeam(){
        return "this is not done yet";
    }
    public bool jcGetIsTurn(){
        return _jcIsTurn;
    }
    public void jcSetIsTurn(bool jcIsTurn){
        _jcIsTurn = jcIsTurn;
    }
}