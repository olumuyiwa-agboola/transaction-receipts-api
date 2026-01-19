namespace TransactionService.API.Configurations;

public static class WebApplicationBuilderConfiguration
{
    public static WebApplication ConfigureAndBuild(this WebApplicationBuilder builder)
    {
        return builder.Build();
    }
}