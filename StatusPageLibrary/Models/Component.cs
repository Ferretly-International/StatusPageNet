/*
 * Statuspage API
 *
 * # Code of Conduct Please don't abuse the API, and please report all feature requests and issues to https://support.atlassian.com/contact  # Rate Limiting Each API token is limited to 1 request / second as measured on a 60 second rolling window. To get this limit increased, please contact us at https://support.atlassian.com/contact  Error codes 420 or 429 indicate that you have exceeded the rate limit and the request has been rejected.  # Basics  ## HTTPS It's required  ## URL Prefix In order to maintain version integrity into the future, the API is versioned. All calls currently begin with the following prefix:    https://api.statuspage.io/v1/  ## RESTful Interface Wherever possible, the API seeks to implement repeatable patterns with logical, representative URLs and descriptive HTTP verbs. Below are some examples and conventions you will see throughout the documentation.  * Collections are buckets: https://api.statuspage.io/v1/pages/asdf123/incidents.json * Elements have unique IDs: https://api.statuspage.io/v1/pages/asdf123/incidents/jklm456.json * GET will retrieve information about a collection/element * POST will create an element in a collection * PATCH will update a single element * PUT will replace a single element in a collection (rarely used) * DELETE will destroy a single element  ## Sending Data Information can be sent in the body as form urlencoded or JSON, but make sure the Content-Type header matches the body structure or the server gremlins will be angry.  All examples are provided in JSON format, however they can easily be converted to form encoding if required.  Some examples of how to convert things are below:      // JSON     {       \"incident\": {         \"name\": \"test incident\",         \"components\": [\"8kbf7d35c070\", \"vtnh60py4yd7\"]       }     }      // Form Encoded (using curl as an example):     curl -X POST https://api.statuspage.io/v1/example \\       -d \"incident[name]=test incident\" \\       -d \"incident[components][]=8kbf7d35c070\" \\       -d \"incident[components][]=vtnh60py4yd7\"  # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace StatusPageLibrary.Models
{ 
    /// <summary>
    /// Add page access groups to a component
    /// </summary>
    [DataContract]
    public partial class Component
    {
        /// <summary>
        /// Identifier for component
        /// </summary>
        /// <value>Identifier for component</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Page identifier
        /// </summary>
        /// <value>Page identifier</value>
        [DataMember(Name="page_id", EmitDefaultValue=false)]
        public string PageId { get; set; }

        /// <summary>
        /// Component Group identifier
        /// </summary>
        /// <value>Component Group identifier</value>
        [DataMember(Name="group_id", EmitDefaultValue=false)]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Is this component a group
        /// </summary>
        /// <value>Is this component a group</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public bool Group { get; set; }

        /// <summary>
        /// Display name for component
        /// </summary>
        /// <value>Display name for component</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// More detailed description for component
        /// </summary>
        /// <value>More detailed description for component</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Order the component will appear on the page
        /// </summary>
        /// <value>Order the component will appear on the page</value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public int Position { get; set; }


        /// <summary>
        /// Status of component
        /// </summary>
        /// <value>Status of component</value>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum OperationalEnum for operational
            /// </summary>
            [EnumMember(Value = "operational")]
            operational = 1,
            
            /// <summary>
            /// Enum UnderMaintenanceEnum for under_maintenance
            /// </summary>
            [EnumMember(Value = "under_maintenance")]
            under_maintenance = 2,
            
            /// <summary>
            /// Enum DegradedPerformanceEnum for degraded_performance
            /// </summary>
            [EnumMember(Value = "degraded_performance")]
            degraded_performance = 3,
            
            /// <summary>
            /// Enum PartialOutageEnum for partial_outage
            /// </summary>
            [EnumMember(Value = "partial_outage")]
            partial_outage = 4,
            
            /// <summary>
            /// Enum MajorOutageEnum for major_outage
            /// </summary>
            [EnumMember(Value = "major_outage")]
            major_outage = 5,
            
            /// <summary>
            /// Enum Empty for 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 6
        }

        /// <summary>
        /// Status of component
        /// </summary>
        /// <value>Status of component</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Should this component be showcased
        /// </summary>
        /// <value>Should this component be showcased</value>
        [DataMember(Name="showcase", EmitDefaultValue=false)]
        public bool Showcase { get; set; }

        /// <summary>
        /// Requires a special feature flag to be enabled
        /// </summary>
        /// <value>Requires a special feature flag to be enabled</value>
        [DataMember(Name="only_show_if_degraded", EmitDefaultValue=false)]
        public bool OnlyShowIfDegraded { get; set; }

        /// <summary>
        /// Requires a special feature flag to be enabled
        /// </summary>
        /// <value>Requires a special feature flag to be enabled</value>
        [DataMember(Name="automation_email", EmitDefaultValue=false)]
        public string AutomationEmail { get; set; }

        /// <summary>
        /// The date this component started being used
        /// </summary>
        /// <value>The date this component started being used</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Component {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PageId: ").Append(PageId).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Showcase: ").Append(Showcase).Append("\n");
            sb.Append("  OnlyShowIfDegraded: ").Append(OnlyShowIfDegraded).Append("\n");
            sb.Append("  AutomationEmail: ").Append(AutomationEmail).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonSerializer.Serialize(this, 
                new JsonSerializerOptions
                {
                    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                    WriteIndented = true
                });
        }
    }
}