using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class NotificationMessageTemplate : Entity, IParsable {
        /// <summary>The Message Template Branding Options. Branding is defined in the Intune Admin Console. Possible values are: none, includeCompanyLogo, includeCompanyName, includeContactInformation.</summary>
        public NotificationTemplateBrandingOptions? BrandingOptions { get; set; }
        /// <summary>The default locale to fallback onto when the requested locale is not available.</summary>
        public string DefaultLocale { get; set; }
        /// <summary>Display name for the Notification Message Template.</summary>
        public string DisplayName { get; set; }
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The list of localized messages for this Notification Message Template.</summary>
        public List<LocalizedNotificationMessage> LocalizedNotificationMessages { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new NotificationMessageTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NotificationMessageTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"brandingOptions", n => { BrandingOptions = n.GetEnumValue<NotificationTemplateBrandingOptions>(); } },
                {"defaultLocale", n => { DefaultLocale = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"localizedNotificationMessages", n => { LocalizedNotificationMessages = n.GetCollectionOfObjectValues<LocalizedNotificationMessage>(LocalizedNotificationMessage.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<NotificationTemplateBrandingOptions>("brandingOptions", BrandingOptions);
            writer.WriteStringValue("defaultLocale", DefaultLocale);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<LocalizedNotificationMessage>("localizedNotificationMessages", LocalizedNotificationMessages);
        }
    }
}
