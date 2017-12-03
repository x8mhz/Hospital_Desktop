using Hospital.Desktop.Presenter;
using System;
using System.Globalization;
using System.Windows.Forms;
using Hospital.Desktop.Model.Repositories;
using Hospital.Desktop.View.Services;

namespace Hospital.Desktop.View.UserControls
{
    public partial class UcPatient : UserControl, IPatientView
    {
        private static UcPatient _instancia;
        private string _genere;

        public static UcPatient Instancia => _instancia ?? (_instancia = new UcPatient());

        public UcPatient()
        {
            InitializeComponent();

            new PatientPresenter(this, new PatientRepository());
        }

        private void btnAddPatient_Click(object sender, System.EventArgs e)
        {
            ProgressiveBar();

            Genere();
            var presenter = new PatientPresenter(this);
            presenter.SavePatient();
            ClearTextbox(this);

            new PatientPresenter(this, new PatientRepository());
        }

        #region ProgressiveBar

        public void ProgressiveBar()
        {
            progbarAddPatient.Enabled = true;
            progbarAddPatient.Visible = true;
            progbarAddPatient.Value = 0;
            timer1.Enabled = true;
            timer1.Start();

            progbarAddPatient.MaxValue = 10;
            timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progbarAddPatient.Value != 10)
            {
                progbarAddPatient.Value++;
            }
            else
            {
                MessageBox.Show(@"Paciente salco com sucesso!");
                timer1.Stop();
                progbarAddPatient.Value = 0;
                progbarAddPatient.Visible = false;
                progbarAddPatient.Enabled = false;
                timer1.Enabled = false;              
            }
        }

        #endregion

        public void ClearTextbox(Control con)
        {
            txtName.Clear();
            txtDocument.Clear();
            txtZipCode.Clear();
            txtStreet.Clear();
            txtNumber.Clear();
            txtTelephone.Clear();
            txtNotice.Clear();
            txtCity.Clear();
            txtState.Clear();
            dtBirthDate.Text = DateTime.Now.ToString(CultureInfo.InvariantCulture);
        }

        public void Genere()
        {
            if (cboxWoman.Checked)
            {
                _genere = "Feminino";
            }
            if (cboxMan.Checked)
            {
                _genere = "Masculino";
            }
        }

        #region ViewImplementation

        public object GridDataSource
        {
            get => gridPacient.DataSource;
            set => gridPacient.DataSource = value;
        }

        public string NameComplete
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        string IPatientView.Genere
        {
            get { return _genere; }
            set { _genere = value; }
        }

        public string BirthDate
        {
            get { return dtBirthDate.Value.Date.ToString(); }
            set { dtBirthDate.Value = Convert.ToDateTime(value); }
        }

        public string Document
        {
            get { return txtDocument.Text; }
            set { txtDocument.Text = value; }
        }

        public string Telephone
        {
            get { return txtTelephone.Text; }
            set { txtTelephone.Text = value; }
        }

        public string ZipCode
        {
            get { return txtZipCode.Text; }
            set { txtZipCode.Text = value; }
        }

        public string Street
        {
            get { return txtStreet.Text; }
            set { txtStreet.Text = value; }
        }

        public string Number
        {
            get { return txtNumber.Text; }
            set { txtNumber.Text = value; }
        }

        public string Country
        {
            get { return cboxCountry.Text; }
            set { cboxCountry.Text = value; }
        }

        public string State
        {
            get { return txtState.Text; }
            set { txtState.Text = value; }
        }

        public string City
        {
            get { return txtCity.Text; }
            set { txtCity.Text = value; }
        }

        public string Notice
        {
            get { return txtNotice.Text; }
            set { txtNotice.Text = value; }
        }

        public string Specialization
        {
            get { return cboxSpecialization.Text; }
            set { cboxSpecialization.Text = value; }
        }


        #endregion
    }
}
