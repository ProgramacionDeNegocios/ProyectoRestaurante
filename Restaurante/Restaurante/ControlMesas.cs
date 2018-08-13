using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurante
{
    public partial class ControlMesas : Form
    {
        public static Color valorColor;
        //string color1;
        public ControlMesas()
        {
            InitializeComponent();

        } 
        string nombre;
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void ControlMesas_Load(object sender, EventArgs e)
        {
            habilitartodos();
            CargarAreas();
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mesas.SelectedIndex != 0)
            {
                mesas.SelectedIndex -= 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mesas.SelectedIndex != 3)
            {
                mesas.SelectedIndex += 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        int numero = 0;
        int numero1 = 0;
        int numero2 = 0;
        int numero3 = 0;
        private void CargarAreas()
        {
            
            for (int i = 1; i <= 4; i++)
            {
                
                switch (i)
                {
                    case 1:

                        Clases.Areas area = new Clases.Areas();
                        area.ObtenerAreas(i);
                        tabPage1.Text = area.Nombre;
                        numero = area.NumeroMesas;

                        if (numero>=1 && numero <=24)
                        {
                            
                                switch (numero)
                                {
                                    case 1:
                                        mesa2.Visible= false;
                                        mesa3.Visible= false;
                                        mesa4.Visible= false;
                                        mesa5.Visible= false;
                                        mesa6.Visible= false;
                                        mesa7.Visible= false;
                                        mesa8.Visible= false;
                                        mesa9.Visible= false;
                                        mesa10.Visible= false;
                                        mesa11.Visible= false;
                                        mesa12.Visible= false;
                                        mesa13.Visible= false;
                                        mesa14.Visible= false;
                                        mesa15.Visible= false;
                                        mesa16.Visible= false;
                                        mesa17.Visible= false;
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
                                    ///
                                    l2.Visible = false;
                                    l3.Visible = false;
                                    l4.Visible = false;
                                    l5.Visible = false;
                                    l6.Visible = false;
                                    l7.Visible = false;
                                    l8.Visible = false;
                                    l9.Visible = false;
                                    l10.Visible = false;
                                    l11.Visible = false;
                                    l12.Visible = false;
                                    l13.Visible = false;
                                    l14.Visible = false;
                                    l15.Visible = false;
                                    l16.Visible = false;
                                    l17.Visible = false;
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 2:
                                        mesa3.Visible= false;
                                        mesa4.Visible= false;
                                        mesa5.Visible= false;
                                        mesa6.Visible= false;
                                        mesa7.Visible= false;
                                        mesa8.Visible= false;
                                        mesa9.Visible= false;
                                        mesa10.Visible= false;
                                        mesa11.Visible= false;
                                        mesa12.Visible= false;
                                        mesa13.Visible= false;
                                        mesa14.Visible= false;
                                        mesa15.Visible= false;
               
                                        mesa16.Visible= false;
                                        mesa17.Visible= false;
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
                                    l3.Visible = false;
                                    l4.Visible = false;
                                    l5.Visible = false;
                                    l6.Visible = false;
                                    l7.Visible = false;
                                    l8.Visible = false;
                                    l9.Visible = false;
                                    l10.Visible = false;
                                    l11.Visible = false;
                                    l12.Visible = false;
                                    l13.Visible = false;
                                    l14.Visible = false;
                                    l15.Visible = false;
                                    l16.Visible = false;
                                    l17.Visible = false;
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 3:
                             
                                        mesa4.Visible= false;
                                        mesa5.Visible= false;
                                        mesa6.Visible= false;
                                        mesa7.Visible= false;
                                        mesa8.Visible= false;
                                        mesa9.Visible= false;
                                        mesa10.Visible= false;
                                        mesa11.Visible= false;
                                        mesa12.Visible= false;
                                        mesa13.Visible= false;
                                        mesa14.Visible= false;
                                        mesa15.Visible= false;
                                        mesa16.Visible= false;
                                        mesa17.Visible= false;
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;

                                    l4.Visible = false;
                                    l5.Visible = false;
                                    l6.Visible = false;
                                    l7.Visible = false;
                                    l8.Visible = false;
                                    l9.Visible = false;
                                    l10.Visible = false;
                                    l11.Visible = false;
                                    l12.Visible = false;
                                    l13.Visible = false;
                                    l14.Visible = false;
                                    l15.Visible = false;
                                    l16.Visible = false;
                                    l17.Visible = false;
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 4:

                                        mesa5.Visible= false;
                                        mesa6.Visible= false;
                                        mesa7.Visible= false;
                                        mesa8.Visible= false;
                                        mesa9.Visible= false;
                                        mesa10.Visible= false;
                                        mesa11.Visible= false;
                                        mesa12.Visible= false;
                                        mesa13.Visible= false;
                                        mesa14.Visible= false;
                                        mesa15.Visible= false;
                                        mesa16.Visible= false;
                                        mesa17.Visible= false;
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;

                                    l5.Visible = false;
                                    l6.Visible = false;
                                    l7.Visible = false;
                                    l8.Visible = false;
                                    l9.Visible = false;
                                    l10.Visible = false;
                                    l11.Visible = false;
                                    l12.Visible = false;
                                    l13.Visible = false;
                                    l14.Visible = false;
                                    l15.Visible = false;
                                    l16.Visible = false;
                                    l17.Visible = false;
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 5:

                                        mesa6.Visible= false;
                                        mesa7.Visible= false;
                                        mesa8.Visible= false;
                                        mesa9.Visible= false;
                                        mesa10.Visible= false;
                                        mesa11.Visible= false;
                                        mesa12.Visible= false;
                                        mesa13.Visible= false;
                                        mesa14.Visible= false;
                                        mesa15.Visible= false;
                                        mesa16.Visible= false;
                                        mesa17.Visible= false;
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
 
                                    l6.Visible = false;
                                    l7.Visible = false;
                                    l8.Visible = false;
                                    l9.Visible = false;
                                    l10.Visible = false;
                                    l11.Visible = false;
                                    l12.Visible = false;
                                    l13.Visible = false;
                                    l14.Visible = false;
                                    l15.Visible = false;
                                    l16.Visible = false;
                                    l17.Visible = false;
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 6:

                                        mesa7.Visible= false;
                                        mesa8.Visible= false;
                                        mesa9.Visible= false;
                                        mesa10.Visible= false;
                                        mesa11.Visible= false;
                                        mesa12.Visible= false;
                                        mesa13.Visible= false;
                                        mesa14.Visible= false;
                                        mesa15.Visible= false;
                                        mesa16.Visible= false;
                                        mesa17.Visible= false;
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
 
                                    l7.Visible = false;
                                    l8.Visible = false;
                                    l9.Visible = false;
                                    l10.Visible = false;
                                    l11.Visible = false;
                                    l12.Visible = false;
                                    l13.Visible = false;
                                    l14.Visible = false;
                                    l15.Visible = false;
                                    l16.Visible = false;
                                    l17.Visible = false;
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 7:

                                        mesa8.Visible= false;
                                        mesa9.Visible= false;
                                        mesa10.Visible= false;
                                        mesa11.Visible= false;
                                        mesa12.Visible= false;
                                        mesa13.Visible= false;
                                        mesa14.Visible= false;
                                        mesa15.Visible= false;
                                        mesa16.Visible= false;
                                        mesa17.Visible= false;
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;

                                    l8.Visible = false;
                                    l9.Visible = false;
                                    l10.Visible = false;
                                    l11.Visible = false;
                                    l12.Visible = false;
                                    l13.Visible = false;
                                    l14.Visible = false;
                                    l15.Visible = false;
                                    l16.Visible = false;
                                    l17.Visible = false;
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 8:
                                        mesa9.Visible= false;
                                        mesa10.Visible= false;
                                        mesa11.Visible= false;
                                        mesa12.Visible= false;
                                        mesa13.Visible= false;
                                        mesa14.Visible= false;
                                        mesa15.Visible= false;
                                        mesa16.Visible= false;
                                        mesa17.Visible= false;
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;

                                    l9.Visible = false;
                                    l10.Visible = false;
                                    l11.Visible = false;
                                    l12.Visible = false;
                                    l13.Visible = false;
                                    l14.Visible = false;
                                    l15.Visible = false;
                                    l16.Visible = false;
                                    l17.Visible = false;
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 9:
                                        mesa10.Visible= false;
                                        mesa11.Visible= false;
                                        mesa12.Visible= false;
                                        mesa13.Visible= false;
                                        mesa14.Visible= false;
                                        mesa15.Visible= false;
                                        mesa16.Visible= false;
                                        mesa17.Visible= false;
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;

                                    l10.Visible = false;
                                    l11.Visible = false;
                                    l12.Visible = false;
                                    l13.Visible = false;
                                    l14.Visible = false;
                                    l15.Visible = false;
                                    l16.Visible = false;
                                    l17.Visible = false;
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 10:
                                        mesa11.Visible= false;
                                        mesa12.Visible= false;
                                        mesa13.Visible= false;
                                        mesa14.Visible= false;
                                        mesa15.Visible= false;
                                        mesa16.Visible= false;
                                        mesa17.Visible= false;
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
     
                                    l11.Visible = false;
                                    l12.Visible = false;
                                    l13.Visible = false;
                                    l14.Visible = false;
                                    l15.Visible = false;
                                    l16.Visible = false;
                                    l17.Visible = false;
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 11:
                                        mesa12.Visible= false;
                                        mesa13.Visible= false;
                                        mesa14.Visible= false;
                                        mesa15.Visible= false;
                                        mesa16.Visible= false;
                                        mesa17.Visible= false;
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
     
                                    l12.Visible = false;
                                    l13.Visible = false;
                                    l14.Visible = false;
                                    l15.Visible = false;
                                    l16.Visible = false;
                                    l17.Visible = false;
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 12:
                                        mesa13.Visible= false;
                                        mesa14.Visible= false;
                                        mesa15.Visible= false;
                                        mesa16.Visible= false;
                                        mesa17.Visible= false;
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;

                                    l13.Visible = false;
                                    l14.Visible = false;
                                    l15.Visible = false;
                                    l16.Visible = false;
                                    l17.Visible = false;
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 13:
                                        mesa14.Visible= false;
                                        mesa15.Visible= false;
                                        mesa16.Visible= false;
                                        mesa17.Visible= false;
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;

                                    l14.Visible = false;
                                    l15.Visible = false;
                                    l16.Visible = false;
                                    l17.Visible = false;
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 14:
                                        mesa15.Visible= false;
                                        mesa16.Visible= false;
                                        mesa17.Visible= false;
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;

                                    l15.Visible = false;
                                    l16.Visible = false;
                                    l17.Visible = false;
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 15:
                                        mesa16.Visible= false;
                                        mesa17.Visible= false;
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
                         
                                    l16.Visible = false;
                                    l17.Visible = false;
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 16:
                                        
                                        mesa17.Visible= false;
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
                       
                                    l17.Visible = false;
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 17:
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
                         
                                    l18.Visible = false;
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 18:
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
                               
                                    l19.Visible = false;
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 19:
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
                     
                                    l20.Visible = false;
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 20:
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
                           
                                    l21.Visible = false;
                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 21:
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;

                                    l22.Visible = false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 22:
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
                                    l23.Visible = false;
                                    l24.Visible = false;
                                    break;
                                    case 23:
                                        mesa24.Visible= false;
                                   
                                    l24.Visible = false;
                                    break;
                                    default:
                                        habilitartodos();
                                        break;
                                }
                            
                        }
                        break;
                    case 2:
                        Clases.Areas area2 = new Clases.Areas();
                        area2.ObtenerAreas(i);
                        tabPage2.Text = area2.Nombre;
                        numero1 = area2.NumeroMesas;
                        if (numero1 >= 1 && numero1 <= 24)
                        {

                            switch (numero1)
                            {
                                case 1:
                                    mes2.Visible = false;
                                    mes3.Visible = false;
                                    mes4.Visible = false;
                                    mes5.Visible = false;
                                    mes6.Visible = false;
                                    mes7.Visible = false;
                                    mes8.Visible = false;
                                    mes9.Visible = false;
                                    mes10.Visible = false;
                                    mes11.Visible = false;
                                    mes12.Visible = false;
                                    mes13.Visible = false;
                                    mes14.Visible = false;
                                    mes15.Visible = false;
                                    mes16.Visible = false;
                                    mes17.Visible = false;
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;
                                    
                                    break;
                                case 2:
                                    mes3.Visible = false;
                                    mes4.Visible = false;
                                    mes5.Visible = false;
                                    mes6.Visible = false;
                                    mes7.Visible = false;
                                    mes8.Visible = false;
                                    mes9.Visible = false;
                                    mes10.Visible = false;
                                    mes11.Visible = false;
                                    mes12.Visible = false;
                                    mes13.Visible = false;
                                    mes14.Visible = false;
                                    mes15.Visible = false;

                                    mes16.Visible = false;
                                    mes17.Visible = false;
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;
                                    break;
                                case 3:

                                    mes4.Visible = false;
                                    mes5.Visible = false;
                                    mes6.Visible = false;
                                    mes7.Visible = false;
                                    mes8.Visible = false;
                                    mes9.Visible = false;
                                    mes10.Visible = false;
                                    mes11.Visible = false;
                                    mes12.Visible = false;
                                    mes13.Visible = false;
                                    mes14.Visible = false;
                                    mes15.Visible = false;
                                    mes16.Visible = false;
                                    mes17.Visible = false;
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;
                                    break;
                                case 4:

                                    mes5.Visible = false;
                                    mes6.Visible = false;
                                    mes7.Visible = false;
                                    mes8.Visible = false;
                                    mes9.Visible = false;
                                    mes10.Visible = false;
                                    mes11.Visible = false;
                                    mes12.Visible = false;
                                    mes13.Visible = false;
                                    mes14.Visible = false;
                                    mes15.Visible = false;
                                    mes16.Visible = false;
                                    mes17.Visible = false;
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;

                                    la5.Visible = false;
                                    la6.Visible = false;
                                    la7.Visible = false;
                                    la8.Visible = false;
                                    la9.Visible = false;
                                    la10.Visible = false;
                                    la11.Visible = false;
                                    la12.Visible = false;
                                    la13.Visible = false;
                                    la14.Visible = false;
                                    la15.Visible = false;
                                    la16.Visible = false;
                                    la17.Visible = false;
                                    la18.Visible = false;
                                    la19.Visible = false;
                                    la20.Visible = false;
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 5:

                                    mes6.Visible = false;
                                    mes7.Visible = false;
                                    mes8.Visible = false;
                                    mes9.Visible = false;
                                    mes10.Visible = false;
                                    mes11.Visible = false;
                                    mes12.Visible = false;
                                    mes13.Visible = false;
                                    mes14.Visible = false;
                                    mes15.Visible = false;
                                    mes16.Visible = false;
                                    mes17.Visible = false;
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;
                                    la6.Visible = false;
                                    la7.Visible = false;
                                    la8.Visible = false;
                                    la9.Visible = false;
                                    la10.Visible = false;
                                    la11.Visible = false;
                                    la12.Visible = false;
                                    la13.Visible = false;
                                    la14.Visible = false;
                                    la15.Visible = false;
                                    la16.Visible = false;
                                    la17.Visible = false;
                                    la18.Visible = false;
                                    la19.Visible = false;
                                    la20.Visible = false;
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 6:

                                    mes7.Visible = false;
                                    mes8.Visible = false;
                                    mes9.Visible = false;
                                    mes10.Visible = false;
                                    mes11.Visible = false;
                                    mes12.Visible = false;
                                    mes13.Visible = false;
                                    mes14.Visible = false;
                                    mes15.Visible = false;
                                    mes16.Visible = false;
                                    mes17.Visible = false;
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;

                                    la7.Visible = false;
                                    la8.Visible = false;
                                    la9.Visible = false;
                                    la10.Visible = false;
                                    la11.Visible = false;
                                    la12.Visible = false;
                                    la13.Visible = false;
                                    la14.Visible = false;
                                    la15.Visible = false;
                                    la16.Visible = false;
                                    la17.Visible = false;
                                    la18.Visible = false;
                                    la19.Visible = false;
                                    la20.Visible = false;
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 7:

                                    mes8.Visible = false;
                                    mes9.Visible = false;
                                    mes10.Visible = false;
                                    mes11.Visible = false;
                                    mes12.Visible = false;
                                    mes13.Visible = false;
                                    mes14.Visible = false;
                                    mes15.Visible = false;
                                    mes16.Visible = false;
                                    mes17.Visible = false;
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;
                                
                                    la8.Visible = false;
                                    la9.Visible = false;
                                    la10.Visible = false;
                                    la11.Visible = false;
                                    la12.Visible = false;
                                    la13.Visible = false;
                                    la14.Visible = false;
                                    la15.Visible = false;
                                    la16.Visible = false;
                                    la17.Visible = false;
                                    la18.Visible = false;
                                    la19.Visible = false;
                                    la20.Visible = false;
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 8:
                                    mes9.Visible = false;
                                    mes10.Visible = false;
                                    mes11.Visible = false;
                                    mes12.Visible = false;
                                    mes13.Visible = false;
                                    mes14.Visible = false;
                                    mes15.Visible = false;
                                    mes16.Visible = false;
                                    mes17.Visible = false;
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;

                   
                                    la9.Visible = false;
                                    la10.Visible = false;
                                    la11.Visible = false;
                                    la12.Visible = false;
                                    la13.Visible = false;
                                    la14.Visible = false;
                                    la15.Visible = false;
                                    la16.Visible = false;
                                    la17.Visible = false;
                                    la18.Visible = false;
                                    la19.Visible = false;
                                    la20.Visible = false;
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 9:
                                    mes10.Visible = false;
                                    mes11.Visible = false;
                                    mes12.Visible = false;
                                    mes13.Visible = false;
                                    mes14.Visible = false;
                                    mes15.Visible = false;
                                    mes16.Visible = false;
                                    mes17.Visible = false;
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;


                      
                                    la10.Visible = false;
                                    la11.Visible = false;
                                    la12.Visible = false;
                                    la13.Visible = false;
                                    la14.Visible = false;
                                    la15.Visible = false;
                                    la16.Visible = false;
                                    la17.Visible = false;
                                    la18.Visible = false;
                                    la19.Visible = false;
                                    la20.Visible = false;
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 10:
                                    mes11.Visible = false;
                                    mes12.Visible = false;
                                    mes13.Visible = false;
                                    mes14.Visible = false;
                                    mes15.Visible = false;
                                    mes16.Visible = false;
                                    mes17.Visible = false;
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;

            
                                    la11.Visible = false;
                                    la12.Visible = false;
                                    la13.Visible = false;
                                    la14.Visible = false;
                                    la15.Visible = false;
                                    la16.Visible = false;
                                    la17.Visible = false;
                                    la18.Visible = false;
                                    la19.Visible = false;
                                    la20.Visible = false;
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 11:
                                    mes12.Visible = false;
                                    mes13.Visible = false;
                                    mes14.Visible = false;
                                    mes15.Visible = false;
                                    mes16.Visible = false;
                                    mes17.Visible = false;
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;
                                    la12.Visible = false;
                                    la13.Visible = false;
                                    la14.Visible = false;
                                    la15.Visible = false;
                                    la16.Visible = false;
                                    la17.Visible = false;
                                    la18.Visible = false;
                                    la19.Visible = false;
                                    la20.Visible = false;
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 12:
                                    mes13.Visible = false;
                                    mes14.Visible = false;
                                    mes15.Visible = false;
                                    mes16.Visible = false;
                                    mes17.Visible = false;
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;

                            
                                    la13.Visible = false;
                                    la14.Visible = false;
                                    la15.Visible = false;
                                    la16.Visible = false;
                                    la17.Visible = false;
                                    la18.Visible = false;
                                    la19.Visible = false;
                                    la20.Visible = false;
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 13:
                                    mes14.Visible = false;
                                    mes15.Visible = false;
                                    mes16.Visible = false;
                                    mes17.Visible = false;
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;

                              
                                    la14.Visible = false;
                                    la15.Visible = false;
                                    la16.Visible = false;
                                    la17.Visible = false;
                                    la18.Visible = false;
                                    la19.Visible = false;
                                    la20.Visible = false;
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 14:
                                    mes15.Visible = false;
                                    mes16.Visible = false;
                                    mes17.Visible = false;
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;
      
                                    la15.Visible = false;
                                    la16.Visible = false;
                                    la17.Visible = false;
                                    la18.Visible = false;
                                    la19.Visible = false;
                                    la20.Visible = false;
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 15:
                                    mes16.Visible = false;
                                    mes17.Visible = false;
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;

                                    la16.Visible = false;
                                    la17.Visible = false;
                                    la18.Visible = false;
                                    la19.Visible = false;
                                    la20.Visible = false;
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 16:

                                    mes17.Visible = false;
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;
                                  
                                    la17.Visible = false;
                                    la18.Visible = false;
                                    la19.Visible = false;
                                    la20.Visible = false;
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 17:
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;

                               
                                    la18.Visible = false;
                                    la19.Visible = false;
                                    la20.Visible = false;
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 18:
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;

                        
                                    la19.Visible = false;
                                    la20.Visible = false;
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 19:
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;

                                    la20.Visible = false;
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 20:
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;
                                    
                                    la21.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 21:
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;
                                    la22.Visible = false;
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 22:
                                    mes23.Visible = false;
                                    mes24.Visible = false;
                                    
                                    la23.Visible = false;
                                    la24.Visible = false;
                                    break;
                                case 23:
                                    mes24.Visible = false;
                                    la24.Visible = false;
                                    break;
                                default:
                                    habilitartodos();
                                    break;
                            }
                        }
                            break;
                    case 3:
                        Clases.Areas area3 = new Clases.Areas();
                        area3.ObtenerAreas(i);
                        tabPage3.Text = area3.Nombre;
                        numero2 = area3.NumeroMesas;
                        if (numero2 >= 1 && numero2 <= 24)
                        {

                            switch (numero2)
                            {
                                case 1:
                                    mesas2.Visible = false;
                                    mesas3.Visible = false;
                                    mesas4.Visible = false;
                                    mesas5.Visible = false;
                                    mesas6.Visible = false;
                                    mesas7.Visible = false;
                                    mesas8.Visible = false;
                                    mesas9.Visible = false;
                                    mesas10.Visible = false;
                                    mesas11.Visible = false;
                                    mesas12.Visible = false;
                                    mesas13.Visible = false;
                                    mesas14.Visible = false;
                                    mesas15.Visible = false;
                                    mesas16.Visible = false;
                                    mesas17.Visible = false;
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;
                                    //mesas24.Visible = false;
                                    break;
                                case 2:
                                    mesas3.Visible = false;
                                    mesas4.Visible = false;
                                    mesas5.Visible = false;
                                    mesas6.Visible = false;
                                    mesas7.Visible = false;
                                    mesas8.Visible = false;
                                    mesas9.Visible = false;
                                    mesas10.Visible = false;
                                    mesas11.Visible = false;
                                    mesas12.Visible = false;
                                    mesas13.Visible = false;
                                    mesas14.Visible = false;
                                    mesas15.Visible = false;

                                    mesas16.Visible = false;
                                    mesas17.Visible = false;
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;
                                    break;
                                case 3:

                                    mesas4.Visible = false;
                                    mesas5.Visible = false;
                                    mesas6.Visible = false;
                                    mesas7.Visible = false;
                                    mesas8.Visible = false;
                                    mesas9.Visible = false;
                                    mesas10.Visible = false;
                                    mesas11.Visible = false;
                                    mesas12.Visible = false;
                                    mesas13.Visible = false;
                                    mesas14.Visible = false;
                                    mesas15.Visible = false;
                                    mesas16.Visible = false;
                                    mesas17.Visible = false;
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;

                                    lab4.Visible = false;
                                    lab5.Visible = false;
                                    lab6.Visible = false;
                                    lab7.Visible = false;
                                    lab8.Visible = false;
                                    lab9.Visible = false;
                                    lab10.Visible = false;
                                    lab11.Visible = false;
                                    lab12.Visible = false;
                                    lab13.Visible = false;
                                    lab14.Visible = false;
                                    lab15.Visible = false;
                                    lab16.Visible = false;
                                    lab17.Visible = false;
                                    lab18.Visible = false;
                                    lab19.Visible = false;
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 4:

                                    mesas5.Visible = false;
                                    mesas6.Visible = false;
                                    mesas7.Visible = false;
                                    mesas8.Visible = false;
                                    mesas9.Visible = false;
                                    mesas10.Visible = false;
                                    mesas11.Visible = false;
                                    mesas12.Visible = false;
                                    mesas13.Visible = false;
                                    mesas14.Visible = false;
                                    mesas15.Visible = false;
                                    mesas16.Visible = false;
                                    mesas17.Visible = false;
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;

                                    lab5.Visible = false;
                                    lab6.Visible = false;
                                    lab7.Visible = false;
                                    lab8.Visible = false;
                                    lab9.Visible = false;
                                    lab10.Visible = false;
                                    lab11.Visible = false;
                                    lab12.Visible = false;
                                    lab13.Visible = false;
                                    lab14.Visible = false;
                                    lab15.Visible = false;
                                    lab16.Visible = false;
                                    lab17.Visible = false;
                                    lab18.Visible = false;
                                    lab19.Visible = false;
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 5:

                                    mesas6.Visible = false;
                                    mesas7.Visible = false;
                                    mesas8.Visible = false;
                                    mesas9.Visible = false;
                                    mesas10.Visible = false;
                                    mesas11.Visible = false;
                                    mesas12.Visible = false;
                                    mesas13.Visible = false;
                                    mesas14.Visible = false;
                                    mesas15.Visible = false;
                                    mesas16.Visible = false;
                                    mesas17.Visible = false;
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;

                                   
                                    lab6.Visible = false;
                                    lab7.Visible = false;
                                    lab8.Visible = false;
                                    lab9.Visible = false;
                                    lab10.Visible = false;
                                    lab11.Visible = false;
                                    lab12.Visible = false;
                                    lab13.Visible = false;
                                    lab14.Visible = false;
                                    lab15.Visible = false;
                                    lab16.Visible = false;
                                    lab17.Visible = false;
                                    lab18.Visible = false;
                                    lab19.Visible = false;
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 6:

                                    mesas7.Visible = false;
                                    mesas8.Visible = false;
                                    mesas9.Visible = false;
                                    mesas10.Visible = false;
                                    mesas11.Visible = false;
                                    mesas12.Visible = false;
                                    mesas13.Visible = false;
                                    mesas14.Visible = false;
                                    mesas15.Visible = false;
                                    mesas16.Visible = false;
                                    mesas17.Visible = false;
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;

                              
                                    lab7.Visible = false;
                                    lab8.Visible = false;
                                    lab9.Visible = false;
                                    lab10.Visible = false;
                                    lab11.Visible = false;
                                    lab12.Visible = false;
                                    lab13.Visible = false;
                                    lab14.Visible = false;
                                    lab15.Visible = false;
                                    lab16.Visible = false;
                                    lab17.Visible = false;
                                    lab18.Visible = false;
                                    lab19.Visible = false;
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 7:

                                    mesas8.Visible = false;
                                    mesas9.Visible = false;
                                    mesas10.Visible = false;
                                    mesas11.Visible = false;
                                    mesas12.Visible = false;
                                    mesas13.Visible = false;
                                    mesas14.Visible = false;
                                    mesas15.Visible = false;
                                    mesas16.Visible = false;
                                    mesas17.Visible = false;
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;

                                
                                    lab8.Visible = false;
                                    lab9.Visible = false;
                                    lab10.Visible = false;
                                    lab11.Visible = false;
                                    lab12.Visible = false;
                                    lab13.Visible = false;
                                    lab14.Visible = false;
                                    lab15.Visible = false;
                                    lab16.Visible = false;
                                    lab17.Visible = false;
                                    lab18.Visible = false;
                                    lab19.Visible = false;
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 8:
                                    mesas9.Visible = false;
                                    mesas10.Visible = false;
                                    mesas11.Visible = false;
                                    mesas12.Visible = false;
                                    mesas13.Visible = false;
                                    mesas14.Visible = false;
                                    mesas15.Visible = false;
                                    mesas16.Visible = false;
                                    mesas17.Visible = false;
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;


                                    
                                    lab9.Visible = false;
                                    lab10.Visible = false;
                                    lab11.Visible = false;
                                    lab12.Visible = false;
                                    lab13.Visible = false;
                                    lab14.Visible = false;
                                    lab15.Visible = false;
                                    lab16.Visible = false;
                                    lab17.Visible = false;
                                    lab18.Visible = false;
                                    lab19.Visible = false;
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 9:
                                    mesas10.Visible = false;
                                    mesas11.Visible = false;
                                    mesas12.Visible = false;
                                    mesas13.Visible = false;
                                    mesas14.Visible = false;
                                    mesas15.Visible = false;
                                    mesas16.Visible = false;
                                    mesas17.Visible = false;
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;

                                  
                                    lab10.Visible = false;
                                    lab11.Visible = false;
                                    lab12.Visible = false;
                                    lab13.Visible = false;
                                    lab14.Visible = false;
                                    lab15.Visible = false;
                                    lab16.Visible = false;
                                    lab17.Visible = false;
                                    lab18.Visible = false;
                                    lab19.Visible = false;
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 10:
                                    mesas11.Visible = false;
                                    mesas12.Visible = false;
                                    mesas13.Visible = false;
                                    mesas14.Visible = false;
                                    mesas15.Visible = false;
                                    mesas16.Visible = false;
                                    mesas17.Visible = false;
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;

                            
                                    lab11.Visible = false;
                                    lab12.Visible = false;
                                    lab13.Visible = false;
                                    lab14.Visible = false;
                                    lab15.Visible = false;
                                    lab16.Visible = false;
                                    lab17.Visible = false;
                                    lab18.Visible = false;
                                    lab19.Visible = false;
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 11:
                                    mesas12.Visible = false;
                                    mesas13.Visible = false;
                                    mesas14.Visible = false;
                                    mesas15.Visible = false;
                                    mesas16.Visible = false;
                                    mesas17.Visible = false;
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;

                              
                                    lab12.Visible = false;
                                    lab13.Visible = false;
                                    lab14.Visible = false;
                                    lab15.Visible = false;
                                    lab16.Visible = false;
                                    lab17.Visible = false;
                                    lab18.Visible = false;
                                    lab19.Visible = false;
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 12:
                                    mesas13.Visible = false;
                                    mesas14.Visible = false;
                                    mesas15.Visible = false;
                                    mesas16.Visible = false;
                                    mesas17.Visible = false;
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;

                                    lab13.Visible = false;
                                    lab14.Visible = false;
                                    lab15.Visible = false;
                                    lab16.Visible = false;
                                    lab17.Visible = false;
                                    lab18.Visible = false;
                                    lab19.Visible = false;
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 13:
                                    mesas14.Visible = false;
                                    mesas15.Visible = false;
                                    mesas16.Visible = false;
                                    mesas17.Visible = false;
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;
                                 
                                    lab14.Visible = false;
                                    lab15.Visible = false;
                                    lab16.Visible = false;
                                    lab17.Visible = false;
                                    lab18.Visible = false;
                                    lab19.Visible = false;
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 14:
                                    mesas15.Visible = false;
                                    mesas16.Visible = false;
                                    mesas17.Visible = false;
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;

                                   
                                    lab15.Visible = false;
                                    lab16.Visible = false;
                                    lab17.Visible = false;
                                    lab18.Visible = false;
                                    lab19.Visible = false;
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 15:
                                    mesas16.Visible = false;
                                    mesas17.Visible = false;
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;
                                    lab16.Visible = false;
                                    lab17.Visible = false;
                                    lab18.Visible = false;
                                    lab19.Visible = false;
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 16:

                                    mesas17.Visible = false;
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;
                                    
                                    lab17.Visible = false;
                                    lab18.Visible = false;
                                    lab19.Visible = false;
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 17:
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;
                                   
                                    lab18.Visible = false;
                                    lab19.Visible = false;
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 18:
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;

                                    
                                    lab19.Visible = false;
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 19:
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;

                                    
                                    lab20.Visible = false;
                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 20:
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;

                                    lab21.Visible = false;
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 21:
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;
                                   
                                    lab22.Visible = false;
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 22:
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;

                                
                                    lab23.Visible = false;
                                    lab24.Visible = false;
                                    break;
                                case 23:
                                    mesas24.Visible = false;
                                   
                                    lab24.Visible = false;
                                    break;
                                default:
                                    habilitartodos();
                                    break;
                            }
                        }
                            break;
                    case 4:
                        if (mesas.SelectedIndex == 3 && tabPage4.Text == "")
                        {
                            //this.mesas.TabPages.Remove(this.tabPage4);
                            me1.Visible = false;
                            me2.Visible = false;
                            me3.Visible = false;
                            me4.Visible = false;
                            me5.Visible = false;
                            me6.Visible = false;
                            me7.Visible = false;
                            me8.Visible = false;
                            me9.Visible = false;
                            me10.Visible = false;
                            me11.Visible = false;
                            me12.Visible = false;
                            me13.Visible = false;
                            me14.Visible = false;
                            me15.Visible = false;
                            me16.Visible = false;
                            me17.Visible = false;
                            me18.Visible = false;
                            me19.Visible = false;
                            me20.Visible = false;
                            me21.Visible = false;
                            me22.Visible = false;
                            me23.Visible = false;
                            me24.Visible = false;

                        }
                        else
                        {
                            //this.mesas.TabPages.Add(this.tabPage4);
                            Clases.Areas area4 = new Clases.Areas();
                            area4.ObtenerAreas(i);
                            tabPage4.Text = area4.Nombre;
                            numero3 = area4.NumeroMesas;
                            if (numero2 >= 1 && numero2 <= 24)
                            {

                                switch (numero2)
                                {
                                    case 1:
                                        me2.Visible = false;
                                        me3.Visible = false;
                                        me4.Visible = false;
                                        me5.Visible = false;
                                        me6.Visible = false;
                                        me7.Visible = false;
                                        me8.Visible = false;
                                        me9.Visible = false;
                                        me10.Visible = false;
                                        me11.Visible = false;
                                        me12.Visible = false;
                                        me13.Visible = false;
                                        me14.Visible = false;
                                        me15.Visible = false;
                                        me16.Visible = false;
                                        me17.Visible = false;
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        //me24.Visible = false;
                                        break;
                                    case 2:
                                        me3.Visible = false;
                                        me4.Visible = false;
                                        me5.Visible = false;
                                        me6.Visible = false;
                                        me7.Visible = false;
                                        me8.Visible = false;
                                        me9.Visible = false;
                                        me10.Visible = false;
                                        me11.Visible = false;
                                        me12.Visible = false;
                                        me13.Visible = false;
                                        me14.Visible = false;
                                        me15.Visible = false;

                                        me16.Visible = false;
                                        me17.Visible = false;
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 3:

                                        me4.Visible = false;
                                        me5.Visible = false;
                                        me6.Visible = false;
                                        me7.Visible = false;
                                        me8.Visible = false;
                                        me9.Visible = false;
                                        me10.Visible = false;
                                        me11.Visible = false;
                                        me12.Visible = false;
                                        me13.Visible = false;
                                        me14.Visible = false;
                                        me15.Visible = false;
                                        me16.Visible = false;
                                        me17.Visible = false;
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 4:

                                        me5.Visible = false;
                                        me6.Visible = false;
                                        me7.Visible = false;
                                        me8.Visible = false;
                                        me9.Visible = false;
                                        me10.Visible = false;
                                        me11.Visible = false;
                                        me12.Visible = false;
                                        me13.Visible = false;
                                        me14.Visible = false;
                                        me15.Visible = false;
                                        me16.Visible = false;
                                        me17.Visible = false;
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 5:

                                        me6.Visible = false;
                                        me7.Visible = false;
                                        me8.Visible = false;
                                        me9.Visible = false;
                                        me10.Visible = false;
                                        me11.Visible = false;
                                        me12.Visible = false;
                                        me13.Visible = false;
                                        me14.Visible = false;
                                        me15.Visible = false;
                                        me16.Visible = false;
                                        me17.Visible = false;
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 6:

                                        me7.Visible = false;
                                        me8.Visible = false;
                                        me9.Visible = false;
                                        me10.Visible = false;
                                        me11.Visible = false;
                                        me12.Visible = false;
                                        me13.Visible = false;
                                        me14.Visible = false;
                                        me15.Visible = false;
                                        me16.Visible = false;
                                        me17.Visible = false;
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 7:

                                        me8.Visible = false;
                                        me9.Visible = false;
                                        me10.Visible = false;
                                        me11.Visible = false;
                                        me12.Visible = false;
                                        me13.Visible = false;
                                        me14.Visible = false;
                                        me15.Visible = false;
                                        me16.Visible = false;
                                        me17.Visible = false;
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 8:
                                        me9.Visible = false;
                                        me10.Visible = false;
                                        me11.Visible = false;
                                        me12.Visible = false;
                                        me13.Visible = false;
                                        me14.Visible = false;
                                        me15.Visible = false;
                                        me16.Visible = false;
                                        me17.Visible = false;
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 9:
                                        me10.Visible = false;
                                        me11.Visible = false;
                                        me12.Visible = false;
                                        me13.Visible = false;
                                        me14.Visible = false;
                                        me15.Visible = false;
                                        me16.Visible = false;
                                        me17.Visible = false;
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 10:
                                        me11.Visible = false;
                                        me12.Visible = false;
                                        me13.Visible = false;
                                        me14.Visible = false;
                                        me15.Visible = false;
                                        me16.Visible = false;
                                        me17.Visible = false;
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 11:
                                        me12.Visible = false;
                                        me13.Visible = false;
                                        me14.Visible = false;
                                        me15.Visible = false;
                                        me16.Visible = false;
                                        me17.Visible = false;
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 12:
                                        me13.Visible = false;
                                        me14.Visible = false;
                                        me15.Visible = false;
                                        me16.Visible = false;
                                        me17.Visible = false;
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 13:
                                        me14.Visible = false;
                                        me15.Visible = false;
                                        me16.Visible = false;
                                        me17.Visible = false;
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 14:
                                        me15.Visible = false;
                                        me16.Visible = false;
                                        me17.Visible = false;
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 15:
                                        me16.Visible = false;
                                        me17.Visible = false;
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 16:

                                        me17.Visible = false;
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 17:
                                        me18.Visible = false;
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 18:
                                        me19.Visible = false;
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 19:
                                        me20.Visible = false;
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 20:
                                        me21.Visible = false;
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 21:
                                        me22.Visible = false;
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 22:
                                        me23.Visible = false;
                                        me24.Visible = false;
                                        break;
                                    case 23:
                                        me24.Visible = false;

                                        break;
                                    default:
                                        habilitartodos();
                                        break;
                                }
                            }
                        }
                        break;
                    default:
                        if (tabPage1.Text == "" || tabPage2.Text == "" || tabPage3.Text == "" || tabPage4.Text == "")
                        {
                            MessageBox.Show("NO hay mas areas");
                        }
                        break;
                        
                }

            }
           
        }
        public void habilitartodos()
        {
            mesa1.Visible= true;
            mesa2.Visible= true;
            mesa3.Visible= true;
            mesa4.Visible= true;
            mesa5.Visible= true;
            mesa6.Visible= true;
            mesa7.Visible= true;
            mesa8.Visible= true;
            mesa9.Visible= true;
            mesa10.Visible= true;
            mesa11.Visible= true;
            mesa12.Visible= true;
            mesa13.Visible= true;
            mesa14.Visible= true;
            mesa15.Visible= true;
            mesa16.Visible= true;
            mesa17.Visible= true;
            mesa18.Visible= true;
            mesa19.Visible= true;
            mesa20.Visible= true;
            mesa21.Visible= true;
            mesa22.Visible= true;
            mesa23.Visible= true;
            mesa24.Visible= true;
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label106_Click(object sender, EventArgs e)
        {

        }
        public void area()
        {
            switch (mesas.SelectedIndex)
            {
                case 0:
                    //this.nombre = "";
                    this.nombre = tabPage1.Text;
                    break;
                case 1:
                    //this.nombre = "";
                    this.nombre = tabPage2.Text;
                    break;
                case 2:
                    //this.nombre = "";
                    this.nombre = tabPage3.Text;
                    break;
                case 3:
                    //this.nombre = "";
                    this.nombre = tabPage4.Text;
                    break;
            }
        }




        public void ParametrosPedido(int n, string j)
        {
            area();
            SeleccionarMesero.valorArea = this.nombre;
            SeleccionarMesero seleccionarMesero = new SeleccionarMesero();
           
            seleccionarMesero.valorMesa = n;
            seleccionarMesero.ShowDialog();
            estadoMesas(n,mesas.SelectedIndex);
            

        }
        public void estadoMesas(int mesa, int area)
        {
            switch (area)
            {
                case 0:
                    switch (mesa)
                    {
                        case 1:
                            mesa1.BackColor = valorColor;
                            break;
                        case 2:
                            mesa2.BackColor = valorColor;
                            break;
                        case 3:
                            mesa3.BackColor = valorColor;
                            break;
                        case 4:
                            mesa4.BackColor = valorColor;
                            break;
                        case 5:
                            mesa5.BackColor = valorColor;
                            break;
                        case 6:
                            mesa6.BackColor = valorColor;
                            break;
                        case 7:
                            mesa7.BackColor = valorColor;
                            break;
                        case 8:
                            mesa8.BackColor = valorColor;
                            break;
                        case 9:
                            mesa9.BackColor = valorColor;
                            break;
                        case 10:
                            mesa10.BackColor = valorColor;
                            break;
                        case 11:
                            mesa11.BackColor = valorColor;
                            break;
                        case 12:
                            mesa12.BackColor = valorColor;
                            break;
                        case 13:
                            mesa13.BackColor = valorColor;
                            break;
                        case 14:
                            mesa14.BackColor = valorColor;
                            break;
                        case 15:
                            mesa15.BackColor = valorColor;
                            break;
                        case 16:
                            mesa16.BackColor = valorColor;
                            break;
                        case 17:
                            mesa17.BackColor = valorColor;
                            break;
                        case 18:
                            mesa18.BackColor = valorColor;
                            break;
                        case 19:
                            mesa19.BackColor = valorColor;
                            break;
                        case 20:
                            mesa20.BackColor = valorColor;
                            break;
                        case 21:
                            mesa21.BackColor = valorColor;
                            break;
                        case 22:
                            mesa22.BackColor = valorColor;
                            break;
                        case 23:
                            mesa23.BackColor = valorColor;
                            break;
                        case 24:
                            mesa24.BackColor = valorColor;
                            break;
                    }
                    break;
                case 3:
                    switch (mesa)
                    {
                        case 1:
                            me1.BackColor = valorColor;
                            break;
                        case 2:
                            me2.BackColor = valorColor;
                            break;
                        case 3:
                            me3.BackColor = valorColor;
                            break;
                        case 4:
                            me4.BackColor = valorColor;
                            break;
                        case 5:
                            me5.BackColor = valorColor;
                            break;
                        case 6:
                            me6.BackColor = valorColor;
                            break;
                        case 7:
                            me7.BackColor = valorColor;
                            break;
                        case 8:
                            me8.BackColor = valorColor;
                            break;
                        case 9:
                            me9.BackColor = valorColor;
                            break;
                        case 10:
                            me10.BackColor = valorColor;
                            break;
                        case 11:
                            me11.BackColor = valorColor;
                            break;
                        case 12:
                            me12.BackColor = valorColor;
                            break;
                        case 13:
                            me13.BackColor = valorColor;
                            break;
                        case 14:
                            me14.BackColor = valorColor;
                            break;
                        case 15:
                            me15.BackColor = valorColor;
                            break;
                        case 16:
                            me16.BackColor = valorColor;
                            break;
                        case 17:
                            me17.BackColor = valorColor;
                            break;
                        case 18:
                            me18.BackColor = valorColor;
                            break;
                        case 19:
                            me19.BackColor = valorColor;
                            break;
                        case 20:
                            me20.BackColor = valorColor;
                            break;
                        case 21:
                            me21.BackColor = valorColor;
                            break;
                        case 22:
                            me22.BackColor = valorColor;
                            break;
                        case 23:
                            me23.BackColor = valorColor;
                            break;
                        case 24:
                            mesa24.BackColor = valorColor;
                            break;
                    }
                    break;
                case 1:
                    switch (mesa)
                    {
                        case 1:
                            mes1.BackColor = valorColor;
                            break;
                        case 2:
                            mes2.BackColor = valorColor;
                            break;
                        case 3:
                            mes3.BackColor = valorColor;
                            break;
                        case 4:
                            mes4.BackColor = valorColor;
                            break;
                        case 5:
                            mes5.BackColor = valorColor;
                            break;
                        case 6:
                            mes6.BackColor = valorColor;
                            break;
                        case 7:
                            mes7.BackColor = valorColor;
                            break;
                        case 8:
                            mes8.BackColor = valorColor;
                            break;
                        case 9:
                            mes9.BackColor = valorColor;
                            break;
                        case 10:
                            mes10.BackColor = valorColor;
                            break;
                        case 11:
                            mes11.BackColor = valorColor;
                            break;
                        case 12:
                            mes12.BackColor = valorColor;
                            break;
                        case 13:
                            mes13.BackColor = valorColor;
                            break;
                        case 14:
                            mes14.BackColor = valorColor;
                            break;
                        case 15:
                            mes15.BackColor = valorColor;
                            break;
                        case 16:
                            mes16.BackColor = valorColor;
                            break;
                        case 17:
                            mes17.BackColor = valorColor;
                            break;
                        case 18:
                            mes18.BackColor = valorColor;
                            break;
                        case 19:
                            mes19.BackColor = valorColor;
                            break;
                        case 20:
                            mes20.BackColor = valorColor;
                            break;
                        case 21:
                            mes21.BackColor = valorColor;
                            break;
                        case 22:
                            mes22.BackColor = valorColor;
                            break;
                        case 23:
                            mes23.BackColor = valorColor;
                            break;
                        case 24:
                            mes24.BackColor = valorColor;
                            break;
                    }
                    break;
                case 2:
                    switch (mesa)
                    {
                        case 1:
                            mesas1.BackColor = valorColor;
                            break;
                        case 2:
                            mesas2.BackColor = valorColor;
                            break;
                        case 3:
                            mesas3.BackColor = valorColor;
                            break;
                        case 4:
                            mesas4.BackColor = valorColor;
                            break;
                        case 5:
                            mesas5.BackColor = valorColor;
                            break;
                        case 6:
                            mesas6.BackColor = valorColor;
                            break;
                        case 7:
                            mesas7.BackColor = valorColor;
                            break;
                        case 8:
                            mesas8.BackColor = valorColor;
                            break;
                        case 9:
                            mesas9.BackColor = valorColor;
                            break;
                        case 10:
                            mesas10.BackColor = valorColor;
                            break;
                        case 11:
                            mesas11.BackColor = valorColor;
                            break;
                        case 12:
                            mesas12.BackColor = valorColor;
                            break;
                        case 13:
                            mesas13.BackColor = valorColor;
                            break;
                        case 14:
                            mesas14.BackColor = valorColor;
                            break;
                        case 15:
                            mesas15.BackColor = valorColor;
                            break;
                        case 16:
                            mesas16.BackColor = valorColor;
                            break;
                        case 17:
                            mesas17.BackColor = valorColor;
                            break;
                        case 18:
                            mesas18.BackColor = valorColor;
                            break;
                        case 19:
                            mesas19.BackColor = valorColor;
                            break;
                        case 20:
                            mesas20.BackColor = valorColor;
                            break;
                        case 21:
                            mesas21.BackColor = valorColor;
                            break;
                        case 22:
                            mesas22.BackColor = valorColor;
                            break;
                        case 23:
                            mesas23.BackColor = valorColor;
                            break;
                        case 24:
                            mesas24.BackColor = valorColor;
                            break;
                    }
                    break;
        }
            

        }
        private void mesa1_Click(object sender, EventArgs e)
        {
            ParametrosPedido(1,this.nombre);
      
        }

        private void mesa2_Click(object sender, EventArgs e)
        {
            ParametrosPedido(2, this.nombre);
        }

        private void mesa3_Click(object sender, EventArgs e)
        {
            ParametrosPedido(3, this.nombre);
        }

        private void mesa4_Click(object sender, EventArgs e)
        {
            ParametrosPedido(4,this.nombre);
        }
        
        private void mesa5_Click(object sender, EventArgs e)
        {
            ParametrosPedido(5,this.nombre);
        }

        private void mesa6_Click(object sender, EventArgs e)
        {
            ParametrosPedido(6,this.nombre);
        }

        private void mesa7_Click(object sender, EventArgs e)
        {
            ParametrosPedido(7,this.nombre);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            ParametrosPedido(13, this.nombre);
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            ParametrosPedido(11, this.nombre);
        }

        private void mesa8_Click(object sender, EventArgs e)
        {
            ParametrosPedido(8,this.nombre);
        }

        private void mesa9_Click(object sender, EventArgs e)
        {
            ParametrosPedido(9,this.nombre);
        }

        private void mesa10_Click(object sender, EventArgs e)
        {
            ParametrosPedido(10,this.nombre);
        }

        private void mesa11_Click(object sender, EventArgs e)
        {
            ParametrosPedido(11,this.nombre);
        }

        private void mesa12_Click(object sender, EventArgs e)
        {
            ParametrosPedido(12,this.nombre);
        }

        private void mesa13_Click(object sender, EventArgs e)
        {
            ParametrosPedido(13,this.nombre);
        }

        private void mesa14_Click(object sender, EventArgs e)
        {
            ParametrosPedido(14,this.nombre);
        }

        private void mesa15_Click(object sender, EventArgs e)
        {
            ParametrosPedido(15,this.nombre);
        }

        private void mesa16_Click(object sender, EventArgs e)
        {
            ParametrosPedido(16,this.nombre);
        }

        private void mesa17_Click(object sender, EventArgs e)
        {
            ParametrosPedido(17,this.nombre);
        }

        private void mesa18_Click(object sender, EventArgs e)
        {
            ParametrosPedido(18,this.nombre);
        }

        private void mesa19_Click(object sender, EventArgs e)
        {
            ParametrosPedido(19,this.nombre);
        }

        private void mesa20_Click(object sender, EventArgs e)
        {
            ParametrosPedido(20,this.nombre);
        }

        private void mesa21_Click(object sender, EventArgs e)
        {
            ParametrosPedido(21,this.nombre);
        }

        private void mesa22_Click(object sender, EventArgs e)
        {
            ParametrosPedido(22,this.nombre);
        }

        private void mesa23_Click(object sender, EventArgs e)
        {
            ParametrosPedido(23,this.nombre);
        }

        private void mesa24_Click(object sender, EventArgs e)
        {
            ParametrosPedido(24,this.nombre);
        }

        private void mes1_Click(object sender, EventArgs e)
        {
            ParametrosPedido(1, this.nombre);
        }

        private void mes2_Click(object sender, EventArgs e)
        {
            ParametrosPedido(2, this.nombre);
        }

        private void mes3_Click(object sender, EventArgs e)
        {
            ParametrosPedido(3, this.nombre);
        }

        private void mes4_Click(object sender, EventArgs e)
        {
            ParametrosPedido(4, this.nombre);
        }

        private void mes5_Click(object sender, EventArgs e)
        {
            ParametrosPedido(5, this.nombre);
        }

        private void mes6_Click(object sender, EventArgs e)
        {
            ParametrosPedido(6, this.nombre);
        }

        private void mes7_Click(object sender, EventArgs e)
        {
            ParametrosPedido(7, this.nombre);
        }

        private void mes8_Click(object sender, EventArgs e)
        {
            ParametrosPedido(8, this.nombre);
        }

        private void mes9_Click(object sender, EventArgs e)
        {
            ParametrosPedido(9, this.nombre);
        }

        private void mes10_Click(object sender, EventArgs e)
        {
            ParametrosPedido(10, this.nombre);
        }

        private void mes11_Click(object sender, EventArgs e)
        {
            ParametrosPedido(11, this.nombre);
        }

        private void mes12_Click(object sender, EventArgs e)
        {
            ParametrosPedido(12, this.nombre);
        }

        private void mes14_Click(object sender, EventArgs e)
        {
            ParametrosPedido(14, this.nombre);
        }

        private void mes15_Click(object sender, EventArgs e)
        {
            ParametrosPedido(15, this.nombre);
        }

        private void mes16_Click(object sender, EventArgs e)
        {
            ParametrosPedido(16, this.nombre);
        }

        private void mes17_Click(object sender, EventArgs e)
        {
            ParametrosPedido(17, this.nombre);
        }

        private void mes18_Click(object sender, EventArgs e)
        {
            ParametrosPedido(18, this.nombre);
        }

        private void mes19_Click(object sender, EventArgs e)
        {
            ParametrosPedido(19, this.nombre);
        }

        private void mes20_Click(object sender, EventArgs e)
        {
            ParametrosPedido(20, this.nombre);
        }

        private void mes21_Click(object sender, EventArgs e)
        {
            ParametrosPedido(21, this.nombre);
        }

        private void mes22_Click(object sender, EventArgs e)
        {
            ParametrosPedido(22, this.nombre);
        }

        private void mes23_Click(object sender, EventArgs e)
        {
            ParametrosPedido(23, this.nombre);
        }

        private void mes24_Click(object sender, EventArgs e)
        {
            ParametrosPedido(24, this.nombre);
        }

        private void mesas1_Click(object sender, EventArgs e)
        {
            ParametrosPedido(1, this.nombre);
        }

        private void mesas2_Click(object sender, EventArgs e)
        {
            ParametrosPedido(2, this.nombre);
        }

        private void mesas3_Click(object sender, EventArgs e)
        {
            ParametrosPedido(3, this.nombre);
        }

        private void mesas4_Click(object sender, EventArgs e)
        {
            ParametrosPedido(4, this.nombre);
        }

        private void mesas5_Click(object sender, EventArgs e)
        {
            ParametrosPedido(5, this.nombre);
        }

        private void mesas6_Click(object sender, EventArgs e)
        {
            ParametrosPedido(6, this.nombre);
        }

        private void mesas7_Click(object sender, EventArgs e)
        {
            ParametrosPedido(7, this.nombre);
        }

        private void mesas8_Click(object sender, EventArgs e)
        {
            ParametrosPedido(8, this.nombre);
        }

        private void mesas9_Click(object sender, EventArgs e)
        {
            ParametrosPedido(9, this.nombre);
        }

        private void mesas10_Click(object sender, EventArgs e)
        {
            ParametrosPedido(10, this.nombre);
        }

        private void mesas11_Click(object sender, EventArgs e)
        {
            ParametrosPedido(11, this.nombre);
        }

        private void mesas12_Click(object sender, EventArgs e)
        {
            ParametrosPedido(12, this.nombre);
        }

        private void mesas13_Click(object sender, EventArgs e)
        {
            ParametrosPedido(13, this.nombre);
        }

        private void mesas14_Click(object sender, EventArgs e)
        {
            ParametrosPedido(14, this.nombre);
        }

        private void mesas15_Click(object sender, EventArgs e)
        {
            ParametrosPedido(15, this.nombre);
        }

        private void mesas16_Click(object sender, EventArgs e)
        {
            ParametrosPedido(16, this.nombre);
        }

        private void mesas17_Click(object sender, EventArgs e)
        {
            ParametrosPedido(17, this.nombre);
        }

        private void mesas18_Click(object sender, EventArgs e)
        {
            ParametrosPedido(18, this.nombre);
        }

        private void mesas19_Click(object sender, EventArgs e)
        {
            ParametrosPedido(19, this.nombre);
        }

        private void mesas20_Click(object sender, EventArgs e)
        {
            ParametrosPedido(20, this.nombre);
        }

        private void mesas21_Click(object sender, EventArgs e)
        {
            ParametrosPedido(21, this.nombre);
        }

        private void mesas22_Click(object sender, EventArgs e)
        {
            ParametrosPedido(22, this.nombre);
        }

        private void mesas23_Click(object sender, EventArgs e)
        {
            ParametrosPedido(23, this.nombre);
        }

        private void mesas24_Click(object sender, EventArgs e)
        {
            ParametrosPedido(24, this.nombre);
        }

        private void me1_Click(object sender, EventArgs e)
        {
            ParametrosPedido(1, this.nombre);
        }

        private void me2_Click(object sender, EventArgs e)
        {
            ParametrosPedido(2, this.nombre);
        }

        private void me3_Click(object sender, EventArgs e)
        {
            ParametrosPedido(3, this.nombre);
        }

        private void me4_Click(object sender, EventArgs e)
        {
            ParametrosPedido(4, this.nombre);
        }

        private void me5_Click(object sender, EventArgs e)
        {
            ParametrosPedido(5, this.nombre);
        }

        private void me6_Click(object sender, EventArgs e)
        {
            ParametrosPedido(6, this.nombre);
        }

        private void me7_Click(object sender, EventArgs e)
        {
            ParametrosPedido(7, this.nombre);
        }

        private void me8_Click(object sender, EventArgs e)
        {
            ParametrosPedido(8, this.nombre);
        }

        private void me9_Click(object sender, EventArgs e)
        {
            ParametrosPedido(9, this.nombre);
        }

        private void me10_Click(object sender, EventArgs e)
        {
            ParametrosPedido(10, this.nombre);
        }

        private void me12_Click(object sender, EventArgs e)
        {
            ParametrosPedido(12, this.nombre);
        }

        private void me13_Click(object sender, EventArgs e)
        {
            ParametrosPedido(13, this.nombre);
        }

        private void me14_Click(object sender, EventArgs e)
        {
            ParametrosPedido(14, this.nombre);
        }

        private void me15_Click(object sender, EventArgs e)
        {
            ParametrosPedido(15, this.nombre);
        }

        private void me16_Click(object sender, EventArgs e)
        {
            ParametrosPedido(16, this.nombre);
        }

        private void me17_Click(object sender, EventArgs e)
        {
            ParametrosPedido(17, this.nombre);
        }

        private void me18_Click(object sender, EventArgs e)
        {
            ParametrosPedido(18, this.nombre);
        }

        private void me19_Click(object sender, EventArgs e)
        {
            ParametrosPedido(19, this.nombre);
        }

        private void me20_Click(object sender, EventArgs e)
        {
            ParametrosPedido(20, this.nombre);
        }

        private void me21_Click(object sender, EventArgs e)
        {
            ParametrosPedido(21, this.nombre);
        }

        private void me22_Click(object sender, EventArgs e)
        {
            ParametrosPedido(22, this.nombre);
        }

        private void me23_Click(object sender, EventArgs e)
        {
            ParametrosPedido(23, this.nombre);
        }

        private void me24_Click(object sender, EventArgs e)
        {
            ParametrosPedido(24, this.nombre);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label47_Click(object sender, EventArgs e)
        {

        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }
    }
}
