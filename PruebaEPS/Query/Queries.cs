using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaEPS.Query
{
    public class Queries
    {
        public static string Querie(string key) {
            string sp = "";
            Dictionary<string, string> q = new Dictionary<string, string> {
                {"get_departamento",
                    "EXEC EPS.dbo.get_departamento;"
                },
                {"get_especializacion",
                    "EXEC EPS.dbo.get_especializacion;"
                },
                {"get_tipousuario",
                    "EXEC EPS.dbo.get_tipousuario;"
                },
                {"get_tipodocumento",
                    "EXEC EPS.dbo.get_tipodocumento;"
                },
                {"get_horacita",
                    "EXEC EPS.dbo.get_horacita;"
                },
                {"get_cita",
                    "EXEC EPS.dbo.get_cita;"
                },
                {"get_paciente", 
                    "EXEC EPS.dbo.get_paciente"
                },
                {"get_usuarios",
                    "EXEC EPS.dbo.get_usuarios;"
                },
                {"get_paciente_id",
                    "EXEC EPS.dbo.get_paciente_id"
                },
                {"get_paciente_documento",
                    "EXEC EPS.dbo.get_paciente_documento"
                },
                {"get_doctor",
                    "EXEC EPS.dbo.get_doctor"
                },
                {"get_agendadisponible",
                    "EXEC EPS.dbo.get_agendadisponible"
                },
                {"insert_cita",
                    "EXEC EPS.dbo.insert_cita"
                },
                {"get_editpaciente",
                    "EXEC EPS.dbo.get_editpaciente"
                },
                {"get_editusuarios",
                    "EXEC EPS.dbo.get_editusuarios"
                },
                {"get_ciudad",
                    "EXEC EPS.dbo.get_ciudad"
                },
            };

            foreach (KeyValuePair<string, string> consulta in q)
            {
                if (consulta.Key == key) { sp = consulta.Value; }
            }
            return sp;
        }

    }
}
