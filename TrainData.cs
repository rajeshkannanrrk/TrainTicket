using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TrainTicketManagementSystemProject
{
    
    public class TrainData
    {
        DataAccess db = new DataAccess();
        static string[] trainId = new string[12] { "T-001-D", "T-001-N", "T-002-D", "T-002-N", "T-003-D", "T-003-N", "T-004-D", "T-004-N", "T-005-D", "T-005-N", "T-006-D", "T-006-N" };
        static string[] departingTime = new string[12] { "2:00 PM", "5:00 PM", "2:00 PM", "5:00 PM", "2:00 PM", "5:00 PM", "2:00 PM", "5:00 PM", "2:00 PM", "5:00 PM", "2:00 PM", "5:00 PM", };
        static string[] reachingTime = new string[12] { "4:00 PM", "7:00 PM", "4:00 PM", "7:00 PM", "4:00 PM", "7:00 PM", "4:00 PM", "7:00 PM", "4:00 PM", "7:00 PM", "4:00 PM", "7:00 PM", };
        static int[] business = new int[12] { 20, 20, 20, 20, 10, 10, 25, 25, 20, 20, 30, 30 };
        static int[] cabin = new int[12] { 30, 30, 30, 30, 20, 20, 30, 30, 25, 25, 40, 40 };
        static int[] first = new int[12] { 40, 40, 40, 40, 30, 30, 35, 35, 30, 30, 50, 50 };
        public static void updateTrain() {

            var sql = "select * from Train";
            var dt= DataAccess.GetDataSet(sql);
            int index = 0;
            while (index < dt.Tables[0].Rows.Count)
            {
                var q1 = "update Train set number_of_business_class_seats = " + business[index] + ", number_of_cabin_class_seats = " + cabin[index] + ", number_of_1st_class_seats = " + first[index] + "where train_id = '"+trainId[index]+"'";
                DataAccess.ExecuteUpdateQuery(q1);
                index++;
            }

            index = 0;
            var sql2 = "select * from Train_Schedule";
            var dq = DataAccess.GetDataSet(sql2);
            while (index < dq.Tables[0].Rows.Count)
            {

                var q2 = "update Train_Schedule set departing_time = '" + departingTime[index] + "', reaching_time = '" + reachingTime[index] + "' where train_id = '" + trainId[index] + "'";
                DataAccess.ExecuteUpdateQuery(q2);
                index++;
            }
        
        }

        public static void UpdateTrainSchedule(string trainId, string delay) {

            if (delay == "")
            {


            }

            else{

                string timeStart;
                string timeEnd;
                var q1 = "select * from Train_Schedule where train_id = '" + trainId + "'";
                var dt = DataAccess.GetDataSet(q1);
                timeStart = dt.Tables[0].Rows[0][3].ToString();
                timeEnd = dt.Tables[0].Rows[0][4].ToString();
                timeStart = timeStart.Replace("00", "" + delay + "");
                timeEnd = timeEnd.Replace("00", "" + delay + "");
                var q2 = "update Train_Schedule set departing_time = '" + timeStart + "', reaching_time = '" + timeEnd + "' where train_id = '" + trainId + "'";
                var q3 = "update Ticket set depart_time = '" + timeStart + "' where train_id = '" + trainId + "'";
                DataAccess.ExecuteUpdateQuery(q2);
                DataAccess.ExecuteUpdateQuery(q3);
            
            }
            
        
        }

        public static void IncreaseSeats(string trainId, int business, int cabin, int first) {

            var q1 = "update train set number_of_business_class_seats = number_of_business_class_seats+" + business + ", number_of_cabin_class_seats = number_of_cabin_class_seats+" + cabin + ", number_of_1st_class_seats = number_of_1st_class_seats+" + first + " where train_id = '" + trainId + "'";
            DataAccess.ExecuteUpdateQuery(q1);
        
        }

        
        
        
        

        
        

        
        

    }
}
