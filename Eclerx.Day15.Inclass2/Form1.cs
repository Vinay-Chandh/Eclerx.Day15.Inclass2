using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Eclerx.Day15.Inclass2
{
    public partial class Form1 : Form
    {

        private SqlConnection con = null;
        private SqlDataAdapter adapter = null;
        private DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }
        private void RefreshTable()
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRSQL"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department", con))
                {
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");
                    GridDepartment.DataSource = ds.Tables["Department"];
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.RefreshTable();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            this.RefreshTable();
        }

        private void BtnAddNew_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRSQL"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);//This is will generate Insert, Update or Delete Command
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");
                    //Create new row in the dataset
                    DataRow dr = ds.Tables["Department"].NewRow();
                    dr["cDepartmentCode"] = TxtDeptCode.Text;
                    dr["vDepartmentName"] = TxtDeptName.Text;
                    dr["vDepartmentHead"] = TxtDeptHead.Text;
                    dr["vLocation"] = TxtLocation.Text;
                    //Add data row to dataset
                    ds.Tables["Department"].Rows.Add(dr);
                    //Updating Dataset to Database
                    adapter.Update(ds, "Department");
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRSQL"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department WHERE cDepartmentCode = " + TxtDeptCode.Text, con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);//This is will generate Insert, Update or Delete Command
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");
                    //DataColumn[] dc = new DataColumn[1];
                    //dc[0] = ds.Tables["Department"].Columns["cDepartmentCode"];
                    //ds.Tables["Department"].PrimaryKey = dc;
                    //DataRow dr = ds.Tables["Department"].Rows.Find(TxtDeptCode.Text);
                    //dr["cDepartmentCode"] = TxtDeptCode.Text;
                    //dr["vDepartmentName"] = TxtDeptName.Text;
                    //dr["vDepartmentHead"] = TxtDeptHead.Text;
                    //dr["vLocation"] = TxtLocation.Text;

                    ds.Tables["Department"].Rows[0]["vDepartmentName"] = TxtDeptName.Text;
                    ds.Tables["Department"].Rows[0]["vDepartmentHead"] = TxtDeptHead.Text;
                    ds.Tables["Department"].Rows[0]["vLocation"] = TxtLocation.Text;

                    adapter.Update(ds, "Department");
                    adapter.Fill(ds, "Department");
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRSQL"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department", con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);//This is will generate Insert, Update or Delete Command
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");

                    //Applying Primary key
                    DataColumn[] dc = new DataColumn[1];
                    dc[0] = ds.Tables["Department"].Columns["cDepartmentCode"];
                    ds.Tables["Department"].PrimaryKey = dc;

                    //Find the Department Code from Dataset
                    DataRow dr = ds.Tables["Department"].Rows.Find(TxtDeptCode.Text);

                    //Delete the row 
                    //ds.Tables["Department"].Rows.Remove(dr);
                    dr.Delete();//Removing row using DataRow object

                    //update Dataset to Database
                    adapter.Update(ds, "Department");
                    adapter.Fill(ds, "Department");
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["HRSQL"].ConnectionString))
            {
                using (adapter = new SqlDataAdapter("Select * from Department WHERE cDepartmentCode = "+ TxtDeptCode.Text, con))
                {
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);//This is will generate Insert, Update or Delete Command
                    ds = new DataSet();
                    adapter.Fill(ds, "Department");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        TxtDeptName.Text = Convert.ToString(ds.Tables["Department"].Rows[0]["vDepartmentName"]);
                        TxtDeptHead.Text = Convert.ToString(ds.Tables["Department"].Rows[0]["vDepartmentHead"]);
                        TxtLocation.Text = Convert.ToString(ds.Tables["Department"].Rows[0]["vLocation"]);
                    }
                }
            }
        }
    }
}
