
Scaffold-DbContext -Connection "Server=87.228.17.114;Database=hcm;User Id=hcm;Password=C7S8cmMPCXyv;" -OutputDir Data\Models -Provider Npgsql.EntityFrameworkCore.PostgreSQL -Force -Context MigrationPostgresDbContext -StartupProject SqlServerToPostgres -NoPluralize -NoOnConfiguring

Scaffold-DbContext -Connection "Server=localhost;Database=wt_data;Trusted_Connection=True;TrustServerCertificate=True;" -OutputDir Data\Models -Provider Microsoft.EntityFrameworkCore.SqlServer -Force -Context MigrationSqlDbContext -StartupProject SqlServerToPostgres -NoPluralize -NoOnConfiguring