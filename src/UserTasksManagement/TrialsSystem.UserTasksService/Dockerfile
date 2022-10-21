FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

WORKDIR /src

COPY ["UserTasksManagement/TrialsSystem.UserTasksService/TrialsSystem.UserTasksService.Api/TrialsSystem.UserTasksService.Api.csproj", "UserTasksManagement/TrialsSystem.UserTasksService/TrialsSystem.UserTasksService.Api/"]
COPY ["UserTasksManagement/TrialsSystem.UserTasksService/TrialsSystem.UserTasksService.Domain/TrialsSystem.UserTasksService.Domain.csproj", "UserTasksManagement/TrialsSystem.UserTasksService/TrialsSystem.UserTasksService.Domain/"]
COPY ["UserTasksManagement/TrialsSystem.UserTasksService/TrialsSystem.UserTasksService.Infrastructure/TrialsSystem.UserTasksService.Infrastructure.csproj", "UserTasksManagement/TrialsSystem.UserTasksService/TrialsSystem.UserTasksService.Infrastructure/"]
COPY ["UserTasksManagement/TrialsSystem.UserTasksService/TrialsSystem.UserTasksService.sln", "UserTasksManagement/TrialsSystem.UserTasksService/"]


RUN dotnet restore "UserTasksManagement/TrialsSystem.UserTasksService/TrialsSystem.UserTasksService.sln"
COPY . .

WORKDIR UserTasksManagement/TrialsSystem.UserTasksService/TrialsSystem.UserTasksService.Api
RUN dotnet publish --no-restore -c Release -o /app/publish

FROM build AS publish

FROM base AS finals
WORKDIR /app
COPY --from=publish /app/publish .

ENTRYPOINT ["dotnet", "TrialsSystem.UserTasksService.Api.dll"]