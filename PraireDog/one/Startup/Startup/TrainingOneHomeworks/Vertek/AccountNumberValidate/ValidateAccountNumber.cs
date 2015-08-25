﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup.TrainingOneHomeworks.Vertek.AccountNumberValidation
{
    public abstract class ValidateAccountNumber
    {
        private Dictionary<int, string> BankCode = new Dictionary<int, string>()
        {
            //86 10202498 000086020263XXXX
            {1010, "Narodowy Bank Polski" },
            {1020, "PKO BP" },
            {1030, "Citybank Handlowy" },
            {1050, "ING" },
            {1060, "BPH" },
            {1090, "BZ WBK" },
            {1130, "BGK" },
            {1140, "mBank" },
            {1160, "Bank Milennium" },
            {1240, "Pekao" },
            {1280, "HSBC" },
            {1300, "Meritum Bank" },
            {1320, "Bank Pocztowy" },
            {1440, "Nordea Bank" },
            {1470, "Euro Bank" },
            {1540, "BOŚ" },
            {1580, "Mercedes-Benz Bank Polska" },
            {1600, "BNP Paribas Fortis" },
            {1610, "SGB - Bank" },
            {1670, "RBS Bank(Polska)" },
            {1750, "Raiffeisen Bank" },
            {1840, "Societe Generale" },
            {1870, "FM Bank PBP" },
            {1910, "Deutsche Bank Polska" },
            {1930, "Bank Polskiej Spółdzielczości" },
            {1940, "Credit Agricole Bank Polska" },
            {1950, "Idea Bank" },
            {2000, "Rabobank Polska" },
            {2030, "BGŻ" },
            {2070, "FCE Bank Polska" },
            {2120, "Santander Consumer Bank" },
            {2130, "Volkswagen Bank" },
            {2140, "Fiat Bank Polska" },
            {2160, "Toyota Bank" },
            {2190, "DnB Nord" },
            {2480, "Gettin Noble Bank" },
            {2490, "Alior Bank" }

        };
        string BankName;
        public string CheckNumber(int code)
        {
            BankCode.TryGetValue(code, out BankName);
            return BankName;
        }
    }
}
