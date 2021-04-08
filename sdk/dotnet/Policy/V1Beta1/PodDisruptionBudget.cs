// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Policy.V1Beta1
{
    /// <summary>
    /// PodDisruptionBudget is an object to define the max disruption that can be caused to a collection of pods
    /// </summary>
    [KubernetesResourceType("kubernetes:policy/v1beta1:PodDisruptionBudget")]
    public partial class PodDisruptionBudget : KubernetesResource
    {
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// Specification of the desired behavior of the PodDisruptionBudget.
        /// </summary>
        [Output("spec")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Policy.V1Beta1.PodDisruptionBudgetSpec> Spec { get; private set; } = null!;

        /// <summary>
        /// Most recently observed status of the PodDisruptionBudget.
        /// </summary>
        [Output("status")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Policy.V1Beta1.PodDisruptionBudgetStatus> Status { get; private set; } = null!;


        /// <summary>
        /// Create a PodDisruptionBudget resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PodDisruptionBudget(string name, Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.PodDisruptionBudgetArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:policy/v1beta1:PodDisruptionBudget", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal PodDisruptionBudget(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:policy/v1beta1:PodDisruptionBudget", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private PodDisruptionBudget(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:policy/v1beta1:PodDisruptionBudget", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.PodDisruptionBudgetArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.PodDisruptionBudgetArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.PodDisruptionBudgetArgs();
            args.ApiVersion = "policy/v1beta1";
            args.Kind = "PodDisruptionBudget";
            return args;
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Pulumi.Alias { Type = "kubernetes:policy/v1:PodDisruptionBudget"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing PodDisruptionBudget resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PodDisruptionBudget Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new PodDisruptionBudget(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1
{

    public class PodDisruptionBudgetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        /// <summary>
        /// Specification of the desired behavior of the PodDisruptionBudget.
        /// </summary>
        [Input("spec")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Policy.V1Beta1.PodDisruptionBudgetSpecArgs>? Spec { get; set; }

        public PodDisruptionBudgetArgs()
        {
        }
    }
}
