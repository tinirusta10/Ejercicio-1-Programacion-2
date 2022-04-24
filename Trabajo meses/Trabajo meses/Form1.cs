using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_meses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int diaacum = Convert.ToInt32(txt1.Text);
            int mesacum = Convert.ToInt32(txt2.Text);          //variables a usar//
            int añoacum = Convert.ToInt32(txt3.Text);
            string eleccion = txt2.Text;

            int dia = Convert.ToInt32(txt1.Text);
            int mes = Convert.ToInt32(txt2.Text);
            int año = Convert.ToInt32(txt3.Text);

            if (dia < 31)
            {
                diaacum = dia + 1;
            }

          




            switch (mesacum)                            //Escribe los meses en letras//
            {
                case 01:
                    lblmes.Text = "enero del:";
                    break;
                case 02:

                    if (añoacum % 4 == 0 && diaacum == 28)
                    {
                        lblmes.Text = "Febrero del";
                        diaacum = 29;
                    }
                    if ( añoacum % 400 == 0 && diaacum == 28)        //valida año bisiesto//
                    {
                        lblmes.Text = "febrero del";
                        diaacum = 29;

                    }
                    if ( diaacum < 28)
                    {
                        lblmes.Text = "frbero del";
                    }


                    if (diaacum > 27 && añoacum % 4 != 0)
                    {
                        lblmes.Text = "Marzo del ";
                        diaacum = 1;
                    }
                 


                    break;
                case 03:

                    if (diaacum >=31)
                    {
                        lblmes.Text = "Abril del :";
                        diaacum = 1;
                    
                    }
                    else if (diaacum <31)
                    {
                        lblmes.Text = "Marzo del";
                    }
                    
                   
                    break;
                
                
                case 04:

                    if (diaacum >= 30)
                    {
                        lblmes.Text = "Mayo del";
                        diaacum = 1;

                    }
                    else if (mesacum < 30)
                    {
                        lblmes.Text = "abril del";

                    }
                    break;
                case 05:
                    if (diaacum >= 31)
                    {
                        lblmes.Text = "Junio del";
                        diaacum = 1;

                    }
                    else if (diaacum < 31)
                    {
                        lblmes.Text = "mayo del";
                    }


                   
                    break;
                case 06:

                    if (diaacum >= 30)
                    {
                        lblmes.Text = "Julio del";
                        diaacum = 1;

                    }
                    else if (diaacum < 30)
                    {
                        lblmes.Text = "junio del";
                    }

                    break;
                case 07:

                    if (diaacum >= 31)
                    {
                        lblmes.Text = "Agosto del";
                        diaacum = 1;

                    }
                    else if (diaacum < 31)
                    {
                        lblmes.Text = "Julio del";
                    }
                   
                    break;
                case 08:

                    if (diaacum >= 31)
                    {
                        lblmes.Text = "Septiembre del";
                        diaacum = 1;

                    }
                    else if (diaacum < 31)
                    {
                        lblmes.Text = "Agosto del";
                    }
                   
                    break;
                case 09:

                    if (diaacum >= 30)
                    {
                        lblmes.Text = "Septiembre del";
                        diaacum = 1;

                    }
                    lblmes.Text = "Octubre del";
                    break;
                case 10:

                    if (diaacum >= 31)
                    {
                        lblmes.Text = "Noviembre del";
                        diaacum = 1;

                    }
                    else if (diaacum < 31)
                    {
                        lblmes.Text = "Octubre del";
                    }                    
                    break;
                case 11:
                    if (diaacum >= 30)
                    {
                        lblmes.Text = "Diciembre del";
                        diaacum = 1;

                    }
   
                    else if (diaacum < 30)
                    {
                        lblmes.Text = "Nobiembre del";
                    }

                    break;
                case 12:
                    if (diaacum < 31)
                    {
                        lblmes.Text = "Diciembre del";
                    }
                    if (diaacum >= 31)
                    {
                        lblmes.Text = "Enero del";
                        diaacum = 1;
                        añoacum = año + 1;
                    }

                    break;

                default:
                    break;

            }

            
            lbltexto.Text = "El siguiente dia es";
            lbldia.Text = Convert.ToString(diaacum) + "     " + "de";
            lblaño.Text = Convert.ToString(añoacum);                        //muestra el año y dia//
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();


        }

       
        
        
        
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var eleccion = DialogResult;
            for (int i = 0; i < 1; i++)                                     /*esta estrutura repetitiva muestra un mensaje al apretar el boton salir*/
            {
                eleccion = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo);

                if (eleccion == DialogResult.No)
                {
                    break;
                }
            }

            if (eleccion == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
