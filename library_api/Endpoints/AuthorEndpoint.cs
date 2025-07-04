namespace library_api.Endpoints;

public static class AuthorEndpoint
{
    public static void MapAuthorEndpoints(this IEndpointRouteBuilder app)
    {
        var authorGroup = app.MapGroup("/authors").WithTags("Authors");
        
    }
}