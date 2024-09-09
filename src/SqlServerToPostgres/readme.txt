
Scaffold-DbContext -Connection "Server=localhost;Database=wt_data;User Id=postgres;Password=postgres;" -OutputDir Data\Models -Provider Npgsql.EntityFrameworkCore.PostgreSQL -Force -Context MigrationPostgresDbContext -StartupProject SqlServerToPostgres -NoPluralize -NoOnConfiguring

Scaffold-DbContext -Connection "Server=localhost;Database=wt_data;Trusted_Connection=True;TrustServerCertificate=True;" -OutputDir Data\Models -Provider Microsoft.EntityFrameworkCore.SqlServer -Force -Context MigrationSqlDbContext -StartupProject SqlServerToPostgres -NoPluralize -NoOnConfiguring