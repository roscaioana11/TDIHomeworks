using System;
using Lab6Ex.Properties;

namespace Lab6Ex
{
    internal class Program
    {
        /**
         * Scrieti un program care va modela conturi bancare. Un cont bancar poate fi cont de economii, cont de investitii sau cont curent si va fi caracterezat de un nume.
         * - In toate conturi le vom putea depune bani.
         * -- La depunerea banilor soldul curent va creste cu valoarea depusa
         *
         * Din toate cont urile vom putea extrage bani
         * - În situatia in care suma ceruta depașește soldul curent, pe ecran va fi afi ș at un mesaj corespunzator iar suma nu va fi extrasa
         *
         * - Contul curent:
         * -- La extragerea numerarului dintr-un cont curent, in cazul in care suma extrasa este mai mare decat cea disponibila in cont,
         * contul va permite descoperirea de cont in limita plafonului de 5000ron.
         * -- Daca suma ceruta depaseste plafonul descoperirii de cont, atunci pe ecran va fi afișat un mesaj corespunzator iar suma nu va fi extrasa
         * - Contul de economii:
         * -- Este carecterizat de o rata a dobanzii
         * -- Dupa fiecare depunere, soldul contului de economii va fi reactualizat tinandu se cont de rata dobanzii:
         * --- ValoareSold = ValoareSold * (1 + rataDobanzii)
         *
         * - Contul de investiții este un cont bancar care se comportă precum un cont de economii, cu mențiunea ca extragerea banilor este posibila abia dupa atingerea termenului de extragere
         * -- La deschiderea unui cont de investitii, ziua termenului de extragere va fi specificat sub forma unui intreg (1-31)
         * -- Dacă se incearcă extragerea banilor înainte de termen, contul va afișa un mesaj corespunzător iar suma nu va fi extrasa din cont.
         * --- Ziua curenta poate fi determinate folosind: DateTime.Now.Day
         *
         * - Toate conturile vor pune la dispozitie descrierea acestora. Descrierea va contine toate detaliile relevante ale contului
         * (nume, tip, sold curent, rata dobanzii, ziua termenului de extragere, etc)
         * - Suplimentar: Conturile vor avea cate un id unic de tip Guid. Id-ul va fi atribuit automat fiecarui cont la creare si va fi expus in descrierea contului.
         * - Implementati clasele , instantiati obiecte si apelati le metodele
         * - Clasa Cont: va detine o metoda prin care va fi calculat numarul total al tuturor conturilor create
         * - Apelati metodele si afisati le rezultatul
         */
        public static void Main(string[] args)
        {
            CurrentAccount currentAccount = new CurrentAccount("Current Account 1", Type.CurrentAccount, 100);
            Console.WriteLine(currentAccount.Description());
            currentAccount.Deposit(100);
            Console.WriteLine(currentAccount.Description());
            currentAccount.Withdraw(800);
            Console.WriteLine(currentAccount.Description());
            
            SavingsAccount savingsAccount = new SavingsAccount("Savings Account 1", Type.SavingsAccount, 100, 2);
            Console.WriteLine(savingsAccount.Description());
            savingsAccount.Deposit(100);
            Console.WriteLine(savingsAccount.Description());
            savingsAccount.Withdraw(200);
            Console.WriteLine(savingsAccount.Description());

            InvestmentAccount investmentAccount =
                new InvestmentAccount("Investment Account 1", Type.InvestmentAccount, 500, 2, Clamp(20, 1, 31));
            Console.WriteLine(investmentAccount.Description());
            investmentAccount.Withdraw(800);
            Console.WriteLine(investmentAccount.Description());

            Console.WriteLine($"Total number of banck accounts: {BankAccount.GetNumberOfAccounts()}");
        }
        
        private static int Clamp(int value, int min, int max )
        {
            return (value < min) ? min : (value > max) ? max : value;
        }
    }
}