using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollMgmtSystem
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_fname.Text == "")
            {
                lbl_message.Text = "Insert Employee First Name!";
            }
            else if (txt_lname.Text == "")
            {
                lbl_message.Text = "Insert Employee Last Name!";
            }
            else if (txt_nic.Text == "")
            {
                lbl_message.Text = "Insert NIC Number!";
            }
            else if (txt_eid.Text == "")
            {
                lbl_message.Text = "Insert Employee ID!";
            }
            else if (cb_dep.SelectedIndex == 0)
            {
                lbl_message.Text = "Select Department!";
            }
            else if (cb_des.SelectedIndex == 0)
            {
                lbl_message.Text = "Select Designation!";
            }
            else if (txt_add.Text == "")
            {
                lbl_message.Text = "Insert Address!";
            }
            else
            {
                dataGridView.Rows.Add(txt_fname.Text.Trim(), txt_lname.Text.Trim(), txt_nic.Text.Trim(), txt_eid.Text, cb_dep.Text, cb_des.Text.Trim(), txt_add.Text.Trim(), lbl_gender.Text.Trim(), lbl_dob.Text.Trim(), lbl_age.Text.Trim(), lbl_salary.Text.Trim(), lbl_ot.Text.Trim());
            }
        }
        
        private void txt_nic_TextChanged(object sender, EventArgs e)
        {
            if (txt_nic.Text.Trim().Length == 10)
            {
                calculate_Age();
                lbl_message.Text = "";
            }
            else
            {
                lbl_age.Text = "";
                lbl_gender.Text = "";
                lbl_message.Text = "Invalid NIC";
            }
        }

        private void cb_des_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_des.SelectedIndex > 0)
            {
                display_Salary();
            }
            else
            {
                lbl_salary.Text = "";
                lbl_ot.Text = "";
                lbl_message.Text = "Select Designation";
            }
        }

        void calculate_Age()
        {
            int digit_1 = Convert.ToInt16(txt_nic.Text.Substring(0, 2));
            string year = "19" + digit_1;
            int digit_2 = Convert.ToInt16(txt_nic.Text.Substring(2, 3));
            string month = ""; string date = ""; string BDay = "";

            if ((digit_2 > 0 && digit_2 <= 31) || digit_2 > 500 && digit_2 <= 531) //January
            {
                month = "01";
                if (digit_2 > 0 && digit_2 <= 31)
                {
                    date = "" + (digit_2 - 0);
                }
                else
                {
                    date = "" + (digit_2 - 500);
                }
                BDay = year + "/" + month + "/" + date;
                lbl_dob.Text = BDay;
            }
            else if ((digit_2 > 31 && digit_2 <= 59) || digit_2 > 531 && digit_2 <= 559) //February)
            {
                month = "02";
                if (digit_2 > 31 && digit_2 <= 59)
                {
                    date = "" + (digit_2 - 31);
                }
                else
                {
                    date = "" + (digit_2 - 531);
                }
                BDay = year + "/" + month + "/" + date;
                lbl_dob.Text = BDay;
            }
            else if ((digit_2 > 59 && digit_2 <= 90) || digit_2 > 559 && digit_2 <= 590) //March)
            {
                month = "03";
                if (digit_2 > 59 && digit_2 <= 90)
                {
                    date = "" + (digit_2 - 59);
                }
                else
                {
                    date = "" + (digit_2 - 559);
                }
                BDay = year + "/" + month + "/" + date;
                lbl_dob.Text = BDay;
            }
            else if ((digit_2 > 90 && digit_2 <= 120) || digit_2 > 590 && digit_2 <= 620) //April
            {
                month = "04";
                if (digit_2 > 90 && digit_2 <= 120)
                {
                    date = "" + (digit_2 - 90);
                }
                else
                {
                    date = "" + (digit_2 - 590);
                }
                BDay = year + "/" + month + "/" + date;
                lbl_dob.Text = BDay;
            }
            else if ((digit_2 > 120 && digit_2 <= 151) || digit_2 > 620 && digit_2 <= 651) //May
            {
                month = "05";
                if (digit_2 > 120 && digit_2 <= 151)
                {
                    date = "" + (digit_2 - 120);
                }
                else
                {
                    date = "" + (digit_2 - 620);
                }
                BDay = year + "/" + month + "/" + date;
                lbl_dob.Text = BDay;
            }
            else if ((digit_2 > 151 && digit_2 <= 181) || digit_2 > 651 && digit_2 <= 681) //June
            {
                month = "06";
                if (digit_2 > 151 && digit_2 <= 181)
                {
                    date = "" + (digit_2 - 151);
                }
                else
                {
                    date = "" + (digit_2 - 651);
                }
                BDay = year + "/" + month + "/" + date;
                lbl_dob.Text = BDay;
            }
            else if ((digit_2 > 181 && digit_2 <= 212) || digit_2 > 681 && digit_2 <= 712) //July
            {
                month = "07";
                if (digit_2 > 181 && digit_2 <= 212)
                {
                    date = "" + (digit_2 - 181);
                }
                else
                {
                    date = "" + (digit_2 - 681);
                }
                BDay = year + "/" + month + "/" + date;
                lbl_dob.Text = BDay;
            }
            else if ((digit_2 > 212 && digit_2 <= 243) || digit_2 > 712 && digit_2 <= 743) //August
            {
                month = "08";
                if (digit_2 > 212 && digit_2 <= 243)
                {
                    date = "" + (digit_2 - 212);
                }
                else
                {
                    date = "" + (digit_2 - 712);
                }
                BDay = year + "/" + month + "/" + date;
                lbl_dob.Text = BDay;
            }
            else if ((digit_2 > 243 && digit_2 <= 273) || digit_2 > 743 && digit_2 <= 773) //September
            {
                month = "09";
                if (digit_2 > 243 && digit_2 <= 273)
                {
                    date = "" + (digit_2 - 243);
                }
                else
                {
                    date = "" + (digit_2 - 743);
                }
                BDay = year + "/" + month + "/" + date;
                lbl_dob.Text = BDay;
            }
            else if ((digit_2 > 273 && digit_2 <= 304) || digit_2 > 773 && digit_2 <= 804) //October
            {
                month = "10";
                if (digit_2 > 273 && digit_2 <= 304)
                {
                    date = "" + (digit_2 - 273);
                }
                else
                {
                    date = "" + (digit_2 - 773);
                }
                BDay = year + "/" + month + "/" + date;
                lbl_dob.Text = BDay;
            }
            else if ((digit_2 > 304 && digit_2 <= 334) || digit_2 > 804 && digit_2 <= 834) //November
            {
                month = "11";
                if (digit_2 > 304 && digit_2 <= 334)
                {
                    date = "" + (digit_2 - 304);
                }
                else
                {
                    date = "" + (digit_2 - 804);
                }
                BDay = year + "/" + month + "/" + date;
                lbl_dob.Text = BDay;
            }
            else if ((digit_2 > 334 && digit_2 <= 365) || digit_2 > 834 && digit_2 <= 865) //December
            {
                month = "12";
                if (digit_2 > 334 && digit_2 <= 365)
                {
                    date = "" + (digit_2 - 334);
                }
                else
                {
                    date = "" + (digit_2 - 834);
                }
                BDay = year + "/" + month + "/" + date;
                lbl_dob.Text = BDay;
            }
            else
            {
                lbl_message.Text = "Invalid NIC Number!";
            }

            int years = -1, months = -1, days = -1;

            DateTime birthDate = Convert.ToDateTime(BDay);
            TimeSpanToDate(DateTime.Now, birthDate, out years, out months, out days);
            lbl_age.Text = years.ToString() + " years " + months.ToString() + " month(s) " + days.ToString() + " day(s)";

            Gender();
        }

        public void TimeSpanToDate(DateTime d1, DateTime d2, out int years, out int months, out int days)
        {
            // compute & return the difference of two dates,
            // returning years, months & days
            // d1 should be the larger (newest) of the two dates
            // we want d1 to be the larger (newest) date
            // flip if we need to
            if (d1 < d2)
            {
                DateTime d3 = d2;
                d2 = d1;
                d1 = d3;
            }

            // compute difference in total months
            months = 12 * (d1.Year - d2.Year) + (d1.Month - d2.Month);

            // based upon the 'days',
            // adjust months & compute actual days difference
            if (d1.Day < d2.Day)
            {
                months--;
                days = DateTime.DaysInMonth(d2.Year, d2.Month) - d2.Day + d1.Day;
            }
            else
            {
                days = d1.Day - d2.Day;
            }
            // compute years & actual months
            years = months / 12;
            months -= years * 12;
        }

        void Gender()
        {
            int digit = Convert.ToInt16(txt_nic.Text.Substring(2, 3));
            if (digit >= 0 && digit < 500)
            {
                lbl_gender.Text = "Male";
            }
            else
            {
                lbl_gender.Text = "Female";
            }
        }

        public void display_Salary()
        {
            if (cb_des.SelectedIndex > 0)
            {
                if (cb_des.Text == "Junior Executive I")
                {
                    lbl_salary.Text = "45000";
                    lbl_ot.Text = "150";
                }
                else if (cb_des.Text == "Junior Executive II")
                {
                    lbl_salary.Text = "65000";
                    lbl_ot.Text = "250";
                }
                else if (cb_des.Text == "Executive I")
                {
                    lbl_salary.Text = "85000";
                    lbl_ot.Text = "350";
                }
                else if (cb_des.Text == "Executive II")
                {
                    lbl_salary.Text = "125000";
                    lbl_ot.Text = "400";
                }
                else if (cb_des.Text == "Senior Executive I")
                {
                    lbl_salary.Text = "150000";
                    lbl_ot.Text = "0";
                }
                else if (cb_des.Text == "Senior Executive II")
                {
                    lbl_salary.Text = "175000";
                    lbl_ot.Text = "0";
                }
                else if (cb_des.Text == "Manager")
                {
                    lbl_salary.Text = "200000";
                    lbl_ot.Text = "0";
                }
                else if (cb_des.Text == "Senior Manager")
                {
                    lbl_salary.Text = "225000";
                    lbl_ot.Text = "0";
                }
                else if (cb_des.Text == "Assistant General Manager")
                {
                    lbl_salary.Text = "275000";
                    lbl_ot.Text = "0";
                }
                else if (cb_des.Text == "Deputy General Manager")
                {
                    lbl_salary.Text = "375000";
                    lbl_ot.Text = "0";
                }
                else
                {
                    lbl_salary.Text = "";
                    lbl_ot.Text = "";
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                lbl_message.Text = "Enter Employee ID";
            }
            else
            {
                RemoveEmployee();
            }
        }

        private void RemoveEmployee()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EE5OS5K\\SQLEXPRESS;Initial Catalog=PayrollManagement;Integrated Security=True");
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("Sp_delete_emp_details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@emp_no", SqlDbType.Int).Value = txt_search.Text;

                int x = cmd.ExecuteNonQuery();

                if (x > 0)
                {
                    lbl_message.Text = "Employee has removed Successfully!";
                    txt_search.Text = "";
                }
                else
                {
                    lbl_message.Text = "Operation Unuccessful!";
                }
            }
            catch (Exception ex)
            {
                lbl_message.Text = ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {

            if (dataGridView.Rows.Count > 0)
            {
                InsertIntoDB();
            }
            else
            {
                lbl_message.Text = "Add to grid first!";
            }
        }

        public void InsertIntoDB()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-EE5OS5K\\SQLEXPRESS;Initial Catalog=PayrollManagement;Integrated Security=True");
            con.Open();

            try
            {
                int x = 0;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    SqlCommand cmd = new SqlCommand("Sp_Insert_Update_emp_details", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@emp_fname", SqlDbType.VarChar).Value = row.Cells[0].Value.ToString();
                    cmd.Parameters.Add("@emp_lname", SqlDbType.VarChar).Value = row.Cells[1].Value.ToString();
                    string eno = row.Cells[3].Value.ToString();
                    cmd.Parameters.Add("@emp_no", SqlDbType.Int).Value = Convert.ToInt32(eno);
                    cmd.Parameters.Add("@emp_nic", SqlDbType.VarChar).Value = row.Cells[2].Value.ToString();
                    cmd.Parameters.Add("@emp_address", SqlDbType.VarChar).Value = row.Cells[6].Value.ToString();
                    cmd.Parameters.Add("@emp_dob", SqlDbType.VarChar).Value = row.Cells[8].Value.ToString();
                    cmd.Parameters.Add("@designation", SqlDbType.VarChar).Value = row.Cells[5].Value.ToString();
                    cmd.Parameters.Add("@despartment", SqlDbType.VarChar).Value = row.Cells[4].Value.ToString();
                    cmd.Parameters.Add("@gender", SqlDbType.VarChar).Value = row.Cells[7].Value.ToString();
                    string basic = row.Cells[10].Value.ToString();
                    string ot = row.Cells[11].Value.ToString();
                    cmd.Parameters.Add("@age", SqlDbType.VarChar).Value = row.Cells[9].Value.ToString();
                    cmd.Parameters.Add("@basic", SqlDbType.Decimal).Value = Convert.ToDecimal(basic);
                    cmd.Parameters.Add("@OT_rate", SqlDbType.Int).Value = Convert.ToInt32(ot);

                    x = cmd.ExecuteNonQuery();
                }

                if (x > 0)
                {
                    lbl_message.Text = "Employee has Added Successfully!";

                    txt_fname.Text = "";
                    txt_lname.Text = "";
                    txt_nic.Text = "";
                    txt_eid.Text = "";
                    cb_dep.SelectedIndex = 0;
                    cb_des.SelectedIndex = 0;
                    txt_add.Text = "";
                    lbl_gender.Text = "";
                    lbl_dob.Text = "";
                    lbl_age.Text = "";
                    lbl_salary.Text = "";
                    lbl_ot.Text = "";
                    dataGridView.Rows.Clear();
                }
                else
                {
                    lbl_message.Text = "Operation Unuccessful!";
                }
            }
            catch (Exception ex)
            {
                lbl_message.Text = ex.Message;
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_nic.Text = "";
            txt_eid.Text = "";
            cb_dep.SelectedIndex = 0;
            cb_des.SelectedIndex = 0;
            txt_add.Text = "";
            lbl_gender.Text = "";
            lbl_dob.Text = "";
            lbl_age.Text = "";
            lbl_salary.Text = "";
            lbl_message.Text = "";
            dataGridView.Rows.Clear();
            
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            cb_dep.SelectedIndex = 0;
            cb_des.SelectedIndex = 0;
        }
                
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txt_search.Text == "")
            {
                lbl_message.Text = "Select Employee ID";
            }
            else
            {
                SearchEmployee();
            }
        }

        public void SearchEmployee()
        {
            SqlConnection con = new SqlConnection("Data Source=Data Source=DESKTOP-EE5OS5K\\SQLEXPRESS;Initial Catalog=PayrollManagement;Integrated Security=True");
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("Sp_select_emp_details", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@emp_no", SqlDbType.Int).Value = txt_search.Text;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        dataGridView.Rows.Add(row[2].ToString(), row[1].ToString(), row[0].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString(), row[9].ToString());
                    }

                    lbl_message.Text = "Added to Grid!";
                    txt_search.Text = "";
                }
                else
                {
                    lbl_message.Text = "Operation Unuccessful!";
                }
            }
            catch (Exception ex)
            {
                lbl_message.Text = ex.Message;
            }
            finally
            {
                con.Close();
            }

        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
    }
}

