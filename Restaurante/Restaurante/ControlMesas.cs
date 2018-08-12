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
        public ControlMesas()
        {
            InitializeComponent();
        }

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
            Clases.Areas area = new Clases.Areas();
            for (int i = 0; i <= 3; i++)
            {
                area.ObtenerAreas(i);
                switch (i)
                {
                    case 1:
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
                                        //mesa24.Visible = false;
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
                                        break;
                                    case 17:
                                        mesa18.Visible= false;
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
                                        break;
                                    case 18:
                                        mesa19.Visible= false;
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
                                        break;
                                    case 19:
                                        mesa20.Visible= false;
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
                                        break;
                                    case 20:
                                        mesa21.Visible= false;
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
                                        break;
                                    case 21:
                                        mesa22.Visible= false;
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
                                        break;
                                    case 22:
                                        mesa23.Visible= false;
                                        mesa24.Visible= false;
                                        break;
                                    case 23:
                                        mesa24.Visible= false;
                           
                                        break;
                                    default:
                                        habilitartodos();
                                        break;
                                }
                            
                        }
                        break;
                    case 2:
                        tabPage2.Text = area.Nombre;
                        numero1 = area.NumeroMesas;
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
                                    //mes24.Visible = false;
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
                                    break;
                                case 17:
                                    mes18.Visible = false;
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;
                                    break;
                                case 18:
                                    mes19.Visible = false;
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;
                                    break;
                                case 19:
                                    mes20.Visible = false;
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;
                                    break;
                                case 20:
                                    mes21.Visible = false;
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;
                                    break;
                                case 21:
                                    mes22.Visible = false;
                                    mes23.Visible = false;
                                    mes24.Visible = false;
                                    break;
                                case 22:
                                    mes23.Visible = false;
                                    mes24.Visible = false;
                                    break;
                                case 23:
                                    mes24.Visible = false;

                                    break;
                                default:
                                    habilitartodos();
                                    break;
                            }
                        }
                            break;
                    case 3:
                        tabPage3.Text = area.Nombre;
                        numero2 = area.NumeroMesas;
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
                                    break;
                                case 17:
                                    mesas18.Visible = false;
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;
                                    break;
                                case 18:
                                    mesas19.Visible = false;
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;
                                    break;
                                case 19:
                                    mesas20.Visible = false;
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;
                                    break;
                                case 20:
                                    mesas21.Visible = false;
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;
                                    break;
                                case 21:
                                    mesas22.Visible = false;
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;
                                    break;
                                case 22:
                                    mesas23.Visible = false;
                                    mesas24.Visible = false;
                                    break;
                                case 23:
                                    mesas24.Visible = false;

                                    break;
                                default:
                                    habilitartodos();
                                    break;
                            }
                        }
                            break;
                    case 4:
                        if (tabPage4.Text == "")
                        {
                            this.mesas.TabPages.Remove(this.tabPage4);
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
                            this.mes.TabPages.Add(this.tabPage4);
                            tabPage4.Text = area.Nombre;
                            numero3 = area.Numeromes;
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
        public void je()
        {
            SeleccionarMesero seleccionarMesero = new SeleccionarMesero();
            seleccionarMesero.ShowDialog();
        }
        private void mesa1_Click(object sender, EventArgs e)
        {
            SeleccionarMesero seleccionarMesero = new SeleccionarMesero();
            seleccionarMesero.ShowDialog();
        }

        private void mesa2_Click(object sender, EventArgs e)
        {
            SeleccionarMesero seleccionarMesero = new SeleccionarMesero();
            seleccionarMesero.ShowDialog();
        }

        private void mesa3_Click(object sender, EventArgs e)
        {
            SeleccionarMesero seleccionarMesero = new SeleccionarMesero();
            seleccionarMesero.ShowDialog();
        }

        private void mesa4_Click(object sender, EventArgs e)
        {
            SeleccionarMesero seleccionarMesero2 = new SeleccionarMesero();
            seleccionarMesero2.ShowDialog();
        }

        private void mesa5_Click(object sender, EventArgs e)
        {
            SeleccionarMesero seleccionarMesero = new SeleccionarMesero();
            seleccionarMesero.ShowDialog();
        }

        private void mesa6_Click(object sender, EventArgs e)
        {
            SeleccionarMesero seleccionarMesero = new SeleccionarMesero();
            seleccionarMesero.ShowDialog();
        }

        private void mesa7_Click(object sender, EventArgs e)
        {
            SeleccionarMesero seleccionarMesero = new SeleccionarMesero();
            seleccionarMesero.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            je();
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa8_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa9_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa10_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa11_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa12_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa13_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa14_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa15_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa16_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa17_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa18_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa19_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa20_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa21_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa22_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa23_Click(object sender, EventArgs e)
        {
            je();
        }

        private void mesa24_Click(object sender, EventArgs e)
        {
            je();
        }
    }
}
