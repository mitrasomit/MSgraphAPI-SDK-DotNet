using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class DelegatedAdminRelationshipOperation : Entity, IParsable {
        /// <summary>The time in ISO 8601 format and in UTC time when the long-running operation was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The data (payload) for the operation. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Data {
            get { return BackingStore?.Get<string?>("data"); }
            set { BackingStore?.Set("data", value); }
        }
#nullable restore
#else
        public string Data {
            get { return BackingStore?.Get<string>("data"); }
            set { BackingStore?.Set("data", value); }
        }
#endif
        /// <summary>The time in ISO 8601 format and in UTC time when the long-running operation was last modified. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The operationType property</summary>
        public DelegatedAdminRelationshipOperationType? OperationType {
            get { return BackingStore?.Get<DelegatedAdminRelationshipOperationType?>("operationType"); }
            set { BackingStore?.Set("operationType", value); }
        }
        /// <summary>The status property</summary>
        public LongRunningOperationStatus? Status {
            get { return BackingStore?.Get<LongRunningOperationStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DelegatedAdminRelationshipOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DelegatedAdminRelationshipOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"data", n => { Data = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"operationType", n => { OperationType = n.GetEnumValue<DelegatedAdminRelationshipOperationType>(); } },
                {"status", n => { Status = n.GetEnumValue<LongRunningOperationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("data", Data);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<DelegatedAdminRelationshipOperationType>("operationType", OperationType);
            writer.WriteEnumValue<LongRunningOperationStatus>("status", Status);
        }
    }
}
