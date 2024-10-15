﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Presentation_Layer/Forms/Doctor/Doctor.Master" AutoEventWireup="true" CodeBehind="Patients.aspx.cs" Inherits="My_Clinic_2024_IFS303E.Presentation_Layer.Forms.Doctor.Patients" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/sweetalert2@11/dist/sweetalert2.min.css">
<script src="https://cdn.jsdelivr.net/npm/sweetalert2@11/dist/sweetalert2.all.min.js"></script>
    <link href="../../Styles/DoctorPatients.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="w3-main">
    <!-- Header -->
    <header class="w3-container" style="padding-top:22px">
        <h5><b><i class="fa fa-calendar"></i> MyClinic Appointments</b></h5>
    </header>

    <!-- Appointments GridView -->
    <div class="w3-container">
        <h5>Past Appointments</h5>
        <asp:GridView ID="GridViewAppointments" runat="server" AutoGenerateColumns="False" CssClass="grid-view" >
            <Columns>
                <asp:BoundField DataField="AppointmentID" HeaderText="Appointment ID" Visible="False" />
                <asp:BoundField DataField="PatientID" HeaderText="Patient ID" Visible="False" />
                <asp:BoundField DataField="DoctorID" HeaderText="Doctor ID" Visible="False" />
                <asp:BoundField DataField="AdminID" HeaderText="Admin ID" Visible="False" />
                <asp:BoundField DataField="PatientName" HeaderText="Patient Name" />
                <asp:BoundField DataField="AppointmentDate" HeaderText="Appointment Date" DataFormatString="{0:yyyy-MM-dd}" Visible="False" />
                <asp:BoundField DataField="AppointmentTime" HeaderText="Time" Visible="False" />
                <asp:BoundField DataField="Category" HeaderText="Category" Visible="False" />
                <asp:BoundField DataField="PhoneNumber" HeaderText="Phone Number" Visible="False" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" />
                <asp:BoundField DataField="Status" HeaderText="Status" Visible="False" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button ID="btnCancel" runat="server" Text="Remove" CommandName="CancelAppointment" CssClass="w3-button w3-red" />
      
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</div>
</asp:Content>