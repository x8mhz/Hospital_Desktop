using Hospital.Desktop.Presenter;
using System;
using System.Windows.Forms;
using Hospital.Desktop.View.Services;

namespace Hospital.Desktop.View.UserControls
{
    public partial class UcPatient : UserControl, IPatientView
    {
        private static UcPatient _instancia;
        private string _genere;
        private string _birthDate;


        public static UcPatient Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new UcPatient();
                }
                return _instancia;
            }
        }
        public UcPatient()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, System.EventArgs e)
        {
            Genere();
            var presenter = new PatientPresenter(this);
            presenter.SavePatient();
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
