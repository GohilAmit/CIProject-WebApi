using BackEnd.DAL;
using BackEnd.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.BAL
{
    public class BALMission
    {
        private readonly DALMission _dalMission;     
        public BALMission(DALMission dalMission)
        {
            _dalMission = dalMission;
        }
        public List<Missions> MissionList()
        {
            return _dalMission.MissionList();
        }
        public string AddMission(Missions  mission)
        {
            return _dalMission.AddMission(mission);
        }       
        public Missions MissionDetailById(int id)
        {
            return _dalMission.MissionDetailById(id);
        }
        public string UpdateMission(Missions mission)
        {
            return _dalMission.UpdateMission(mission);
        }
        public string DeleteMission(int id)
        {
            return _dalMission.DeleteMission(id);
        }


        public List<Missions> ClientSideMissionList()
        {
            return _dalMission.ClientSideMissionList();
        }
        public string ApplyMission(MissionApplication missionApplication)
        {
            return _dalMission.ApplyMission(missionApplication);
        }
        public List<MissionApplication> MissionApplicationList()
        {
            return _dalMission.MissionApplicationList();
        }
    }
}
