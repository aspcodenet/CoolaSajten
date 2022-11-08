namespace CoolaSajten.Services;

public class HockeyService
{
    public List<HockeyPlayer> GetAllPlayers()
    {
        return new List<HockeyPlayer>
        {
            new HockeyPlayer{ Id=1, Name="Foppa", Team="Colorado" },
            new HockeyPlayer{ Id=2, Name="Sudden", Team="Toronto" },
            new HockeyPlayer{ Id=3, Name="Lidas", Team="Detroit" },
        };
    }
}