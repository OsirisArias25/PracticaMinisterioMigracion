using LumenWorks.Framework.IO.Csv;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace Practica.Paises
{
    public class OperacionesPaises
    {
        
        public List<SelectListItem> ListadoDePaises() 
        {

            var listado_paises = new List<Paises>();

            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead("./Paises/countrys.csv")), true))
            {
                csvTable.Load(csvReader);
            }

            for (int i = 0; i < csvTable.Rows.Count; i++)
            {
                listado_paises.Add(new Paises 
                { 
                    EnglishShortName = csvTable.Rows[i][0].ToString(), 
                    Alpha3Code = csvTable.Rows[i][2].ToString()
                });
            }

            var listado = new List<SelectListItem>();
            foreach(var pais in listado_paises)
            {
                listado.Add(new SelectListItem { Text = pais.EnglishShortName, Value = pais.Alpha3Code });
            }

            return listado;
        }

    }
}
