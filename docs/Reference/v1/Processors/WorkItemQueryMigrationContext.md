## Processors: WorkItemQueryMigrationContext

>**_This documentation is for a preview version of the Azure DevOps Migration Tools._ If you are not using the preview version then please head over to the main [documentation](https://nkdagility.github.io/azure-devops-migration-tools).**

[Overview](/docs/index.md) > [Reference](/docs/Reference/index.md) > [API v1](/docs/Reference/v1/index.md) > [Processors](/docs/Reference/v1/Processors/index.md)> **WorkItemQueryMigrationContext**

This processor can migrate queries for work items. Only shared queries are included. Personal queries can't migrate with this tool.

### Options

| Parameter name         | Type    | Description                              | Default Value                            |
|------------------------|---------|------------------------------------------|------------------------------------------|
| Enabled | Boolean | missng XML code comments | missng XML code comments |
| PrefixProjectToNodes | Boolean | Prefix your iterations and areas with the project name. If you have enabled this in `NodeStructuresMigrationConfig` you must do it here too. | false |
| SharedFolderName | String | The name of the shared folder, made a parameter incase it every needs to be edited | none |
| SourceToTargetFieldMappings | Dictionary`2 | Any field mappings | none |


### Example JSON

```JSON
{
  "$type": "WorkItemQueryMigrationConfig",
  "Enabled": false,
  "PrefixProjectToNodes": false,
  "SharedFolderName": "Shared Queries",
  "SourceToTargetFieldMappings": null
}
```