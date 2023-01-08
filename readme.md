# TodoApp using nth layered architecture and repository pattern

### For migration and data persistence use command

1. dotnet tool install --global dotnet-ef
2. dotnet add package Microsoft.Entity.EntityFramworkCore
3. dotnet ef migrations add migrationName -s ../TodoApp.Api
4. dotnet ef database update -s ../Todo.Api

#### Run above command 1 and 2 one time only
#### Run command 3 and 4 whenever you need to some changes in database 