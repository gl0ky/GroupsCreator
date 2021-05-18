using System;
//using codigo.produccion.Equipos;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Linq;
using GemBox.Spreadsheet;
using System.Collections.Generic;

namespace codigo.console
{
    class Program
    {
        static void Main(string[] args)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            
            if (args.Length == 3)
            {
                string students_path = args[0];
                string topics_path = args[1];
                bool succes = Int32.TryParse(args[2], out int teams_quantity);
                
                if(succes)
                {
                    Console.WriteLine($"{students_path} {topics_path} {teams_quantity}");
                    // var s = new EquipoConstructor();
                    // s.obtenerEstudiantes(students_path);
                    // s.ObtenerTemas(topics_path);
                    // s.GenerarEquipos(teams_quantity);
                    // s.AsignarTemas();
                    // string json = JsonConvert.SerializeObject(s.Equipos, Formatting.Indented);
                    // Console.WriteLine(json)
                }
                
                else
                {
                    usage();
                }
                
            }  
            else if (args.Length < 3 )
            {
                usage();
            }
            
            else if (args.Length > 3)
            {
                usage();
            }
        }
        
        static void usage()
        {
            
            Console.WriteLine("Uso del programa en Linux: ./run.sh /ruta/del/archivo/estudiantes /ruta/del/archivo/temas cantidad de equipos");
            Console.WriteLine(@"Uso del programa en Windows: .\run.bat \ruta\del\archivo\estudiantes \ruta\del\archivo\temas cantidad de equipos");
            Environment.Exit(1);
            
        }
    }
}
