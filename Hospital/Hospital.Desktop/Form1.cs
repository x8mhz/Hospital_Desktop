using Hospital.Desktop.View.UserControls;
using System;
using System.Windows.Forms;

namespace Hospital.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            if (!pnMain.Controls.Contains(UcPatient.Instancia))
            {
                pnMain.Controls.Add(UcPatient.Instancia);
                UcPatient.Instancia.Dock = DockStyle.Fill;
                UcPatient.Instancia.BringToFront();
            }
            else
            {
                UcPatient.Instancia.BringToFront();
            }
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            if (!pnMain.Controls.Contains(UcDoctor.Instancia))
            {
                pnMain.Controls.Add(UcDoctor.Instancia);
                UcDoctor.Instancia.Dock = DockStyle.Fill;
                UcDoctor.Instancia.BringToFront();
            }
            else
            {
                UcDoctor.Instancia.BringToFront();
            }
        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            if (!pnMain.Controls.Contains(UcHospital.Instancia))
            {
                pnMain.Controls.Add(UcHospital.Instancia);
                UcHospital.Instancia.Dock = DockStyle.Fill;
                UcHospital.Instancia.BringToFront();
            }
            else
            {
                UcHospital.Instancia.BringToFront();
            }
        }   
    }
}
