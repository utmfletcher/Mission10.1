﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission10._1._1.Data;

namespace Mission10._1._1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlerController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlerController(IBowlerRepository temp) { 
            _bowlerRepository = temp;
        
        }

        [HttpGet]
        public IEnumerable<object> Get()
        {
            var joinedData = from Bowlers in _bowlerRepository.Bowlers
                             join Teams in _bowlerRepository.Teams on Bowlers.TeamID equals Teams.TeamID
                             select new JoinedBowler
                             {
                                 BowlerMiddleInit = Bowlers.BowlerMiddleInit,
                                 BowlerAddress = Bowlers.BowlerAddress,
                                 BowlerCity = Bowlers.BowlerCity,
                                 BowlerID = Bowlers.BowlerID,
                                 BowlerLastName = Bowlers.BowlerLastName,
                                 BowlerFirstName = Bowlers.BowlerFirstName,
                                 BowlerState = Bowlers.BowlerState,
                                 BowlerZip = Bowlers.BowlerZip,
                                 BowlerPhoneNumber = Bowlers.BowlerPhoneNumber,
                                 TeamID = Bowlers.TeamID,
                                 TeamName = Teams.TeamName
                             };

           
            return joinedData.Where(data => data.TeamName == "Marlins" || data.TeamName == "Sharks").ToList();

        }
    }
}
