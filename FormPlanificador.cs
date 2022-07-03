using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ProySistemasOperativos1
{
    public partial class FormPlanificador : Form
    {

        private PCB PRUN;
        private Queue<PCB>[] Colas;
        private int k = 0;
        private bool Estado = false;
        private int NumPrun = 0;
        private int NumPrunCola = 0;
        private int NumPrunEjecutando = 0;
        private int NumPapelera=0;
        private bool prender = false;
        public FormPlanificador()
        {
            InitializeComponent();
        }
        public void  Init()
        {
            for (int i = 0; i <Int32.Parse(numericColas.Value.ToString()); i++)
            {
                Colas[i] = new Queue<PCB>();
                this.PRUN = new PCB();
                PRUN.DIR = 0;
                Colas[i].Enqueue(PRUN);
            }
        }
        private void CicloPlanificador()
        {
           
            Init();
            Estado = true;
            timerPRUN.Start();
            while (Estado == true)
            {
                Planificador();
                Application.DoEvents();
            }
        }
        private bool finalizo()
        {
            return NumPrun >= Int32.Parse(dataGridViewDatos.Rows[k].Cells[3].Value.ToString());  
        }
        private bool finalizoCola()
        {
            return NumPrunCola >= Int32.Parse(dataGridViewDatos.Rows[k].Cells[2].Value.ToString());
        }
        private int nextK(int k)
        {
            if (k < Int32.Parse(numericColas.Value.ToString()) -1)
                return k + 1;
            else
                return 0;
        }
        private void Planificador()
        {
            if (finalizo())
            {
               Colas[k].Enqueue(PRUN);
                if (finalizoCola())
                {
                    dataGridViewDatos.Rows[k].Cells[0].Style.BackColor = Color.White;
                    dataGridViewProcesos.Rows[k].Cells[0].Style.BackColor = Color.White;
                    dataGridViewProcesos.Rows[k].Cells[PRUN.DIR+1].Style.BackColor = Color.White;
                    k = nextK(k);
                    NumPrunCola = 0;
                    NumPrun = 0;
                    NumPrunEjecutando = 0;
                    PRUN = Colas[k].Dequeue();
                    return;
                }
                NumPrun = 0;
                dataGridViewProcesos.Rows[k].Cells[PRUN.DIR+1].Style.BackColor = Color.White;
                PRUN = Colas[k].Dequeue();
            }
            else
            {
                dataGridViewDatos.Rows[k].Cells[0].Style.BackColor = Color.Red;
                dataGridViewProcesos.Rows[k].Cells[0].Style.BackColor = Color.Red;
                dataGridViewProcesos.Rows[k].Cells[PRUN.DIR+1].Style.BackColor = Color.Blue;
                PRUNtext.Text  = "PRUN # " + (PRUN.DIR+1).ToString() + " Cola # " + (k + 1).ToString();
            }
        }
        private void timerPRUN_Tick(object sender, EventArgs e)
        {
            NumPrun++;
            NumPrunCola++;
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {

            if (numericColas.Value > 0)
            {
                buttonParar.Visible = true;
                dataGridViewProcesos.Visible = true;
                Colas = new Queue<PCB>[Int32.Parse(numericColas.Value.ToString())];
                for (int i = 0; i < Int32.Parse(numericColas.Value.ToString()); i++)
                {
                    dataGridViewDatos.Rows.Add();
                    dataGridViewDatos.Rows[i].Cells[0].Value = i;
                    dataGridViewDatos.Rows[i].Cells[1].Value = 1;
                    dataGridViewDatos.Rows[i].Cells[2].Value = 1;
                    dataGridViewDatos.Rows[i].Cells[3].Value = 1;
                    dataGridViewProcesos.Rows.Add();
                    dataGridViewProcesos.Rows[i].Cells[0].Value = i;
                    dataGridViewProcesos.Rows[i].Cells[1].Value = 1;
                }
                CicloPlanificador();
            }
            else
            {
                MessageBox.Show("INGRESAR UN DATO MAYOR A 0");
            }
        }

        private void FormPlanificador_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewDatos_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                NumPapelera = Int32.Parse(dataGridViewDatos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            }
        }

        private void dataGridViewDatos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
          if(e.ColumnIndex==1)
            {
                if (Int32.Parse(dataGridViewDatos.Rows[e.RowIndex].Cells[1].Value.ToString()) < 16)
                {
                    Colas[e.RowIndex] = new Queue<PCB>();
                    for (int i = 0; i < Int32.Parse(dataGridViewDatos.Rows[e.RowIndex].Cells[1].Value.ToString()); i++)
                    {
                        PCB aux = new PCB();
                        aux.DIR = i;
                        Colas[e.RowIndex].Enqueue(aux);
                        dataGridViewProcesos.Rows[e.RowIndex].Cells[i + 1].Value = 1;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (prender == false)
            {
                prender = true;
                dataGridViewDatos.Visible = true;
            }
            else
            {
                prender = false;
                dataGridViewDatos.Visible = false;
                
            }
        }

        private void buttonParar_Click(object sender, EventArgs e)
        {
            Estado = false;
            buttonParar.Visible= false;
            dataGridViewDatos.Visible=false;
            dataGridViewProcesos.Visible = false;

        }
    }
}
