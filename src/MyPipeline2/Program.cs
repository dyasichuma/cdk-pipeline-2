﻿using Amazon.CDK;

namespace MyPipeline2
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new MyPipeline2Stack(app, "MyPipeline2Stack", new StackProps
            {
                Env = new Amazon.CDK.Environment {
                Account = "597011385066", Region = "us-east-1" }
            });
            app.Synth();
        }
    }
}
