using System;

namespace AccessControlCard
{
    [FISCA.UDT.TableName("access_control_card.history")]
    public class AccessControlCardHistory : FISCA.UDT.ActiveRecord
    {
        [FISCA.UDT.Field(Field = "card_no",Indexed = true)]
        public string CardNo { get; set;}

        [FISCA.UDT.Field(Field = "oclock_name")]
        public string OClockName { get; set; }

        [FISCA.UDT.Field(Field = "use_time")]
        public DateTime UseTime { get; set; }
        
        [FISCA.UDT.Field(Field = "use_type")]
        public string UseType { get; set;}

        [FISCA.UDT.Field(Field = "guid",Indexed=true)]
        public string GUID { get; set;}

        [FISCA.UDT.Field(Field = "step2_time")]
        public DateTime Step2Time { get; set;}

        [FISCA.UDT.Field(Field = "step2_session_guid")]
        public string Step2SessionGuid { get; set;}

        [FISCA.UDT.Field(Field = "upload_time")]
        public DateTime UploadTime { get; set;}

        [FISCA.UDT.Field(Field = "upload_success")]
        public bool UploadSuccess { get; set;}

        [FISCA.UDT.Field(Field = "step4_session_guid")]
        public string Step4SessionGuid { get; set;}
    }
}