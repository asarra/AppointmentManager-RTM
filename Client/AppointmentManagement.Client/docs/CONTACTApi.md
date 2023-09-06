# AppointmentManagement.Client.Api.CONTACTApi

All URIs are relative to *http://localhost:3001/api/v3*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateContact**](CONTACTApi.md#createcontact) | **POST** /contacts | Create a new contact |
| [**DeleteContact**](CONTACTApi.md#deletecontact) | **DELETE** /contacts/{ContactID} | Delete a single contact |
| [**GetContact**](CONTACTApi.md#getcontact) | **GET** /contacts/{ContactID} | Get a single contact |
| [**GetContacts**](CONTACTApi.md#getcontacts) | **GET** /contacts | Get all contacts |
| [**ReplaceContact**](CONTACTApi.md#replacecontact) | **PUT** /contacts/{ContactID} | Replace a single contact |

<a id="createcontact"></a>
# **CreateContact**
> void CreateContact (CONTACT CONTACT)

Create a new contact

Create a new contact by Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AppointmentManagement.Client.Api;
using AppointmentManagement.Client.Client;
using AppointmentManagement.Client.Model;

namespace Example
{
    public class CreateContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3001/api/v3";
            // Configure OAuth2 access token for authorization: appointmentmanagement_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CONTACTApi(config);
            var CONTACT = new CONTACT(); // CONTACT | 

            try
            {
                // Create a new contact
                apiInstance.CreateContact(CONTACT);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CONTACTApi.CreateContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a new contact
    apiInstance.CreateContactWithHttpInfo(CONTACT);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CONTACTApi.CreateContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **CONTACT** | [**CONTACT**](CONTACT.md) |  |  |

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

<a id="deletecontact"></a>
# **DeleteContact**
> void DeleteContact (Object contactID)

Delete a single contact

Delete a single contact by Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AppointmentManagement.Client.Api;
using AppointmentManagement.Client.Client;
using AppointmentManagement.Client.Model;

namespace Example
{
    public class DeleteContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3001/api/v3";
            // Configure OAuth2 access token for authorization: appointmentmanagement_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CONTACTApi(config);
            var contactID = new Object(); // Object | 

            try
            {
                // Delete a single contact
                apiInstance.DeleteContact(contactID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CONTACTApi.DeleteContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a single contact
    apiInstance.DeleteContactWithHttpInfo(contactID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CONTACTApi.DeleteContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactID** | [**Object**](Object.md) |  |  |

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
| **204** | Deleted the contact |  -  |
| **0** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcontact"></a>
# **GetContact**
> void GetContact (Object contactID)

Get a single contact

Get a single contact by Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AppointmentManagement.Client.Api;
using AppointmentManagement.Client.Client;
using AppointmentManagement.Client.Model;

namespace Example
{
    public class GetContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3001/api/v3";
            // Configure OAuth2 access token for authorization: appointmentmanagement_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CONTACTApi(config);
            var contactID = new Object(); // Object | 

            try
            {
                // Get a single contact
                apiInstance.GetContact(contactID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CONTACTApi.GetContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a single contact
    apiInstance.GetContactWithHttpInfo(contactID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CONTACTApi.GetContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactID** | [**Object**](Object.md) |  |  |

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

<a id="getcontacts"></a>
# **GetContacts**
> Object GetContacts ()

Get all contacts

Get all contacts as JSON

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AppointmentManagement.Client.Api;
using AppointmentManagement.Client.Client;
using AppointmentManagement.Client.Model;

namespace Example
{
    public class GetContactsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3001/api/v3";
            // Configure OAuth2 access token for authorization: appointmentmanagement_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CONTACTApi(config);

            try
            {
                // Get all contacts
                Object result = apiInstance.GetContacts();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CONTACTApi.GetContacts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetContactsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all contacts
    ApiResponse<Object> response = apiInstance.GetContactsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CONTACTApi.GetContactsWithHttpInfo: " + e.Message);
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
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="replacecontact"></a>
# **ReplaceContact**
> void ReplaceContact (Object contactID, CONTACT CONTACT)

Replace a single contact

Replace a single contact by Id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using AppointmentManagement.Client.Api;
using AppointmentManagement.Client.Client;
using AppointmentManagement.Client.Model;

namespace Example
{
    public class ReplaceContactExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:3001/api/v3";
            // Configure OAuth2 access token for authorization: appointmentmanagement_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CONTACTApi(config);
            var contactID = new Object(); // Object | 
            var CONTACT = new CONTACT(); // CONTACT | 

            try
            {
                // Replace a single contact
                apiInstance.ReplaceContact(contactID, CONTACT);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CONTACTApi.ReplaceContact: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReplaceContactWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replace a single contact
    apiInstance.ReplaceContactWithHttpInfo(contactID, CONTACT);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CONTACTApi.ReplaceContactWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **contactID** | [**Object**](Object.md) |  |  |
| **CONTACT** | [**CONTACT**](CONTACT.md) |  |  |

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

