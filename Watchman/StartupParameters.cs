﻿using CommandLine;
using CommandLine.Text;
using Watchman.Engine;

namespace Watchman
{
    public class StartupParameters
    {
        [Option("RunMode", DefaultValue = RunMode.DryRun,
            HelpText = "RunMode is one of 'TestConfig', 'DryRun' or 'GenerateAlarms'")]
        public RunMode RunMode { get; set; }

        [Option("AwsAccessKey", HelpText = "The access key to the AWS account to connect to")]
        public string AwsAccessKey { get; set; }

        [Option("AwsSecretKey", HelpText = "The secret key to the AWS account to connect to")]
        public string AwsSecretKey { get; set; }

        [Option("AwsRegion", HelpText = "The AWS region")]
        public string AwsRegion { get; set; }

        [Option("AwsProfile", HelpText = "The name of the AWS profile to use for credentials", Required = false)]
        public string AwsProfile { get; set; }

        [Option("ConfigFolder", HelpText = "The location of the config files", Required = true)]
        public string ConfigFolderLocation { get; set; }

        [Option("Verbose", HelpText = "Detailed output", DefaultValue = false)]
        public bool Verbose { get; set; }

        [Option("TemplateS3Path", HelpText = "Base s3 path for cloudformation template deployment")]
        public string TemplateS3Path { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, current => HelpText.DefaultParsingErrorsHandler(this, current));
        }
    }
}
