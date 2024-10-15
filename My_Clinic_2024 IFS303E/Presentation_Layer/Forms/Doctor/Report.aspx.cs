﻿using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace My_Clinic_2024_IFS303E.Presentation_Layer.Forms.Doctor
{
    public partial class Report : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-FMQLGT3P\\SQLEXPRESS;Initial Catalog=MyClinic;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPatientInfoReport_Click(object sender, EventArgs e)
        {
            LoadReport("PatientInfo");
        }

        protected void btnAppointmentsReport_Click(object sender, EventArgs e)
        {
            LoadReport("Appointments");
        }
        private void LoadReport(string reportType)
        {
            string query = "";

            if (reportType == "PatientInfo")
            {
                query = "SELECT FirstName, LastName, Email, City, DateOfBirth, Sex  FROM Patients";
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Presentation_Layer/Forms/Reports/PatientInfo.rdlc");
            }
            else if (reportType == "Appointments")
            {
                query = "SELECT PatientName, AppointmentDate, Category, PhoneNumber, Gender FROM Appointments"; // Replace with actual query for Revenue Report
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Presentation_Layer/Forms/Reports/AppointmentsReport.rdlc");
            }
            else if (reportType == "Emergency")
            {
                query = "SELECT PatientName, PatientAge, RequestDate, Status FROM AmbulanceRequests"; // Replace with actual query for Emergency Report
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Presentation_Layer/Forms/Reports/Emergency.rdlc");
            }
            else if (reportType == "Doctor")
            {
                query = "SELECT FirstName, LastName, Specialty, PhoneNumber FROM Doctors"; // Replace with actual query for Doctor Report
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Presentation_Layer/Forms/Reports/Doctors.rdlc");
            }

            SqlCommand c = new SqlCommand(query, con);
            SqlDataAdapter s = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            s.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                // Log or display a message indicating no data was returned
                Response.Write("No data found found.");
                return;
            }

            ReportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            ReportViewer1.LocalReport.DataSources.Add(rds);
            ReportViewer1.LocalReport.Refresh();
        }

        protected void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Presentation_Layer/Forms/Doctor/Dashboard.aspx");
        }
    }
}