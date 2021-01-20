using System;
using System.Collections.Generic;

namespace AbiTest2013
{
    class MenueService
    {

        List<Monatsabrechnung> monatsabrechnungen = new List<Monatsabrechnung>();

        public void Bestellen(int kundenNr, int menueNr, Datum verzehrDatum)
        {
            
        }

        public void ErstelleMonatsabrechnung(int personalNr, int monat, int jahr)
        {
            double betrag = 0;
            var mitarbeiter = GetMitarbeiter(personalNr);

            if(mitarbeiter != null && GetMonatsabrechnung(personalNr, monat, jahr) != null)
            {
                foreach(var b in mitarbeiter.Bestellungen)
                    betrag += b.ErmittlePreis();

                var monatsabrechnung = new Monatsabrechnung(mitarbeiter, monat, jahr, betrag);
                monatsabrechnungen.Add(monatsabrechnung);
            }
        }

        private Mitarbeiter GetMitarbeiter(int personalNr)
        {
            return Mitarbeiter.mitarbeiter[personalNr - 1000];
        }

        public Monatsabrechnung GetMonatsabrechnung(int personalNr, int monat, int jahr)
        {
            var mitarbeiter = GetMitarbeiter(personalNr - 1000);

            foreach (var m in monatsabrechnungen)
                if (personalNr == m.Kunde.PersonalNr && m.Monat == monat && m.Jahr == jahr)
                    return m;

            return null;
        }

        public void SortiereMonatsabrechnungen()
        {
            var monatsabrechnungenArray = monatsabrechnungen.ToArray();

            for(int i = 0; i < monatsabrechnungenArray.Length; i++)
            {
                for(int j = 0; j < monatsabrechnungenArray.Length - (i + 1); j++)
                {
                    int compare = monatsabrechnungenArray[j].Kunde.Name.CompareTo(monatsabrechnungenArray[j - 1].Kunde.Name);
                    if (compare > 0)
                    {
                        var temp = monatsabrechnungen[j];
                        monatsabrechnungenArray[j] = monatsabrechnungenArray[j - 1];
                        monatsabrechnungenArray[j - 1] = temp;
                    }
                    else if(compare == 0)
                    {
                        compare = monatsabrechnungenArray[j].Kunde.Vorname.CompareTo(monatsabrechnungenArray[j + 1].Kunde.Vorname);
                        if(compare > 0)
                        {
                            var temp = monatsabrechnungen[j];
                            monatsabrechnungenArray[j] = monatsabrechnungenArray[j - 1];
                            monatsabrechnungenArray[j - 1] = temp;
                        }
                    }
                }
            }
        }

    }
}
