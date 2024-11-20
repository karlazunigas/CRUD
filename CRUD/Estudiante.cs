using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class Estudiante
    {
        string nombre;
        string cédula;
        string carnet;
        string carrera;
        string teléfono;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Cédula { get => cédula; set => cédula = value; }
        public string Carnet { get => carnet; set => carnet = value; }
        public string Carrera { get => carrera; set => carrera = value; }
        public string Teléfono { get => teléfono; set => teléfono = value; }
    }
}
