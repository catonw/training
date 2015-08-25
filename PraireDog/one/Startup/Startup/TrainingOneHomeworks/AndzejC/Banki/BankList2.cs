﻿using System.Collections.Generic;
using Startup.TrainingOneHomeworks.AndzejC.Banki.Abstrakty;
using Startup.TrainingOneHomeworks.AndzejC.Banki.Banks;

namespace Startup.TrainingOneHomeworks.AndzejC.Banki
{
    public class BankList2 : GenFactory<SendTransaction>
    {
         public BankList2(Transaction transaction)
        {
            ItemList = new Dictionary<string, SendTransaction>
            {
               
                {"1050", new Ing().SendTransfer(transaction)}
              
            };
        }
    }
    }