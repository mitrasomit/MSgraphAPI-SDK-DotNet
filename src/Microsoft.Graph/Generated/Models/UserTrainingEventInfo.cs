using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class UserTrainingEventInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The displayName property</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The latestTrainingStatus property</summary>
        public TrainingStatus? LatestTrainingStatus {
            get { return BackingStore?.Get<TrainingStatus?>("latestTrainingStatus"); }
            set { BackingStore?.Set("latestTrainingStatus", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The trainingAssignedProperties property</summary>
        public UserTrainingContentEventInfo TrainingAssignedProperties {
            get { return BackingStore?.Get<UserTrainingContentEventInfo>("trainingAssignedProperties"); }
            set { BackingStore?.Set("trainingAssignedProperties", value); }
        }
        /// <summary>The trainingCompletedProperties property</summary>
        public UserTrainingContentEventInfo TrainingCompletedProperties {
            get { return BackingStore?.Get<UserTrainingContentEventInfo>("trainingCompletedProperties"); }
            set { BackingStore?.Set("trainingCompletedProperties", value); }
        }
        /// <summary>The trainingUpdatedProperties property</summary>
        public UserTrainingContentEventInfo TrainingUpdatedProperties {
            get { return BackingStore?.Get<UserTrainingContentEventInfo>("trainingUpdatedProperties"); }
            set { BackingStore?.Set("trainingUpdatedProperties", value); }
        }
        /// <summary>
        /// Instantiates a new userTrainingEventInfo and sets the default values.
        /// </summary>
        public UserTrainingEventInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.userTrainingEventInfo";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserTrainingEventInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserTrainingEventInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"latestTrainingStatus", n => { LatestTrainingStatus = n.GetEnumValue<TrainingStatus>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"trainingAssignedProperties", n => { TrainingAssignedProperties = n.GetObjectValue<UserTrainingContentEventInfo>(UserTrainingContentEventInfo.CreateFromDiscriminatorValue); } },
                {"trainingCompletedProperties", n => { TrainingCompletedProperties = n.GetObjectValue<UserTrainingContentEventInfo>(UserTrainingContentEventInfo.CreateFromDiscriminatorValue); } },
                {"trainingUpdatedProperties", n => { TrainingUpdatedProperties = n.GetObjectValue<UserTrainingContentEventInfo>(UserTrainingContentEventInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<TrainingStatus>("latestTrainingStatus", LatestTrainingStatus);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<UserTrainingContentEventInfo>("trainingAssignedProperties", TrainingAssignedProperties);
            writer.WriteObjectValue<UserTrainingContentEventInfo>("trainingCompletedProperties", TrainingCompletedProperties);
            writer.WriteObjectValue<UserTrainingContentEventInfo>("trainingUpdatedProperties", TrainingUpdatedProperties);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
