﻿using DataAccess.DbAccess;
using DataAccess.Models;



namespace DataAccess.Data;
public class CustomerRepository : ICustomerRepository
{
    private readonly ISqlDataAccess _db;

    public CustomerRepository(ISqlDataAccess db)
    {
        _db = db;
    }



    public Task<IEnumerable<CustomerModel>> GetCustomers() =>
        _db.LoadData<CustomerModel, dynamic>(storedProcedure: "dbo.spCustomer_GetAll", new { });

    public async Task<CustomerModel> GetCustomer(int id)
    {
        var results = await _db.LoadData<CustomerModel, dynamic>(storedProcedure: "dbo.spCustomer_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }
    public Task InsertCustomer(CustomerModel customer) =>
        _db.SaveData(storedProcedure: "dbo.spCustomer_Insert", new { customer.FirstName, customer.LastName,
            customer.ChildsName, customer.ChildsAge, customer.HairCutStyle});

    public Task UpdateCustomer(CustomerModel customer) =>
        _db.SaveData(storedProcedure: "dbo.spCustomer_Update", customer);

    public Task DeleteCustomer(int id) =>
        _db.SaveData(storedProcedure: "dbo.spCustomer_Delete", new { Id = id });
}