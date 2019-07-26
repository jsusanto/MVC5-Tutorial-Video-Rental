To make your Visual Studio better or more productive:
1. Tools - Extensions and Updates - online - visual studio productivity power tool
2. Tools - Extensions and Updates - online - web essential

===================================================================================

To download bootstrap theme: https://bootswatch.com/

Use the version 3 unless it will be broken - https://bootswatch.com/3/

===================================================================================

// To enable migration
PM> enable-migrations
Checking if the context targets an existing database...
Code First Migrations enabled for project Vidly.

/* 
* add migration on initial migration
* add-migration {NAME OF MIGRATION}
*
*/
>add-migration initial_migration
Example:
>add-migration InitialModel

// To force the migration to be replace
>add-migration InitialModel -force

// to execute the migration
>update-database

// Add a new column in the Customer Model
PM> add-migration AddIsSubscribedToCustomer
Scaffolding migration 'AddIsSubscribedToCustomer'.

PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201907180549575_AddIsSubscribedToCustomer].
Applying explicit migration: 201907180549575_AddIsSubscribedToCustomer.
Running Seed method.

//Add Prepopulate script using migration
PM> add-migration PopulateMembershipTypes
Scaffolding migration 'PopulateMembershipTypes'.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201907180632499_PopulateMembershipTypes].
Applying explicit migration: 201907180632499_PopulateMembershipTypes.
Running Seed method.

//Apply Annotation to Customer Name
PM> add-migration ApplyAnnotationToCustomerName
Scaffolding migration 'ApplyAnnotationToCustomerName'.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201907190001104_ApplyAnnotationToCustomerName].


//Add Name to MembershipType Schema
PM> add-migration AddNameToMembershipType
Scaffolding migration 'AddNameToMembershipType'.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201907190200528_AddNameToMembershipType].
Applying explicit migration: 201907190200528_AddNameToMembershipType.
Running Seed method.

//Add Birthday to Customer Schema
PM> add-migration BirthDateToCustomerSchema
Scaffolding migration 'BirthDateToCustomerSchema'.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201907190218369_BirthDateToCustomerSchema].
Applying explicit migration: 201907190218369_BirthDateToCustomerSchema.
Running Seed method.

//Install the auto-mapper package manager
PM> install-package automapper -version:4.1
Attempting to gather dependency information for package 'automapper.4.1.0' with respect to project 'Vidly', targeting '.NETFramework,Version=v4.5.2'
Attempting to resolve dependencies for package 'automapper.4.1.0' with DependencyBehavior 'Lowest'
Resolving actions to install package 'automapper.4.1.0'
Resolved actions to install package 'automapper.4.1.0'
Adding package 'AutoMapper.4.1.0' to folder 'E:\MVC5-Tutorial-Video-Rental\packages'
Added package 'AutoMapper.4.1.0' to folder 'E:\MVC5-Tutorial-Video-Rental\packages'
Added package 'AutoMapper.4.1.0' to 'packages.config'
Successfully installed 'AutoMapper 4.1.0' to Vidly
