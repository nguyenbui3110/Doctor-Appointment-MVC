FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["DoctorAppointment.WebApp/DoctorAppointment.WebApp.csproj", "DoctorAppointment.WebApp/"]
COPY ["DoctorAppointment.Application/DoctorAppointment.Application.csproj", "DoctorAppointment.Application/"]
COPY ["DoctorAppointment.Domain/DoctorAppointment.Domain.csproj", "DoctorAppointment.Domain/"]
COPY ["DoctorAppointment.Infrastructure/DoctorAppointment.Infrastructure.csproj", "DoctorAppointment.Infrastructure/"]
RUN dotnet restore "DoctorAppointment.WebApp/DoctorAppointment.WebApp.csproj"
COPY . .
WORKDIR "/src/DoctorAppointment.WebApp"
RUN dotnet build "DoctorAppointment.WebApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DoctorAppointment.WebApp.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "DoctorAppointment.WebApp.dll"]