---
optionsClassName: TfsWorkItemDeleteProcessorOptions
optionsClassFullName: MigrationTools.Processors.TfsWorkItemDeleteProcessorOptions
configurationSamples:
- name: defaults
  description: 
  code: There are no defaults! Check the sample for options!
  sampleFor: MigrationTools.Processors.TfsWorkItemDeleteProcessorOptions
- name: sample
  description: 
  code: There is no sample, but you can check the classic below for a general feel.
  sampleFor: MigrationTools.Processors.TfsWorkItemDeleteProcessorOptions
- name: classic
  description: 
  code: >-
    {
      "$type": "TfsWorkItemDeleteProcessorOptions",
      "Enabled": false,
      "WIQLQuery": "SELECT [System.Id] FROM WorkItems WHERE [System.TeamProject] = @TeamProject AND [System.WorkItemType] NOT IN ('Test Suite', 'Test Plan','Shared Steps','Shared Parameter','Feedback Request') ORDER BY [System.ChangedDate] desc",
      "WorkItemIDs": null,
      "FilterWorkItemsThatAlreadyExistInTarget": false,
      "PauseAfterEachWorkItem": false,
      "WorkItemCreateRetryLimit": 0,
      "Enrichers": null,
      "SourceName": null,
      "TargetName": null,
      "RefName": null
    }
  sampleFor: MigrationTools.Processors.TfsWorkItemDeleteProcessorOptions
description: The `WorkItemDelete` processor allows you to delete any amount of work items that meet the query. **DANGER:** This is not a recoverable action and should be use with extream caution.
className: TfsWorkItemDeleteProcessor
typeName: Processors
architecture: 
options:
- parameterName: Enabled
  type: Boolean
  description: If set to `true` then the processor will run. Set to `false` and the processor will not run.
  defaultValue: missng XML code comments
- parameterName: Enrichers
  type: List
  description: List of Enrichers that can be used to add more features to this processor. Only works with Native Processors and not legacy Processors.
  defaultValue: missng XML code comments
- parameterName: FilterWorkItemsThatAlreadyExistInTarget
  type: Boolean
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: PauseAfterEachWorkItem
  type: Boolean
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
- parameterName: TargetName
  type: String
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: WIQLQuery
  type: String
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: WorkItemCreateRetryLimit
  type: Int32
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: WorkItemIDs
  type: IList
  description: missng XML code comments
  defaultValue: missng XML code comments
status: ready
processingTarget: WorkItem
classFile: /src/MigrationTools.Clients.TfsObjectModel/Processors/TfsWorkItemDeleteProcessor.cs
optionsClassFile: /src/MigrationTools.Clients.TfsObjectModel/Processors/TfsWorkItemDeleteProcessorOptions.cs

redirectFrom:
- /Reference/Processors/TfsWorkItemDeleteProcessorOptions/
layout: reference
toc: true
permalink: /Reference/Processors/TfsWorkItemDeleteProcessor/
title: TfsWorkItemDeleteProcessor
categories:
- Processors
- 
topics:
- topic: notes
  path: /docs/Reference/Processors/TfsWorkItemDeleteProcessor-notes.md
  exists: false
  markdown: ''
- topic: introduction
  path: /docs/Reference/Processors/TfsWorkItemDeleteProcessor-introduction.md
  exists: false
  markdown: ''

---