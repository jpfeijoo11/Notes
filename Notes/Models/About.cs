using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Models;

internal class About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://aka.ms/maui";
    public string Message => "Hola, soy Juan Feijoo, desarrollador apasionado por la tecnología, el aprendizaje constante y la creación de soluciones digitales que generen impacto positivo. Me interesa el desarrollo de software multiplataforma, la inteligencia artificial y la innovación educativa. Esta aplicación es parte de mi camino como estudiante y creador, donde combino creatividad, lógica y ganas de seguir creciendo en el mundo del desarrollo. ¡Gracias por visitar esta sección y ser parte de esta experiencia!";
}
