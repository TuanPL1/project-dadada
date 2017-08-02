using System;
using System.Linq;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Data
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider applicationServices)
        {
            using (var serviceScope = applicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var db = applicationServices.GetService<RemovalistContext>())
                {
                    db.Database.EnsureCreated();
                    
                    //if (db.JobDetailses.Any())
                    //{
                    //    return;   
                    //}

                    //var jobs = new[]
                    //{
                    //    new JobDetails{Notes= "test1"},
                    //};
                    //foreach (var s in jobs)
                    //{
                    //    db.JobDetailses.Add(s);
                    //}
                    //db.SaveChanges();
                }
            }
            
        }
    }
}