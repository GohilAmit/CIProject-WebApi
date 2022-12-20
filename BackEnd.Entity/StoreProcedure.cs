using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Entity
{
    public class StoreProcedure
    {
        //Login and Register
        public const string UserRegister_Usp = "UserRegister_Usp";
        public const string UserLogin_Usp = "UserLogin_Usp";
        public const string ChangePassword_Usp = "ChangePassword_Usp";
        public const string UserDetailByUserId_Usp = "UserDetailByUserId_Usp";
        public const string UserDetailRegister_Usp = "UserDetailRegister_Usp";
        public const string GetUserProfileDetailByUserId_Usp = "GetUserProfileDetailByUserId_Usp";
        public const string UserDetailList_Usp = "UserDetailList_Usp";
        public const string DeleteUserANDUserDetail_Usp = "DeleteUserANDUserDetail_Usp";
        
        
        //CMS
        public const string AddCMS_Usp = "AddCMS_Usp";
        public const string CMSList_Usp = "CMSList_Usp";
        public const string CMSDetailById_Usp = "CMSDetailById_Usp";
        public const string UpdateCMS_Usp = "UpdateCMS_Usp";
        public const string DeleteCMS_Usp = "DeleteCMS_Usp";

        //Mission
        public const string AddMission_Usp = "AddMission_Usp";
        public const string MissionList_Usp = "MissionList_Usp";        
        public const string MissionDetailById_Usp = "MissionDetailById_Usp";
        public const string UpdateMission_Usp = "UpdateMission_Usp";
        public const string DeleteMission_Usp = "DeleteMission_Usp";
        public const string CountryWiseCityList_Usp = "CountryWiseCityList_Usp";
        public const string MissionListClientSide_Usp = "MissionListClientSide_Usp";
        public const string ApplyMission_Usp = "ApplyMission_Usp";

        //MissionApplication 
        public const string MissionApplicationList_Usp = "MissionApplicationList_Usp";

        //Story
        public const string AddStory_Usp = "AddStory_Usp";
        public const string StoryList_Usp = "StoryList_Usp";
        public const string StoryListClientSide_Usp = "StoryListClientSide_Usp";
        public const string StoryDetailById_Usp = "StoryDetailById_Usp";       
        public const string DeleteStory_Usp = "DeleteStory_Usp";
        public const string UpdateStoryActiveStatus_Usp = "UpdateStoryActiveStatus_Usp";
        public const string StoryDetailByIdAdmin_Usp = "StoryDetailByIdAdmin_Usp";


        //ContactUs
        public const string AddContactUs_Usp = "AddContactUs_Usp";
        
        //UserSkill
        public const string AddUserSkill_Usp = "AddUserSkill_Usp";
        public const string UserIdWiseSkillList_Usp = "UserIdWiseSkillList_Usp";

        //Volunteering Timesheet Hours
        public const string AddVolunteeringHours_Usp = "AddVolunteeringHours_Usp";
        public const string VolunteeringHoursList_Usp = "VolunteeringHoursList_Usp";
        public const string VolunteeringHoursDetailById_Usp = "VolunteeringHoursDetailById_Usp";
        public const string UpdateVolunteeringHours_Usp = "UpdateVolunteeringHours_Usp";
        public const string DeleteVolunteeringHours_Usp = "DeleteVolunteeringHours_Usp";

        //Volunteering Timesheet Goals
        public const string VolunteeringGoalsList_Usp = "VolunteeringGoalsList_Usp";
        public const string VolunteeringGoalsDetailById_Usp = "VolunteeringGoalsDetailById_Usp";
        public const string AddVolunteeringGoals_Usp    = "AddVolunteeringGoals_Usp";
        public const string UpdateVolunteeringGoals_Usp = "UpdateVolunteeringGoals_Usp";
        public const string DeleteVolunteeringGoals_Usp = "DeleteVolunteeringGoals_Usp";
    }
}
