using System;

namespace Eleve
{
    public class classElev
    {
        public int idEleve { get; set; }
        public string nom { get; set; }
        public int nbNote;
        public int[] tnot;




        public classElev(int id, string nom, int nbNote, int[] tnot)
        {
            this.idEleve = id;
            this.nom = nom;
            this.nbNote = nbNote;
            this.tnot = tnot;
        }

        public double moyenne()
        {
            double res = 0;

            for(int i = 0;i < nbNote; i++)
            {
                res += tnot[i];
            }
            res = res / nbNote;
            return res;
        }
    }
    class classElevLV3 : classElev
    {
        public int noteLV3 { get; set; }
        public classElevLV3(int id, string nom, int nbNote, int[] tnot, int noteLV3) : base(id, nom, nbNote,tnot)
            {
                this.noteLV3 = noteLV3;
            }
        public double moyenneLV3()
        {
            double res = 0;
            for (int i = 0; i < nbNote; i++)
            {
                res += tnot[i];
            }
            res += noteLV3;
            res = res / (nbNote+1);
            return res;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            
            classElev eleve1 = new classElev(1,"thomas",8,new int[] {18,15,14,12,16,20,14,2 });
            Console.WriteLine("id eleve= " + eleve1.idEleve);
            Console.WriteLine("nom eleve= " + eleve1.nom);
            Console.Write("Note eleve= ");
            for(int i = 0; i < eleve1.nbNote; i++)
            {
                Console.Write(eleve1.tnot[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("nombre de note eleve= " + eleve1.nbNote);
            Console.WriteLine("moyenne eleve= " + eleve1.moyenne());
            Console.WriteLine("");
            classElev eleve2 = new classElev(2, "Frédérick", 5, new int[] { 10, 5, 1, 2, 0 });
            Console.WriteLine("id eleve= " + eleve2.idEleve);
            Console.WriteLine("nom eleve= " + eleve2.nom);
            Console.Write("Note eleve= ");
            for (int i = 0; i < eleve2.nbNote; i++)
            {
                Console.Write(eleve2.tnot[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("nombre de note eleve= " + eleve2.nbNote);
            Console.WriteLine("moyenne eleve= " + eleve2.moyenne());
            Console.WriteLine("");
            classElev eleve3 = new classElev(3, "Marguérite", 9, new int[] { 19, 17, 5, 17, 20, 20, 4, 2,0 });
            Console.WriteLine("id eleve= " + eleve3.idEleve);
            Console.WriteLine("nom eleve= " + eleve3.nom);
            Console.Write("Note eleve= ");
            for (int i = 0; i < eleve3.nbNote; i++)
            {
                Console.Write(eleve3.tnot[i] + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("nombre de note eleve= " + eleve3.nbNote);
            Console.WriteLine("moyenne eleve= " + eleve3.moyenne());
            Console.WriteLine("");
            classElevLV3 eleve4 = new classElevLV3(4, "Stéfanyii", 10, new int[] { 19, 17, 16, 17, 20, 20, 18, 19, 20,15 },19);
            Console.WriteLine("id eleve= " + eleve4.idEleve);
            Console.WriteLine("nom eleve= " + eleve4.nom);
            Console.Write("Note eleve= ");
            for (int i = 0; i < eleve4.nbNote; i++)
            {
                Console.Write(eleve4.tnot[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Note LV3=" + eleve4.noteLV3);
            Console.WriteLine("nombre de note eleve= " + eleve4.nbNote  + 1);
            Console.WriteLine("moyenne eleve= " + eleve4.moyenneLV3());
        }
    }
}
