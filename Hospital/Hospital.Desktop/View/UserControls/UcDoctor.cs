using Hospital.Desktop.Model.Repositories;
using Hospital.Desktop.Presenter;
using Hospital.Desktop.View.Services;
using System.Windows.Forms;

namespace Hospital.Desktop.View.UserControls
{
    public partial class UcDoctor : UserControl, IDoctorView
    {
        private static UcDoctor _instancia;

        public static UcDoctor Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new UcDoctor();
                }
                return _instancia;
            }
        }     

        public UcDoctor()
        {
            InitializeComponent();

             new DoctorPresenter(this, new DoctorRepository());
        }

        public object GridDataSource
        {
            get => gridDoctor.DataSource;
            set => gridDoctor.DataSource = value;
        }
    }
}
