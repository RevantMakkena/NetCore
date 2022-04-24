using CityInfo.API.Models;

namespace CityInfo.API
{
    //Single pattern 
    public class CitiesDataSTore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataSTore current { get; } = new CitiesDataSTore();

        public CitiesDataSTore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto() { Id = 1, Name = "Texas City", Description = "The one" },
                new CityDto() { Id = 2, Name = "NY City", Description="The two"},
                new CityDto() { Id = 3, Name ="Denver City", Description ="The one with the snow"}

            };
        }
    }
}
