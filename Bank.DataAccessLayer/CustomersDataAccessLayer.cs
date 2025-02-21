using Bank.DataAccessLayer.DALContracts;
using Bank.Entities;
using Bank.Exceptions;

namespace Bank.DataAccessLayer
{
    /// <summary>
    /// Represents DAL for bank customers
    /// </summary>
    public class CustomersDataAccessLayer : ICustomersDataAccessLayer
    {
        #region Fields
        private List<Customer> _customers;
        #endregion

        #region Constructors
        public CustomersDataAccessLayer()
        {
            _customers = new List<Customer>();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Represents source customers collection
        /// </summary>
        private List<Customer> Customers
        {
            set => _customers = value;
            get => _customers;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Return all existing customers
        /// </summary>
        /// <returns>Customer list</returns>
        public List<Customer> GetCustomers()
        {
            try
            {
                //create a new customer list
                List<Customer> customerList = new List<Customer>();

                //copy all the customer from the source collection into the newCustomer list
                Customers.ForEach(item => customerList.Add(item.Clone() as Customer));
                return customerList;
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
        /// Returns list of customers that are matching with specific criteria
        /// </summary>
        /// <param name="predicate">Lambda expression with condition</param>
        /// <returns>List of matching customers</returns>
        public List<Customer> GetCustomersByCondition(Predicate<Customer> predicate)
        {
            try
            {
                //create a new customer list
                List<Customer> customerList = new List<Customer>();

                //filter the collection
                List<Customer> filteredCustomer = customerList.FindAll(predicate);

                //copy all the customer from the source collection into the newCustomer list
                Customers.ForEach(item => filteredCustomer.Add(item.Clone() as Customer));
                return customerList;
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
        /// Adds a new customer to the existing list
        /// </summary>
        /// <param name="customer">Customer object to add</param>
        /// <returns>Returns Guid of newly created customer</returns>
        public Guid AddCustomer(Customer customer)
        {
            try
            {
                //generate new Guid
                customer.CustomerID = Guid.NewGuid();

                //add customer
                Customers.Add(customer);

                return customer.CustomerID;
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
        /// Updates an existing customer's details
        /// </summary>
        /// <param name="customer">Customer object with updated details</param>
        /// <returns>Determines whether the customer is updated or not</returns>
        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                //find existing customer by CustomerID
                Customer existingCustomer = Customers.Find(item => item.CustomerID == customer.CustomerID);

                //update all details of customer
                if (existingCustomer != null)
                {
                    existingCustomer.CustomerCode = customer.CustomerCode;
                    existingCustomer.CustomerName = customer.CustomerName;
                    existingCustomer.Address = customer.Address;
                    existingCustomer.Landmark = customer.Landmark;
                    existingCustomer.City = customer.City;
                    existingCustomer.Country = customer.Country;
                    existingCustomer.Mobile = customer.Mobile;

                    return true; //indicates the customer is updated
                }
                else
                {
                    return false; //indicates no object is updated
                }
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
        /// Deletes an existing customer based on CustomerID
        /// </summary>
        /// <param name="customerID">CustomerID to delete</param>
        /// <returns>Indicates whether the customer is deleted or not</returns>
        public bool DeleteCustomer(Guid customerID)
        {
            try
            {
                //delete customer by CustomerID
                if (Customers.RemoveAll(item => item.CustomerID == customerID) > 0)
                {
                    return true; //indicates one or more customers are deleted
                }
                else
                {
                    return false; //indicates no customer is deleted
                }
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
