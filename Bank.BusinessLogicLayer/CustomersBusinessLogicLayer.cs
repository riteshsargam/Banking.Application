using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.BusinessLogicLayer.BALContracts;
using Bank.DataAccessLayer;
using Bank.DataAccessLayer.DALContracts;
using Bank.Entities;
using Bank.Entities.Contracts;
using Bank.Exceptions;

namespace Bank.BusinessLogicLayer
{
    /// <summary>
    /// Represents customer business logic
    /// </summary>
    public class CustomersBusinessLogicLayer : ICustomersBusinessLogicLayer
    {
        #region Private Fields
        private ICustomersDataAccessLayer _customersDataAccessLayer;
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor that initializes CustomersDataAccessLayer
        /// </summary>
        public CustomersBusinessLogicLayer()
        {
            _customersDataAccessLayer = new CustomersDataAccessLayer();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Private property that represents reference of CustomerDataAccessLayer
        /// </summary>
        private ICustomersDataAccessLayer CustomersDataAccessLayer
        {
            set => _customersDataAccessLayer = value;
            get => _customersDataAccessLayer;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns all existing customer
        /// </summary>
        /// <returns>List of customers</returns>
        public List<Customer> GetCustomers()
        {
            try
            {
                //invoke DAL
                return CustomersDataAccessLayer.GetCustomers();
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Returns a set of customers that matches with specific criteria
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            try
            {
                //invoke DAL
                return CustomersDataAccessLayer.GetCustomersByCondition(predicate);
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Adds a new customer to the existing customers list
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public Guid AddCustomer(Customer customer)
        {
            try
            {
                //get all customers
                List<Customer> allCustomers = CustomersDataAccessLayer.GetCustomers();
                long maxCustCode = 0;
                foreach (var item in allCustomers)
                {
                    if (item.CustomerCode > maxCustCode)
                    {
                        maxCustCode = item.CustomerCode;
                    }
                }

                //generate new customer no
                if (allCustomers.Count >= 1)
                {
                    customer.CustomerCode = maxCustCode + 1;
                }
                else
                {
                    customer.CustomerCode = Bank.Configuration.Settings.BaseCustomerNo + 1;
                }
                //invoke DAL
                return CustomersDataAccessLayer.AddCustomer(customer);
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Updates an existing customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                //invoke DAL
                return CustomersDataAccessLayer.UpdateCustomer(customer);
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Deletes an existing customer
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public bool DeleteCustomer(Guid customerID)
        {
            try
            {
                //invoke DAL
                return CustomersDataAccessLayer.DeleteCustomer(customerID);
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
