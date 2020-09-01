# trophonious
Data Access Layer for an engineering process database

## project environment setup

### ef-core setup
```
dotnet new console
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design

dotnet ef dbcontext scaffold "Server=localhost;Database=AWS;User Id=sa; Password=Password_01" Microsoft.EntityFrameworkCore.SqlServer -o model -c DaoContext --json -v --force
   ```