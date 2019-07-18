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