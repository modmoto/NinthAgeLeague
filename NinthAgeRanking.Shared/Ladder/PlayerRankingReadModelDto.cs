namespace NinthAgeCmsToArmyBook.Shared.Ladder
{
    public class PlayerRankingReadModelDto
    {
        public string Id { get; set; }
        public string IdRaw { get; set; }
        public string Name { get; set; }
        public int Wins { get; set; }
        public double WinRate { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public int Mmr { get; set; }
        public int MatchCount => Wins + Losses + Draws;
    }
}