using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
     class RecourseManager
    {
        public void DoRecourse(ICreditManager creditManager,ILoggerService loggerService)
        {
            //Basvuru bilgilerini degerlendirme
            creditManager.Calculator();
            loggerService.Log();

        }

        public void CreditInformation(List<ICreditManager> credits)
        {
            foreach (var item in credits)
            {
                item.Calculator();

            }
        }
    }
}
