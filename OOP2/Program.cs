using System;
using System.Collections.Generic;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personelCreditManager = new PersonelCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager homeCreditManager = new HomeCreditManager();

            RecourseManager recourseManager = new RecourseManager();
            recourseManager.DoRecourse(personelCreditManager,new DatabaseLoggerService());

            List<ICreditManager> credits = new List<ICreditManager>()
            {
                personelCreditManager,vehicleCreditManager,homeCreditManager
            };
            
            //recourseManager.CreditInformation(credits);


        }
    }
}
