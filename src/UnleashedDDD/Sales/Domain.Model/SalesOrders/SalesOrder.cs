using System;
using UnleashedDDD.Contracts.Sales.SalesOrder.Events;
using UnleashedDDD.Sales.Domain.Model.Customers;
using UnleashedDDD.Sales.Domain.Model.SalesOrders.State;
using UnleashedDDD.Sales.Domain.Model.Salespersons;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrders
{
    public class SalesOrder : IStatable<SalesOrderState>
    {
        private readonly IDomainEventRaiser _observer;
        private SalesOrderState _state = null;

        public SalesOrderId Id { get; private set; }

        private Status _status;
        public Status Status { get { return _status; } private set { _status = value; }}

        public CustomerId Customer {get; private set; }

        private RefWarehouseId _warehouse;

        public RefWarehouseId Warehouse
        {
            get { return _warehouse; }
            set
            {
                Status.AssureChangeToOrderIsAllowed();
                _warehouse = value;
            }
        }

        public SalespersonId Salesperson { get; private set; }

        public Lines Lines { get; private set; }

        public SalesTax Tax { get; private set; }

        public SalesOrder(IDomainEventRaiser observer, CustomerId customer, RefWarehouseId warehouse)
        {
            _observer = observer;

            if (customer == null) throw new Exception("Customer id cannot be null");
            if (warehouse == null) throw new Exception("Warehouse id cannot be null");

            Id = new SalesOrderId(Guid.NewGuid());
            Customer = customer;
            _warehouse = warehouse;
            
            Status = Status.CreateOpened();
            Lines = new Lines(Id, ref _status);
        }

        public SalesOrder(IDomainEventRaiser observer, SalesOrderState state)
        {
            _observer = observer;
            _state = state;
        }

        public void Complete()
        {
            _observer.Raise(
                new SalesOrderCompleted(Id.Id));
        }

        public Totals CalculateTotals()
        {
            return new Totals(Lines);
        }

        public SalesOrderState GetState()
        {
            return new SalesOrderState();
        }

        public void ChangeTax(SalesTax tax)
        {
            Tax = tax;
        }

        public void ChangeWarehouse(RefWarehouseId warehouse)
        {
            Warehouse = warehouse;
        }

        public void ChangeSalesPerson(SalespersonId salesperson)
        {
            Salesperson = salesperson;
        }
    }
}