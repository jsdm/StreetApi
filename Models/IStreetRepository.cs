namespace StreetApi.Models
{
    public interface IStreetRepository
    {
        public List<StreetItem> GetAll();
    }
}
