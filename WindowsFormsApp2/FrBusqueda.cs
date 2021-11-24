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
    public partial class FrBusqueda : Form
    {
        //creamos variables para almacenar los registros de los libros
        string[] libros = new string[10];
        string[] autor = new string[10];
        string[] cant = new String[10];
        string[] ubi = new string[10];
        int contt = 3;
        public FrBusqueda()
        {
            InitializeComponent();
            //para efectos del ejercicio siempre se van a tener 3 libros ya registrados a continuacion:
            libros[0] = "historia de dos ciudades";libros[1] = "orgullo y prejuicio";libros[2] = "el lobo estepario";
            autor[0] = "charles dickens";autor[1] = "jane austen";autor[2] = "Hermann Hesse";
            cant[0] ="7";cant[1] ="2";cant[2] ="12";
            ubi[0] = "primer piso";ubi[1] = "segundo piso";ubi[2] = "tercer piso";
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // se crea la variable f como switch para validar si el libro que se busca se encuentra registrado
            int f=0;
            //el for recorre los registros de libros
            for(int i = 0;i<10;i++)
            {
                //se compara si hay alguna coincidencia del registro con el libro que se busca
                if(tbLibroConsulta.Text == libros[i])
                {
                    //si hay coincidencias se muestran los datos del libro y se enciende el switch para saber que si se encontro el libro
                    tbLibroResultado.Text = libros[i];
                    tbAutorResultado.Text = autor[i];
                    tbCantidad.Text = cant[i];
                    tbUbicacion.Text=ubi[i];
                    f = 1;
                }
            }
            // si no hay coincidencias el switch sigue apagado y se envia un mensaje
            if(f==0)
            {
                MessageBox.Show("el libro no se encuentra en la Biblioteca");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //se cierra sesion si se da click en el boton salir
            FrmRegistro frmRegistro = new FrmRegistro();
            frmRegistro.ShowDialog();
        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            // se crea la variable f como switch para validar si el libro que se busca se encuentra registrado 
            int f = 0;
            //el for recorre los registros de libros
            for (int i = 0; i < 10; i++)
            {
                //se compara si hay alguna coincidencia del registro con el autor que se busca
                if (tbAutorConsulta.Text == autor[i])
                {
                    //si hay coincidencias se muestran los datos del libro y se enciende el switch para saber que si se encontro el libro
                    tbLibroResultado.Text = libros[i];
                    tbAutorResultado.Text = autor[i];
                    tbCantidad.Text = cant[i];
                    tbUbicacion.Text = ubi[i];
                    f = 1;
                }
            }
            // si no hay coincidencias el switch sigue apagado y se envia un mensaje
            if (f == 0)
            {
                MessageBox.Show("el libro no se encuentra en la Biblioteca");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //se valida si hay espacio para agregar un nuevo libro
            if(autor[9]==null)
            {
                //se valida que todos los campos esten llenos
                if (tbLibroAgg.Text.Length == 0 | tbAutorAgg.Text.Length == 0 | tbUbiAgg.Text.Length == 0 | tbCantAgg.Text.Length == 0)
                {
                    MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS");
                }
                else
                {
                    //se crea una variable again como switch para saber cuando un libro ya se encuentra registrado
                    int again = 1;
                    //se crea un for que va a recorrer todo el registro para saber si ya esta registrado el libro
                    for (int i = 0; i <10; i++)
                    {
                        //se valida si ya el libro esta registrado y si ya esta se envia un mensaje informando y se apaga el switch para que no registre el libro de nuevo
                        if (tbAutorAgg.Text == autor[i])
                        {
                            MessageBox.Show("el libro ya esta registrado");
                            again = 0;
                        }
                    }
                    //si el libro no esta registrado se registra, se limpian los campos y se envia un mensaje de confirmacion
                    if (again == 1)
                    {
                        libros[contt] = tbLibroAgg.Text; 
                        autor[contt] = tbAutorAgg.Text;
                        ubi[contt] = tbUbiAgg.Text;
                        cant[contt] = tbCantAgg.Text;
                        tbLibroAgg.Clear();
                        tbAutorAgg.Clear();
                        tbUbiAgg.Clear();
                        tbCantAgg.Clear();
                        contt++;
                        MessageBox.Show("el libro se registro con exito");
                    }
                }
            }
            //si no hay espacio en el registro se envia un mensaje informandolo y se limpian los campos
            else
            {
                MessageBox.Show("no se pueden agregar más libros, lista llena");
                tbLibroAgg.Clear();
                tbAutorAgg.Clear();
                tbUbiAgg.Clear();
                tbCantAgg.Clear();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // boton limpia todos los campos de la pantalla
            tbLibroConsulta.Clear();
            tbAutorConsulta.Clear();
            tbLibroResultado.Clear();
            tbAutorResultado.Clear();
            tbUbicacion.Clear();
            tbCantidad.Clear();
            tbLibroAgg.Clear();
            tbAutorAgg.Clear();
            tbUbiAgg.Clear();
            tbCantAgg.Clear();
        }
    }
}
