# DotNetCore_GraphQL_HotChocolate

🔗 WSL Install: https://docs.microsoft.com/en-us/windows/wsl/install-win10
🔗 Installing Docker in WSL: https://docs.docker.com/docker-for-windows/install-windows-home/
🔗 Visual Studio Code: https://code.visualstudio.com/download
🔗 SQL Server Express: https://www.microsoft.com/en-en/sql-server/sql-server-downloads
🔗 Visual Studio: https://visualstudio.microsoft.com/downloads/
🔗 Insomnia: https://insomnia.rest/
🔗 SQL Server on Docker: https://hub.docker.com/_/microsoft-mssql-server
🔗 SQL Server Management Studio: https://aka.ms/ssmsfullsetup
🔗 GraphQL Voyager: https://github.com/APIs-guru/graphql-voyager
🔗 GraphQL Official Site: https://graphql.org/
🔗 Chilli Cream / Hot Chocolate Site: https://chillicream.com


cd into src
* dotnet new web -n CommanderGQL

add necessary nuget packages (www.nuget.org):
* dotnet add package HotChocolate.AspNetCore
* dotnet add package HotChocolate.Data.EntityFramework
* dotnet add package Microsoft.EntityFrameworkCore.Design
* dotnet add package Microsoft.EntityFrameworkCore.SqlServer
* dotnet add package GraphQL.Server.Ui.Voyager

add 'docker-compose.yaml' to project root
* https://docs.docker.com/compose/aspnet-mssql-compose/

sql server express
* username: express
* password: express

run in docker (login into docker hub first):
* docker-compose up -d
* docker-compose stop
* https://docs.microsoft.com/en-us/visualstudio/docker/tutorials/docker-tutorial

Setup Startup & DbContext

Install EF if you don't have it installed:
* dotnet tool update --global  dotnet-ef
* dotnet ef -> to check is installed

Setup Migrations
* dotnet ef migrations add AddPlatformToDb