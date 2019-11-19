using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTareasForma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Tarea> ListaTarea = new List<Tarea>();
        int fila;

        private void Form1_Load(object sender, EventArgs e)

        {

        }
        public void Agregar()
        {
            Tarea TAREA = new Tarea();

            TAREA.NombreUsuario = NombreUsuariotxt.Text;
            TAREA.tarea = Tareatxt.Text;
            TAREA.Hora = Horatxt.Text;
            TAREA.Fecha = Fechatxt.Text;
            TAREA.Estatus = Estadotxt.Text;
            ListaTarea.Add(TAREA);

            DtvTareas.Rows.Add();
            int filas = DtvTareas.Rows.Count - 1;
            DtvTareas[0, filas].Value = TAREA.NombreUsuario;
            DtvTareas[1, filas].Value = TAREA.tarea;
            DtvTareas[2, filas].Value = TAREA.Hora;
            DtvTareas[3, filas].Value = TAREA.Fecha;  
            DtvTareas[4, filas].Value = TAREA.Estatus;

            

            NombreUsuariotxt.Text = "";
            Tareatxt.Text = "";
            Horatxt.Text = "";
            Fechatxt.Text = "";
            Estadotxt.Text = "";
            NombreUsuariotxt.Focus();
        }

      
        public void Editar()
        {
            Tarea TAREA = new Tarea();

            TAREA.NombreUsuario = NombreUsuariotxt.Text;
            TAREA.tarea = Tareatxt.Text;
            TAREA.Hora = Horatxt.Text;
            TAREA.Fecha = Fechatxt.Text;
            TAREA.Estatus = Estadotxt.Text;
            ListaTarea.Add(TAREA);

            DtvTareas[0, fila].Value = NombreUsuariotxt.Text;
            DtvTareas[1, fila].Value = Tareatxt.Text;
            DtvTareas[2, fila].Value = Horatxt.Text;
            DtvTareas[3, fila].Value = Fechatxt.Text;
            DtvTareas[4, fila].Value = Estadotxt.Text;

            NombreUsuariotxt.Text = "";
            Tareatxt.Text = "";
            Horatxt.Text = "";
            Fechatxt.Text = "";
            Estadotxt.Text = "";
            NombreUsuariotxt.Focus();

        }


        private void Agregarbtn_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void Editarbtn_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void DtvTareas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = DtvTareas.CurrentRow.Index;
            NombreUsuariotxt.Text = DtvTareas.CurrentRow.Cells[0].Value.ToString();
            Tareatxt.Text = DtvTareas.CurrentRow.Cells[1].Value.ToString();
            Horatxt.Text = DtvTareas.CurrentRow.Cells[2].Value.ToString();
            Fechatxt.Text = DtvTareas.CurrentRow.Cells[3].Value.ToString();
            Estadotxt.Text = DtvTareas.CurrentRow.Cells[4].Value.ToString();

            Agregarbtn.Enabled = false;

        }
    }
}
