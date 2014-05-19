using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DependencyInjection.Models;

namespace DependencyInjection.DAL
{
    public class FakeRepository : IEventRepository
    {
        public IList<Event> GetEvents()
        {
            var data = new List<Event>{
                new Event
                {
                    Guid = new Guid(),
                    Title = "Tytul1",
                    Description = "description1",
                    StartDate = DateTime.Now,
                },
            new Event
                {
                    Guid = new Guid(),
                    Title = "Tytul2",
                    Description = "description1",
                    StartDate = DateTime.Now.AddDays(1),
                },
            new Event
                {
                    Guid = new Guid(),
                    Title = "Tytul2",
                    Description = "description1",
                    StartDate = DateTime.Now.AddDays(2),
                },
            new Event
                {
                    Guid = new Guid(),
                    Title = "Tytul3",
                    Description = "description1",
                    StartDate = DateTime.Now.AddDays(3),
                },
            new Event
                {
                    Guid = new Guid(),
                    Title = "Tytul4",
                    Description = "description1",
                    StartDate = DateTime.Now.AddDays(4),
                },};

            return data;
        }
    }
}