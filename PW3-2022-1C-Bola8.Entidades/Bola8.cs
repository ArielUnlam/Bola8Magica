using System;
using System.Collections.Generic;

namespace PW3_2022_1C_Bola8.Entidades
{
    public static class Bola8
    {
        public static string Pregunta()
        {
            var random = new Random();
            List <string> respuestasList = new List <string>();

            respuestasList.Add("Es cierto");
            respuestasList.Add("Es decididamente así");
            respuestasList.Add("Sin lugar a dudas.");
            respuestasList.Add("Sí, definitivamente");
            respuestasList.Add("Puedes confiar en ello");
            respuestasList.Add("Respuesta confusa, vuelve a intentarlo.");
            respuestasList.Add("Vuelve a preguntar más tarde.");
            respuestasList.Add("Mejor no decirte ahora.");
            respuestasList.Add("No cuentes con ello");
            respuestasList.Add("Mi respuesta es no.");
            respuestasList.Add("Mis fuentes dicen que no");
            respuestasList.Add("Las perspectivas no son muy buenas");
            respuestasList.Add("Muy dudoso");
            respuestasList.Add("No se puede predecir ahora");
            respuestasList.Add("Concéntrate y vuelve a preguntar");

            int respuestaRnd = random.Next(respuestasList.Count);

            return respuestasList[respuestaRnd];
        }
    }
}
