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

        // Single design pattern 
        private static FakeEventRepository _instance;
        public static FakeEventRepository Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new FakeEventRepository();
                }
                return _instance;
            }
        }

        // Get all Events function 
        public List<Event> GetAllEvents()
        {
            return Events;
        }
        // Add New Events 
        public void AddEvents(Event ev)
        {
            List<int> eventId = new List<int>();
            foreach(var evt in Events)
            {
                eventId.Add(evt.Id);
            }
            if(eventId.Count != 0)
            {
                int inc = eventId.Max() + 1;
                ev.Id = inc; 
            }
            else
            {
                ev.Id = 1;
            }
            Events.Add(ev);
        }

        // Get Event By Id
        public Event GetEvent(int id)
        {
            foreach(var v in Events)
            {
                if(v.Id == id)
                {
                    return v;
                }
            }
            return new Event();
        }

        // Update Events

        public void UpdateEvent(Event @event)
        {
            if(@event != null)
            {
                foreach(var evt in Events)
                {
                    if(evt.Id == @event.Id)
                    {
                        evt.Id = @event.Id;
                        evt.Name = @event.Name;
                        evt.City = @event.City;
                        evt.Description = @event.Description;
                        evt.DateTime = @event.DateTime;
                    }
                }
            }
        }

        public void DeleteEvent(Event evt)
        {
            if(evt != null)
            {
                Events.Remove(evt);
            }
        }
    }
}
