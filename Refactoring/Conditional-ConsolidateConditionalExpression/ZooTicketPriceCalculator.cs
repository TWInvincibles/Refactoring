﻿using System;

namespace Refactoring.Conditional_ConsolidateConditionalExpression
{
    public class ZooTicketPriceCalculator
    {
        private static readonly DateTime SUMMER_START = new DateTime();
        private static readonly DateTime SUMMER_END = new DateTime();
        const double winterRate = 20;
        public readonly double winterServiceCharge = 2;
        const double summerRate = 30;

        public double GetTicketPrice1(DateTime date, int quantity)
        {
            if (date < SUMMER_START || date > SUMMER_END)
            {
                return quantity * winterRate + winterServiceCharge;
            }
            return quantity * summerRate;
        }

    }
}
