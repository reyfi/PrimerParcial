using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Entity;
using rPrimerParcial.Entidades;
using rPrimerParcial.BLL;
using rPrimerParcial.DAL;


namespace rPrimerParcial.UI.Registro
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private Grupos LlenarClase()
        {
            Grupos grupo = new Grupos();

            grupo.GrupoId = Convert.ToInt32(IdnumericUpDown.Value);
            grupo.Fecha = FechadateTimePicker.Value;
            grupo.Descripcion = DescripciontextBox.Text;
            grupo.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
            grupo.Grupo = Convert.ToInt32(GrupotextBox.Text);
            grupo.integrantes = Convert.ToInt32(IntegrantestextBox.Text);
        
            return grupo;
        }

        //boton guardar
        private void button3_Click(object sender, EventArgs e)
        {
            Grupos grupo = LlenarClase();
            bool Paso = false;

            if (IdnumericUpDown.Value == 0)
                Paso = BLL.GruposBLL.Guardar(grupo);
            else
                Paso = BLL.GruposBLL.Editar(LlenarClase());
            if (Paso)
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo guardar", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);

            if (BLL.GruposBLL.Eliminar(id))
                MessageBox.Show("Eliminado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
