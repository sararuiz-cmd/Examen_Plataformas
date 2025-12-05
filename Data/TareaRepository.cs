using System;
using System.Collections.Generic;
using System.IO;
using CollabSecure.Domain;

namespace CollabSecure.Data
{
    public class TareaRepository
    {
        private string ruta = "tareas.txt";

        public void Guardar(Tarea tarea)
        {
            string linea = $"{tarea.Autor}|{tarea.Contenido}|{tarea.Fecha}";
            File.AppendAllLines(ruta, new[] { linea });
        }

        public List<Tarea> Cargar()
        {
            var lista = new List<Tarea>();

            if (!File.Exists(ruta))
                return lista;

            foreach (var linea in File.ReadAllLines(ruta))
            {
                var partes = linea.Split('|');
                if (partes.Length == 3)
                {
                    lista.Add(new Tarea
                    {
                        Autor = partes[0],
                        Contenido = partes[1],
                        Fecha = DateTime.Parse(partes[2])
                    });
                }
            }

            return lista;
        }
    }
}
