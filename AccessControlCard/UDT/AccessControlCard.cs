
namespace AccessControlCard
{
    [FISCA.UDT.TableName("access_control_card.student_cardno")]
    public class AccessControlCard : FISCA.UDT.ActiveRecord
    {
        [FISCA.UDT.Field(Field="ref_student_id")]
        public int RefStudentID { get; set;}

        [FISCA.UDT.Field(Field="card_no",Indexed=true)]
        public string CardNo { get; set;}
    }
}