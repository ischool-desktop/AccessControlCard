using System;

namespace AccessControlCard
{
    [FISCA.UDT.TableName("sms.queue")]
    public class SmsQueue : FISCA.UDT.ActiveRecord
    {
        [FISCA.UDT.Field(Field="system_name")]
        public string SystemName { get; set;}

        [FISCA.UDT.Field(Field = "target_type")]
        public string TargetType { get; set; }

        [FISCA.UDT.Field(Field="target_id")]
        public int TargetID { get; set; }

        [FISCA.UDT.Field(Field="target_phone")]
        public string TargetPhone {　get; set; }

        [FISCA.UDT.Field(Field="sms_content")]
        public string SMSContent {　get; set; }

        [FISCA.UDT.Field(Field="guid")]
        public string GUID { get; set; }

        [FISCA.UDT.Field(Field="remark")]
        public string Remark { get; set;}

        [FISCA.UDT.Field(Field="send_time")]
        public DateTime SendTime { get; set; }

        [FISCA.UDT.Field(Field="status")]
        public int Status { get; set; }

        [FISCA.UDT.Field(Field="fail_message")]
        public string FailMessage { get; set; }  
    }
}