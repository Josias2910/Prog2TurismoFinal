using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProg2
{
    public partial class Form1 : Form
    {
        private List<Destino> listaDestinosPreCargada = new List<Destino>();     
        private Turismo t;
        private Paquete p;
        public Form1()
        {
            InitializeComponent();
            string data = "data.dat";
            FileStream fs = null;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(data))
            {
                try
                {
                    fs = new FileStream(data, FileMode.Open, FileAccess.Read);
                    t = (Turismo)bf.Deserialize(fs);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    t = new Turismo(new Destino(0, "", 0));
                }
                finally
                {
                    if (fs != null) fs.Close();
                }
            }
            else
            {
                t = new Turismo(new Destino(0, "", 0));
            }            
            listaDestinosPreCargada.Add(new Destino(1001,"Bariloche", 9580));
            listaDestinosPreCargada.Add(new Destino(2003,"Cataratas", 8500));
            listaDestinosPreCargada.Add(new Destino(1004,"San Rafael MZA", 9300));
        }
        private void btnGenerarPaquete_Click(object sender, EventArgs e)
        {
            VentaPaquetes vp = new VentaPaquetes();

            foreach (Destino d in listaDestinosPreCargada)
                vp.cbxDestino.Items.Add(d);

            if (vp.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Destino destino = vp.cbxDestino.SelectedItem as Destino;
                    if (destino == null)
                    {
                        MessageBox.Show("Debe seleccionar un destino válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string nombre = vp.tbNombre.Text;
                    string cuit = vp.tbCuit.Text;
                    long telefono = Convert.ToInt64(vp.tbTelefono.Text);
                    string tarjeta = vp.tbTarjeta.Text;
                    Cliente cliente = new Cliente(nombre, cuit, telefono, tarjeta);

                    p = new Paquete(cliente, destino);
                    int idxIda = vp.cbxTransporteIda.SelectedIndex;
                    if (idxIda == 0) 
                    {
                        string patenteIda = vp.tbPatenteIda.Text;
                        Transporte bus = new Bus(patenteIda, 3, destino);
                        p.AgregarTransporte(bus);
                    }
                    else if (idxIda == 1) 
                    {
                        string vueloIda = vp.tbPatenteIda.Text;
                        Transporte avion = new Avion(vueloIda, destino);
                        p.AgregarTransporte(avion);
                    }
                    int idxVuelta = vp.cbxTransporteVuelta.SelectedIndex;
                    if (idxVuelta == 0) 
                    {
                        string patenteVuelta = vp.tbPatenteVuelta.Text;
                        Transporte bus = new Bus(patenteVuelta, 3, destino);
                        p.AgregarTransporte(bus);
                    }
                    else if (idxVuelta == 1) 
                    {
                        string vueloVuelta = vp.tbPatenteVuelta.Text;
                        Transporte avion = new Avion(vueloVuelta, destino);
                        p.AgregarTransporte(avion);
                    }
                    if (p == null || p.ToString().Contains(";") == false)
                    {
                        MessageBox.Show("Debe agregar al menos un transporte válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    MessageBox.Show("Paquete creado con exito");
                    t.AgregarDestino(destino);
                    t.AgregarPaquete(p);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error de formato: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DatoInvalidoException ex)
                {
                    MessageBox.Show("Dato inválido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            vp.Dispose();
        }

        private void btnCargarDestinos_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            ofd.Title = "Cargar destinos desde archivo";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string ruta = ofd.FileName;
                try
                {
                    ImportarDestinos importados = new ImportarDestinos(t.GetDestinos());
                    importados.CargarArchivo(ruta);
                    foreach(Destino d in t.GetDestinos())
                    {
                        lbDestinos.Items.Add(d);
                    }
                    MessageBox.Show("Destinos cargados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar destinos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            Resumen r = new Resumen();
            try
            {
                string[] paquetes = t.MostrarPaquetesOrdenados();
                if (paquetes.Length == 0)
                {
                    MessageBox.Show("No hay paquetes cargados aún.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                r.lbDestinos.Items.Clear();
                r.lbDestinos.Items.AddRange(paquetes);
                r.ShowDialog();
                r.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al mostrar paquetes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileStream fs = null;
            BinaryFormatter bf = new BinaryFormatter();
            string data = "data.dat";
            try
            {
                fs = new FileStream(data, FileMode.Create, FileAccess.Write);
                bf.Serialize(fs, t);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
    }
}
