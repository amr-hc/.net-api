using Microsoft.AspNetCore.Mvc;

namespace api.DTO
{
    public class GetCategory 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<string> products { get; set; }
    }
}
