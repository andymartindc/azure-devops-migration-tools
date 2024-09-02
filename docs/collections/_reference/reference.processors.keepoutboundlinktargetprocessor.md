---
optionsClassName: KeepOutboundLinkTargetProcessorOptions
optionsClassFullName: MigrationTools.Clients.AzureDevops.Rest.Processors.KeepOutboundLinkTargetProcessorOptions
configurationSamples:
- name: defaults
  description: 
  code: There are no defaults! Check the sample for options!
  sampleFor: MigrationTools.Clients.AzureDevops.Rest.Processors.KeepOutboundLinkTargetProcessorOptions
- name: sample
  description: 
  code: There is no sample, but you can check the classic below for a general feel.
  sampleFor: MigrationTools.Clients.AzureDevops.Rest.Processors.KeepOutboundLinkTargetProcessorOptions
- name: classic
  description: 
  code: >-
    {
      "$type": "KeepOutboundLinkTargetProcessorOptions",
      "Enabled": false,
      "WIQLQuery": "Select [System.Id] From WorkItems Where [System.TeamProject] = @project and not [System.WorkItemType] contains 'Test Suite, Test Plan,Shared Steps,Shared Parameter,Feedback Request'",
      "TargetLinksToKeepOrganization": "https://dev.azure.com/nkdagility",
      "TargetLinksToKeepProject": "7dd43083-3ca7-4e5f-8ec6-f0544ed80445",
      "CleanupFileName": "c:/temp/OutboundLinkTargets.bat",
      "PrependCommand": "start",
      "DryRun": true,
      "Enrichers": null,
      "SourceName": null,
      "TargetName": null,
      "RefName": null
    }
  sampleFor: MigrationTools.Clients.AzureDevops.Rest.Processors.KeepOutboundLinkTargetProcessorOptions
description: missng XML code comments
className: KeepOutboundLinkTargetProcessor
typeName: Processors
architecture: 
options:
- parameterName: CleanupFileName
  type: String
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: DryRun
  type: Boolean
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: Enabled
  type: Boolean
  description: If set to `true` then the processor will run. Set to `false` and the processor will not run.
  defaultValue: missng XML code comments
- parameterName: Enrichers
  type: List
  description: List of Enrichers that can be used to add more features to this processor. Only works with Native Processors and not legacy Processors.
  defaultValue: missng XML code comments
- parameterName: PrependCommand
  type: String
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: RefName
  type: String
  description: '`Refname` will be used in the future to allow for using named Options without the need to copy all of the options.'
  defaultValue: missng XML code comments
- parameterName: SourceName
  type: String
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: TargetLinksToKeepOrganization
  type: String
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: TargetLinksToKeepProject
  type: String
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: TargetName
  type: String
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: WIQLQuery
  type: String
  description: missng XML code comments
  defaultValue: missng XML code comments
status: missng XML code comments
processingTarget: missng XML code comments
classFile: /src/MigrationTools.Clients.AzureDevops.Rest/Processors/KeepOutboundLinkTargetProcessor.cs
optionsClassFile: /src/MigrationTools.Clients.AzureDevops.Rest/Processors/KeepOutboundLinkTargetProcessorOptions.cs

redirectFrom:
- /Reference/Processors/KeepOutboundLinkTargetProcessorOptions/
layout: reference
toc: true
permalink: /Reference/Processors/KeepOutboundLinkTargetProcessor/
title: KeepOutboundLinkTargetProcessor
categories:
- Processors
- 
topics:
- topic: notes
  path: /docs/Reference/Processors/KeepOutboundLinkTargetProcessor-notes.md
  exists: false
  markdown: ''
- topic: introduction
  path: /docs/Reference/Processors/KeepOutboundLinkTargetProcessor-introduction.md
  exists: false
  markdown: ''

---