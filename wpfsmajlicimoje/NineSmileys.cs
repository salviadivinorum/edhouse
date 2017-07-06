using System.Collections.Generic;

namespace wpfsmajlicimoje
{
    // zdroj dat - policka
    public class NineSmileys
    {
        // konstruktor
        public NineSmileys() { }

        // VSECHNY mozne ctverce vyskutjici  se na desce ... to kvuli mozne rotaci ctvercu 0,90,180,270 stupnu = A1,A2,A3,A4
        // Priklad: A1[ID pole, pusa+cervena nahore, pusa+zelena vpravo, oci+cerevena dole, oci+zelena vlevo]
        // Prikla: A2 - totez co A1 jen otoceno o 90° doprava

        static string[] A1 = { "A1", "puce", "puzl", "occe", "ocze" }; 
        static string[] A2 = { "A2", "ocze", "puce", "puzl", "occe" };
        static string[] A3 = { "A3", "occe", "ocze", "puce", "puzl" };
        static string[] A4 = { "A4", "puzl", "occe", "ocze", "puce" };

        static string[] B1 = { "B1", "ocmo", "oczl", "pumo", "puze" };
        static string[] B2 = { "B2", "puze", "ocmo", "oczl", "pumo" };
        static string[] B3 = { "B3", "pumo", "puze", "ocmo", "oczl" };
        static string[] B4 = { "B4", "oczl", "pumo", "puze", "ocmo" };

        static string[] C1 = { "C1", "occe", "oczl", "pumo", "puzl" };
        static string[] C2 = { "C2", "puzl", "occe", "oczl", "pumo" };
        static string[] C3 = { "C3", "pumo", "puzl", "occe", "oczl" };
        static string[] C4 = { "C4", "oczl", "pumo", "puzl", "occe" };

        static string[] D1 = { "D1", "puce", "ocmo", "ocze", "puce" };
        static string[] D2 = { "D2", "puce", "puce", "ocmo", "ocze" };
        static string[] D3 = { "D3", "ocze", "puce", "puce", "ocmo" };
        static string[] D4 = { "D4", "ocmo", "ocze", "puce", "puce" };

        static string[] E1 = { "E1", "ocmo", "ocze", "puce", "puzl" };
        static string[] E2 = { "E2", "puzl", "ocmo", "ocze", "puce" };
        static string[] E3 = { "E3", "puce", "puzl", "ocmo", "ocze" };
        static string[] E4 = { "E4", "ocze", "puce", "puzl", "ocmo" };

        static string[] F1 = { "F1", "pumo", "puzl", "occe", "ocze" };
        static string[] F2 = { "F2", "ocze", "pumo", "puzl", "occe" };
        static string[] F3 = { "F3", "occe", "ocze", "pumo", "puzl" };
        static string[] F4 = { "F4", "puzl", "occe", "ocze", "pumo" };

        static string[] G1 = { "G1", "pumo", "puze", "oczl", "ocmo" };
        static string[] G2 = { "G2", "ocmo", "pumo", "puze", "oczl" };
        static string[] G3 = { "G3", "oczl", "ocmo", "pumo", "puze" };
        static string[] G4 = { "G4", "puze", "oczl", "ocmo", "pumo" };

        static string[] H1 = { "H1", "ocmo", "puce", "pumo", "oczl" };
        static string[] H2 = { "H2", "oczl", "ocmo", "puce", "pumo" };
        static string[] H3 = { "H3", "pumo", "oczl", "ocmo", "puce" };
        static string[] H4 = { "H4", "puce", "pumo", "oczl", "ocmo" };

        static string[] I1 = { "I1", "oczl", "puce", "puze", "ocze" };
        static string[] I2 = { "I2", "ocze", "oczl", "puce", "puze" };
        static string[] I3 = { "I3", "puze", "ocze", "oczl", "puce" };
        static string[] I4 = { "I4", "puce", "puze", "ocze", "oczl" };

        // seskupeni do kategorii
        List<string[]> AX = new List<string[]>() { A1, A2, A3, A4 };
        List<string[]> BX = new List<string[]>() { B1, B2, B3, B4 };
        List<string[]> CX = new List<string[]>() { C1, C2, C3, C4 };
        List<string[]> DX = new List<string[]>() { D1, D2, D3, D4 };
        List<string[]> EX = new List<string[]>() { E1, E2, E3, E4 };
        List<string[]> FX = new List<string[]>() { F1, F2, F3, F4 };
        List<string[]> GX = new List<string[]>() { G1, G2, G3, G4 };
        List<string[]> HX = new List<string[]>() { H1, H2, H3, H4 };
        List<string[]> IX = new List<string[]>() { I1, I2, I3, I4 };

        
        // pomocne splacane pole vsech pripustnych hodnot
        public List<string[]> vseSplacano = new List<string[]>()
        {   A1, A2, A3, A4,
            B1, B2, B3, B4,
            C1, C2, C3, C4,
            D1, D2, D3, D4,
            E1, E2, E3, E4,
            F1, F2, F3, F4,
            G1, G2, G3, G4,
            H1, H2, H3, H4,
            I1, I2, I3, I4 };


    
        // vlastnosti
        public List<string[]> AllA
        {
            get { return AX; }
            set { AX = value; }
        }

        public List<string[]> AllB
        {
            get { return BX; }
            set { BX = value; }
        }

        public List<string[]> AllC
        {
            get { return CX; }
            set { CX = value; }
        }

        public List<string[]> AllD
        {
            get { return DX; }
            set { DX = value; }
        }

        public List<string[]> AllE
        {
            get { return EX; }
            set { EX = value; }
        }

        public List<string[]> AllF
        {
            get { return FX; }
            set { FX = value; }
        }

        public List<string[]> AllG
        {
            get { return GX; }
            set { GX = value; }
        }

        public List<string[]> AllH
        {
            get { return HX; }
            set { HX = value; }
        }

        public List<string[]> AllI
        {
            get { return IX; }
            set { IX = value; }
        }
    }
}



