
namespace AccessControlCard
{
    [FISCA.UDT.TableName("access_control_card.setting")]
    public class Setting : FISCA.UDT.ActiveRecord
    {
        [FISCA.UDT.Field(Field="arrive_school_sms")]
        public string ArriveSchoolSMS { get; set;}

        [FISCA.UDT.Field(Field="leave_school_sms")]
        public string LeaveSchoolSMS { get; set;}

        [FISCA.UDT.Field(Field = "enable_arrive_school_sms")]
        public bool EnableArriveSchoolSMS { get; set; }

        [FISCA.UDT.Field(Field = "enable_leave_school_sms")]
        public bool EnableLeaveSchoolSMS { get; set; }

        [FISCA.UDT.Field(Field = "error_phone")]
        public string ErrorPhone { get; set; }

        [FISCA.UDT.Field(Field = "enable_error_sms")]
        public bool EnableErrorSMS { get; set;}

        [FISCA.UDT.Field(Field = "enable_auto_sms")]
        public bool EnableAutoSMS { get; set; }	
    }
}