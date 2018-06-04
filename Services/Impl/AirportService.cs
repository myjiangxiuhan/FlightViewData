﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using Contexts;
using Microsoft.EntityFrameworkCore;
using Models;
using Tools;

namespace Services.Impl
{
    public class AirportService : IAirportService
    {
        private readonly DataContext _context;

        public AirportService(DataContext context)
        {
            _context = context;
        }

        public async Task<int> DataUpdataAsync()
        {
            _context.RemoveRange( await _context.Airports.ToArrayAsync());
            WebClient wc = new WebClient();
            List<Airport> airports = new List<Airport>();
            string datas = await wc.DownloadStringTaskAsync(
                new Uri(@"https://raw.githubusercontent.com/jpatokal/openflights/master/data/airports.dat"));
            foreach (string data in datas.Split("\n"))
            {
                if (!string.IsNullOrWhiteSpace(data))
                {
                    string[] ss = data.SingleSplit();
                    Console.WriteLine(data);
                    airports.Add(new Airport
                    {
                        Id = ss[0].Contains(@"\N") ? 0 : Convert.ToInt32(ss[0]),
                        Name = ss[1].Contains(@"\N") ? null : ss[1],
                        City = ss[2].Contains(@"\N") ? null : ss[2],
                        Couutry = ss[3].Contains(@"\N") ? null : ss[3],
                        Iata = ss[4].Contains(@"\N") ? null : ss[4],
                        Icao = ss[5].Contains(@"\N") ? null : ss[5],
                        Latitude = ss[6].Contains(@"\N") ? (double?) null : Convert.ToDouble(ss[6]),
                        Longitude = ss[7].Contains(@"\N") ? (double?) null : Convert.ToDouble(ss[7]),
                        Altitude = ss[8].Contains(@"\N") ? (int?) null : Convert.ToInt32(ss[8]),
                        Timezone = ss[9].Contains(@"\N") ? (double?) null : Convert.ToDouble(ss[9]),
                        Dst = ss[10].Contains(@"\N") ? null : ss[10],
                        Tz = ss[11].Contains(@"\N") ? null : ss[11],
                        Type = ss[12].Contains(@"\N") ? null : ss[12],
                        Source = ss[13].Contains(@"\N") ? null : ss[13],
                    });
                }
            }

            await _context.Airports.AddRangeAsync(airports);
            return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Airport>> AllAsync()
        {
            return await _context.Airports.ToListAsync();
        }

        public async Task<IEnumerable<Airport>> SelectAsync(Expression<Func<Airport, bool>> predicate)
        {
            return await _context.Airports.Where(predicate).ToListAsync();
        }
        
        public async Task<Airport> SelectFirstAsync(Expression<Func<Airport, bool>> predicate)
        {
            return await _context.Airports.FirstAsync(predicate);
        }

        public async Task<int> UpdataAsync(params Airport[] airports)
        {
            _context.Airports.UpdateRange(airports);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> AddAsync(params Airport[] airports)
        {
            await _context.Airports.AddRangeAsync(airports);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> RemoveAsync(params Airport[] airports)
        {
            _context.Airports.RemoveRange(airports);
            return await _context.SaveChangesAsync();
        }
    }
}