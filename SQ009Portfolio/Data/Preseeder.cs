using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using SQ009Portfolio.Data.Models;

namespace SQ009Portfolio.Data
{
    public static class Preseeder
    {
        public static void Seed(IApplicationBuilder app)
        {
            //Get db context
            var _context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<PortfolioContext>();
            if (_context.Database.GetPendingMigrations().Any())
            {
                _context.Database.Migrate();
            }

            if (_context.Users.Any())
            {
                return;
            }
            else
            {
                var path = Path.GetFullPath(@"Data/json-data/data.json");
                var jsondata = File.ReadAllText(path);
                var output = JsonSerializer.Deserialize<List<AppUser>>(jsondata, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                _context.Users.AddRange(output);
                _context.SaveChangesAsync();

                var users = _context.Users.ToListAsync().GetAwaiter().GetResult();
                foreach(var user in users)
                {
                    var apiKey = new ApiKey { AppUserId = user.Id };
                    _context.APIKeys.Add(apiKey);
                }
                _context.SaveChangesAsync().Wait();
            }
        }
    }
}
