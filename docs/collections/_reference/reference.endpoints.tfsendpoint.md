---
optionsClassName: TfsEndpointOptions
optionsClassFullName: MigrationTools.Endpoints.TfsEndpointOptions
configurationSamples:
- name: defaults
  description: 
  code: There are no defaults! Check the sample for options!
  sampleFor: MigrationTools.Endpoints.TfsEndpointOptions
- name: sample
  description: 
  code: There is no sample, but you can check the classic below for a general feel.
  sampleFor: MigrationTools.Endpoints.TfsEndpointOptions
- name: classic
  description: 
  code: >-
    {
      "$type": "TfsEndpointOptions",
      "Organisation": null,
      "Project": null,
      "AuthenticationMode": "AccessToken",
      "AccessToken": null,
      "ReflectedWorkItemIdField": null,
      "LanguageMaps": null,
      "EndpointEnrichers": null
    }
  sampleFor: MigrationTools.Endpoints.TfsEndpointOptions
description: missng XML code comments
className: TfsEndpoint
typeName: Endpoints
architecture: 
options:
- parameterName: AccessToken
  type: String
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: AuthenticationMode
  type: AuthenticationMode
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: EndpointEnrichers
  type: List
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: LanguageMaps
  type: TfsLanguageMapOptions
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: Organisation
  type: String
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: Project
  type: String
  description: missng XML code comments
  defaultValue: missng XML code comments
- parameterName: ReflectedWorkItemIdField
  type: String
  description: missng XML code comments
  defaultValue: missng XML code comments
status: missng XML code comments
processingTarget: missng XML code comments
classFile: /src/MigrationTools.Clients.TfsObjectModel/Endpoints/TfsEndpoint.cs
optionsClassFile: /src/MigrationTools.Clients.TfsObjectModel/Endpoints/TfsEndpointOptions.cs

redirectFrom:
- /Reference/Endpoints/TfsEndpointOptions/
layout: reference
toc: true
permalink: /Reference/Endpoints/TfsEndpoint/
title: TfsEndpoint
categories:
- Endpoints
- 
topics:
- topic: notes
  path: /docs/Reference/Endpoints/TfsEndpoint-notes.md
  exists: false
  markdown: ''
- topic: introduction
  path: /docs/Reference/Endpoints/TfsEndpoint-introduction.md
  exists: false
  markdown: ''

---