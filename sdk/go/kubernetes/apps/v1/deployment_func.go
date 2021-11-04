package v1

import (
	metav1 "github.com/pulumi/pulumi-kubernetes/sdk/v3/go/kubernetes/meta/v1"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func NewDeploymentArgs() *DeploymentArgs {
	return &DeploymentArgs{}
}

func (d *DeploymentArgs) WithApiVersion(val pulumi.StringPtrInput) {
	d.ApiVersion = val
}

func (d *DeploymentArgs) WithKind(val pulumi.StringPtrInput) {
	d.Kind = val
}

func (d *DeploymentArgs) WithMetadata(val metav1.ObjectMetaPtrInput) {
	d.Metadata = val
}

func (d *DeploymentArgs) WithSpec(val DeploymentSpecPtrInput) {
	d.Spec = val
}
