// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1
{

    /// <summary>
    /// An EphemeralContainer is a container that may be added temporarily to an existing pod for user-initiated activities such as debugging. Ephemeral containers have no resource or scheduling guarantees, and they will not be restarted when they exit or when a pod is removed or restarted. If an ephemeral container causes a pod to exceed its resource allocation, the pod may be evicted. Ephemeral containers may not be added by directly updating the pod spec. They must be added via the pod's ephemeralcontainers subresource, and they will appear in the pod spec once added. This is an alpha feature enabled by the EphemeralContainers feature flag.
    /// </summary>
    [OutputType]
    public sealed class EphemeralContainer
    {
        /// <summary>
        /// Arguments to the entrypoint. The docker image's CMD is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        /// </summary>
        public readonly ImmutableArray<string> Args;
        /// <summary>
        /// Entrypoint array. Not executed within a shell. The docker image's ENTRYPOINT is used if this is not provided. Variable references $(VAR_NAME) are expanded using the container's environment. If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Cannot be updated. More info: https://kubernetes.io/docs/tasks/inject-data-application/define-command-argument-container/#running-a-command-in-a-shell
        /// </summary>
        public readonly ImmutableArray<string> Command;
        /// <summary>
        /// List of environment variables to set in the container. Cannot be updated.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1.EnvVar> Env;
        /// <summary>
        /// List of sources to populate environment variables in the container. The keys defined within a source must be a C_IDENTIFIER. All invalid keys will be reported as an event when the container is starting. When a key exists in multiple sources, the value associated with the last source will take precedence. Values defined by an Env with a duplicate key will take precedence. Cannot be updated.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1.EnvFromSource> EnvFrom;
        /// <summary>
        /// Docker image name. More info: https://kubernetes.io/docs/concepts/containers/images
        /// </summary>
        public readonly string Image;
        /// <summary>
        /// Image pull policy. One of Always, Never, IfNotPresent. Defaults to Always if :latest tag is specified, or IfNotPresent otherwise. Cannot be updated. More info: https://kubernetes.io/docs/concepts/containers/images#updating-images
        /// </summary>
        public readonly string ImagePullPolicy;
        /// <summary>
        /// Lifecycle is not allowed for ephemeral containers.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1.Lifecycle Lifecycle;
        /// <summary>
        /// Probes are not allowed for ephemeral containers.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1.Probe LivenessProbe;
        /// <summary>
        /// Name of the ephemeral container specified as a DNS_LABEL. This name must be unique among all containers, init containers and ephemeral containers.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Ports are not allowed for ephemeral containers.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1.ContainerPort> Ports;
        /// <summary>
        /// Probes are not allowed for ephemeral containers.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1.Probe ReadinessProbe;
        /// <summary>
        /// Resources are not allowed for ephemeral containers. Ephemeral containers use spare resources already allocated to the pod.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1.ResourceRequirements Resources;
        /// <summary>
        /// Optional: SecurityContext defines the security options the ephemeral container should be run with. If set, the fields of SecurityContext override the equivalent fields of PodSecurityContext.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1.SecurityContext SecurityContext;
        /// <summary>
        /// Probes are not allowed for ephemeral containers.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Core.V1.Probe StartupProbe;
        /// <summary>
        /// Whether this container should allocate a buffer for stdin in the container runtime. If this is not set, reads from stdin in the container will always result in EOF. Default is false.
        /// </summary>
        public readonly bool Stdin;
        /// <summary>
        /// Whether the container runtime should close the stdin channel after it has been opened by a single attach. When stdin is true the stdin stream will remain open across multiple attach sessions. If stdinOnce is set to true, stdin is opened on container start, is empty until the first client attaches to stdin, and then remains open and accepts data until the client disconnects, at which time stdin is closed and remains closed until the container is restarted. If this flag is false, a container processes that reads from stdin will never receive an EOF. Default is false
        /// </summary>
        public readonly bool StdinOnce;
        /// <summary>
        /// If set, the name of the container from PodSpec that this ephemeral container targets. The ephemeral container will be run in the namespaces (IPC, PID, etc) of this container. If not set then the ephemeral container is run in whatever namespaces are shared for the pod. Note that the container runtime must support this feature.
        /// </summary>
        public readonly string TargetContainerName;
        /// <summary>
        /// Optional: Path at which the file to which the container's termination message will be written is mounted into the container's filesystem. Message written is intended to be brief final status, such as an assertion failure message. Will be truncated by the node if greater than 4096 bytes. The total message length across all containers will be limited to 12kb. Defaults to /dev/termination-log. Cannot be updated.
        /// </summary>
        public readonly string TerminationMessagePath;
        /// <summary>
        /// Indicate how the termination message should be populated. File will use the contents of terminationMessagePath to populate the container status message on both success and failure. FallbackToLogsOnError will use the last chunk of container log output if the termination message file is empty and the container exited with an error. The log output is limited to 2048 bytes or 80 lines, whichever is smaller. Defaults to File. Cannot be updated.
        /// </summary>
        public readonly string TerminationMessagePolicy;
        /// <summary>
        /// Whether this container should allocate a TTY for itself, also requires 'stdin' to be true. Default is false.
        /// </summary>
        public readonly bool Tty;
        /// <summary>
        /// volumeDevices is the list of block devices to be used by the container.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1.VolumeDevice> VolumeDevices;
        /// <summary>
        /// Pod volumes to mount into the container's filesystem. Cannot be updated.
        /// </summary>
        public readonly ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1.VolumeMount> VolumeMounts;
        /// <summary>
        /// Container's working directory. If not specified, the container runtime's default will be used, which might be configured in the container image. Cannot be updated.
        /// </summary>
        public readonly string WorkingDir;

        [OutputConstructor]
        private EphemeralContainer(
            ImmutableArray<string> args,

            ImmutableArray<string> command,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1.EnvVar> env,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1.EnvFromSource> envFrom,

            string image,

            string imagePullPolicy,

            Pulumi.Kubernetes.Types.Outputs.Core.V1.Lifecycle lifecycle,

            Pulumi.Kubernetes.Types.Outputs.Core.V1.Probe livenessProbe,

            string name,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1.ContainerPort> ports,

            Pulumi.Kubernetes.Types.Outputs.Core.V1.Probe readinessProbe,

            Pulumi.Kubernetes.Types.Outputs.Core.V1.ResourceRequirements resources,

            Pulumi.Kubernetes.Types.Outputs.Core.V1.SecurityContext securityContext,

            Pulumi.Kubernetes.Types.Outputs.Core.V1.Probe startupProbe,

            bool stdin,

            bool stdinOnce,

            string targetContainerName,

            string terminationMessagePath,

            string terminationMessagePolicy,

            bool tty,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1.VolumeDevice> volumeDevices,

            ImmutableArray<Pulumi.Kubernetes.Types.Outputs.Core.V1.VolumeMount> volumeMounts,

            string workingDir)
        {
            Args = args;
            Command = command;
            Env = env;
            EnvFrom = envFrom;
            Image = image;
            ImagePullPolicy = imagePullPolicy;
            Lifecycle = lifecycle;
            LivenessProbe = livenessProbe;
            Name = name;
            Ports = ports;
            ReadinessProbe = readinessProbe;
            Resources = resources;
            SecurityContext = securityContext;
            StartupProbe = startupProbe;
            Stdin = stdin;
            StdinOnce = stdinOnce;
            TargetContainerName = targetContainerName;
            TerminationMessagePath = terminationMessagePath;
            TerminationMessagePolicy = terminationMessagePolicy;
            Tty = tty;
            VolumeDevices = volumeDevices;
            VolumeMounts = volumeMounts;
            WorkingDir = workingDir;
        }
    }
}
