namespace Mission10._1._1.Data
{
    public interface IBowlerRepository
    {
        IEnumerable<Bowlers> Bowlers { get; }

        IEnumerable<Teams> Teams { get; }
    }
}
