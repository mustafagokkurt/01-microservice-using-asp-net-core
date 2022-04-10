#FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
#WORKDIR /app
#EXPOSE 80
#EXPOSE 443
#
#FROM microsoft/dotnet:2.2-sdk AS build
#WORKDIR /src
#COPY ["ProductMicroservice/ProductMicroservice.csproj", "ProductMicroservice/"]
#RUN dotnet restore "ProductMicroservice/ProductMicroservice.csproj"
#COPY . .
#WORKDIR "/src/ProductMicroservice"
#RUN dotnet build "ProductMicroservice.csproj" -c Release -o /app
#
#FROM build AS publish
#RUN dotnet publish "ProductMicroservice.csproj" -c Release -o /app
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "ProductMicroservice.dll"]

FROM mcr.microsoft.com/dotnet/core/sdk:2.2
WORKDIR /app
COPY . .
RUN dotnet restore
RUN dotnet publish ProductMicroservice.csproj -c Release -o out
WORKDIR out
ENV ASPNETCORE_URLS="http://*:1453"
ENTRYPOINT ["dotnet", "ProductMicroservice.dll"]

#docker build -t image1 .
#docker run -p 1071:1453 --name ProductMicroservice image1