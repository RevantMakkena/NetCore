using CityInfo.API.Models;

namespace CityInfo.API
{
    //Single pattern 
    public class CitiesDataSTore
    {
        public List<CityDto> Cities { get; set; }
        public static CitiesDataSTore current { get; } = new CitiesDataSTore();

        private CitiesDataSTore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto() { Id = 1, Name = "Texas City", Description = "The one" ,
                PointsOfInterest = new List<PointsOfInterestDto>(){
                    new PointsOfInterestDto() { Id = 1, Name = "Texas City 1", Description="Hi"},
                    new PointsOfInterestDto() { Id = 2, Name = "Texas City 2", Description="Hello"},
                } },
                new CityDto() { Id = 2, Name = "NY City", Description="The two",
                    PointsOfInterest = new List<PointsOfInterestDto>(){
                    new PointsOfInterestDto() { Id = 1, Name = "NY City 1", Description="Hi"},
                    new PointsOfInterestDto() { Id = 2, Name = "NY City 2", Description="Hello"},
                }},
                new CityDto() { Id = 3, Name ="Denver City", Description ="The one with the snow",
                PointsOfInterest = new List<PointsOfInterestDto>(){
                    new PointsOfInterestDto() { Id = 1, Name = "Denver City 1", Description="Hi"},
                    new PointsOfInterestDto() { Id = 2, Name = "Denver City 2", Description="Hello"},
                }}

            };
        }
    }
}
