// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Apps.V1
{

    /// <summary>
    /// StatefulSetStatus represents the current state of a StatefulSet.
    /// </summary>
    public class StatefulSetStatusArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Total number of available pods (ready for at least minReadySeconds) targeted by this statefulset. This is an alpha field and requires enabling StatefulSetMinReadySeconds feature gate. Remove omitempty when graduating to beta
        /// </summary>
        [Input("availableReplicas")]
        public Input<int>? AvailableReplicas { get; set; }

        /// <summary>
        /// collisionCount is the count of hash collisions for the StatefulSet. The StatefulSet controller uses this field as a collision avoidance mechanism when it needs to create the name for the newest ControllerRevision.
        /// </summary>
        [Input("collisionCount")]
        public Input<int>? CollisionCount { get; set; }

        [Input("conditions")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.StatefulSetConditionArgs>? _conditions;

        /// <summary>
        /// Represents the latest available observations of a statefulset's current state.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.StatefulSetConditionArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Pulumi.Kubernetes.Types.Inputs.Apps.V1.StatefulSetConditionArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// currentReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by currentRevision.
        /// </summary>
        [Input("currentReplicas")]
        public Input<int>? CurrentReplicas { get; set; }

        /// <summary>
        /// currentRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [0,currentReplicas).
        /// </summary>
        [Input("currentRevision")]
        public Input<string>? CurrentRevision { get; set; }

        /// <summary>
        /// observedGeneration is the most recent generation observed for this StatefulSet. It corresponds to the StatefulSet's generation, which is updated on mutation by the API Server.
        /// </summary>
        [Input("observedGeneration")]
        public Input<int>? ObservedGeneration { get; set; }

        /// <summary>
        /// readyReplicas is the number of Pods created by the StatefulSet controller that have a Ready Condition.
        /// </summary>
        [Input("readyReplicas")]
        public Input<int>? ReadyReplicas { get; set; }

        /// <summary>
        /// replicas is the number of Pods created by the StatefulSet controller.
        /// </summary>
        [Input("replicas", required: true)]
        public Input<int> Replicas { get; set; } = null!;

        /// <summary>
        /// updateRevision, if not empty, indicates the version of the StatefulSet used to generate Pods in the sequence [replicas-updatedReplicas,replicas)
        /// </summary>
        [Input("updateRevision")]
        public Input<string>? UpdateRevision { get; set; }

        /// <summary>
        /// updatedReplicas is the number of Pods created by the StatefulSet controller from the StatefulSet version indicated by updateRevision.
        /// </summary>
        [Input("updatedReplicas")]
        public Input<int>? UpdatedReplicas { get; set; }

        public StatefulSetStatusArgs()
        {
        }
    }
}
