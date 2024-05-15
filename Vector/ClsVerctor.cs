using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vector
{
    class ClsVerctor
    {
        // Propiedades del Vector
        private int[] Vector;
        private int lg;

        // Contructor ->Inicia las propiedades
        public ClsVerctor()
        {
            Vector = new int[100];
            lg = 0;
        }
        // Metodos (propiedades o funciones)
        public void adicionar(int valor)
        {
            Vector[lg] = valor;
            lg = lg + 1;
        }
        // obtener el valor en la posicion p
        public int obtenervalor(int pos) {
            return Vector[pos];
        }
        // longitud del vector
        public int longitud() {
            return lg;
        }
        // Invertir los elementos del vector
        public void invertir() {
            int fin = lg-1;
            int mitad = lg / 2;
            int i = 0;
            int aux = 0;
            while (i<mitad) {
                aux = Vector[fin - i];
                Vector[fin - i] = Vector[i];
                Vector[i] = aux;
                i++;
            }
        }

        //Cantidad de elementos pares
        public int cantpares() {
            int cont = 0;
            for (int i = 0; i < lg; i++) {
                if (Vector[i] % 2 == 0)
                    cont++;
            }
                 return cont;
        }
        // Ordenar los elementos del vector de menor a mayor
        public void OrdenarMenorAmayor() {
            int aux = 0;
            for (int i = 0; i < lg; i++) {
                for (int j = i; j < lg; j++) {
                    if (Vector[i] > Vector[j]) {
                        aux = Vector[j];
                        Vector[j] = Vector[i];
                        Vector[i] = aux;
                    }
                }
            }
        }
        //Eliminar el elemento de la pos. p
        public void EliminarElementoPos(int p) {
            for (int i = p - 1; i < lg; i++) {
                Vector[i] = Vector[i + 1];
            }
            lg = lg - 1;
             
        }
        //INVERTIR ELEMEMENTOS VECTOR
        public void invertirCadaElementoVector()
        {
            int final = lg - 1;
            int i = 0;
            int aux = 0;
            int mitad = lg / 2;
            while (i < mitad) {
                aux = Vector[final - i] = Vector[i];
                Vector[final - i] = Vector[i];
                Vector[i] = aux;
                i++;
            }
            for (var j = lg; j < lg; j++) ;
        }
        //CANTIDAD DE ELEMENTOS PRIMOS
        public int ElementosPrimo() {
            int ElementoPrimo = 0;
            for (int i = 0; i < lg; i++) {
                int num = Vector[i];
                int c = 0;
                for (int j = i; j <= num; j++){
                    if (num % j == 0)
                    {
                        c++;
                    }
                }
                    if (c == 2){
                        ElementoPrimo++;
                    }
                
                }
                return ElementoPrimo;
        }
        //CANTIDAD DE ELEMENTOS CAPICUA
        public int ElementosCapicua() {
            int capi = 0;
            for (int i = 0; i < lg; i++) {
                int num = Vector[i];
                int ac = 0;
                int aux = num;
                while (num > 0) {
                    int r = num % 10;
                    ac = (ac - 10) + r;
                    aux = num / 10;
                }
                if (ac == aux) {
                    capi++;
                }
            }
            return capi;
        }

    }
}
