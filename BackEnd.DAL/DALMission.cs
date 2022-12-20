using BackEnd.Entity;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DAL
{
    public class DALMission
    {
        private readonly CIDbContext _cIDbContext;
        
        public DALMission(CIDbContext cIDbContext)
        {
            _cIDbContext = cIDbContext;
        }
        public List<Missions> MissionList()
        {
            List<Missions> missions = new List<Missions>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(_cIDbContext.CreateConnection().ConnectionString))
                {                    
                    missions = cnn.Query<Missions>(StoreProcedure.MissionList_Usp, null, null, true, 0, CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return missions;
        }
        public string AddMission(Missions mission)
        {
            string result = "";
            try
            {
                using(SqlConnection cnn = new SqlConnection(_cIDbContext.CreateConnection().ConnectionString))
                {
                    cnn.Open();
                    var param = new DynamicParameters();                  
                    param.Add("@MissionTitle", mission.MissionTitle);
                    param.Add("@MissionDescription", mission.MissionDescription);
                    param.Add("@MissionOrganisationName", mission.MissionOrganisationName);
                    param.Add("@MissionOrganisationDetail", mission.MissionOrganisationDetail);
                    param.Add("@CountryId", mission.CountryId);
                    param.Add("@CityId", mission.CityId);
                    param.Add("@StartDate", mission.StartDate);
                    param.Add("@EndDate", mission.EndDate);
                    param.Add("@TotalSheets", mission.TotalSheets);
                    param.Add("@RegistrationDeadLine", mission.RegistrationDeadLine);
                    param.Add("@MissionTheme", mission.MissionTheme);
                    param.Add("@MissionSkill", mission.MissionSkill);
                    param.Add("@MissionImages", mission.MissionImages);
                    param.Add("@MissionDocuments", mission.MissionDocuments);
                    param.Add("@MissionAvilability", mission.MissionAvilability);
                    result = Convert.ToString(cnn.ExecuteScalar(StoreProcedure.AddMission_Usp, param, null, 0, CommandType.StoredProcedure));
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }        
        public Missions MissionDetailById(int id)
        {
            Missions mission = new Missions();
            try
            {
                using (SqlConnection cnn = new SqlConnection(_cIDbContext.CreateConnection().ConnectionString))
                {
                    var param = new DynamicParameters();
                    param.Add("@Id", id);
                    mission = cnn.Query<Missions>(StoreProcedure.MissionDetailById_Usp, param, null, true, 0, CommandType.StoredProcedure).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return mission;
        }
        public string UpdateMission(Missions mission)
        {
            string result = "";
            try
            {
                using (SqlConnection cnn = new SqlConnection(_cIDbContext.CreateConnection().ConnectionString))
                {
                    cnn.Open();
                    var param = new DynamicParameters();
                    param.Add("@Id", mission.Id);
                    param.Add("@MissionTitle", mission.MissionTitle);
                    param.Add("@MissionDescription", mission.MissionDescription);
                    param.Add("@MissionOrganisationName", mission.MissionOrganisationName);
                    param.Add("@MissionOrganisationDetail", mission.MissionOrganisationDetail);
                    param.Add("@CountryId", mission.CountryId);
                    param.Add("@CityId", mission.CityId);
                    param.Add("@StartDate", mission.StartDate);
                    param.Add("@EndDate", mission.EndDate);
                    param.Add("@TotalSheets", mission.TotalSheets);
                    param.Add("@RegistrationDeadLine", mission.RegistrationDeadLine);
                    param.Add("@MissionTheme", mission.MissionTheme);
                    param.Add("@MissionSkill", mission.MissionSkill);
                    param.Add("@MissionImages", mission.MissionImages);
                    param.Add("@MissionDocuments", mission.MissionDocuments);
                    param.Add("@MissionAvilability", mission.MissionAvilability);
                    result = Convert.ToString(cnn.ExecuteScalar(StoreProcedure.UpdateMission_Usp, param, null, 0, CommandType.StoredProcedure));
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public string DeleteMission(int id)
        {
            try
            {
                string result = "";
                using (SqlConnection cnn = new SqlConnection(_cIDbContext.CreateConnection().ConnectionString))
                {
                    cnn.Open();
                    var param = new DynamicParameters();
                    param.Add("@Id", id);
                    result = Convert.ToString(cnn.ExecuteScalar(StoreProcedure.DeleteMission_Usp, param, null, 0, CommandType.StoredProcedure));
                    return result;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }




        public List<Missions> ClientSideMissionList()
        {
            List<Missions> clientSideMissionlist = new List<Missions>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(_cIDbContext.CreateConnection().ConnectionString))
                {
                    clientSideMissionlist = cnn.Query<Missions>(StoreProcedure.MissionListClientSide_Usp, null, null, true, 0, CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return clientSideMissionlist;
        }

        public string ApplyMission(MissionApplication missionApplication)
        {
            string result = "";
            try
            {
                using (SqlConnection cnn = new SqlConnection(_cIDbContext.CreateConnection().ConnectionString))
                {
                    cnn.Open();
                    var param = new DynamicParameters();
                    param.Add("@MissionId", missionApplication.MissionId);
                    param.Add("@UserId", missionApplication.UserId);
                    param.Add("@AppliedDate", missionApplication.AppliedDate);
                    param.Add("@Status", missionApplication.Status);                            
                    param.Add("@Sheet", missionApplication.Sheet);                            
                    result = Convert.ToString(cnn.ExecuteScalar(StoreProcedure.ApplyMission_Usp, param, null, 0, CommandType.StoredProcedure));
                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public List<MissionApplication> MissionApplicationList()
        {
            List<MissionApplication> missionApplicationList = new List<MissionApplication>();
            try
            {
                using (SqlConnection cnn = new SqlConnection(_cIDbContext.CreateConnection().ConnectionString))
                {
                    missionApplicationList = cnn.Query<MissionApplication>(StoreProcedure.MissionApplicationList_Usp, null, null, true, 0, CommandType.StoredProcedure).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return missionApplicationList;
        }
    }
}
