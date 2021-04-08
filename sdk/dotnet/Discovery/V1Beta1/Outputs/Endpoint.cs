// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Discovery.V1Beta1
{

    [OutputType]
    public sealed class Endpoint
    {
        /// <summary>
        /// addresses of this endpoint. The contents of this field are interpreted according to the corresponding EndpointSlice addressType field. Consumers must handle different types of addresses in the context of their own capabilities. This must contain at least one address but no more than 100.
        /// </summary>
        public readonly ImmutableArray<string> Addresses;
        /// <summary>
        /// conditions contains information about the current status of the endpoint.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Discovery.V1Beta1.EndpointConditions Conditions;
        /// <summary>
        /// hints contains information associated with how an endpoint should be consumed.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Discovery.V1Beta1.EndpointHints Hints;
        /// <summary>
        /// hostname of this endpoint. This field may be used by consumers of endpoints to distinguish endpoints from each other (e.g. in DNS names). Multiple endpoints which use the same hostname should be considered fungible (e.g. multiple A values in DNS). Must be lowercase and pass DNS Label (RFC 1123) validation.
        /// </summary>
        public readonly string Hostname;
        /// <summary>
        /// nodeName represents the name of the Node hosting this endpoint. This can be used to determine endpoints local to a Node. This field can be enabled with the EndpointSliceNodeName feature gate.
        /// </summary>
        public readonly string NodeName;
        /// <summary>
        /// targetRef is a reference to a Kubernetes object that represents this endpoint.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1.ObjectReference TargetRef;
        /// <summary>
        /// topology contains arbitrary topology information associated with the endpoint. These key/value pairs must conform with the label format. https://kubernetes.io/docs/concepts/overview/working-with-objects/labels Topology may include a maximum of 16 key/value pairs. This includes, but is not limited to the following well known keys: * kubernetes.io/hostname: the value indicates the hostname of the node
        ///   where the endpoint is located. This should match the corresponding
        ///   node label.
        /// * topology.kubernetes.io/zone: the value indicates the zone where the
        ///   endpoint is located. This should match the corresponding node label.
        /// * topology.kubernetes.io/region: the value indicates the region where the
        ///   endpoint is located. This should match the corresponding node label.
        /// This field is deprecated and will be removed in future api versions.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Topology;

        [OutputConstructor]
        private Endpoint(
            ImmutableArray<string> addresses,

            Pulumi.Kubernetes.Types.Outputs.Discovery.V1Beta1.EndpointConditions conditions,

            Pulumi.Kubernetes.Types.Outputs.Discovery.V1Beta1.EndpointHints hints,

            string hostname,

            string nodeName,

            Pulumi.Kubernetes.Types.Outputs.Core.V1.ObjectReference targetRef,

            ImmutableDictionary<string, string> topology)
        {
            Addresses = addresses;
            Conditions = conditions;
            Hints = hints;
            Hostname = hostname;
            NodeName = nodeName;
            TargetRef = targetRef;
            Topology = topology;
        }
    }
}
