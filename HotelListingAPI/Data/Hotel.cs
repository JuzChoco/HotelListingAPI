using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListingAPI.Data
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address {  get; set; }
        public double Rating {  get; set; }


        //* Foreign Key CountryId will reference another table called Country
        [ForeignKey(nameof(CountryId))]
        public int CountryId {  get; set; }
        public Country Country { get; set; }
    }
}
