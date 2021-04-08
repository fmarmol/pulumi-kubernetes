// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1
{

    /// <summary>
    /// PodSpec is a description of a pod.
    /// </summary>
    public class PodSpecArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Optional duration in seconds the pod may be active on the node relative to StartTime before the system will actively try to mark it failed and kill associated containers. Value must be a positive integer.
        /// </summary>
        [Input("activeDeadlineSeconds")]
        public Input<int>? ActiveDeadlineSeconds { get; set; }

        /// <summary>
        /// If specified, the pod's scheduling constraints
        /// </summary>
        [Input("affinity")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.AffinityArgs>? Affinity { get; set; }

        /// <summary>
        /// AutomountServiceAccountToken indicates whether a service account token should be automatically mounted.
        /// </summary>
        [Input("automountServiceAccountToken")]
        public Input<bool>? AutomountServiceAccountToken { get; set; }

        [Input("containers", required: true)]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.ContainerArgs>? _containers;

        /// <summary>
        /// List of containers belonging to the pod. Containers cannot currently be added or removed. There must be at least one container in a Pod. Cannot be updated.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.ContainerArgs> Containers
        {
            get => _containers ?? (_containers = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.ContainerArgs>());
            set => _containers = value;
        }

        /// <summary>
        /// Specifies the DNS parameters of a pod. Parameters specified here will be merged to the generated DNS configuration based on DNSPolicy.
        /// </summary>
        [Input("dnsConfig")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.PodDNSConfigArgs>? DnsConfig { get; set; }

        /// <summary>
        /// Set DNS policy for the pod. Defaults to "ClusterFirst". Valid values are 'ClusterFirstWithHostNet', 'ClusterFirst', 'Default' or 'None'. DNS parameters given in DNSConfig will be merged with the policy selected with DNSPolicy. To have DNS options set along with hostNetwork, you have to specify DNS policy explicitly to 'ClusterFirstWithHostNet'.
        /// </summary>
        [Input("dnsPolicy")]
        public Input<string>? DnsPolicy { get; set; }

        /// <summary>
        /// EnableServiceLinks indicates whether information about services should be injected into pod's environment variables, matching the syntax of Docker links. Optional: Defaults to true.
        /// </summary>
        [Input("enableServiceLinks")]
        public Input<bool>? EnableServiceLinks { get; set; }

        [Input("ephemeralContainers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.EphemeralContainerArgs>? _ephemeralContainers;

        /// <summary>
        /// List of ephemeral containers run in this pod. Ephemeral containers may be run in an existing pod to perform user-initiated actions such as debugging. This list cannot be specified when creating a pod, and it cannot be modified by updating the pod spec. In order to add an ephemeral container to an existing pod, use the pod's ephemeralcontainers subresource. This field is alpha-level and is only honored by servers that enable the EphemeralContainers feature.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.EphemeralContainerArgs> EphemeralContainers
        {
            get => _ephemeralContainers ?? (_ephemeralContainers = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.EphemeralContainerArgs>());
            set => _ephemeralContainers = value;
        }

        [Input("hostAliases")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.HostAliasArgs>? _hostAliases;

        /// <summary>
        /// HostAliases is an optional list of hosts and IPs that will be injected into the pod's hosts file if specified. This is only valid for non-hostNetwork pods.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.HostAliasArgs> HostAliases
        {
            get => _hostAliases ?? (_hostAliases = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.HostAliasArgs>());
            set => _hostAliases = value;
        }

        /// <summary>
        /// Use the host's ipc namespace. Optional: Default to false.
        /// </summary>
        [Input("hostIPC")]
        public Input<bool>? HostIPC { get; set; }

        /// <summary>
        /// Host networking requested for this pod. Use the host's network namespace. If this option is set, the ports that will be used must be specified. Default to false.
        /// </summary>
        [Input("hostNetwork")]
        public Input<bool>? HostNetwork { get; set; }

        /// <summary>
        /// Use the host's pid namespace. Optional: Default to false.
        /// </summary>
        [Input("hostPID")]
        public Input<bool>? HostPID { get; set; }

        /// <summary>
        /// Specifies the hostname of the Pod If not specified, the pod's hostname will be set to a system-defined value.
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        [Input("imagePullSecrets")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.LocalObjectReferenceArgs>? _imagePullSecrets;

        /// <summary>
        /// ImagePullSecrets is an optional list of references to secrets in the same namespace to use for pulling any of the images used by this PodSpec. If specified, these secrets will be passed to individual puller implementations for them to use. For example, in the case of docker, only DockerConfig type secrets are honored. More info: https://kubernetes.io/docs/concepts/containers/images#specifying-imagepullsecrets-on-a-pod
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.LocalObjectReferenceArgs> ImagePullSecrets
        {
            get => _imagePullSecrets ?? (_imagePullSecrets = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.LocalObjectReferenceArgs>());
            set => _imagePullSecrets = value;
        }

        [Input("initContainers")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.ContainerArgs>? _initContainers;

        /// <summary>
        /// List of initialization containers belonging to the pod. Init containers are executed in order prior to containers being started. If any init container fails, the pod is considered to have failed and is handled according to its restartPolicy. The name for an init container or normal container must be unique among all containers. Init containers may not have Lifecycle actions, Readiness probes, Liveness probes, or Startup probes. The resourceRequirements of an init container are taken into account during scheduling by finding the highest request/limit for each resource type, and then using the max of of that value or the sum of the normal containers. Limits are applied to init containers in a similar fashion. Init containers cannot currently be added or removed. Cannot be updated. More info: https://kubernetes.io/docs/concepts/workloads/pods/init-containers/
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.ContainerArgs> InitContainers
        {
            get => _initContainers ?? (_initContainers = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.ContainerArgs>());
            set => _initContainers = value;
        }

        /// <summary>
        /// NodeName is a request to schedule this pod onto a specific node. If it is non-empty, the scheduler simply schedules this pod onto that node, assuming that it fits resource requirements.
        /// </summary>
        [Input("nodeName")]
        public Input<string>? NodeName { get; set; }

        [Input("nodeSelector")]
        private InputMap<string>? _nodeSelector;

        /// <summary>
        /// NodeSelector is a selector which must be true for the pod to fit on a node. Selector which must match a node's labels for the pod to be scheduled on that node. More info: https://kubernetes.io/docs/concepts/configuration/assign-pod-node/
        /// </summary>
        public InputMap<string> NodeSelector
        {
            get => _nodeSelector ?? (_nodeSelector = new InputMap<string>());
            set => _nodeSelector = value;
        }

        [Input("overhead")]
        private InputMap<string>? _overhead;

        /// <summary>
        /// Overhead represents the resource overhead associated with running a pod for a given RuntimeClass. This field will be autopopulated at admission time by the RuntimeClass admission controller. If the RuntimeClass admission controller is enabled, overhead must not be set in Pod create requests. The RuntimeClass admission controller will reject Pod create requests which have the overhead already set. If RuntimeClass is configured and selected in the PodSpec, Overhead will be set to the value defined in the corresponding RuntimeClass, otherwise it will remain unset and treated as zero. More info: https://git.k8s.io/enhancements/keps/sig-node/20190226-pod-overhead.md This field is alpha-level as of Kubernetes v1.16, and is only honored by servers that enable the PodOverhead feature.
        /// </summary>
        public InputMap<string> Overhead
        {
            get => _overhead ?? (_overhead = new InputMap<string>());
            set => _overhead = value;
        }

        /// <summary>
        /// PreemptionPolicy is the Policy for preempting pods with lower priority. One of Never, PreemptLowerPriority. Defaults to PreemptLowerPriority if unset. This field is beta-level, gated by the NonPreemptingPriority feature-gate.
        /// </summary>
        [Input("preemptionPolicy")]
        public Input<string>? PreemptionPolicy { get; set; }

        /// <summary>
        /// The priority value. Various system components use this field to find the priority of the pod. When Priority Admission Controller is enabled, it prevents users from setting this field. The admission controller populates this field from PriorityClassName. The higher the value, the higher the priority.
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        /// <summary>
        /// If specified, indicates the pod's priority. "system-node-critical" and "system-cluster-critical" are two special keywords which indicate the highest priorities with the former being the highest priority. Any other name must be defined by creating a PriorityClass object with that name. If not specified, the pod priority will be default or zero if there is no default.
        /// </summary>
        [Input("priorityClassName")]
        public Input<string>? PriorityClassName { get; set; }

        [Input("readinessGates")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.PodReadinessGateArgs>? _readinessGates;

        /// <summary>
        /// If specified, all readiness gates will be evaluated for pod readiness. A pod is ready when all its containers are ready AND all conditions specified in the readiness gates have status equal to "True" More info: https://git.k8s.io/enhancements/keps/sig-network/0007-pod-ready%2B%2B.md
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.PodReadinessGateArgs> ReadinessGates
        {
            get => _readinessGates ?? (_readinessGates = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.PodReadinessGateArgs>());
            set => _readinessGates = value;
        }

        /// <summary>
        /// Restart policy for all containers within the pod. One of Always, OnFailure, Never. Default to Always. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle/#restart-policy
        /// </summary>
        [Input("restartPolicy")]
        public Input<string>? RestartPolicy { get; set; }

        /// <summary>
        /// RuntimeClassName refers to a RuntimeClass object in the node.k8s.io group, which should be used to run this pod.  If no RuntimeClass resource matches the named class, the pod will not be run. If unset or empty, the "legacy" RuntimeClass will be used, which is an implicit class with an empty definition that uses the default runtime handler. More info: https://git.k8s.io/enhancements/keps/sig-node/runtime-class.md This is a beta feature as of Kubernetes v1.14.
        /// </summary>
        [Input("runtimeClassName")]
        public Input<string>? RuntimeClassName { get; set; }

        /// <summary>
        /// If specified, the pod will be dispatched by specified scheduler. If not specified, the pod will be dispatched by default scheduler.
        /// </summary>
        [Input("schedulerName")]
        public Input<string>? SchedulerName { get; set; }

        /// <summary>
        /// SecurityContext holds pod-level security attributes and common container settings. Optional: Defaults to empty.  See type description for default values of each field.
        /// </summary>
        [Input("securityContext")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.PodSecurityContextArgs>? SecurityContext { get; set; }

        /// <summary>
        /// DeprecatedServiceAccount is a depreciated alias for ServiceAccountName. Deprecated: Use serviceAccountName instead.
        /// </summary>
        [Input("serviceAccount")]
        public Input<string>? ServiceAccount { get; set; }

        /// <summary>
        /// ServiceAccountName is the name of the ServiceAccount to use to run this pod. More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/
        /// </summary>
        [Input("serviceAccountName")]
        public Input<string>? ServiceAccountName { get; set; }

        /// <summary>
        /// If true the pod's hostname will be configured as the pod's FQDN, rather than the leaf name (the default). In Linux containers, this means setting the FQDN in the hostname field of the kernel (the nodename field of struct utsname). In Windows containers, this means setting the registry value of hostname for the registry key HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters to FQDN. If a pod does not have FQDN, this has no effect. Default to false.
        /// </summary>
        [Input("setHostnameAsFQDN")]
        public Input<bool>? SetHostnameAsFQDN { get; set; }

        /// <summary>
        /// Share a single process namespace between all of the containers in a pod. When this is set containers will be able to view and signal processes from other containers in the same pod, and the first process in each container will not be assigned PID 1. HostPID and ShareProcessNamespace cannot both be set. Optional: Default to false.
        /// </summary>
        [Input("shareProcessNamespace")]
        public Input<bool>? ShareProcessNamespace { get; set; }

        /// <summary>
        /// If specified, the fully qualified Pod hostname will be "&lt;hostname&gt;.&lt;subdomain&gt;.&lt;pod namespace&gt;.svc.&lt;cluster domain&gt;". If not specified, the pod will not have a domainname at all.
        /// </summary>
        [Input("subdomain")]
        public Input<string>? Subdomain { get; set; }

        /// <summary>
        /// Optional duration in seconds the pod needs to terminate gracefully. May be decreased in delete request. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). If this value is nil, the default grace period will be used instead. The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds.
        /// </summary>
        [Input("terminationGracePeriodSeconds")]
        public Input<int>? TerminationGracePeriodSeconds { get; set; }

        [Input("tolerations")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.TolerationArgs>? _tolerations;

        /// <summary>
        /// If specified, the pod's tolerations.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.TolerationArgs> Tolerations
        {
            get => _tolerations ?? (_tolerations = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.TolerationArgs>());
            set => _tolerations = value;
        }

        [Input("topologySpreadConstraints")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.TopologySpreadConstraintArgs>? _topologySpreadConstraints;

        /// <summary>
        /// TopologySpreadConstraints describes how a group of pods ought to spread across topology domains. Scheduler will schedule pods in a way which abides by the constraints. All topologySpreadConstraints are ANDed.
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.TopologySpreadConstraintArgs> TopologySpreadConstraints
        {
            get => _topologySpreadConstraints ?? (_topologySpreadConstraints = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.TopologySpreadConstraintArgs>());
            set => _topologySpreadConstraints = value;
        }

        [Input("volumes")]
        private InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.VolumeArgs>? _volumes;

        /// <summary>
        /// List of volumes that can be mounted by containers belonging to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes
        /// </summary>
        public InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.VolumeArgs> Volumes
        {
            get => _volumes ?? (_volumes = new InputList<Pulumi.Kubernetes.Types.Inputs.Core.V1.VolumeArgs>());
            set => _volumes = value;
        }

        public PodSpecArgs()
        {
        }
    }
}
