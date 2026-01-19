namespace TransactionService.API.Configurations;

public static class RequestPipelineConfiguration
{
    public static void ConfigureRequestPipeline(this WebApplication app)
    {
        app.MapGet("/", () => "Hello World!");
    }
}