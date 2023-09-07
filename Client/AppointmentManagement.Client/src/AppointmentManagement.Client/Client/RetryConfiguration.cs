/*
 * Swagger Appointment managment - RTM - OpenAPI 3.1
 *
 * This is the OpenAPI 3.0 specification of Appointment managment - RTM.
 *
 * The version of the OpenAPI document: 0.1
 * Contact: mehmet-ali.asar@protonmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Polly;
using RestSharp;

namespace AppointmentManagement.Client.Client
{
    /// <summary>
    /// Configuration class to set the polly retry policies to be applied to the requests.
    /// </summary>
    public static class RetryConfiguration
    {
        /// <summary>
        /// Retry policy
        /// </summary>
        public static Policy<RestResponse> RetryPolicy { get; set; }

        /// <summary>
        /// Async retry policy
        /// </summary>
        public static AsyncPolicy<RestResponse> AsyncRetryPolicy { get; set; }
    }
}