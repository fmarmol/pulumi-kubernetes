// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Discovery.V1
{

    [OutputType]
    public sealed class EndpointConditions
    {
        /// <summary>
        /// ready indicates that this endpoint is prepared to receive traffic, according to whatever system is managing the endpoint. A nil value indicates an unknown state. In most cases consumers should interpret this unknown state as ready. For compatibility reasons, ready should never be "true" for terminating endpoints.
        /// </summary>
        public readonly bool Ready;
        /// <summary>
        /// serving is identical to ready except that it is set regardless of the terminating state of endpoints. This condition should be set to true for a ready endpoint that is terminating. If nil, consumers should defer to the ready condition. This field can be enabled with the EndpointSliceTerminatingCondition feature gate.
        /// </summary>
        public readonly bool Serving;
        /// <summary>
        /// terminating indicates that this endpoint is terminating. A nil value indicates an unknown state. Consumers should interpret this unknown state to mean that the endpoint is not terminating. This field can be enabled with the EndpointSliceTerminatingCondition feature gate.
        /// </summary>
        public readonly bool Terminating;

        [OutputConstructor]
        private EndpointConditions(
            bool ready,

            bool serving,

            bool terminating)
        {
            Ready = ready;
            Serving = serving;
            Terminating = terminating;
        }
    }
}
