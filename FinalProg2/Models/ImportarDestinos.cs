using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProg2
{
    [Serializable]
    internal class ImportarDestinos : IImportable
    {
        private List<Destino> listaDestinos;

        public ImportarDestinos(List<Destino> listaDestinos)
        {
            this.listaDestinos = listaDestinos;
        }

        public void CargarArchivo(string ruta)
        {
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                listaDestinos.Clear();
                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    string[] data = linea.Split(';');
                    if (data.Length!= 3)
                    {
                        throw new Exception("Formato de datos incorrecto en la línea: " + linea);
                    }
                    int codigo = Convert.ToInt32(data[0]);
                    string descripcion = data[1];
                    double precioSinImpuestos = Convert.ToDouble(data[2]);
                    Destino destino = new Destino(codigo, descripcion, precioSinImpuestos);
                    listaDestinos.Add(destino);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Error: Archivo no encontrado. " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Formato de datos incorrecto. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar el archivo: " + ex.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
        }
    }
}
