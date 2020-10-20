using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPages_EventMaker.Models
{
    public class FakeEventRepository
    {
        public List<Event> Events { get; set; }

        public FakeEventRepository()
        {
            Events = new List<Event>()
            {
                new Event(){Id=1, Name="Roskilde Festival", City="Roskilde" , Description="lot of music" , DateTime = new DateTime(2020,6,9,10,2,2)},
                new Event(){Id=2, Name="CPH Distortion", City="CPH" , Description="lot of music" , DateTime = new DateTime(2020,6,9,10,2,2)},
                new Event(){Id=3, Name="CPH Marathon", City="Slagelse" , Description="lot of music" , DateTime = new DateTime(2020,6,9,10,2,2)},
                new Event(){Id=4, Name="Demo day", City="Korsor" , Description="lot of music" , DateTime = new DateTime(2020,6,9,10,2,2)},
                new Event(){Id=5, Name="Festival 1", City="alborg" , Description="lot of music" , DateTime = new DateTime(2020,6,9,10,2,2)},
                new Event(){Id=6, Name="Festival 2", City="Roskilde" , Description="lot of music" , DateTime = new DateTime(2020,6,9,10,2,2)},
            };
        }

        public List<Event> GetAllEvents()
        {
            return Events;
        }
    }
}
