﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public struct Mascota
    {
        public string NombreMascota;
        public int EdadMascota;
        public string TipoMascota;

        public Mascota(string nNombreMascota, int nEdadMascota, string nTipoMascota)
        {
            NombreMascota = nNombreMascota;
            EdadMascota = nEdadMascota;
            TipoMascota = nTipoMascota;
        }
    }

    public struct Dueño
    {
        public string NombreDueño;
        public int EdadDueño;
        public Mascota Perro;

        public Dueño(string nNombreDueño, int nEdadDueño, string NM, int EM, string TM)
        {
            NombreDueño = nNombreDueño;
            EdadDueño = nEdadDueño;

            Perro = new Mascota(NM, EM, TM);
        }
    }

namespace EjerciciosCSharp3.Capitulo_9
{
    public class Cap9_Ejercicio3
    {
        public void DatosMascota()
        {
            Dueño Du;
            Console.Clear();
            Du.NombreDueño = "Clifford";
            Du.EdadDueño = 22;
            Du.Perro.NombreMascota = "caballo";
            Du.Perro.TipoMascota = "perro";
            Du.Perro.EdadMascota = 20;
            Console.WriteLine("Nombre del Dueño: " + Du.NombreDueño + "\nEdad del Dueño: " + Du.EdadDueño + "\nNombre de la Mascota: " + Du.Perro.NombreMascota + "\nTipo de Mascota: " + Du.Perro.TipoMascota + "\nEdad de La Mascota: " + Du.Perro.TipoMascota);

            Console.ReadKey();
        }
    }
}


