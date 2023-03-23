using StreetApi.Models;

namespace StreetApi
{
    public class StreetRepository : IStreetRepository
    {
        private string path = ".\\Content\\Data\\A370715.txt";
        public StreetRepository()
        {
            StreamReader reader = new StreamReader(path);
            
            using (var context = new ApiContext())
            {
                var streets = new List<StreetItem>();
                while (reader.Peek() != -1)
                {
                    string line = reader.ReadLine();
                    string recordType = line.Substring(0, 3);
                    if (recordType == "001")
                    {
                        streets.Add(new StreetItem
                        {
                            Id = Int32.Parse(line.Substring(3, 8)),
                            KommuneKode = short.Parse(line.Substring(3, 4)),
                            VejKode = short.Parse(line.Substring(7, 4)),
                            VejNavn = line.Substring(71, 40)
                        });
                    }
                }
                context.StreetItems.AddRange(streets);
                context.SaveChanges();
            }
        }
        public List<StreetItem> GetAll()
        {
            
            using (var context = new ApiContext())
            {
                var list = context.StreetItems.ToList();
                return list;
            }
        }
    }
}
