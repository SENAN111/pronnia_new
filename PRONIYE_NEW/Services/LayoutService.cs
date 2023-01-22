using PRONIYE_NEW.DAL;

namespace PRONIYE_NEW.Services
{
    public class LayoutService
    {
        readonly AppDbContext _context;
        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public Dictionary<string, string> GetSettings()
        {
            return _context.Settings.ToDictionary(s => s.Key, s => s.Value);
        }
    }
}
