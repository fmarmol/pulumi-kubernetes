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
    public sealed class ForZone
    {
        /// <summary>
        /// name represents the name of the zone.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private ForZone(string name)
        {
            Name = name;
        }
    }
}
