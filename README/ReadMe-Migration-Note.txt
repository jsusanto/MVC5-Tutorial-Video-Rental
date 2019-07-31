Use all password (registered users): Password123!
2 users
- admin@jsusanto.com *assigned CanManageMovie Role
- guest@jsusanto.com 

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

//Install bootbox js to customise the modal dialog
PM> install-package bootbox -version:4.3.0
Attempting to gather dependency information for package 'bootbox.4.3.0' with respect to project 'Vidly', targeting '.NETFramework,Version=v4.5.2'
Attempting to resolve dependencies for package 'bootbox.4.3.0' with DependencyBehavior 'Lowest'
Resolving actions to install package 'bootbox.4.3.0'
Resolved actions to install package 'bootbox.4.3.0'
Adding package 'bootbox.4.3.0' to folder 'E:\MVC5-Tutorial-Video-Rental\packages'
Added package 'bootbox.4.3.0' to folder 'E:\MVC5-Tutorial-Video-Rental\packages'
Added package 'bootbox.4.3.0' to 'packages.config'
Successfully installed 'bootbox 4.3.0' to Vidly

//Install jquery datatables for pagination, search
PM> install-package jquery.datatables -version:1.10.11
Attempting to gather dependency information for package 'jquery.datatables.1.10.11' with respect to project 'Vidly', targeting '.NETFramework,Version=v4.5.2'
Attempting to resolve dependencies for package 'jquery.datatables.1.10.11' with DependencyBehavior 'Lowest'
Resolving actions to install package 'jquery.datatables.1.10.11'
Resolved actions to install package 'jquery.datatables.1.10.11'
Adding package 'jquery.datatables.1.10.11' to folder 'E:\MVC5-Tutorial-Video-Rental\packages'
Added package 'jquery.datatables.1.10.11' to folder 'E:\MVC5-Tutorial-Video-Rental\packages'
Added package 'jquery.datatables.1.10.11' to 'packages.config'
Successfully installed 'jquery.datatables 1.10.11' to Vidly

//Add initial users
PM> add-migration SeedUsers
Scaffolding migration 'SeedUsers'.

PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201907300040363_SeedUsers].
Applying explicit migration: 201907300040363_SeedUsers.
Running Seed method.

//Add Driving License to Application User
PM> add-migration AddDrivingLicenseToApplicationUser
Scaffolding migration 'AddDrivingLicenseToApplicationUser'.

PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201907300448211_AddDrivingLicenseToApplicationUser].
Applying explicit migration: 201907300448211_AddDrivingLicenseToApplicationUser.
Running Seed method.

//For Facebook Authentication, you need to install - Microsoft.Owin.Security.Facebook
PM> Install-Package Microsoft.Owin.Security.Facebook
Attempting to gather dependency information for package 'Microsoft.Owin.Security.Facebook.4.0.1' with respect to project 'Vidly', targeting '.NETFramework,Version=v4.5.2'
Attempting to resolve dependencies for package 'Microsoft.Owin.Security.Facebook.4.0.1' with DependencyBehavior 'Lowest'

//Install Glimpse for diagnostic and see insight on your application
PM> install-package glimpse.mvc5
Attempting to gather dependency information for package 'glimpse.mvc5.1.5.3' with respect to project 'Vidly', targeting '.NETFramework,Version=v4.5.2'
Attempting to resolve dependencies for package 'glimpse.mvc5.1.5.3' with DependencyBehavior 'Lowest'
Resolving actions to install package 'glimpse.mvc5.1.5.3'
Resolved actions to install package 'glimpse.mvc5.1.5.3'
...

PM> install-package glimpse.ef6
Attempting to gather dependency information for package 'glimpse.ef6.1.6.5' with respect to project 'Vidly', targeting '.NETFramework,Version=v4.5.2'
Attempting to resolve dependencies for package 'glimpse.ef6.1.6.5' with DependencyBehavior 'Lowest'
Resolving actions to install package 'glimpse.ef6.1.6.5'
Resolved actions to install package 'glimpse.ef6.1.6.5'
...

To open glimpse locally https://localhost:44386/glimpse.axd
Glimpse is purposely set up and configured on localhost, if you want to implement on production you need to follow the instruction in the 
Glimpse documentation.