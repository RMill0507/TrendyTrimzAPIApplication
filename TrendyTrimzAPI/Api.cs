namespace TrendyTrimzsAPI;

public static class Api

{
	// Define a public static extension method for WebApplication named ConfigureApi, with a single parameter of type WebApplication named app
	public static void ConfigureApi(this WebApplication app)
    {
        //Mapping all the HTTP methods the the endpoints and associate them with the methods below
        app.MapGet(pattern: "/Customers", GetCustomers);
        app.MapGet(pattern: "/Customers/{id}", GetCustomer);
        app.MapPost(pattern: "/Customers", InsertCustomer);
        app.MapPut(pattern: "/Customers", UpdateCustomer);
        app.MapDelete(pattern: "/Customers", DeleteCustomer);
    }
	//Defining a private static async method named GetCustomers that takes an ICustomerRepository named data as a parameter and returns an IResult
	private static async Task<IResult> GetCustomers(ICustomerRepository data)
    {
        try
        {
            //call the GetCustomers method on the data repository and return an Ok result with the returned data
            return Results.Ok(await data.GetCustomers());//wrapping results in an http message  
        }
        catch (Exception ex)
        {
            // Return a Problem result with the exception message if an error occurs
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
