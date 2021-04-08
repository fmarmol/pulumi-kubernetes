// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1
{

    [OutputType]
    public sealed class ResourceRequirements
    {
        /// <summary>
        /// Limits describes the maximum amount of compute resources allowed. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
        /// </summary>
        public readonly ImmutableDictionary<string, string> Limits;
        /// <summary>
        /// Requests describes the minimum amount of compute resources required. If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
        /// </summary>
        public readonly ImmutableDictionary<string, string> Requests;

        [OutputConstructor]
        private ResourceRequirements(
            ImmutableDictionary<string, string> limits,

            ImmutableDictionary<string, string> requests)
        {
            Limits = limits;
            Requests = requests;
        }
    }
}
