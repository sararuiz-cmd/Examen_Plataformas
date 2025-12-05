using CollabSecure.Domain;

using System.Collections.Generic;

using System.IO;

using System.Text.Json;



namespace CollabSecure.Data

{

    public class TareaRepository

    {

        private string ruta = "tareas.json";



        public void Guardar(Tarea tarea)

        {

            var lista = Cargar();

            lista.Add(tarea);

            File.WriteAllText(ruta, JsonSerializer.Serialize(lista));

        }



        public List<Tarea> Cargar()

        {

            if (!File.Exists(ruta))

                return new List<Tarea>();



            string json = File.ReadAllText(ruta);

            return JsonSerializer.Deserialize<List<Tarea>>(json);

        }

    }

}