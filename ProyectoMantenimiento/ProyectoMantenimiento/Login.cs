using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMantenimiento
{
    public partial class Login : Form
    {
        //Se declaran dos variables de tipo String
        public String id;
        public String user;
        public String tipo;
        public Login()
        {
            InitializeComponent();            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Cierra la ventana
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //minimiza la ventana
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Se valida que no estén vacíos los campos
            if (txtUser.Text == "" || txtPass.Text == "")
            {
                MessageBox.Show("Los campos son obligatorios", "Corregir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Boolean condicion = false;
                try
                {
                //Se consulta que el usuario exista, de existir se da ingreso al Menú
                String sql = String.Format("SELECT * FROM user WHERE usuario = '{0}' AND contrasena = '{1}'", txtUser.Text, txtPass.Text);
                DataRow row = Conexion.Data(sql).Rows[0];
                id = row["id"].ToString();
                tipo = row["tipo"].ToString();
                user = row["id"].ToString();
                condicion = true;                
                }
                catch (Exception)
                {
                    condicion = false;
                    MessageBox.Show("Las credenciales no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Text = "";
                }
                if (condicion)
                {
                    Hide();
                    new menu(this).ShowDialog();
                    Show();
                }                

            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if ((int)e.KeyCode == (int)Keys.Enter)
            {
                //Se valida que no estén vacíos los campos
                if (txtUser.Text == "" || txtPass.Text == "")
                {
                    MessageBox.Show("Los campos son obligatorios", "Corregir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                    //Se consulta que el usuario exista, de existir se da ingreso al Menú
                    String sql = String.Format("SELECT * FROM user WHERE usuario = '{0}' AND contrasena = '{1}'", txtUser.Text, txtPass.Text);
                    DataRow row = Conexion.Data(sql).Rows[0];
                    id = row["id"].ToString();
                    tipo = row["tipo"].ToString();
                    user = row["id"].ToString();
                    Hide();
                    new menu(this).ShowDialog();
                    Show();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Las credenciales no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPass.Text = "";
                    } 

                }
            }
        }
    }
}
