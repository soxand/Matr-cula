using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace Matrícula
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            panelLogin.BackColor = Color.FromArgb(240, Color.White);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int msg, int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario*")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario*";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }


        private void txtContra_Leave(object sender, EventArgs e)
        {
            if (txtContra.Text == "")
            {
                txtContra.Text = "Contraseña*";
                txtContra.UseSystemPasswordChar = false;
                txtContra.ForeColor = Color.DimGray;

            }
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña*")
            {
                txtContra.Text = "";
                txtContra.ForeColor = Color.Black;
                txtContra.UseSystemPasswordChar = true;
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=(EDUARDO\SQLEXPRESS);Initial Cataloge=Matricula; Security=true");
        public void logear(string usuario,string contraseña)
        {
            try {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT DNombreAdministrador, IdAministrador FROM Administrador WHERE usuario=@IdAdministrador AND contraseña= @CContraseñaAdministrador");
                cmd.Parameters.AddWithValue("IdAdministrador", usuario);
                cmd.Parameters.AddWithValue("CContraseñaAdministrador", contraseña);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count==1)
                {
                    this.Hide();
                    Form1 frmo = new Form1();
                    frmo.Show();

                    f
                }
                else MessageBox.Show("Uusario y/o contraseña incorrecta");


            }
            catch (Exception e) {
                MessageBox.Show(e.Message);

            }
            finally { }

        }
    
    }
}
