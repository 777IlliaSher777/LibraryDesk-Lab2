using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDesk.Core
{
    // клас
    public class vidacha
    {
        public string id;
        public string reader;
        public List<string[]> pr = new List<string[]>();
        public int st = 0; // 0-нова,1-видана,2-повернута,3-скасована
        public DateTime dt;
        // public string prim; // примітка, поки не треба

        // конструктор
        public vidacha(string a, string b)
        {
            id = a; // ставимо id
            reader = b; // ставимо читача
            dt = DateTime.Now; // ставимо дату
        }

        // метод додавання
        public void Add(string s, int k)
        {
            string[] t = new string[2];
            t[0] = s; t[1] = k.ToString();
            pr.Add(t); // додаємо t у pr
        }

        // ProcessData
        public int ProcessData()
        {
            int sum1 = 0; int kolvo = 0;
            for (int i = 0; i < pr.Count; i++)
            {
                int k = int.Parse(pr[i][1]);
                sum1 = sum1 + k; // додаємо кількість примірників
                kolvo = kolvo + 1; // збільшуємо kolvo на одиницю
            }

            if (sum1 < 0) sum1 = 0;
            return sum1; // повертаємо sum1
        }

        // міняємо статус
        public bool Chg(int n)
        {
            if (st == 0 && n == 1) { st = 1; return true; }
            if (st == 1 && n == 2) { st = 2; return true; }
            if (st == 0 && n == 3) { st = 3; return true; }
            return false; // не можна
        }

        // перевірка
        public bool Ck()
        {
            if (id != null && id != "" && reader != null && reader.Length > 2 && pr.Count > 0 && pr.Count < 100 && st >= 0 && st <= 3)
                return true;
            else
                return false;
        }

        // звіт
        public string Rep()
        {
            string s = "";
            for (int i = 0; i < pr.Count; i++)
            {
                s = s + "Примірник: " + pr[i][0] + "; кількість: " + pr[i][1] + "\n";
            }
            s = s + "Загальна кількість виданих примірників: " + ProcessData() + "\n";
            return s; // повертаємо s
        }

        // пошук
        public static vidacha F(List<vidacha> L, string x)
        {
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i].id == x) { return L[i]; }
            }
            return null;
        }
    }
}