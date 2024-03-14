
namespace Mission10._1._1.Data
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private  BowlerContext _BowlerContext;
        public EFBowlerRepository(BowlerContext temp) {
            _BowlerContext = temp;
        }
        public IEnumerable<Bowlers> Bowlers => _BowlerContext.Bowlers;
    }
}
