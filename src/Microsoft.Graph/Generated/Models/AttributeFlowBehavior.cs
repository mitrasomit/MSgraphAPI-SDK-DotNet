using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum AttributeFlowBehavior {
        [EnumMember(Value = "FlowWhenChanged")]
        FlowWhenChanged,
        [EnumMember(Value = "FlowAlways")]
        FlowAlways,
    }
}
