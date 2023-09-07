/*
 * Swagger Appointment managment - RTM - OpenAPI 3.1
 *
 * This is the OpenAPI 3.0 specification of Appointment managment - RTM.
 *
 * The version of the OpenAPI document: 0.1
 * Contact: mehmet-ali.asar@protonmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using AppointmentManagement.Client.Client;
using AppointmentManagement.Client.Api;
// uncomment below to import models
//using AppointmentManagement.Client.Model;

namespace AppointmentManagement.Client.Test.Api
{
    /// <summary>
    ///  Class for testing APPOINTMENTApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class APPOINTMENTApiTests : IDisposable
    {
        private APPOINTMENTApi instance;

        public APPOINTMENTApiTests()
        {
            instance = new APPOINTMENTApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of APPOINTMENTApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' APPOINTMENTApi
            //Assert.IsType<APPOINTMENTApi>(instance);
        }

        /// <summary>
        /// Test CreateAppointment
        /// </summary>
        [Fact]
        public void CreateAppointmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //APPOINTMENT APPOINTMENT = null;
            //instance.CreateAppointment(APPOINTMENT);
        }

        /// <summary>
        /// Test DeleteAppointment
        /// </summary>
        [Fact]
        public void DeleteAppointmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object appointmentID = null;
            //instance.DeleteAppointment(appointmentID);
        }

        /// <summary>
        /// Test GetAppointment
        /// </summary>
        [Fact]
        public void GetAppointmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object appointmentID = null;
            //instance.GetAppointment(appointmentID);
        }

        /// <summary>
        /// Test GetAppointments
        /// </summary>
        [Fact]
        public void GetAppointmentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAppointments();
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test ReplaceAppointment
        /// </summary>
        [Fact]
        public void ReplaceAppointmentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Object appointmentID = null;
            //APPOINTMENT APPOINTMENT = null;
            //instance.ReplaceAppointment(appointmentID, APPOINTMENT);
        }
    }
}