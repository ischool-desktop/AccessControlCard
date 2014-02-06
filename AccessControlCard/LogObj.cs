using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace AccessControlCard
{
    class LogObj
    {
        public String Id, Name, Sms_phone, Card_no;

        public LogObj(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Name = row["name"].ToString();
            this.Sms_phone = row["sms_phone"].ToString();
            this.Card_no = row["card_no"].ToString();
        }
    }
}