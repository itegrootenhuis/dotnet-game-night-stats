namespace GameNight.Domain.Entities;

public class GameNight
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public DateTime DateTime { get; set; }

    public string? Group { get; set; }

    public string? Notes { get; set; }

    //public IEnumerable<Player>? Players { get; set; }

    //public IEnumerable<Game>? Games { get; set; }
}
