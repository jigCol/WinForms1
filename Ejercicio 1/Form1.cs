using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class formulario1 : Form
    {

        static bool boolbtnRun = false;
        public formulario1()
        {
            InitializeComponent();
        }

        private void formulario1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a WinForms!");
        }

        private void formulario1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Hasta luego!");
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            if(boolbtnRun == false)
            {
                MessageBox.Show("Cambiando color..");
                boolbtnRun = true;
            }
            
            if(this.BackColor == Color.LightGreen)
            {
            this.BackColor = Color.CornflowerBlue;
            }else if(this.BackColor == Color.CornflowerBlue)
            {
                this.BackColor = Color.LightGreen;
            }
        }

        private void formulario1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            
            if(click.Button == MouseButtons.Left)
            {
                MessageBox.Show("Ha hecho click izquierdo.");
            }else if(click.Button == MouseButtons.Right)
            {
                MessageBox.Show("Ha hecho click derecho");
            }
            else
            {
                MessageBox.Show("Ha presionado la rueda.");
            }
        }

        private void lblTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            lblTitulo.BackColor = Color.Moccasin;
            lblTitulo.Cursor = Cursors.Hand;
        }

        private void lblTitulo_MouseLeave(object sender, EventArgs e)
        {
            lblTitulo.BackColor = Color.Aquamarine;
            lblTitulo.Cursor = Cursors.Arrow;
        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {

            List<TextBox> listaTexto = new List<TextBox>();
            listaTexto.Add(tboxNombre);
            listaTexto.Add(tboxApellido);
            listaTexto.Add(tboxEdad);
            listaTexto.Add(tboxDireccion);

            

            foreach(TextBox textbox in listaTexto)
            {
                if(textbox.Text == "")
                {
                    textbox.BackColor = Color.LightCoral;
                    
                }else if(textbox.Text != "")
                {
                    textbox.BackColor = System.Drawing.SystemColors.Control;
                }
            }

            int conLista = 0;
            foreach(TextBox textbox in listaTexto)
            {
                if(textbox.BackColor == Color.LightCoral)
                {
                    MessageBox.Show("No se han ingresado todos los datos");
                    break;
                }
                else
                {
                    conLista++;
                }

                
            }

            string nombre = "";
            string apellido = "";
            string edad = "";
            string direccion = "";
            if (conLista == 4)
            {
                MessageBox.Show("Se han ingresado los datos correctamente");
                nombre = tboxNombre.Text;
                apellido = tboxApellido.Text;
                edad = tboxEdad.Text;
                direccion = tboxDireccion.Text;

                tboxMulti.AppendText("Nombre: "+nombre+"\r\nApellido: "+apellido+"\r\nEdad: "+edad+"\r\nDireccion: "+direccion);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void tboxMulti_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + tboxMulti.Text.Length + " caracteres.");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            tboxMulti.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
