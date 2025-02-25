// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Provider
{

    /// <summary>
    /// BETA FEATURE - Options to configure the Helm Release resource.
    /// </summary>
    public class HelmReleaseSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The backend storage driver for Helm. Values are: configmap, secret, memory, sql.
        /// </summary>
        [Input("driver")]
        public Input<string>? Driver { get; set; }

        /// <summary>
        /// The path to the helm plugins directory.
        /// </summary>
        [Input("pluginsPath")]
        public Input<string>? PluginsPath { get; set; }

        /// <summary>
        /// The path to the registry config file.
        /// </summary>
        [Input("registryConfigPath")]
        public Input<string>? RegistryConfigPath { get; set; }

        /// <summary>
        /// The path to the file containing cached repository indexes.
        /// </summary>
        [Input("repositoryCache")]
        public Input<string>? RepositoryCache { get; set; }

        /// <summary>
        /// The path to the file containing repository names and URLs.
        /// </summary>
        [Input("repositoryConfigPath")]
        public Input<string>? RepositoryConfigPath { get; set; }

        /// <summary>
        /// While Helm Release provider is in beta, by default 'pulumi up' will log a warning if the resource is used. If present and set to "true", this warning is omitted.
        /// </summary>
        [Input("suppressBetaWarning")]
        public Input<bool>? SuppressBetaWarning { get; set; }

        public HelmReleaseSettingsArgs()
        {
            Driver = Utilities.GetEnv("PULUMI_K8S_HELM_DRIVER");
            PluginsPath = Utilities.GetEnv("PULUMI_K8S_HELM_PLUGINS_PATH");
            RegistryConfigPath = Utilities.GetEnv("PULUMI_K8S_HELM_REGISTRY_CONFIG_PATH");
            RepositoryCache = Utilities.GetEnv("PULUMI_K8S_HELM_REPOSITORY_CACHE");
            RepositoryConfigPath = Utilities.GetEnv("PULUMI_K8S_HELM_REPOSITORY_CONFIG_PATH");
            SuppressBetaWarning = Utilities.GetEnvBoolean("PULUMI_K8S_SUPPRESS_HELM_RELEASE_BETA_WARNING");
        }
    }
}
