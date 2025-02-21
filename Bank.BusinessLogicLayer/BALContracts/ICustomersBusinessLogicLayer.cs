using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Entities;


namespace Bank.BusinessLogicLayer.BALContracts
{
    /// <summary>
    /// Interface that represents customers business logic
    /// </summary>
    public interface ICustomersBusinessLogicLayer
    {
        /// <summary>
        /// Returns all existing customer
        /// </summary>
        /// <returns>List of customers</returns>
        List<Customer> GetCustomers();

        /// <summary>
        /// Returns a set of customers that matches with specific criteria
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        List<Customer> GetCustomersByCondition(Predicate<Customer> predicate);

        /// <summary>
        /// Adds a new customer to the existing customers list
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        Guid AddCustomer(Customer customer);

        /// <summary>
        /// Updates an existing customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        bool UpdateCustomer(Customer customer);

        /// <summary>
        /// Deletes an existing customer
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        bool DeleteCustomer(Guid customerID);
    }
}
