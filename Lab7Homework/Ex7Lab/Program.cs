using Ex7Lab.Cards;
using Ex7Lab.POS;

namespace Ex7Lab
{
    internal class Program
    {
        /*
         * Partea 1 POS-ul:
         * - Un POS-ul va accepta atat plata contactless cat si plata contact-full. Cele doua modalitati de plata vor fi modelate prin intermediul a doua metode,
         * ce vor primi cate doi parametri:
         * -- 1. Suma de plata
         * -- 2. dispozitivul prin care se va efectua plata „ascuns” sub o interfata specifica fiecarui mod de plata.
         * - Pentru plata prin intermediul POS-ului, clientul va putea folosi atat:
         * -- carduri clasice – suporta doar plati contactfull
         * -- carduri contactless - suporta atat plati contact-full cat si plati contactless
         * -- telefoane mobile contactless - suporta doar plati contactless
         *
         * Descrierea interfetelor:
         * - Plata contact-full implica urmatoarele operatiuni:
         * -- Introduce
         * -- EfectueazaPlata
         * -- Extrage
         * - Plata contactless implica urmatoarele operatiuni:
         * -- Apropie
         * -- EfectueazaPlata
         * - Instantiati casa, carduri, telefoane, efectuati plati.
         * - Scrieti clasa, apelati metodele, efectuati plati. Pentru verificarea functionarii programului, metodele descrise vor afisa pe ecran mesaje adecvate.
         *
         * Partea a 2-a Casa de marcat:
         * - Casa de marcat va oferi metode de plata cash sau prin intermediul unui POS.
         *      • In cazul platii cash, casa de marcat
         *          1. va deschide un seif
         *          2. va introduce suma in seif
         *          3. va inchide seif-ul
         *          4. Va elibera chitanta
         *      -- Aceasta functionalitate va fi modelata printr-o metoda care va primi un singur parametru, suma de plata. La fiecare dintre operatiunile de mai sus,
         *      un mesaj corespunzator va fi afisat pe ecran
         * 
         *      • In cazul platii cu cardul, casa de marcat
         *          1. Va trimite POS-ului suma de plata
         *              ▪ Comunicarea cu POS-ul va fi realizata prin intermediul unei interfete
         *          2. va pune la dispozitia clientului POS-ul.
         *              ▪ Pos-ul pus la dispozitia clientului va avea “incarcata” suma de plata
         *              ▪ Clientul (functia main) va decide modalitatea de plata prin intermediul cardului (contactless/contactfull)
         *      --Scrieti clasele, apelati metodele, efectuati plati. Pentru verificarea functionarii programului, metodele descrise vor afisa pe ecran mesaje adecvate.
         */
        public static void Main(string[] args)
        {
            // p1
            Pos pos = new Pos();
            ContactlessCard contactlessCard = new ContactlessCard();
            ClassicCard classicCard = new ClassicCard();
            SmartPhone phone = new SmartPhone();
            SmartWatch smartWatch = new SmartWatch();
            
            pos.PlatesteContactfull(classicCard);
            pos.PlatesteContactfull(contactlessCard);
            
            pos.PlatesteContactless(phone);
            pos.PlatesteContactless(contactlessCard);
            
            pos.PlatesteContactless(smartWatch);
            
            DumbWatch dumbWatch = new DumbWatch();
            dumbWatch.AddPhone(phone);
            
            pos.PlatesteContactless(dumbWatch);
            
            // p2
            Register cashRegister = new Register();
            
            cashRegister.AddPos(pos);

            Pos posBun = cashRegister.PlataCuCardul(1000.0);
            posBun.PlatesteContactfull(classicCard);

            posBun = cashRegister.PlataCuCardul(5000.0);
            posBun.PlatesteContactfull(contactlessCard);

            cashRegister.PlataCuCardul(2000.0).PlatesteContactless(contactlessCard);
        }
    }
}