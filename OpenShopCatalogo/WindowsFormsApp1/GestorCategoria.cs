using System;
using System.Collections.Generic;


namespace WindowsFormsApp1
{
    public class GestorCategoria
    {

        public static Categoria Tecnologia = new Categoria();
        public static Categoria Deporte = new Categoria();
        public static Categoria Limpieza = new Categoria();
        public static Categoria Indumentaria = new Categoria();

        public static List<Categoria> ListaCategorias = new List<Categoria>();

        public static void AgregarCategorias()
        {

            Tecnologia.IdCategoria = 0;
            Tecnologia.Nombre = "Tecnologia";

            Deporte.IdCategoria = 1;
            Deporte.Nombre = "Deportes";


            Limpieza.IdCategoria = 2;
            Limpieza.Nombre = "Limpieza";


            Indumentaria.IdCategoria = 3;
            Indumentaria.Nombre = "Indumentaria";


            ListaCategorias.Add(new Categoria(Tecnologia.IdCategoria, Tecnologia.Nombre));
            ListaCategorias.Add(new Categoria(Deporte.IdCategoria, Deporte.Nombre));
            ListaCategorias.Add(new Categoria(Limpieza.IdCategoria, Limpieza.Nombre));
            ListaCategorias.Add(new Categoria(Indumentaria.IdCategoria, Indumentaria.Nombre));

        }

    }
}

