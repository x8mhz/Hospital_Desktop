using System.Windows.Forms;
using Hospital.Desktop.Model.Repositories;
using Hospital.Desktop.Presenter;
using Hospital.Desktop.View.Services;

namespace Hospital.Desktop.View.UserControls
{
    public partial class UcHospital : UserControl, IHospitalService
    {
        private static UcHospital _instancia;

        public static UcHospital Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new UcHospital();
                }
                return _instancia;
            }
        }
   
        public UcHospital()
        {
            InitializeComponent();

            new HospitalPresenter(this, new HospitalRepository());
        }

        public object GridDataSource
        {
            get => gridHospital.DataSource;
            set => gridHospital.DataSource = value;
        }
    }
}
