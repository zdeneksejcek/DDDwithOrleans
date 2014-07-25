using System;
using UnleashedDDD.Sales.Domain.Model.SalesOrders.Exceptions;

namespace UnleashedDDD.Sales.Domain.Model.SalesOrders
{
    public class Status
    {
        public StatusEnum Value { get; private set; }

        public Status(StatusEnum value)
        {
            Value = value;
        }

        public Status ChangeTo(StatusEnum newValue)
        {
            if (Value == StatusEnum.Opened && newValue == StatusEnum.Completing)
                return new Status(StatusEnum.Completing);

            if (Value == StatusEnum.Completing && newValue == StatusEnum.Completed)
                return new Status(StatusEnum.Completed);

            throw new UnallowedStateChange();
        }

        public void AssureChangeToOrderIsAllowed()
        {
            if (Value == StatusEnum.Completed)
                throw new ModificationOfCompletedOrderIsNoAllowed();

            if (Value == StatusEnum.Completing)
                throw new ModificationOfOrderIsNoAllowedWhileBeingCompleted();
        }

        public static Status CreateOpened()
        {
            return new Status(StatusEnum.Opened);
        }

        public static Status FromString(string value)
        {
            var status = (StatusEnum) Enum.Parse(typeof(StatusEnum), value);

            return new Status(status);
        }

        public enum StatusEnum
        {
            Opened,
            Completing,
            Completed
        }
    }
}