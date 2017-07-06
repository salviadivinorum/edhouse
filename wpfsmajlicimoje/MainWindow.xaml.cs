using System.Collections.Generic;
using System.Windows;
using System.Diagnostics;

namespace wpfsmajlicimoje
{
    // Predpokladem je zaply Vystup z Debuggeru, tam se hlasi data programu !
    // Vysledkem je MessageBox co hlasi string - radu ctvercu:
    // radu ctvercu je e formatu napr, "A1B2C3 D4E1F2 G1H1I3" - logicky 1.rada, 2.rada, 3. rada ctverecku
   

    public partial class MainWindow : Window
    {
        List<string[]> source = new List<string[]>();
        List<string> permutatitons = new List<string>();
        NineSmileys deska = new NineSmileys();
        bool uspech = false;
        int pocitadloPermutaci = 1;
        
        public MainWindow()
        {
            InitializeComponent();    
        }

        // startuju vypocet tlacitkem, testovaci rezim !
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoToho();
        }

        public void DoToho()
        {       
            do
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Reset();
                stopWatch.Start();  
                source = new List<string[]> {   deska.AllA.RandomElement(), deska.AllB.RandomElement(), deska.AllC.RandomElement(),
                                                deska.AllD.RandomElement(), deska. AllE.RandomElement(), deska.AllF.RandomElement(),
                                                deska.AllG.RandomElement(), deska.AllH.RandomElement(), deska.AllI.RandomElement() };
                
                permutatitons = Permutations.Test(source);
                
                // vlastni porovnani zda sedi oci+pusa+barva sousednich ctvercu
                Porovnani();
                stopWatch.Stop();
                Debug.Print($"Cyklus vypoctu a porovnani {permutatitons.Count} permutaci trval {stopWatch.ElapsedMilliseconds} milisekund");
                stopWatch.Reset();
            }
            while (uspech == false);
        }

        
        // prakticky = vypoce 9! permutaci + jejich porovnani na smajliky trva cca 1.07s
        // 4^9 moznosti otoceni * 9! = 9.5 E10 * 1.07s = 3,5 dne vypoctu vsech moznosti
        public void Porovnani()
        {
            for (int i = 0; i < permutatitons.Count; i++)
            {
                // A) Nejprve hledam ID v poli vypoctenych permutaci "permutations"

                // stredovy kriz
                string E = permutatitons[i].Substring(8, 2);
                string B = permutatitons[i].Substring(2, 2);
                string D = permutatitons[i].Substring(6, 2);
                string F = permutatitons[i].Substring(10, 2);
                string H = permutatitons[i].Substring(14, 2);

                // leva vertikala 
                string A = permutatitons[i].Substring(0, 2);
                string G = permutatitons[i].Substring(12, 2);

                // prava vertikala 
                string C = permutatitons[i].Substring(4, 2);
                string I = permutatitons[i].Substring(16, 2);


                // pak hledam v listove michacce "vseSplacano"

                // stredovy kriz
                string[] EE = deska.vseSplacano.Find(x => x[0] == E);
                string[] BB = deska.vseSplacano.Find(x => x[0] == B);
                string[] DD = deska.vseSplacano.Find(x => x[0] == D);
                string[] FF = deska.vseSplacano.Find(x => x[0] == F);
                string[] HH = deska.vseSplacano.Find(x => x[0] == H);


                //leva vertikala
                string[] AA = deska.vseSplacano.Find(x => x[0] == A);
                string[] GG = deska.vseSplacano.Find(x => x[0] == G);

                // prava vertikala
                string[] CC = deska.vseSplacano.Find(x => x[0] == C);
                string[] II = deska.vseSplacano.Find(x => x[0] == I);
                


                // B) A nakonec otestuju ctverce zda sedi oci+pusa+barva
                if (
                   // podminka na kriz  = NAJDE 4 SMAJLIKY
                   (EE[1].Substring(2, 2) == BB[3].Substring(2, 2)) &&
                   (EE[1].Substring(0, 2) != BB[3].Substring(0, 2)) &&

                   (EE[2].Substring(2, 2) == FF[4].Substring(2, 2)) &&
                   (EE[2].Substring(0, 2) != FF[4].Substring(0, 2)) &&

                   (EE[3].Substring(2, 2) == HH[1].Substring(2, 2)) &&
                   (EE[3].Substring(0, 2) != HH[1].Substring(0, 2)) &&

                   (EE[4].Substring(2, 2) == DD[2].Substring(2, 2)) &&
                   (EE[4].Substring(0, 2) != DD[2].Substring(0, 2)) &&
                    // az sem to zvladne spravne vypocitat do 0s


                    //podminka na levou vertiaklu = NAJDE CELKEM 6 SMAJLIKU
                    (DD[1].Substring(2, 2) == AA[3].Substring(2, 2)) &&
                    (DD[1].Substring(0, 2) != AA[3].Substring(0, 2)) &&
                    // az sem to zvladne spravne vypocitat do 10ms

                    (DD[3].Substring(2, 2) == GG[1].Substring(2, 2)) &&
                    (DD[3].Substring(0, 2) != GG[1].Substring(0, 2))
                    // az sem to zvladne spravny vysleddek do 30s vypocist


                    // podminka na pravou vertikalu  - NAJDE CELKEM 8 SMAJLIKU 
                    /*
                    (FF[1].Substring(2, 2) == CC[3].Substring(2, 2)) &&
                    (FF[1].Substring(0, 2) != CC[3].Substring(0, 2)) &&
                    (FF[3].Substring(2, 2) == II[1].Substring(2, 2)) &&
                    (FF[3].Substring(0, 2) != II[1].Substring(0, 2)) 
                    */
                    // az sem to zvladne spravny vysleddek do 6min vypocist


                    // mozna to ma smysl porovnavat dal, moznosti ks desek = 4^9 * 9! = 9.5 E10 = 3.5dne vypoctu (MAXIMALNE)
                    // diky technice pseudonahodneho vyberu pocatecniho otoceni crtverecku je pravdepodobnost nalezu casove jina mozna nizsi
                    // odstran spodni komentar a cekej 3.2 dny 

                    /*
                    // horni veritkala - NAJDE CELKEM 10 SMAJLIKU
                    (AA[2].Substring(2,2) == BB[4].Substring(2,2)) &&
                    (AA[2].Substring(0,2) != BB[4].Substring(0,2)) &&
                    (BB[2].Substring(2,2) == CC[4].Substring(2,2)) &&
                    (BB[2].Substring(0,2) != CC[4].Substring(0,2)) &&

                    //dolni vertikala - NAJDE CELKEM VSECH 12 SMAJLIKU
                    (GG[2].Substring(2,2) == HH[4].Substring(2,2)) &&
                    (GG[2].Substring(0,2) != HH[4].Substring(0,2)) &&
                    (HH[2].Substring(2, 2) == II[4].Substring(2, 2)) &&
                    (HH[2].Substring(0, 2) != II[4].Substring(0, 2)) 
                    */

                    )
                {
                    MessageBox.Show("NASEL JSEM PERMUTACI CTVERCU CO VYHOVI:          " + permutatitons[i]);
                    uspech = true;
                }
                else
                {
                    uspech = false;

                }
            }


            if (uspech == false)
            {
                pocitadloPermutaci++;
                Debug.Print($" Pocet permutaci {pocitadloPermutaci.ToString()} ");
                return;
            }

        }
        
    }

}



        

