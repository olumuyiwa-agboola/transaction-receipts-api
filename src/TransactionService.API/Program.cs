using TransactionService.API.Configurations;

var builder = WebApplication.CreateBuilder(args);

var app = builder.ConfigureAndBuild();

app.ConfigureRequestPipeline();

app.Run();