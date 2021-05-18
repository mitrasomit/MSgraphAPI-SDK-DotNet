// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Calendar.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Calendar>))]
    public partial class Calendar : Entity
    {
    
		///<summary>
		/// The Calendar constructor
		///</summary>
        public Calendar()
        {
            this.ODataType = "microsoft.graph.calendar";
        }
	
        /// <summary>
        /// Gets or sets allowed online meeting providers.
        /// Represent the online meeting service providers that can be used to create online meetings in this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.
        /// </summary>
        [JsonPropertyName("allowedOnlineMeetingProviders")]
        public IEnumerable<OnlineMeetingProviderType> AllowedOnlineMeetingProviders { get; set; }
    
        /// <summary>
        /// Gets or sets can edit.
        /// true if the user can write to the calendar, false otherwise. This property is true for the user who created the calendar. This property is also true for a user who has been shared a calendar and granted write access, through an Outlook client or the corresponding calendarPermission resource. Read-only.
        /// </summary>
        [JsonPropertyName("canEdit")]
        public bool? CanEdit { get; set; }
    
        /// <summary>
        /// Gets or sets can share.
        /// true if the user has the permission to share the calendar, false otherwise. Only the user who created the calendar can share it. Read-only.
        /// </summary>
        [JsonPropertyName("canShare")]
        public bool? CanShare { get; set; }
    
        /// <summary>
        /// Gets or sets can view private items.
        /// true if the user can read calendar items that have been marked private, false otherwise. This property is set through an Outlook client or the corresponding calendarPermission resource. Read-only.
        /// </summary>
        [JsonPropertyName("canViewPrivateItems")]
        public bool? CanViewPrivateItems { get; set; }
    
        /// <summary>
        /// Gets or sets change key.
        /// Identifies the version of the calendar object. Every time the calendar is changed, changeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.
        /// </summary>
        [JsonPropertyName("changeKey")]
        public string ChangeKey { get; set; }
    
        /// <summary>
        /// Gets or sets color.
        /// Specifies the color theme to distinguish the calendar from other calendars in a UI. The property values are: auto, lightBlue, lightGreen, lightOrange, lightGray, lightYellow, lightTeal, lightPink, lightBrown, lightRed, maxColor.
        /// </summary>
        [JsonPropertyName("color")]
        public CalendarColor? Color { get; set; }
    
        /// <summary>
        /// Gets or sets default online meeting provider.
        /// The default online meeting provider for meetings sent from this calendar. Possible values are: unknown, skypeForBusiness, skypeForConsumer, teamsForBusiness.
        /// </summary>
        [JsonPropertyName("defaultOnlineMeetingProvider")]
        public OnlineMeetingProviderType? DefaultOnlineMeetingProvider { get; set; }
    
        /// <summary>
        /// Gets or sets hex color.
        /// The calendar color, expressed in a hex color code of three hexadecimal values, each ranging from 00 to FF and representing the red, green, or blue components of the color in the RGB color space. If the user has never explicitly set a color for the calendar, this property is  empty.
        /// </summary>
        [JsonPropertyName("hexColor")]
        public string HexColor { get; set; }
    
        /// <summary>
        /// Gets or sets is default calendar.
        /// true if this is the default calendar where new events are created by default, false otherwise.
        /// </summary>
        [JsonPropertyName("isDefaultCalendar")]
        public bool? IsDefaultCalendar { get; set; }
    
        /// <summary>
        /// Gets or sets is removable.
        /// Indicates whether this user calendar can be deleted from the user mailbox.
        /// </summary>
        [JsonPropertyName("isRemovable")]
        public bool? IsRemovable { get; set; }
    
        /// <summary>
        /// Gets or sets is tallying responses.
        /// Indicates whether this user calendar supports tracking of meeting responses. Only meeting invites sent from users' primary calendars support tracking of meeting responses.
        /// </summary>
        [JsonPropertyName("isTallyingResponses")]
        public bool? IsTallyingResponses { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// The calendar name.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets owner.
        /// If set, this represents the user who created or added the calendar. For a calendar that the user created or added, the owner property is set to the user. For a calendar shared with the user, the owner property is set to the person who shared that calendar with the user. Read-only.
        /// </summary>
        [JsonPropertyName("owner")]
        public EmailAddress Owner { get; set; }
    
        /// <summary>
        /// Gets or sets calendar permissions.
        /// The permissions of the users with whom the calendar is shared.
        /// </summary>
        [JsonPropertyName("calendarPermissions")]
        public ICalendarCalendarPermissionsCollectionPage CalendarPermissions { get; set; }

        /// <summary>
        /// Gets or sets calendarPermissionsNextLink.
        /// </summary>
        [JsonPropertyName("calendarPermissions@odata.nextLink")]
        public string CalendarPermissionsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets calendar view.
        /// The calendar view for the calendar. Navigation property. Read-only.
        /// </summary>
        [JsonPropertyName("calendarView")]
        public ICalendarCalendarViewCollectionPage CalendarView { get; set; }

        /// <summary>
        /// Gets or sets calendarViewNextLink.
        /// </summary>
        [JsonPropertyName("calendarView@odata.nextLink")]
        public string CalendarViewNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets events.
        /// The events in the calendar. Navigation property. Read-only.
        /// </summary>
        [JsonPropertyName("events")]
        public ICalendarEventsCollectionPage Events { get; set; }

        /// <summary>
        /// Gets or sets eventsNextLink.
        /// </summary>
        [JsonPropertyName("events@odata.nextLink")]
        public string EventsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets multi value extended properties.
        /// The collection of multi-value extended properties defined for the calendar. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("multiValueExtendedProperties")]
        public ICalendarMultiValueExtendedPropertiesCollectionPage MultiValueExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets multiValueExtendedPropertiesNextLink.
        /// </summary>
        [JsonPropertyName("multiValueExtendedProperties@odata.nextLink")]
        public string MultiValueExtendedPropertiesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets single value extended properties.
        /// The collection of single-value extended properties defined for the calendar. Read-only. Nullable.
        /// </summary>
        [JsonPropertyName("singleValueExtendedProperties")]
        public ICalendarSingleValueExtendedPropertiesCollectionPage SingleValueExtendedProperties { get; set; }

        /// <summary>
        /// Gets or sets singleValueExtendedPropertiesNextLink.
        /// </summary>
        [JsonPropertyName("singleValueExtendedProperties@odata.nextLink")]
        public string SingleValueExtendedPropertiesNextLink { get; set; }
    
    }
}

