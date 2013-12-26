using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FISCA.Data;

namespace AccessControlCard
{
    public partial class frmQuerySMS : FISCA.Presentation.Controls.BaseForm
    {
        public frmQuerySMS()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (dteEnd.Value < dteStart.Value)
                MessageBox.Show("結束日期必須大於等於開始日期！");

            QueryHelper helper = new QueryHelper();

            string strSQL = "select student.student_number,student.name,to_char(send_time,'YYYY/MM/DD') as send_time,target_phone,sms_content, $sms.queue.status,$access_control_card.student_cardno.card_no from  $sms.queue inner join student on student.id=$sms.queue.target_id inner join $access_control_card.student_cardno on $access_control_card.student_cardno.ref_student_id=$sms.queue.target_id inner join $access_control_card.history on  $access_control_card.history.guid=$sms.queue.guid where target_type='S' and use_time>='" + dteStart.Value.ToShortDateString() + "' and use_time<='" + dteEnd.Value.AddDays(1).ToShortDateString() + "'";

            DataTable table = helper.Select(strSQL);

            BindingList<SMSRecord> StudentCards = new BindingList<SMSRecord>();

            foreach (DataRow row in table.Rows)
            {
                SMSRecord vStudentCard = new SMSRecord(row);
                StudentCards.Add(vStudentCard);
            }

            grdSMSQueqe.DataSource = StudentCards;
        }

        private void QuerySMS_Load(object sender, EventArgs e)
        {
            dteStart.Value = DateTime.Now;
            dteEnd.Value = DateTime.Now;
        }

        /// <summary>
        /// 匯出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "查詢門禁簡訊發送記錄";
            saveFileDialog1.Filter = "Excel (*.xls)|*.xls";
            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            DataGridViewExport export = new DataGridViewExport(grdSMSQueqe);
            export.Save(saveFileDialog1.FileName);

            if (new CompleteForm().ShowDialog() == DialogResult.Yes)
                System.Diagnostics.Process.Start(saveFileDialog1.FileName);
        }

        /// <summary>
        /// 離開
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}