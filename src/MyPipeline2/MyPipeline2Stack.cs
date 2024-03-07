using Amazon.CDK;
using Constructs;
using Amazon.CDK.Pipelines;

namespace MyPipeline2
{
    public class MyPipeline2Stack : Stack
    {
        internal MyPipeline2Stack(Construct scope, string id, IStackProps props = null) : base(scope, id, props)
        {
            var pipeline = new CodePipeline(this, "pipeline", new CodePipelineProps
            {
                PipelineName = "MyPipeline",
                Synth = new ShellStep("Synth", new ShellStepProps
                {
                    Input = CodePipelineSource.GitHub("dyasichuma/cdk-pipeline-2", "main"),
                    Commands = new string[] { "npm install -g aws-cdk", "cdk synth" }
                })
            });
        }
    }
}
