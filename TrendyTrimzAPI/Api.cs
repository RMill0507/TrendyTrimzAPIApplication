namespace TrendyTrimzsAPI;

public static class Api

{
    public static void ConfigureApi(this WebApplication app)
    {
        app.MapGet(pattern: "/Customers", GetCustomers);
        app.MapGet(pattern: "/Customers/{id}", GetCustomer);
        app.MapPost(pattern: "/Customers", InsertCustomer);
        app.MapPut(pattern: "/Customers", UpdateCustomer);
        app.MapDelete(pattern: "/Customers", DeleteCustomer);
    }
    private static async Task<IResult> GetCustomers(ICustomerRepository data)
    {
        try
        {
            return Results.Ok(await data.GetCustomers());//wrapping results in an http message 
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> GetCustomer(int id, ICustomerRepository data)
    {
        try
        {
            var results = await data.GetCustomer(id);//get results from user 
            if (results == null) return Results.NotFound();//make sure not null
            return Results.Ok(results);//return ok with results if they are found
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }

    }
    private static async Task<IResult> InsertCustomer(CustomerModel customer, ICustomerRepository data)
    {
        try
        {
            await data.InsertCustomer(customer);
            return Results.Ok();
        }
        catch (Exception ex)
        {
           return Results.Problem(ex.Message);
        }
       
    }
    private static async Task<IResult> UpdateCustomer(CustomerModel customer, ICustomerRepository data)
    {
        try
        {
            await data.UpdateCustomer(customer);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
    private static async Task<IResult> DeleteCustomer(int id, ICustomerRepository data)
    {
        try
        {
            await data.DeleteCustomer(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
