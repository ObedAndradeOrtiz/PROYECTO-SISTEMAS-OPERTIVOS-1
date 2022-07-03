using System;
using System.Collections.Generic;
using System.Text;

namespace ProySistemasOperativos1
{
    
    static class Constants
    {
        public const int MAX = 200;
    }
    class Cola
    {
        private PCB[] V ;
        private int ini;
        private int fin;
        public int cantQ=1;
        public Cola()
        {
            V = new PCB [cantQ];
            Init();
        }
        public void Init()
        {
            ini = 0;
            fin = -1;
        }
        public bool Vacia()
        {
            return ini == fin-1;
        }
        public bool Llena()
        {
            return (V.Length==cantQ);
        }
        public void Meter(PCB P)
        {
                fin = siguiente(fin);
                Array.Resize(ref V,fin+1);
                V[fin] = P;
        }
        public PCB Sacar()
        {
            PCB aux = V[ini];         
            ini = siguiente(ini);
            return aux;
        }
        int siguiente(int e)
        {
            if(e+1==cantQ) 
            {
                return 0;
            }
            return e + 1;

        }
    }
}
