using AdaYazilim_Case.Models;

namespace AdaYazilim_Case
{
    public class DatabaseService
    {

        private readonly DbContextCase _context;

        public DatabaseService(DbContextCase context)
        {
            _context = context;
        }

        public Train GetTrainById(int id)
        {
            var train = _context.Trains.Where(x => x.TrainId == id).FirstOrDefault();

            return train;
        }
    }
}
