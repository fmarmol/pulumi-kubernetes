// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Policy.V1
{

    /// <summary>
    /// PodDisruptionBudgetStatus represents information about the status of a PodDisruptionBudget. Status may trail the actual state of a system.
    /// </summary>
    public class PodDisruptionBudgetStatusArgs : Pulumi.ResourceArgs
    {
        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ConditionArgs>? _conditions;

        /// <summary>
        /// Conditions contain conditions for PDB. The disruption controller sets the DisruptionAllowed condition. The following are known values for the reason field (additional reasons could be added in the future): - SyncFailed: The controller encountered an error and wasn't able to compute
        ///               the number of allowed disruptions. Therefore no disruptions are
        ///               allowed and the status of the condition will be False.
        /// - InsufficientPods: The number of pods are either at or below the number
        ///                     required by the PodDisruptionBudget. No disruptions are
        ///                     allowed and the status of the condition will be False.
        /// - SufficientPods: There are more pods than required by the PodDisruptionBudget.
        ///                   The condition will be True, and the number of allowed
        ///                   disruptions are provided by the disruptionsAllowed property.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ConditionArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ConditionArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// current number of healthy pods
        /// </summary>
        [Input("currentHealthy", required: true)]
        public Input<int> CurrentHealthy { get; set; } = null!;

        /// <summary>
        /// minimum desired number of healthy pods
        /// </summary>
        [Input("desiredHealthy", required: true)]
        public Input<int> DesiredHealthy { get; set; } = null!;

        [Input("disruptedPods")]
        private InputMap<string>? _disruptedPods;

        /// <summary>
        /// DisruptedPods contains information about pods whose eviction was processed by the API server eviction subresource handler but has not yet been observed by the PodDisruptionBudget controller. A pod will be in this map from the time when the API server processed the eviction request to the time when the pod is seen by PDB controller as having been marked for deletion (or after a timeout). The key in the map is the name of the pod and the value is the time when the API server processed the eviction request. If the deletion didn't occur and a pod is still there it will be removed from the list automatically by PodDisruptionBudget controller after some time. If everything goes smooth this map should be empty for the most of the time. Large number of entries in the map may indicate problems with pod deletions.
        /// </summary>
        public InputMap<string> DisruptedPods
        {
            get => _disruptedPods ?? (_disruptedPods = new InputMap<string>());
            set => _disruptedPods = value;
        }

        /// <summary>
        /// Number of pod disruptions that are currently allowed.
        /// </summary>
        [Input("disruptionsAllowed", required: true)]
        public Input<int> DisruptionsAllowed { get; set; } = null!;

        /// <summary>
        /// total number of pods counted by this disruption budget
        /// </summary>
        [Input("expectedPods", required: true)]
        public Input<int> ExpectedPods { get; set; } = null!;

        /// <summary>
        /// Most recent generation observed when updating this PDB status. DisruptionsAllowed and other status information is valid only if observedGeneration equals to PDB's object generation.
        /// </summary>
        [Input("observedGeneration")]
        public Input<int>? ObservedGeneration { get; set; }

        public PodDisruptionBudgetStatusArgs()
        {
        }
    }
}
