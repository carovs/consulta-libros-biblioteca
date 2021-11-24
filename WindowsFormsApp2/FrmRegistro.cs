using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FrmRegistro : Form
    { 
        /*se crean las variables para ingresar los registros de usuarios, solo hay un maximo de registro de 10 usuarios*/
        public string[] nombre = new string[10];
        public string[] id = new string[10];
        public string[] cont = new string[10];
        public int con = 0;
        public FrmRegistro()
        {
            InitializeComponent();
            /*se da valores al primer registro, este sera para el administrador*/
            nombre[0] = "admin";
            id[0] = "123";
            cont[0] = "admin123";
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            //validamos que todos los campos este llenos
            if (tbnombre.Text.Length == 0 | tbCedula.Text.Length == 0 | tbContrasena1.Text.Length == 0 | tbContrasena2.Text.Length == 0)
            {
                MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS");
            }
            else
            {
                //creamos una variable que nos va  a servir como switch para cuando una cedula ya esta registrada no me la registre de nuevo
                int again = 1;
                //el for nos va a recorrer todos los registros
                for (int i = 0; i <= con; i++)
                {
                    //comparamos la cedula que se ingresa con las cedulas registradas
                    if (tbCedula.Text == id[i])
                    {
                        MessageBox.Show("la cedula ya esta registrada");
                        again = 0;
                    }
                }
                //si el switch esta encendido o vale 1 se va a registrar una nueva cedula
                if (again == 1)
                {
                    //comparamos que los dos campos de contraseña tengan el mismo valor
                    if (tbContrasena1.Text != tbContrasena2.Text)
                    {
                        MessageBox.Show("las contraseñas no coinciden");
                    }
                    else
                    {
                        //si las dos contraseñas son iguales se guardan los datos de registro y se limpian todos los campos
                        con++;
                        nombre[con] = tbnombre.Text;
                        id[con] = tbCedula.Text;
                        cont[con] = tbContrasena1.Text;
                        tbnombre.Clear();
                        tbCedula.Clear();
                        tbContrasena1.Clear();
                        tbContrasena2.Clear();
                        MessageBox.Show("Registro exitoso");
                    }
                }
            }
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //se crea una variable para guardar la ubicacion del registro si los datos que se ingresan estan registrados
            int ub = -1;
            //se valida que todos los campos esten llenos
            if (tbDocumento.Text.Length == 0 | tbContrasenai.Text.Length == 0)
            {
                MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS");
            }
            else
            {
                //el siguiente for recorre todo el registro
                for (int i = 0; i < 10; i++)
                {
                    //se compara el id ingresado con los del registro y si alguno coincide la variable ub guarda su ubicación
                    if (tbDocumento.Text == id[i])
                    {
                        ub = i;
                    }
                }
                //si se encontro una coincidencia del id se continua validando la clave
                if (ub!= -1)
                {
                    //si la contraseña coincide con la del registro se pasa a el form del programa
                    if(tbContrasenai.Text==cont[ub])
                    {
                        
                        FrBusqueda frBusqueda = new FrBusqueda();
                        frBusqueda.ShowDialog();
                        this.Close();
                    }
                    //si las contraseña que se ingreso no coincide con la del registro se manda un mensaje de advertencia
                    else
                    {
                        MessageBox.Show("contraseña incorrecta");
                    }
                }
                else
                //si no hay ninguna coincidencia del id ingresado con los registrados se envia un mensaje de advertencia
                {
                    MessageBox.Show("usted no esta registrado, porfavor registrese antes de continuar");
                }

            }
        }
    }
}
