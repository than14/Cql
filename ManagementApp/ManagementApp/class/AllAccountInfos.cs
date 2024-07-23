using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementApp
{
    public class AdInfos
    {
        public string aaid { get; set; }
        public string AccountName { get; set; }
        public string AccountStatus { get; set; }
        public string DisableReason { get; set; }
        public string AccountType { get; set; }
        public string AccountIsPersonal { get; set; }//
        public string stored_balance_status { get; set; }//
        public string AccountCreateTime { get; set; }
        public string currency { get; set; }
        public double balance { get; set; }//
        public double limit { get; set; }//
        public double amount_spent { get; set; }
        public double threshold { get; set; }//
        public double balance_USD { get; set; }
        public double limit_USD { get; set; }
        public double amount_spent_USD { get; set; }
        public double threshold_USD { get; set; }
        public List<string> payment_methods { get; set; }
        public bool has_extended_credit { get; set; }
        public int ad_admins { get; set; }
    }    

    public class BMInfos
    {
        public string BMid { get; set; }
        public string BMName { get; set; }
        public string BMSharingStatus { get; set; }
        public bool is_disabled_for_integrity_reasons { get; set; }
        public int BMType { get; set; }
        public string permitted_roles { get; set; }//
        public string BMCreateTime { get; set; }
        public List<string> BM_payment_methods { get; set; }
        public string business_invoices { get; set; }
        public string extendedcredits { get; set; }
        public string verification_status { get; set; }
        public List<string> owned_ad_accounts { get; set; }
        public List<string> viewable_ad_accounts { get; set; }//
        public List<string> owned_pages { get; set; }
        public List<string> business_users { get; set; }//
        public List<string> pending_users { get; set; }//
        public List<string> system_users { get; set; }//
        public string businessUserID { get; set; }//
        public bool GetSuccess { get; set; }//
    }
    public class PageInfos
    {
        public string PageID { get; set; }
        public string additional_profile_id { get; set; }//
        public string PageName { get; set; }
        public string InBMId { get; set; }//
        public int PageFollowers { get; set; }
        public bool IsProfile { get; set; }//
        public bool IsAdmin { get; set; }//
        public List<string> PageAdmins { get; set; }//
        public int VideoCount { get; set; }
        public int ReelCount { get; set; }//
        public int TotalVideoViewCount { get; set; }
        public int TotalReelViewCount { get; set; }//
        public double Adbreak60kMins { get; set; }  //// to percent
        public string AdBreakEligibilityStatus { get; set; }//
        public bool AdBreakIntegrityStatus { get; set; }//
        public string FanSubEligibilityStatus { get; set; }//
        public string ReelEligibilityStatus { get; set; }//
        public bool ReelIntegrityStatus { get; set; }//
        public bool CanAppeal { get; set; }//
        public bool HasRM { get; set; }//
        public bool HasBonus { get; set; }//
        public bool HasPerformance { get; set; }//
        public bool HasBrandCollapse { get; set; }//
        public string LinkedPayoutID { get; set; }//
        public string verification_status { get; set; }//
        public int Reach28Days { get; set; }
        public int PostCount { get; set; }
        public string TopCountry { get; set; }
        public string page_created_time { get; set; }//
        public string HasLevelUp { get; set; }//
        public bool NoViolation { get; set; }//

    }
    public class GroupInfos
    {
        public string GroupID { get; set; }
        public string GroupName { get; set; }
        public int GroupMemCount { get; set; }
        public List<string> GroupAdmin { get; set; }
        public string GroupCountry { get; set; }//

    }
    public class PayoutInfos
    {
        public string PayoutID { get; set; }
        public string PayoutName { get; set; }
        public string PayoutType { get; set; } //cn-dn
        public string PayoutStatus { get; set; }
        public string PayoutPaymentMethods { get; set; }
        public string PayoutCountry { get; set; }
        public string PayoutEmail { get; set; }
        public List<string> PayoutTransactions { get; set; }//
        public List<string> PayoutSources { get; set; }
        public List<string> PayoutAdmins { get; set; }

    }
    public class AccountInfos
    {
        public string UID { get; set; }
        public string Password { get; set; }//
        public string _2FA { get; set; }//
        public string Email { get; set; }//
        public string PassMail { get; set; }//
        public string AccountQuality { get; set; }
        public List<BMInfos> AllBmInfos { get; set; }
        public List<AdInfos> AllAdInfos { get; set; }
        public List<PageInfos> AllPageInfos { get; set; }
        public List<GroupInfos> AllGroupInfos { get; set; }
        public List<PayoutInfos> AllPayoutInfos { get; set; }
        public string FbName { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Location { get; set; }


    }
}
