using System;
namespace CSharp_Challenge_OvertimePay.classes
{
    public class OverTime
    {
        // - Fields -
        private double[] workingDay; //Format for array goes [Start of Day (Decimal), End of Day (Decimal), Hourly Rate, Overtime Multiplier] | Time in 24hr Format
        private double startDay, endDay, hourlyRate, overtimeMultiplier;
        private bool overtimeWorked;

        // - Constructor -
        public OverTime(double[] workingDay)
        {
            this.workingDay = workingDay;
            this.startDay = workingDay[0];
            this.endDay = workingDay[1];
            this.hourlyRate = workingDay[2];
            this.overtimeMultiplier = workingDay[3];
            this.overtimeWorked = false;
        }


        public double CalculatePay()
        {
            double overtimeHours = 0, regularHours = 0;

            //Checks if employee worked after 5PM | Calculates hours of overtime
            if (this.endDay > 17) 
            {
                overtimeHours = this.endDay - 17;
                this.overtimeWorked = true;
            }

            //Checks for 9AM - 5PM | Regular hours w/ Overtime
            if (this.startDay >= 9 && overtimeWorked) 
            {
                regularHours = 17 - this.startDay;
            } else //Regular Hours w/o Overtime
            {
                regularHours = this.endDay - this.startDay; //Calculates regular hours during normal working hours
            }

            return (regularHours * this.hourlyRate) + (overtimeHours * this.hourlyRate * this.overtimeMultiplier);
        }
    }
}

