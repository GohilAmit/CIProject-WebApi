﻿using BackEnd.BAL;
using BackEnd.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientMissionController : ControllerBase
    {
        private readonly BALMission _balMission;
        ResponseResult result = new ResponseResult();        
        public ClientMissionController(BALMission balMission)
        {
            _balMission = balMission;          
        }
        [HttpGet]
        [Route("ClientSideMissionList")]
        public ResponseResult ClientSideMissionList()
        {
            try
            {
                result.Data = _balMission.ClientSideMissionList();
                result.Result = ResponseStatus.Success;
            }
            catch (Exception ex)
            {
                result.Result = ResponseStatus.Error;
                result.Message = ex.Message;
            }
            return result;
        }

        [HttpPost]
        [Route("ApplyMission")]
        public ResponseResult ApplyMission(MissionApplication missionApplication)
        {
            try
            {
                result.Data = _balMission.ApplyMission(missionApplication);
                result.Result = ResponseStatus.Success;
            }
            catch (Exception ex)
            {
                result.Result = ResponseStatus.Error;
                result.Message = ex.Message;
            }
            return result;
        }
    }
}
