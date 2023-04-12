using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HPA.Models;
using System.Data;
using System.Data.OleDb;

namespace HPA.Utility
{
    public class ADONET
    {

        public DataTable Select(string checkid)
        {

            string sql = @"SELECT  A.EMPLOYE_NO AS ""EMPLOYEE_NO"", A.id_no AS ""Idno"", LPAD(A.birth_date, 7, '0') AS ""Birthdate"" FROM emp.emp A WHERE 1 = 1 AND A.id_no = '{0}'";
            //string sql = @"SELECT  A.EMPLOYE_NO AS ""EMPLOYEE_NO"", A.id_no AS ""Idno"", LPAD(A.birth_date, 7, '0') AS ""Birthdate"" FROM emp.emp A WHERE Concat(Substr(A.id_no, '-4', '4'),Substr(A.birth_date, -4, 4)) = '{0}'";
            sql = string.Format(sql, checkid);            
            
            Oledb oledb = new Oledb();
            OleDbConnection odcnn = new OleDbConnection();
            odcnn = oledb.GetOledbConnnection("ORACLE_DB_HI", "mast");
            OleDbCommand odcmm = new OleDbCommand();
            odcmm.Connection = odcnn;
            odcmm.CommandType = CommandType.Text;
            odcmm.CommandText = sql;
            DataTable dt = new DataTable();
            OleDbDataAdapter oddad = new OleDbDataAdapter();

            try
            {
                odcnn.Open();
                oddad = new OleDbDataAdapter(odcmm);
                oddad.Fill(dt);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                oddad.Dispose();
                odcmm.Dispose();
                odcnn.Dispose();

            }
            return dt;

        }
        public void Insert(string idno, string birthdate, string stringage, string employeeno, EmpHP emphp, string systemtime)
        {
            string emp_specialid = emphp.emp_specialid.ToString();
            string emp_id = idno;
            string emp_sex = emphp.emp_sex.ToString();
            string emp_birthday = birthdate;
            string emp_age = stringage;
            string height = emphp.height.ToString();
            string weight = emphp.weight.ToString();
            string waist_circumference = emphp.waist_circumference;
            string systolic_blood_pressure = emphp.systolic_blood_pressure.ToString();
            string total_cholesterol = emphp.total_cholesterol;
            string hdl_cholesterol = emphp.hdl_cholesterol.ToString();
            string ldl_cholesterol = emphp.ldl_cholesterol.ToString();
            string triglycerides = emphp.triglycerides.ToString();
            string fasting_plasma_glucose = emphp.fasting_plasma_glucose.ToString();
            string diabetes = emphp.diabetes;
            string hypertension = emphp.hypertension;
            string smoking = emphp.smoking.ToString();
            string sql=
                        @"INSERT INTO HPA2(emp_specialid,                                                                                            " +
                        @"                emp_id,                                                                                                    " +
                        @"                emp_sex,                                                                                                   " +
                        @"                emp_birthday,                                                                                              " +
                        @"                emp_age,                                                                                                   " +
                        @"                height,                                                                                                    " +
                        @"                weight,                                                                                                    " +
                        @"                WAIST_CIRCUMFERENCE,                                                                                       " +
                        @"                systolic_blood_pressure,                                                                                   " +
                        @"                total_cholesterol,                                                                                         " +
                        @"                hdl_cholesterol,                                                                                           " +
                        @"                ldl_cholesterol,                                                                                           " +
                        @"                triglycerides,                                                                                             " +
                        @"                fasting_plasma_glucose,                                                                                    " +
                        @"                diabetes,                                                                                                  " +
                        @"                hypertension,                                                                                              " +
                        @"                smoking,                                                                                                   " +
                        @"                datetimenow)                                                                                               " +
                        @"VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}')" ;
            sql = string.Format(sql, emp_specialid, emp_id, emp_sex, emp_birthday, emp_age, height, weight, waist_circumference, systolic_blood_pressure, total_cholesterol, hdl_cholesterol, ldl_cholesterol, triglycerides, fasting_plasma_glucose, diabetes, hypertension, smoking, systemtime);

            Oledb oledb = new Oledb();
            OleDbConnection olecn = oledb.GetOledbConnnection("ORACLE_DB_HO", "ic");
            OleDbCommand olecm = new OleDbCommand();
            DataTable datatable = new DataTable();
            olecm.Connection = olecn;
            olecm.CommandType = CommandType.Text;
            olecm.CommandText = sql;

            try
            {
                olecn.Open();
                olecm.ExecuteNonQuery();
                olecn.Dispose();
                olecm.Dispose();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (olecn != null)
                {
                    olecn.Dispose();
                }
                if (olecm != null)
                {
                    olecm.Dispose();
                }
            }
         }
    }                                     
}                                         
                                          
                                          
                                          
                                          
                                          
                                          
                                          
                                          
                                          