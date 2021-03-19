# Creating seeding migrations
[Learn by dejanstojanovic](https://dejanstojanovic.net/aspnet/2020/july/seeding-data-with-entity-framework-core-using-migrations/)
```
The concept behind using migrations to seed the data is pretty simple and relies on EF Core mechanism for 
executing migration only once by tracking executed migration in the migrations table. 
This ensures that your data will be seeded only once.
With this approach you can easily rollback your seeding like any other migration and since it is part of the migrations
```
> NOTE
> It is important that you do not apply this migration before you populate the logic for it. 
> However, if you accidentally apply this seeding migration to the database, you can easy revert it by 
> applying the previous migration and in our case the command will be the following "dotnet ef database update "previous-migration-name""

