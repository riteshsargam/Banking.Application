﻿using Bank.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Exceptions;

namespace Bank.Entities
{
    /// <summary>
    /// Represents customer of the bank
    /// </summary>
    public class Customer : ICustomer, ICloneable
    {
        #region Private fields
        private Guid _customerID;
        private long _customerCode;
        private string _customerName;
        private string _address;
        private string _landmark;
        private string _city;
        private string _country;
        private string _mobile;
        #endregion

        #region Public Properties
        /// <summary>
        /// Guid of Customer for Unique identification
        /// </summary>
        public Guid CustomerID { get => _customerID; set => _customerID = value; }

        /// <summary>
        /// Auto-generated code number of the customer
        /// </summary>
        public long CustomerCode
        {
            get => _customerCode;
            set
            {
                if (value > 0)
                {
                    _customerCode = value;
                }
                else
                {
                    throw new CustomerException("Customer code should be positive only.");
                }
            }
        }

        /// <summary>
        /// Name of the customer
        /// </summary>
        public string CustomerName
        {
            get => _customerName;
            set
            {
                if (value.Length <= 40 && string.IsNullOrEmpty(value) == false)
                {
                    _customerName = value;
                }
                else
                {
                    throw new CustomerException("Customer Name should not be null and less than 40 characters long.");
                }
            }
        }

        /// <summary>
        /// Address of the customer
        /// </summary>
        public string Address { get => _address; set => _address = value; }

        /// <summary>
        /// Landmark of the customer's address
        /// </summary>
        public string Landmark { get => _landmark; set => _landmark = value; }

        /// <summary>
        /// City of the customer
        /// </summary>
        public string City { get => _city; set => _city = value; }

        /// <summary>
        /// Country of the customer
        /// </summary>
        public string Country { get => _country; set => _country = value; }

        /// <summary>
        /// 10-digit Mobile number of the customer
        /// </summary>
        public string Mobile
        {
            get => _mobile;
            set
            {
                if (value.Length == 10)
                {
                    _mobile = value;
                }
                else
                {
                    throw new CustomerException("Mobile number should be a 10-digit mobile number.");
                }
            }
        }
        #endregion

        #region Methods
        public object Clone() 
        {
            return new Customer()
            {
                CustomerID = this.CustomerID,
                CustomerCode = this.CustomerCode,
                CustomerName = this.CustomerName,
                Address = this.Address,
                City = this.City,
                Country = this.Country,
                Mobile = this.Mobile,
            };
        }
        #endregion
    }
}
