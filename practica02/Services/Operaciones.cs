using System;
using WSDL.mensajes;
using System.Collections;

namespace WSDL.operaciones{
    public class Operaciones : Mensajes{
        ArrayList arreglo = new ArrayList();

        public string Saludar(string nombre){
            string msj = "hola " + nombre;
            arreglo.Add(msj);
            return msj;
        }

        public string Mostrar(int id){
            string dato = (string)arreglo[id];
            return dato;
        }
    }

}