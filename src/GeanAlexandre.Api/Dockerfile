FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY ./bin/Release/netcoreapp2.0/publish/ /app/
ENV ASPNETCORE_URLS http://*:5000
RUN ls -lrt
EXPOSE 5000
ENTRYPOINT ["dotnet", "GeanAlexandre.Api.dll"]
