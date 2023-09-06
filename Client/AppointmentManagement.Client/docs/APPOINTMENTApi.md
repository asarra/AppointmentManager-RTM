# AppointmentManagement.Client.Api.APPOINTMENTApi

All URIs are relative to *http://localhost:3001/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAppointment**](APPOINTMENTApi.md#createappointment) | **POST** /appointments | Create a new appointment |
| [**DeleteAppointment**](APPOINTMENTApi.md#deleteappointment) | **DELETE** /appointments/{AppointmentID} | Delete a single appointment |
| [**GetAppointment**](APPOINTMENTApi.md#getappointment) | **GET** /appointments/{AppointmentID} | Get a single appointment |
| [**GetAppointments**](APPOINTMENTApi.md#getappointments) | **GET** /appointments | Get all appointments |
| [**ReplaceAppointment**](APPOINTMENTApi.md#replaceappointment) | **PUT** /appointments/{AppointmentID} | Replace a single appointment |

<a id="createappointment"></a>
# **CreateAppointment**
> void CreateAppointment (APPOINTMENT APPOINTMENT)

Create a new appointment

Create a new appointment by Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AppointmentManagement.Client.Api;
using AppointmentManagement.Client.Client;
using AppointmentManagement.Client.Model;

namespace Example
{
    public class CreateAppointmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3001/api/v3";
            // Configure OAuth2 access token for authorization: appointmentmanagement_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new APPOINTMENTApi(config);
            var APPOINTMENT = new APPOINTMENT(); // APPOINTMENT | 

            try
            {
                // Create a new appointment
                apiInstance.CreateAppointment(APPOINTMENT);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APPOINTMENTApi.CreateAppointment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAppointmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new appointment
    apiInstance.CreateAppointmentWithHttpInfo(APPOINTMENT);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APPOINTMENTApi.CreateAppointmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **APPOINTMENT** | [**APPOINTMENT**](APPOINTMENT.md) |  |  |

### Return type

void (empty response body)

### Authorization

[appointmentmanagement_auth](../README.md#appointmentmanagement_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **0** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteappointment"></a>
# **DeleteAppointment**
> void DeleteAppointment (Object appointmentID)

Delete a single appointment

Delete a single appointment by Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AppointmentManagement.Client.Api;
using AppointmentManagement.Client.Client;
using AppointmentManagement.Client.Model;

namespace Example
{
    public class DeleteAppointmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3001/api/v3";
            // Configure OAuth2 access token for authorization: appointmentmanagement_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new APPOINTMENTApi(config);
            var appointmentID = new Object(); // Object | 

            try
            {
                // Delete a single appointment
                apiInstance.DeleteAppointment(appointmentID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APPOINTMENTApi.DeleteAppointment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAppointmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a single appointment
    apiInstance.DeleteAppointmentWithHttpInfo(appointmentID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APPOINTMENTApi.DeleteAppointmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appointmentID** | [**Object**](Object.md) |  |  |

### Return type

void (empty response body)

### Authorization

[appointmentmanagement_auth](../README.md#appointmentmanagement_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Deleted the appointment |  -  |
| **0** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getappointment"></a>
# **GetAppointment**
> void GetAppointment (Object appointmentID)

Get a single appointment

Get a single appointment by Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AppointmentManagement.Client.Api;
using AppointmentManagement.Client.Client;
using AppointmentManagement.Client.Model;

namespace Example
{
    public class GetAppointmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3001/api/v3";
            // Configure OAuth2 access token for authorization: appointmentmanagement_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new APPOINTMENTApi(config);
            var appointmentID = new Object(); // Object | 

            try
            {
                // Get a single appointment
                apiInstance.GetAppointment(appointmentID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APPOINTMENTApi.GetAppointment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAppointmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a single appointment
    apiInstance.GetAppointmentWithHttpInfo(appointmentID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APPOINTMENTApi.GetAppointmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appointmentID** | [**Object**](Object.md) |  |  |

### Return type

void (empty response body)

### Authorization

[appointmentmanagement_auth](../README.md#appointmentmanagement_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **0** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getappointments"></a>
# **GetAppointments**
> Object GetAppointments ()

Get all appointments

Get all appointments as JSON

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AppointmentManagement.Client.Api;
using AppointmentManagement.Client.Client;
using AppointmentManagement.Client.Model;

namespace Example
{
    public class GetAppointmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3001/api/v3";
            // Configure OAuth2 access token for authorization: appointmentmanagement_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new APPOINTMENTApi(config);

            try
            {
                // Get all appointments
                Object result = apiInstance.GetAppointments();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APPOINTMENTApi.GetAppointments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAppointmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all appointments
    ApiResponse<Object> response = apiInstance.GetAppointmentsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APPOINTMENTApi.GetAppointmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**Object**

### Authorization

[appointmentmanagement_auth](../README.md#appointmentmanagement_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, application/xml


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="replaceappointment"></a>
# **ReplaceAppointment**
> void ReplaceAppointment (Object appointmentID, APPOINTMENT APPOINTMENT)

Replace a single appointment

Replace a single appointment by Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AppointmentManagement.Client.Api;
using AppointmentManagement.Client.Client;
using AppointmentManagement.Client.Model;

namespace Example
{
    public class ReplaceAppointmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3001/api/v3";
            // Configure OAuth2 access token for authorization: appointmentmanagement_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new APPOINTMENTApi(config);
            var appointmentID = new Object(); // Object | 
            var APPOINTMENT = new APPOINTMENT(); // APPOINTMENT | 

            try
            {
                // Replace a single appointment
                apiInstance.ReplaceAppointment(appointmentID, APPOINTMENT);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling APPOINTMENTApi.ReplaceAppointment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReplaceAppointmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replace a single appointment
    apiInstance.ReplaceAppointmentWithHttpInfo(appointmentID, APPOINTMENT);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling APPOINTMENTApi.ReplaceAppointmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **appointmentID** | [**Object**](Object.md) |  |  |
| **APPOINTMENT** | [**APPOINTMENT**](APPOINTMENT.md) |  |  |

### Return type

void (empty response body)

### Authorization

[appointmentmanagement_auth](../README.md#appointmentmanagement_auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **0** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

