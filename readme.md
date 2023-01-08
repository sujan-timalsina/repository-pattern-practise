# TodoApp using nth layered architecture and repository pattern

### For migration and data persistence use command

#### first goto TodoApp.Repository directory [cd TodoApp.Repository]
#### then install the required package which is needed for migration
1. dotnet tool install --global dotnet-ef
2. dotnet add package Microsoft.EntityFrameworkCore.Design

#### Run below command whenever you need to make some changes in the database
3. dotnet ef migrations add migrationName -s ../TodoApp.Api
4. dotnet ef database update -s ../Todo.Api