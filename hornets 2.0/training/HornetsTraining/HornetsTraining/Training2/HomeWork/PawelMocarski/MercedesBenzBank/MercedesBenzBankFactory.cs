﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.HornetsTraining.Training1.Generics.Factory;
using Toci.HornetsTraining.Training2.HomeWork.BankMillenium;
using Toci.HornetsTraining.Training2.HomeWork.BartoszMackiewicz;
using Toci.HornetsTraining.Training2.HomeWork.BZWBK;
using Toci.HornetsTraining.Training2.HomeWork.LukaszCichon.AliorBank;
using Toci.HornetsTraining.Training2.HomeWork.LukaszSmierzchala.ToyotaBank;
using Toci.HornetsTraining.Training2.HomeWork.MarcinJaniak;
using Toci.HornetsTraining.Training2.HomeWork.Mbank;
using Toci.HornetsTraining.Training2.HomeWork.MichalMazur;
using Toci.HornetsTraining.Training2.HomeWork.NBP;
using Toci.HornetsTraining.Training2.HomeWork.PKOBP;
using Toci.HornetsTraining.Training2.HomeWork.SantanderConsumerBank;

namespace Toci.HornetsTraining.Training2.HomeWork.PawelMocarski.MercedesBenzBank
{
    public class MercedesBenzBankFactory : DelegateFactoryBase<TransferHandler>
    {
        public MercedesBenzBankFactory()
        {
            ListOfInstances = new Dictionary<string, Func<TransferHandler>>()
            {
                {"1160", () => new BankMilleniumTransferHandler()},
                {"1060", () => new BphTransferHandler() },
                {"1090", () => new BZWBKTransferHandler() },
                {"2490", () => new AliorBankTransferHandler() },
                {"2160", () => new ToyotaBankTransferHandler() },
                {"2000", () => new RabobankPolskaTransferHandler() },
                {"1140", () => new MBankTransferHandler() },
                {"1050", () => new IngTransferHandler() },
                {"1010", () => new NBPTransferHandler() },
                {"1440", () => new NordeaBankTransferHandler() },
                {"1580", () =>  new MercedesBenzBankTransferHandler() },
                {"1240", () => new PkobpTransferHandler() },
                {"1680", () => new PlusBankTransferHandler() },
                {"2120", () => new SantanderConsumerBankTransferHandler() }
            };

        }
    }
}
