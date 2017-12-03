namespace Hospital.Desktop.View.UserControls
{
    partial class UcPatient
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcPatient));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.gridPacient = new System.Windows.Forms.DataGridView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.cboxCountry = new MetroFramework.Controls.MetroComboBox();
            this.txtNotice = new MetroFramework.Controls.MetroTextBox();
            this.cboxSpecialization = new MetroFramework.Controls.MetroComboBox();
            this.txtZipCode = new MetroFramework.Controls.MetroTextBox();
            this.txtNumber = new MetroFramework.Controls.MetroTextBox();
            this.txtStreet = new MetroFramework.Controls.MetroTextBox();
            this.txtCity = new MetroFramework.Controls.MetroTextBox();
            this.txtState = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboxWoman = new MetroFramework.Controls.MetroCheckBox();
            this.cboxMan = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtTelephone = new MetroFramework.Controls.MetroTextBox();
            this.txtDocument = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.btnAddPatient = new ns1.BunifuFlatButton();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.progbarAddPatient = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacient)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(942, 578);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.gridPacient);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(934, 536);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "   Lista de Paciente   ";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // gridPacient
            // 
            this.gridPacient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPacient.Location = new System.Drawing.Point(0, 3);
            this.gridPacient.Name = "gridPacient";
            this.gridPacient.Size = new System.Drawing.Size(931, 533);
            this.gridPacient.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.progbarAddPatient);
            this.metroTabPage2.Controls.Add(this.dtBirthDate);
            this.metroTabPage2.Controls.Add(this.cboxCountry);
            this.metroTabPage2.Controls.Add(this.txtNotice);
            this.metroTabPage2.Controls.Add(this.cboxSpecialization);
            this.metroTabPage2.Controls.Add(this.txtZipCode);
            this.metroTabPage2.Controls.Add(this.txtNumber);
            this.metroTabPage2.Controls.Add(this.txtStreet);
            this.metroTabPage2.Controls.Add(this.txtCity);
            this.metroTabPage2.Controls.Add(this.txtState);
            this.metroTabPage2.Controls.Add(this.metroLabel2);
            this.metroTabPage2.Controls.Add(this.cboxWoman);
            this.metroTabPage2.Controls.Add(this.cboxMan);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.txtTelephone);
            this.metroTabPage2.Controls.Add(this.txtDocument);
            this.metroTabPage2.Controls.Add(this.txtName);
            this.metroTabPage2.Controls.Add(this.btnAddPatient);
            this.metroTabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(934, 536);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "   Adicionar Paciente   ";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // cboxCountry
            // 
            this.cboxCountry.FormattingEnabled = true;
            this.cboxCountry.ItemHeight = 23;
            this.cboxCountry.Items.AddRange(new object[] {
            "<País>",
            "Afeganistão",
            "África do Sul",
            "Akrotiri",
            "Albânia",
            "Alemanha",
            "Andorra",
            "Angola",
            "Anguila",
            "Antárctida",
            "Antígua e Barbuda",
            "Antilhas Neerlandesas",
            "Arábia Saudita",
            "Arctic Ocean",
            "Argélia",
            "Argentina",
            "Arménia",
            "Aruba",
            "Ashmore and Cartier Islands",
            "Atlantic Ocean",
            "Austrália",
            "Áustria",
            "Azerbaijão",
            "Baamas",
            "Bangladeche",
            "Barbados",
            "Barém",
            "Bélgica",
            "Belize",
            "Benim",
            "Bermudas",
            "Bielorrússia",
            "Birmânia",
            "Bolívia",
            "Bósnia e Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunei",
            "Bulgária",
            "Burquina Faso",
            "Burúndi",
            "Butão",
            "Cabo Verde",
            "Camarões",
            "Camboja",
            "Canadá",
            "Catar",
            "Cazaquistão",
            "Chade",
            "Chile",
            "China",
            "Chipre",
            "Clipperton Island",
            "Colômbia",
            "Comores",
            "Congo-Brazzaville",
            "Congo-Kinshasa",
            "Coral Sea Islands",
            "Coreia do Norte",
            "Coreia do Sul",
            "Costa do Marfim",
            "Costa Rica",
            "Croácia",
            "Cuba",
            "Dhekelia",
            "Dinamarca",
            "Domínica",
            "Egipto",
            "Emiratos Árabes Unidos",
            "Equador",
            "Eritreia",
            "Eslováquia",
            "Eslovénia",
            "Espanha",
            "Estados Unidos",
            "Estónia",
            "Etiópia",
            "Faroé",
            "Fiji",
            "Filipinas",
            "Finlândia",
            "França",
            "Gabão",
            "Gâmbia",
            "Gana",
            "Gaza Strip",
            "Geórgia",
            "Geórgia do Sul e Sandwich do Sul",
            "Gibraltar",
            "Granada",
            "Grécia",
            "Gronelândia",
            "Guame",
            "Guatemala",
            "Guernsey",
            "Guiana",
            "Guiné",
            "Guiné Equatorial",
            "Guiné-Bissau",
            "Haiti",
            "Honduras",
            "Hong Kong",
            "Hungria",
            "Iémen",
            "Ilha Bouvet",
            "Ilha do Natal",
            "Ilha Norfolk",
            "Ilhas Caimão",
            "Ilhas Cook",
            "Ilhas dos Cocos",
            "Ilhas Falkland",
            "Ilhas Heard e McDonald",
            "Ilhas Marshall",
            "Ilhas Salomão",
            "Ilhas Turcas e Caicos",
            "Ilhas Virgens Americanas",
            "Ilhas Virgens Britânicas",
            "Índia",
            "Indian Ocean",
            "Indonésia",
            "Irão",
            "Iraque",
            "Irlanda",
            "Islândia",
            "Israel",
            "Itália",
            "Jamaica",
            "Jan Mayen",
            "Japão",
            "Jersey",
            "Jibuti",
            "Jordânia",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letónia",
            "Líbano",
            "Libéria",
            "Líbia",
            "Listenstaine",
            "Lituânia",
            "Luxemburgo",
            "Macau",
            "Macedónia",
            "Madagáscar",
            "Malásia",
            "Malávi",
            "Maldivas",
            "Mali",
            "Malta",
            "Man, Isle of",
            "Marianas do Norte",
            "Marrocos",
            "Maurícia",
            "Mauritânia",
            "Mayotte",
            "México",
            "Micronésia",
            "Moçambique",
            "Moldávia",
            "Mónaco",
            "Mongólia",
            "Monserrate",
            "Montenegro",
            "Mundo",
            "Namíbia",
            "Nauru",
            "Navassa Island",
            "Nepal",
            "Nicarágua",
            "Níger",
            "Nigéria",
            "Niue",
            "Noruega",
            "Nova Caledónia",
            "Nova Zelândia",
            "Omã",
            "Pacific Ocean",
            "Países Baixos",
            "Palau",
            "Panamá",
            "Papua-Nova Guiné",
            "Paquistão",
            "Paracel Islands",
            "Paraguai",
            "Peru",
            "Pitcairn",
            "Polinésia Francesa",
            "Polónia",
            "Porto Rico",
            "Portugal",
            "Quénia",
            "Quirguizistão",
            "Quiribáti",
            "Reino Unido",
            "República Centro-Africana",
            "República Checa",
            "República Dominicana",
            "Roménia",
            "Ruanda",
            "Rússia",
            "Salvador",
            "Samoa",
            "Samoa Americana",
            "Santa Helena",
            "Santa Lúcia",
            "São Cristóvão e Neves",
            "São Marinho",
            "São Pedro e Miquelon",
            "São Tomé e Príncipe",
            "São Vicente e Granadinas",
            "Sara Ocidental",
            "Seicheles",
            "Senegal",
            "Serra Leoa",
            "Sérvia",
            "Singapura",
            "Síria",
            "Somália",
            "Southern Ocean",
            "Spratly Islands",
            "Sri Lanca",
            "Suazilândia",
            "Sudão",
            "Suécia",
            "Suíça",
            "Suriname",
            "Svalbard e Jan Mayen",
            "Tailândia",
            "Taiwan",
            "Tajiquistão",
            "Tanzânia",
            "Território Britânico do Oceano Índico",
            "Territórios Austrais Franceses",
            "Timor Leste",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trindade e Tobago",
            "Tunísia",
            "Turquemenistão",
            "Turquia",
            "Tuvalu",
            "Ucrânia",
            "Uganda",
            "União Europeia",
            "Uruguai",
            "Usbequistão",
            "Vanuatu",
            "Vaticano",
            "Venezuela",
            "Vietname",
            "Wake Island",
            "Wallis e Futuna",
            "West Bank",
            "Zâmbia",
            "Zimbabué"});
            this.cboxCountry.Location = new System.Drawing.Point(482, 288);
            this.cboxCountry.Name = "cboxCountry";
            this.cboxCountry.Size = new System.Drawing.Size(447, 29);
            this.cboxCountry.TabIndex = 41;
            this.cboxCountry.UseSelectable = true;
            // 
            // txtNotice
            // 
            // 
            // 
            // 
            this.txtNotice.CustomButton.Image = null;
            this.txtNotice.CustomButton.Location = new System.Drawing.Point(347, 1);
            this.txtNotice.CustomButton.Name = "";
            this.txtNotice.CustomButton.Size = new System.Drawing.Size(99, 99);
            this.txtNotice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNotice.CustomButton.TabIndex = 1;
            this.txtNotice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNotice.CustomButton.UseSelectable = true;
            this.txtNotice.CustomButton.Visible = false;
            this.txtNotice.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNotice.Lines = new string[0];
            this.txtNotice.Location = new System.Drawing.Point(7, 412);
            this.txtNotice.MaxLength = 32767;
            this.txtNotice.Multiline = true;
            this.txtNotice.Name = "txtNotice";
            this.txtNotice.PasswordChar = '\0';
            this.txtNotice.PromptText = "Observações";
            this.txtNotice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNotice.SelectedText = "";
            this.txtNotice.SelectionLength = 0;
            this.txtNotice.SelectionStart = 0;
            this.txtNotice.ShortcutsEnabled = true;
            this.txtNotice.Size = new System.Drawing.Size(447, 101);
            this.txtNotice.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNotice.TabIndex = 40;
            this.txtNotice.UseSelectable = true;
            this.txtNotice.WaterMark = "Observações";
            this.txtNotice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNotice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cboxSpecialization
            // 
            this.cboxSpecialization.FormattingEnabled = true;
            this.cboxSpecialization.ItemHeight = 23;
            this.cboxSpecialization.Location = new System.Drawing.Point(482, 475);
            this.cboxSpecialization.Name = "cboxSpecialization";
            this.cboxSpecialization.Size = new System.Drawing.Size(447, 29);
            this.cboxSpecialization.TabIndex = 39;
            this.cboxSpecialization.UseSelectable = true;
            // 
            // txtZipCode
            // 
            // 
            // 
            // 
            this.txtZipCode.CustomButton.Image = null;
            this.txtZipCode.CustomButton.Location = new System.Drawing.Point(413, 1);
            this.txtZipCode.CustomButton.Name = "";
            this.txtZipCode.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtZipCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtZipCode.CustomButton.TabIndex = 1;
            this.txtZipCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtZipCode.CustomButton.UseSelectable = true;
            this.txtZipCode.CustomButton.Visible = false;
            this.txtZipCode.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtZipCode.Lines = new string[0];
            this.txtZipCode.Location = new System.Drawing.Point(482, 101);
            this.txtZipCode.MaxLength = 32767;
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.PasswordChar = '\0';
            this.txtZipCode.PromptText = "CEP";
            this.txtZipCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtZipCode.SelectedText = "";
            this.txtZipCode.SelectionLength = 0;
            this.txtZipCode.SelectionStart = 0;
            this.txtZipCode.ShortcutsEnabled = true;
            this.txtZipCode.Size = new System.Drawing.Size(447, 35);
            this.txtZipCode.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtZipCode.TabIndex = 38;
            this.txtZipCode.UseSelectable = true;
            this.txtZipCode.WaterMark = "CEP";
            this.txtZipCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtZipCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtNumber
            // 
            // 
            // 
            // 
            this.txtNumber.CustomButton.Image = null;
            this.txtNumber.CustomButton.Location = new System.Drawing.Point(413, 1);
            this.txtNumber.CustomButton.Name = "";
            this.txtNumber.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumber.CustomButton.TabIndex = 1;
            this.txtNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumber.CustomButton.UseSelectable = true;
            this.txtNumber.CustomButton.Visible = false;
            this.txtNumber.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNumber.Lines = new string[0];
            this.txtNumber.Location = new System.Drawing.Point(482, 226);
            this.txtNumber.MaxLength = 32767;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.PasswordChar = '\0';
            this.txtNumber.PromptText = "Número";
            this.txtNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumber.SelectedText = "";
            this.txtNumber.SelectionLength = 0;
            this.txtNumber.SelectionStart = 0;
            this.txtNumber.ShortcutsEnabled = true;
            this.txtNumber.Size = new System.Drawing.Size(447, 35);
            this.txtNumber.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumber.TabIndex = 36;
            this.txtNumber.UseSelectable = true;
            this.txtNumber.WaterMark = "Número";
            this.txtNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtStreet
            // 
            // 
            // 
            // 
            this.txtStreet.CustomButton.Image = null;
            this.txtStreet.CustomButton.Location = new System.Drawing.Point(413, 1);
            this.txtStreet.CustomButton.Name = "";
            this.txtStreet.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtStreet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStreet.CustomButton.TabIndex = 1;
            this.txtStreet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStreet.CustomButton.UseSelectable = true;
            this.txtStreet.CustomButton.Visible = false;
            this.txtStreet.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtStreet.Lines = new string[0];
            this.txtStreet.Location = new System.Drawing.Point(482, 163);
            this.txtStreet.MaxLength = 32767;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.PasswordChar = '\0';
            this.txtStreet.PromptText = "Rua";
            this.txtStreet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStreet.SelectedText = "";
            this.txtStreet.SelectionLength = 0;
            this.txtStreet.SelectionStart = 0;
            this.txtStreet.ShortcutsEnabled = true;
            this.txtStreet.Size = new System.Drawing.Size(447, 35);
            this.txtStreet.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStreet.TabIndex = 35;
            this.txtStreet.UseSelectable = true;
            this.txtStreet.WaterMark = "Rua";
            this.txtStreet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStreet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtCity
            // 
            // 
            // 
            // 
            this.txtCity.CustomButton.Image = null;
            this.txtCity.CustomButton.Location = new System.Drawing.Point(413, 1);
            this.txtCity.CustomButton.Name = "";
            this.txtCity.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtCity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCity.CustomButton.TabIndex = 1;
            this.txtCity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCity.CustomButton.UseSelectable = true;
            this.txtCity.CustomButton.Visible = false;
            this.txtCity.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCity.Lines = new string[0];
            this.txtCity.Location = new System.Drawing.Point(482, 412);
            this.txtCity.MaxLength = 32767;
            this.txtCity.Name = "txtCity";
            this.txtCity.PasswordChar = '\0';
            this.txtCity.PromptText = "Cidade";
            this.txtCity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCity.SelectedText = "";
            this.txtCity.SelectionLength = 0;
            this.txtCity.SelectionStart = 0;
            this.txtCity.ShortcutsEnabled = true;
            this.txtCity.Size = new System.Drawing.Size(447, 35);
            this.txtCity.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCity.TabIndex = 34;
            this.txtCity.UseSelectable = true;
            this.txtCity.WaterMark = "Cidade";
            this.txtCity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtState
            // 
            // 
            // 
            // 
            this.txtState.CustomButton.Image = null;
            this.txtState.CustomButton.Location = new System.Drawing.Point(413, 1);
            this.txtState.CustomButton.Name = "";
            this.txtState.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtState.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtState.CustomButton.TabIndex = 1;
            this.txtState.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtState.CustomButton.UseSelectable = true;
            this.txtState.CustomButton.Visible = false;
            this.txtState.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtState.Lines = new string[0];
            this.txtState.Location = new System.Drawing.Point(482, 349);
            this.txtState.MaxLength = 32767;
            this.txtState.Name = "txtState";
            this.txtState.PasswordChar = '\0';
            this.txtState.PromptText = "Estado";
            this.txtState.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtState.SelectedText = "";
            this.txtState.SelectionLength = 0;
            this.txtState.SelectionStart = 0;
            this.txtState.ShortcutsEnabled = true;
            this.txtState.Size = new System.Drawing.Size(447, 35);
            this.txtState.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtState.TabIndex = 33;
            this.txtState.UseSelectable = true;
            this.txtState.WaterMark = "Estado";
            this.txtState.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtState.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(7, 232);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(78, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Nascimento";
            // 
            // cboxWoman
            // 
            this.cboxWoman.AutoSize = true;
            this.cboxWoman.Location = new System.Drawing.Point(93, 171);
            this.cboxWoman.Name = "cboxWoman";
            this.cboxWoman.Size = new System.Drawing.Size(73, 15);
            this.cboxWoman.TabIndex = 28;
            this.cboxWoman.Text = "Feminino";
            this.cboxWoman.UseSelectable = true;
            // 
            // cboxMan
            // 
            this.cboxMan.AutoSize = true;
            this.cboxMan.Location = new System.Drawing.Point(184, 171);
            this.cboxMan.Name = "cboxMan";
            this.cboxMan.Size = new System.Drawing.Size(78, 15);
            this.cboxMan.TabIndex = 27;
            this.cboxMan.Text = "Masculino";
            this.cboxMan.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 167);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Sexo";
            // 
            // txtTelephone
            // 
            // 
            // 
            // 
            this.txtTelephone.CustomButton.Image = null;
            this.txtTelephone.CustomButton.Location = new System.Drawing.Point(413, 1);
            this.txtTelephone.CustomButton.Name = "";
            this.txtTelephone.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtTelephone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelephone.CustomButton.TabIndex = 1;
            this.txtTelephone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelephone.CustomButton.UseSelectable = true;
            this.txtTelephone.CustomButton.Visible = false;
            this.txtTelephone.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTelephone.Lines = new string[0];
            this.txtTelephone.Location = new System.Drawing.Point(7, 349);
            this.txtTelephone.MaxLength = 32767;
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.PasswordChar = '\0';
            this.txtTelephone.PromptText = "Telefone";
            this.txtTelephone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelephone.SelectedText = "";
            this.txtTelephone.SelectionLength = 0;
            this.txtTelephone.SelectionStart = 0;
            this.txtTelephone.ShortcutsEnabled = true;
            this.txtTelephone.Size = new System.Drawing.Size(447, 35);
            this.txtTelephone.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelephone.TabIndex = 22;
            this.txtTelephone.UseSelectable = true;
            this.txtTelephone.WaterMark = "Telefone";
            this.txtTelephone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelephone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtDocument
            // 
            // 
            // 
            // 
            this.txtDocument.CustomButton.Image = null;
            this.txtDocument.CustomButton.Location = new System.Drawing.Point(413, 1);
            this.txtDocument.CustomButton.Name = "";
            this.txtDocument.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtDocument.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocument.CustomButton.TabIndex = 1;
            this.txtDocument.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocument.CustomButton.UseSelectable = true;
            this.txtDocument.CustomButton.Visible = false;
            this.txtDocument.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDocument.Lines = new string[0];
            this.txtDocument.Location = new System.Drawing.Point(7, 286);
            this.txtDocument.MaxLength = 32767;
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.PasswordChar = '\0';
            this.txtDocument.PromptText = "CPF";
            this.txtDocument.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocument.SelectedText = "";
            this.txtDocument.SelectionLength = 0;
            this.txtDocument.SelectionStart = 0;
            this.txtDocument.ShortcutsEnabled = true;
            this.txtDocument.Size = new System.Drawing.Size(447, 35);
            this.txtDocument.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocument.TabIndex = 21;
            this.txtDocument.UseSelectable = true;
            this.txtDocument.WaterMark = "CPF";
            this.txtDocument.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocument.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(413, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(7, 101);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Nome";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(447, 35);
            this.txtName.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.TabIndex = 17;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Nome";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(102)))), ((int)(((byte)(214)))));
            this.btnAddPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPatient.BorderRadius = 0;
            this.btnAddPatient.ButtonText = "   Adicionar Paciente";
            this.btnAddPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPatient.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddPatient.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddPatient.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddPatient.Iconimage")));
            this.btnAddPatient.Iconimage_right = null;
            this.btnAddPatient.Iconimage_right_Selected = null;
            this.btnAddPatient.Iconimage_Selected = null;
            this.btnAddPatient.IconMarginLeft = 0;
            this.btnAddPatient.IconMarginRight = 0;
            this.btnAddPatient.IconRightVisible = false;
            this.btnAddPatient.IconRightZoom = 0D;
            this.btnAddPatient.IconVisible = false;
            this.btnAddPatient.IconZoom = 60D;
            this.btnAddPatient.IsTab = false;
            this.btnAddPatient.Location = new System.Drawing.Point(482, 27);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(102)))), ((int)(((byte)(214)))));
            this.btnAddPatient.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAddPatient.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddPatient.selected = false;
            this.btnAddPatient.Size = new System.Drawing.Size(447, 48);
            this.btnAddPatient.TabIndex = 16;
            this.btnAddPatient.Text = "   Adicionar Paciente";
            this.btnAddPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPatient.Textcolor = System.Drawing.Color.White;
            this.btnAddPatient.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.CalendarForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtBirthDate.CalendarTitleForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dtBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthDate.Location = new System.Drawing.Point(93, 225);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(169, 26);
            this.dtBirthDate.TabIndex = 42;
            this.dtBirthDate.Value = new System.DateTime(2017, 12, 3, 0, 0, 0, 0);
            // 
            // progbarAddPatient
            // 
            this.progbarAddPatient.animated = false;
            this.progbarAddPatient.animationIterval = 5;
            this.progbarAddPatient.animationSpeed = 300;
            this.progbarAddPatient.BackColor = System.Drawing.Color.Transparent;
            this.progbarAddPatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progbarAddPatient.BackgroundImage")));
            this.progbarAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.progbarAddPatient.ForeColor = System.Drawing.Color.Black;
            this.progbarAddPatient.LabelVisible = false;
            this.progbarAddPatient.LineProgressThickness = 8;
            this.progbarAddPatient.LineThickness = 5;
            this.progbarAddPatient.Location = new System.Drawing.Point(435, 27);
            this.progbarAddPatient.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.progbarAddPatient.MaxValue = 100;
            this.progbarAddPatient.Name = "progbarAddPatient";
            this.progbarAddPatient.ProgressBackColor = System.Drawing.Color.LightGray;
            this.progbarAddPatient.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.progbarAddPatient.Size = new System.Drawing.Size(48, 48);
            this.progbarAddPatient.TabIndex = 43;
            this.progbarAddPatient.Value = 0;
            this.progbarAddPatient.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UcPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControl1);
            this.Name = "UcPatient";
            this.Size = new System.Drawing.Size(943, 581);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPacient)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView gridPacient;
        private ns1.BunifuFlatButton btnAddPatient;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtTelephone;
        private MetroFramework.Controls.MetroTextBox txtDocument;
        private MetroFramework.Controls.MetroTextBox txtZipCode;
        private MetroFramework.Controls.MetroTextBox txtNumber;
        private MetroFramework.Controls.MetroTextBox txtStreet;
        private MetroFramework.Controls.MetroTextBox txtCity;
        private MetroFramework.Controls.MetroTextBox txtState;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox cboxWoman;
        private MetroFramework.Controls.MetroCheckBox cboxMan;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cboxSpecialization;
        private MetroFramework.Controls.MetroTextBox txtNotice;
        private MetroFramework.Controls.MetroComboBox cboxCountry;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private Bunifu.Framework.UI.BunifuCircleProgressbar progbarAddPatient;
        private System.Windows.Forms.Timer timer1;
    }
}
