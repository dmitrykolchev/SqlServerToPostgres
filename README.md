# SqlServerToPostgres

## How to build

Необходимо установить .NET 8 SDK

#### Debian 12
Installing with APT can be done with a few commands. Before you install .NET, run the following commands to add the Microsoft package signing key to your list of trusted keys and add the package repository.

Open a terminal and run the following commands:
```
wget https://packages.microsoft.com/config/debian/12/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
```
#### Install the SDK
he .NET SDK allows you to develop apps with .NET. If you install the .NET SDK, you don't need to install the corresponding runtime. To install the .NET SDK, run the following commands:

```
sudo apt-get update && \
  sudo apt-get install -y dotnet-sdk-8.0
```

### Build Finder

```
dotnet publish Finder.csproj -c Release -o ~/Publish/Finder -r linux-x64 -p:PublishSingleFile=true --sc true
```
![image](https://github.com/user-attachments/assets/332f02db-cc78-4bc1-ab1a-46e37b894886)

Пример файла настроек для Finder
appsettings.json

``` json
{
  "ConnectionString": "Data Source=localhost;Initial Catalog=wt_data;Trusted_Connection=true;Trust Server Certificate=true;",
  "FullNameOrder": "SFM", // Фамилия (surname) Имя (firstname) Отчество (middlename)
  "CommandTimeout": 60,
  "BatchSize": 100,
  "MaxRecordLoad": 1000,
  "FullNames": [
    {
      "TableName": "learnings",
      "FieldName": "person_fullname"
    },
    {
      "TableName": "requests",
      "FieldName": "person_fullname"
    }
  ]
}
```
### Run Finder
Открыть терминал и выполнить команду
```
  ~/Publish/Finder/Finder
```
![image](https://github.com/user-attachments/assets/70932967-cae5-418f-938d-e9eedcfef2bb)

### Build SqlServerToPostgres

``` bash
 dotnet publish SqlServerToPostgres.csproj -c Release -o ~/Publish/SqlServerToPostgres -r linux-x64 -p:PublishSingleFile=true --sc true
```

## SQL Server Connection String

https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlconnection.connectionstring?view=netframework-4.8.1

## PostgreSQL Connection String (Npgsql)

https://www.npgsql.org/doc/connection-string-parameters.html
