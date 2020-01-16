namespace pizza
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.p1_FirstNameInput = new System.Windows.Forms.TextBox();
            this.p1_NameLbl = new System.Windows.Forms.Label();
            this.p1_PhoneInput = new System.Windows.Forms.TextBox();
            this.p1_PhoneLbl = new System.Windows.Forms.Label();
            this.p1_AdressInput = new System.Windows.Forms.TextBox();
            this.p1_FirstNameLbl = new System.Windows.Forms.Label();
            this.p1_NameInput = new System.Windows.Forms.TextBox();
            this.p1_AddressLbl = new System.Windows.Forms.Label();
            this.p1_GenderBox = new System.Windows.Forms.GroupBox();
            this.p1_GenderBox_Other = new System.Windows.Forms.RadioButton();
            this.p1_GenderBox_Female = new System.Windows.Forms.RadioButton();
            this.p1_GenderBox_Male = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.p2_LeaveBox = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.p2_SousTotal_Input = new System.Windows.Forms.TextBox();
            this.p2_TPS_Input = new System.Windows.Forms.TextBox();
            this.p2_Total_Input = new System.Windows.Forms.TextBox();
            this.p2_TVQ_Input = new System.Windows.Forms.TextBox();
            this.p2_TVQ_lbl = new System.Windows.Forms.Label();
            this.p2_Total_lbl = new System.Windows.Forms.Label();
            this.p2_TPS_lbl = new System.Windows.Forms.Label();
            this.p2_SousTotal_lbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.p2_AddonBox = new System.Windows.Forms.GroupBox();
            this.p2_AddonBox_OlivesBlack = new System.Windows.Forms.CheckBox();
            this.p2_AddonBox_PimentHot = new System.Windows.Forms.CheckBox();
            this.p2_AddonBox_Tomatoes = new System.Windows.Forms.CheckBox();
            this.p2_AddonBox_Bacon = new System.Windows.Forms.CheckBox();
            this.p2_AddonBox_Fromage = new System.Windows.Forms.CheckBox();
            this.p2_AddonBox_Ananas = new System.Windows.Forms.CheckBox();
            this.p2_AddonBox_FruitsMer = new System.Windows.Forms.CheckBox();
            this.p2_AddonBox_Merguez = new System.Windows.Forms.CheckBox();
            this.p2_AddonBox_Olives = new System.Windows.Forms.CheckBox();
            this.p2_AddonBox_Champignons = new System.Windows.Forms.CheckBox();
            this.p2_AddonBox_Piments = new System.Windows.Forms.CheckBox();
            this.p2_AddonBox_Peperonis = new System.Windows.Forms.CheckBox();
            this.p2_CrustBox = new System.Windows.Forms.GroupBox();
            this.p2_CrustBox_No = new System.Windows.Forms.RadioButton();
            this.p2_CrustBox_Yes = new System.Windows.Forms.RadioButton();
            this.p2_FormatBox = new System.Windows.Forms.GroupBox();
            this.p2_FormatBox_Medium = new System.Windows.Forms.RadioButton();
            this.p2_FormatBox_XLarge = new System.Windows.Forms.RadioButton();
            this.p2_FormatBox_Large = new System.Windows.Forms.RadioButton();
            this.p2_FormatBox_Small = new System.Windows.Forms.RadioButton();
            this.p2_Title = new System.Windows.Forms.Label();
            this.p1_ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.form1_PhoneLink = new System.Windows.Forms.LinkLabel();
            this.form1_WebLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.p1_GenderBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.p2_LeaveBox.SuspendLayout();
            this.p2_AddonBox.SuspendLayout();
            this.p2_CrustBox.SuspendLayout();
            this.p2_FormatBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p1_ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.p1_FirstNameInput);
            this.panel1.Controls.Add(this.p1_NameLbl);
            this.panel1.Controls.Add(this.p1_PhoneInput);
            this.panel1.Controls.Add(this.p1_PhoneLbl);
            this.panel1.Controls.Add(this.p1_AdressInput);
            this.panel1.Controls.Add(this.p1_FirstNameLbl);
            this.panel1.Controls.Add(this.p1_NameInput);
            this.panel1.Controls.Add(this.p1_AddressLbl);
            this.panel1.Controls.Add(this.p1_GenderBox);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 93);
            this.panel1.TabIndex = 12;
            // 
            // p1_FirstNameInput
            // 
            this.p1_FirstNameInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.p1_FirstNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1_FirstNameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_FirstNameInput.ForeColor = System.Drawing.Color.White;
            this.p1_FirstNameInput.Location = new System.Drawing.Point(88, 35);
            this.p1_FirstNameInput.Name = "p1_FirstNameInput";
            this.p1_FirstNameInput.Size = new System.Drawing.Size(154, 23);
            this.p1_FirstNameInput.TabIndex = 15;
            this.p1_FirstNameInput.TextChanged += new System.EventHandler(this.p1_FirstNameInput_TextChanged);
            // 
            // p1_NameLbl
            // 
            this.p1_NameLbl.AutoSize = true;
            this.p1_NameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_NameLbl.ForeColor = System.Drawing.Color.LightGray;
            this.p1_NameLbl.Location = new System.Drawing.Point(34, 6);
            this.p1_NameLbl.Name = "p1_NameLbl";
            this.p1_NameLbl.Size = new System.Drawing.Size(56, 21);
            this.p1_NameLbl.TabIndex = 12;
            this.p1_NameLbl.Text = "Nom : ";
            // 
            // p1_PhoneInput
            // 
            this.p1_PhoneInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.p1_PhoneInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1_PhoneInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_PhoneInput.ForeColor = System.Drawing.Color.White;
            this.p1_PhoneInput.Location = new System.Drawing.Point(386, 9);
            this.p1_PhoneInput.MaxLength = 10;
            this.p1_PhoneInput.Name = "p1_PhoneInput";
            this.p1_PhoneInput.Size = new System.Drawing.Size(127, 23);
            this.p1_PhoneInput.TabIndex = 18;
            this.p1_PhoneInput.GotFocus += new System.EventHandler(this.p1_PhoneInput_GotFocus);
            this.p1_PhoneInput.LostFocus += new System.EventHandler(this.p1_PhoneInput_LostFocus);
            // 
            // p1_PhoneLbl
            // 
            this.p1_PhoneLbl.AutoSize = true;
            this.p1_PhoneLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_PhoneLbl.ForeColor = System.Drawing.Color.LightGray;
            this.p1_PhoneLbl.Location = new System.Drawing.Point(293, 6);
            this.p1_PhoneLbl.Name = "p1_PhoneLbl";
            this.p1_PhoneLbl.Size = new System.Drawing.Size(87, 21);
            this.p1_PhoneLbl.TabIndex = 17;
            this.p1_PhoneLbl.Text = "Téléphone :";
            // 
            // p1_AdressInput
            // 
            this.p1_AdressInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.p1_AdressInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1_AdressInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_AdressInput.ForeColor = System.Drawing.Color.White;
            this.p1_AdressInput.Location = new System.Drawing.Point(88, 61);
            this.p1_AdressInput.Name = "p1_AdressInput";
            this.p1_AdressInput.Size = new System.Drawing.Size(681, 23);
            this.p1_AdressInput.TabIndex = 16;
            // 
            // p1_FirstNameLbl
            // 
            this.p1_FirstNameLbl.AutoSize = true;
            this.p1_FirstNameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_FirstNameLbl.ForeColor = System.Drawing.Color.LightGray;
            this.p1_FirstNameLbl.Location = new System.Drawing.Point(14, 32);
            this.p1_FirstNameLbl.Name = "p1_FirstNameLbl";
            this.p1_FirstNameLbl.Size = new System.Drawing.Size(76, 21);
            this.p1_FirstNameLbl.TabIndex = 13;
            this.p1_FirstNameLbl.Text = "Prénom : ";
            // 
            // p1_NameInput
            // 
            this.p1_NameInput.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.p1_NameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p1_NameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_NameInput.ForeColor = System.Drawing.Color.White;
            this.p1_NameInput.Location = new System.Drawing.Point(88, 9);
            this.p1_NameInput.Name = "p1_NameInput";
            this.p1_NameInput.Size = new System.Drawing.Size(154, 23);
            this.p1_NameInput.TabIndex = 11;
            this.p1_NameInput.TextChanged += new System.EventHandler(this.p1_NameInput_TextChanged);
            // 
            // p1_AddressLbl
            // 
            this.p1_AddressLbl.AutoSize = true;
            this.p1_AddressLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_AddressLbl.ForeColor = System.Drawing.Color.LightGray;
            this.p1_AddressLbl.Location = new System.Drawing.Point(5, 58);
            this.p1_AddressLbl.Name = "p1_AddressLbl";
            this.p1_AddressLbl.Size = new System.Drawing.Size(85, 21);
            this.p1_AddressLbl.TabIndex = 14;
            this.p1_AddressLbl.Text = "Addresse : ";
            // 
            // p1_GenderBox
            // 
            this.p1_GenderBox.Controls.Add(this.p1_GenderBox_Other);
            this.p1_GenderBox.Controls.Add(this.p1_GenderBox_Female);
            this.p1_GenderBox.Controls.Add(this.p1_GenderBox_Male);
            this.p1_GenderBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_GenderBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.p1_GenderBox.Location = new System.Drawing.Point(519, 9);
            this.p1_GenderBox.Name = "p1_GenderBox";
            this.p1_GenderBox.Size = new System.Drawing.Size(250, 46);
            this.p1_GenderBox.TabIndex = 19;
            this.p1_GenderBox.TabStop = false;
            this.p1_GenderBox.Text = "Genre";
            // 
            // p1_GenderBox_Other
            // 
            this.p1_GenderBox_Other.AutoSize = true;
            this.p1_GenderBox_Other.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_GenderBox_Other.Location = new System.Drawing.Point(178, 19);
            this.p1_GenderBox_Other.Name = "p1_GenderBox_Other";
            this.p1_GenderBox_Other.Size = new System.Drawing.Size(52, 18);
            this.p1_GenderBox_Other.TabIndex = 2;
            this.p1_GenderBox_Other.TabStop = true;
            this.p1_GenderBox_Other.Text = "Autre";
            this.p1_GenderBox_Other.UseVisualStyleBackColor = true;
            // 
            // p1_GenderBox_Female
            // 
            this.p1_GenderBox_Female.AutoSize = true;
            this.p1_GenderBox_Female.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_GenderBox_Female.Location = new System.Drawing.Point(106, 19);
            this.p1_GenderBox_Female.Name = "p1_GenderBox_Female";
            this.p1_GenderBox_Female.Size = new System.Drawing.Size(59, 18);
            this.p1_GenderBox_Female.TabIndex = 1;
            this.p1_GenderBox_Female.TabStop = true;
            this.p1_GenderBox_Female.Text = "Femme";
            this.p1_GenderBox_Female.UseVisualStyleBackColor = true;
            // 
            // p1_GenderBox_Male
            // 
            this.p1_GenderBox_Male.AutoSize = true;
            this.p1_GenderBox_Male.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1_GenderBox_Male.Location = new System.Drawing.Point(31, 19);
            this.p1_GenderBox_Male.Name = "p1_GenderBox_Male";
            this.p1_GenderBox_Male.Size = new System.Drawing.Size(60, 18);
            this.p1_GenderBox_Male.TabIndex = 0;
            this.p1_GenderBox_Male.TabStop = true;
            this.p1_GenderBox_Male.Text = "Homme";
            this.p1_GenderBox_Male.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.p2_LeaveBox);
            this.panel2.Controls.Add(this.p2_SousTotal_Input);
            this.panel2.Controls.Add(this.p2_TPS_Input);
            this.panel2.Controls.Add(this.p2_Total_Input);
            this.panel2.Controls.Add(this.p2_TVQ_Input);
            this.panel2.Controls.Add(this.p2_TVQ_lbl);
            this.panel2.Controls.Add(this.p2_Total_lbl);
            this.panel2.Controls.Add(this.p2_TPS_lbl);
            this.panel2.Controls.Add(this.p2_SousTotal_lbl);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.p2_AddonBox);
            this.panel2.Controls.Add(this.p2_CrustBox);
            this.panel2.Controls.Add(this.p2_FormatBox);
            this.panel2.Controls.Add(this.p2_Title);
            this.panel2.Location = new System.Drawing.Point(12, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 251);
            this.panel2.TabIndex = 13;
            // 
            // p2_LeaveBox
            // 
            this.p2_LeaveBox.Controls.Add(this.button5);
            this.p2_LeaveBox.Controls.Add(this.button4);
            this.p2_LeaveBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_LeaveBox.ForeColor = System.Drawing.Color.Red;
            this.p2_LeaveBox.Location = new System.Drawing.Point(147, 195);
            this.p2_LeaveBox.Name = "p2_LeaveBox";
            this.p2_LeaveBox.Size = new System.Drawing.Size(167, 49);
            this.p2_LeaveBox.TabIndex = 28;
            this.p2_LeaveBox.TabStop = false;
            this.p2_LeaveBox.Text = "Êtes vous sûr ?";
            this.p2_LeaveBox.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(6, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Non";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(87, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Oui";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // p2_SousTotal_Input
            // 
            this.p2_SousTotal_Input.Enabled = false;
            this.p2_SousTotal_Input.Location = new System.Drawing.Point(386, 158);
            this.p2_SousTotal_Input.Name = "p2_SousTotal_Input";
            this.p2_SousTotal_Input.Size = new System.Drawing.Size(87, 20);
            this.p2_SousTotal_Input.TabIndex = 25;
            // 
            // p2_TPS_Input
            // 
            this.p2_TPS_Input.Enabled = false;
            this.p2_TPS_Input.Location = new System.Drawing.Point(538, 158);
            this.p2_TPS_Input.Name = "p2_TPS_Input";
            this.p2_TPS_Input.Size = new System.Drawing.Size(87, 20);
            this.p2_TPS_Input.TabIndex = 24;
            // 
            // p2_Total_Input
            // 
            this.p2_Total_Input.Enabled = false;
            this.p2_Total_Input.Location = new System.Drawing.Point(692, 187);
            this.p2_Total_Input.Name = "p2_Total_Input";
            this.p2_Total_Input.Size = new System.Drawing.Size(77, 20);
            this.p2_Total_Input.TabIndex = 23;
            // 
            // p2_TVQ_Input
            // 
            this.p2_TVQ_Input.Enabled = false;
            this.p2_TVQ_Input.Location = new System.Drawing.Point(692, 158);
            this.p2_TVQ_Input.Name = "p2_TVQ_Input";
            this.p2_TVQ_Input.Size = new System.Drawing.Size(77, 20);
            this.p2_TVQ_Input.TabIndex = 22;
            // 
            // p2_TVQ_lbl
            // 
            this.p2_TVQ_lbl.AutoSize = true;
            this.p2_TVQ_lbl.Location = new System.Drawing.Point(642, 161);
            this.p2_TVQ_lbl.Name = "p2_TVQ_lbl";
            this.p2_TVQ_lbl.Size = new System.Drawing.Size(29, 13);
            this.p2_TVQ_lbl.TabIndex = 21;
            this.p2_TVQ_lbl.Text = "TVQ";
            // 
            // p2_Total_lbl
            // 
            this.p2_Total_lbl.AutoSize = true;
            this.p2_Total_lbl.Location = new System.Drawing.Point(642, 190);
            this.p2_Total_lbl.Name = "p2_Total_lbl";
            this.p2_Total_lbl.Size = new System.Drawing.Size(42, 13);
            this.p2_Total_lbl.TabIndex = 20;
            this.p2_Total_lbl.Text = "TOTAL";
            // 
            // p2_TPS_lbl
            // 
            this.p2_TPS_lbl.AutoSize = true;
            this.p2_TPS_lbl.Location = new System.Drawing.Point(497, 161);
            this.p2_TPS_lbl.Name = "p2_TPS_lbl";
            this.p2_TPS_lbl.Size = new System.Drawing.Size(28, 13);
            this.p2_TPS_lbl.TabIndex = 19;
            this.p2_TPS_lbl.Text = "TPS";
            // 
            // p2_SousTotal_lbl
            // 
            this.p2_SousTotal_lbl.AutoSize = true;
            this.p2_SousTotal_lbl.Location = new System.Drawing.Point(322, 161);
            this.p2_SousTotal_lbl.Name = "p2_SousTotal_lbl";
            this.p2_SousTotal_lbl.Size = new System.Drawing.Size(58, 13);
            this.p2_SousTotal_lbl.TabIndex = 18;
            this.p2_SousTotal_lbl.Text = "Sous-Total";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(9, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Quitter";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(9, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Calculer";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(9, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Liste de Prix";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // p2_AddonBox
            // 
            this.p2_AddonBox.Controls.Add(this.p2_AddonBox_OlivesBlack);
            this.p2_AddonBox.Controls.Add(this.p2_AddonBox_PimentHot);
            this.p2_AddonBox.Controls.Add(this.p2_AddonBox_Tomatoes);
            this.p2_AddonBox.Controls.Add(this.p2_AddonBox_Bacon);
            this.p2_AddonBox.Controls.Add(this.p2_AddonBox_Fromage);
            this.p2_AddonBox.Controls.Add(this.p2_AddonBox_Ananas);
            this.p2_AddonBox.Controls.Add(this.p2_AddonBox_FruitsMer);
            this.p2_AddonBox.Controls.Add(this.p2_AddonBox_Merguez);
            this.p2_AddonBox.Controls.Add(this.p2_AddonBox_Olives);
            this.p2_AddonBox.Controls.Add(this.p2_AddonBox_Champignons);
            this.p2_AddonBox.Controls.Add(this.p2_AddonBox_Piments);
            this.p2_AddonBox.Controls.Add(this.p2_AddonBox_Peperonis);
            this.p2_AddonBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_AddonBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.p2_AddonBox.Location = new System.Drawing.Point(344, 33);
            this.p2_AddonBox.Name = "p2_AddonBox";
            this.p2_AddonBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p2_AddonBox.Size = new System.Drawing.Size(425, 117);
            this.p2_AddonBox.TabIndex = 14;
            this.p2_AddonBox.TabStop = false;
            this.p2_AddonBox.Text = "Ingrédients";
            // 
            // p2_AddonBox_OlivesBlack
            // 
            this.p2_AddonBox_OlivesBlack.AutoSize = true;
            this.p2_AddonBox_OlivesBlack.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_AddonBox_OlivesBlack.Location = new System.Drawing.Point(325, 92);
            this.p2_AddonBox_OlivesBlack.Name = "p2_AddonBox_OlivesBlack";
            this.p2_AddonBox_OlivesBlack.Size = new System.Drawing.Size(92, 19);
            this.p2_AddonBox_OlivesBlack.TabIndex = 11;
            this.p2_AddonBox_OlivesBlack.Text = "Olives Noirs";
            this.p2_AddonBox_OlivesBlack.UseVisualStyleBackColor = true;
            // 
            // p2_AddonBox_PimentHot
            // 
            this.p2_AddonBox_PimentHot.AutoSize = true;
            this.p2_AddonBox_PimentHot.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_AddonBox_PimentHot.Location = new System.Drawing.Point(325, 71);
            this.p2_AddonBox_PimentHot.Name = "p2_AddonBox_PimentHot";
            this.p2_AddonBox_PimentHot.Size = new System.Drawing.Size(97, 19);
            this.p2_AddonBox_PimentHot.TabIndex = 10;
            this.p2_AddonBox_PimentHot.Text = "Piments forts";
            this.p2_AddonBox_PimentHot.UseVisualStyleBackColor = true;
            // 
            // p2_AddonBox_Tomatoes
            // 
            this.p2_AddonBox_Tomatoes.AutoSize = true;
            this.p2_AddonBox_Tomatoes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_AddonBox_Tomatoes.Location = new System.Drawing.Point(325, 47);
            this.p2_AddonBox_Tomatoes.Name = "p2_AddonBox_Tomatoes";
            this.p2_AddonBox_Tomatoes.Size = new System.Drawing.Size(80, 19);
            this.p2_AddonBox_Tomatoes.TabIndex = 9;
            this.p2_AddonBox_Tomatoes.Text = "Tomatoes";
            this.p2_AddonBox_Tomatoes.UseVisualStyleBackColor = true;
            // 
            // p2_AddonBox_Bacon
            // 
            this.p2_AddonBox_Bacon.AutoSize = true;
            this.p2_AddonBox_Bacon.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_AddonBox_Bacon.Location = new System.Drawing.Point(325, 25);
            this.p2_AddonBox_Bacon.Name = "p2_AddonBox_Bacon";
            this.p2_AddonBox_Bacon.Size = new System.Drawing.Size(61, 19);
            this.p2_AddonBox_Bacon.TabIndex = 8;
            this.p2_AddonBox_Bacon.Text = "Bacon";
            this.p2_AddonBox_Bacon.UseVisualStyleBackColor = true;
            // 
            // p2_AddonBox_Fromage
            // 
            this.p2_AddonBox_Fromage.AutoSize = true;
            this.p2_AddonBox_Fromage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_AddonBox_Fromage.Location = new System.Drawing.Point(164, 92);
            this.p2_AddonBox_Fromage.Name = "p2_AddonBox_Fromage";
            this.p2_AddonBox_Fromage.Size = new System.Drawing.Size(76, 19);
            this.p2_AddonBox_Fromage.TabIndex = 7;
            this.p2_AddonBox_Fromage.Text = "Fromage";
            this.p2_AddonBox_Fromage.UseVisualStyleBackColor = true;
            // 
            // p2_AddonBox_Ananas
            // 
            this.p2_AddonBox_Ananas.AutoSize = true;
            this.p2_AddonBox_Ananas.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_AddonBox_Ananas.Location = new System.Drawing.Point(164, 71);
            this.p2_AddonBox_Ananas.Name = "p2_AddonBox_Ananas";
            this.p2_AddonBox_Ananas.Size = new System.Drawing.Size(68, 19);
            this.p2_AddonBox_Ananas.TabIndex = 6;
            this.p2_AddonBox_Ananas.Text = "Ananas";
            this.p2_AddonBox_Ananas.UseVisualStyleBackColor = true;
            // 
            // p2_AddonBox_FruitsMer
            // 
            this.p2_AddonBox_FruitsMer.AutoSize = true;
            this.p2_AddonBox_FruitsMer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_AddonBox_FruitsMer.Location = new System.Drawing.Point(164, 47);
            this.p2_AddonBox_FruitsMer.Name = "p2_AddonBox_FruitsMer";
            this.p2_AddonBox_FruitsMer.Size = new System.Drawing.Size(102, 19);
            this.p2_AddonBox_FruitsMer.TabIndex = 5;
            this.p2_AddonBox_FruitsMer.Text = "Fruits de Mers";
            this.p2_AddonBox_FruitsMer.UseVisualStyleBackColor = true;
            // 
            // p2_AddonBox_Merguez
            // 
            this.p2_AddonBox_Merguez.AutoSize = true;
            this.p2_AddonBox_Merguez.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_AddonBox_Merguez.Location = new System.Drawing.Point(164, 25);
            this.p2_AddonBox_Merguez.Name = "p2_AddonBox_Merguez";
            this.p2_AddonBox_Merguez.Size = new System.Drawing.Size(74, 19);
            this.p2_AddonBox_Merguez.TabIndex = 4;
            this.p2_AddonBox_Merguez.Text = "Merguez";
            this.p2_AddonBox_Merguez.UseVisualStyleBackColor = true;
            // 
            // p2_AddonBox_Olives
            // 
            this.p2_AddonBox_Olives.AutoSize = true;
            this.p2_AddonBox_Olives.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_AddonBox_Olives.Location = new System.Drawing.Point(7, 92);
            this.p2_AddonBox_Olives.Name = "p2_AddonBox_Olives";
            this.p2_AddonBox_Olives.Size = new System.Drawing.Size(60, 19);
            this.p2_AddonBox_Olives.TabIndex = 3;
            this.p2_AddonBox_Olives.Text = "Olives";
            this.p2_AddonBox_Olives.UseVisualStyleBackColor = true;
            // 
            // p2_AddonBox_Champignons
            // 
            this.p2_AddonBox_Champignons.AutoSize = true;
            this.p2_AddonBox_Champignons.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_AddonBox_Champignons.Location = new System.Drawing.Point(7, 71);
            this.p2_AddonBox_Champignons.Name = "p2_AddonBox_Champignons";
            this.p2_AddonBox_Champignons.Size = new System.Drawing.Size(104, 19);
            this.p2_AddonBox_Champignons.TabIndex = 2;
            this.p2_AddonBox_Champignons.Text = "Champignons";
            this.p2_AddonBox_Champignons.UseVisualStyleBackColor = true;
            // 
            // p2_AddonBox_Piments
            // 
            this.p2_AddonBox_Piments.AutoSize = true;
            this.p2_AddonBox_Piments.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_AddonBox_Piments.Location = new System.Drawing.Point(7, 47);
            this.p2_AddonBox_Piments.Name = "p2_AddonBox_Piments";
            this.p2_AddonBox_Piments.Size = new System.Drawing.Size(71, 19);
            this.p2_AddonBox_Piments.TabIndex = 1;
            this.p2_AddonBox_Piments.Text = "Piments";
            this.p2_AddonBox_Piments.UseVisualStyleBackColor = true;
            // 
            // p2_AddonBox_Peperonis
            // 
            this.p2_AddonBox_Peperonis.AutoSize = true;
            this.p2_AddonBox_Peperonis.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_AddonBox_Peperonis.Location = new System.Drawing.Point(7, 25);
            this.p2_AddonBox_Peperonis.Name = "p2_AddonBox_Peperonis";
            this.p2_AddonBox_Peperonis.Size = new System.Drawing.Size(82, 19);
            this.p2_AddonBox_Peperonis.TabIndex = 0;
            this.p2_AddonBox_Peperonis.Text = "Peperonis";
            this.p2_AddonBox_Peperonis.UseVisualStyleBackColor = true;
            // 
            // p2_CrustBox
            // 
            this.p2_CrustBox.Controls.Add(this.p2_CrustBox_No);
            this.p2_CrustBox.Controls.Add(this.p2_CrustBox_Yes);
            this.p2_CrustBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_CrustBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.p2_CrustBox.Location = new System.Drawing.Point(178, 33);
            this.p2_CrustBox.Name = "p2_CrustBox";
            this.p2_CrustBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.p2_CrustBox.Size = new System.Drawing.Size(130, 117);
            this.p2_CrustBox.TabIndex = 13;
            this.p2_CrustBox.TabStop = false;
            this.p2_CrustBox.Text = "Croute Farcie";
            // 
            // p2_CrustBox_No
            // 
            this.p2_CrustBox_No.AutoSize = true;
            this.p2_CrustBox_No.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_CrustBox_No.Location = new System.Drawing.Point(6, 71);
            this.p2_CrustBox_No.Name = "p2_CrustBox_No";
            this.p2_CrustBox_No.Size = new System.Drawing.Size(48, 19);
            this.p2_CrustBox_No.TabIndex = 5;
            this.p2_CrustBox_No.TabStop = true;
            this.p2_CrustBox_No.Text = "Non";
            this.p2_CrustBox_No.UseVisualStyleBackColor = true;
            // 
            // p2_CrustBox_Yes
            // 
            this.p2_CrustBox_Yes.AutoSize = true;
            this.p2_CrustBox_Yes.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_CrustBox_Yes.Location = new System.Drawing.Point(6, 33);
            this.p2_CrustBox_Yes.Name = "p2_CrustBox_Yes";
            this.p2_CrustBox_Yes.Size = new System.Drawing.Size(44, 19);
            this.p2_CrustBox_Yes.TabIndex = 4;
            this.p2_CrustBox_Yes.TabStop = true;
            this.p2_CrustBox_Yes.Text = "Oui";
            this.p2_CrustBox_Yes.UseVisualStyleBackColor = true;
            // 
            // p2_FormatBox
            // 
            this.p2_FormatBox.Controls.Add(this.p2_FormatBox_Medium);
            this.p2_FormatBox.Controls.Add(this.p2_FormatBox_XLarge);
            this.p2_FormatBox.Controls.Add(this.p2_FormatBox_Large);
            this.p2_FormatBox.Controls.Add(this.p2_FormatBox_Small);
            this.p2_FormatBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_FormatBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.p2_FormatBox.Location = new System.Drawing.Point(11, 33);
            this.p2_FormatBox.Name = "p2_FormatBox";
            this.p2_FormatBox.Size = new System.Drawing.Size(130, 117);
            this.p2_FormatBox.TabIndex = 12;
            this.p2_FormatBox.TabStop = false;
            this.p2_FormatBox.Text = "Format";
            // 
            // p2_FormatBox_Medium
            // 
            this.p2_FormatBox_Medium.AutoSize = true;
            this.p2_FormatBox_Medium.Checked = true;
            this.p2_FormatBox_Medium.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_FormatBox_Medium.Location = new System.Drawing.Point(6, 48);
            this.p2_FormatBox_Medium.Name = "p2_FormatBox_Medium";
            this.p2_FormatBox_Medium.Size = new System.Drawing.Size(75, 19);
            this.p2_FormatBox_Medium.TabIndex = 3;
            this.p2_FormatBox_Medium.TabStop = true;
            this.p2_FormatBox_Medium.Text = "Moyenne";
            this.p2_FormatBox_Medium.UseVisualStyleBackColor = true;
            // 
            // p2_FormatBox_XLarge
            // 
            this.p2_FormatBox_XLarge.AutoSize = true;
            this.p2_FormatBox_XLarge.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_FormatBox_XLarge.Location = new System.Drawing.Point(7, 95);
            this.p2_FormatBox_XLarge.Name = "p2_FormatBox_XLarge";
            this.p2_FormatBox_XLarge.Size = new System.Drawing.Size(69, 19);
            this.p2_FormatBox_XLarge.TabIndex = 2;
            this.p2_FormatBox_XLarge.Text = "X-Large";
            this.p2_FormatBox_XLarge.UseVisualStyleBackColor = true;
            // 
            // p2_FormatBox_Large
            // 
            this.p2_FormatBox_Large.AutoSize = true;
            this.p2_FormatBox_Large.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_FormatBox_Large.Location = new System.Drawing.Point(7, 71);
            this.p2_FormatBox_Large.Name = "p2_FormatBox_Large";
            this.p2_FormatBox_Large.Size = new System.Drawing.Size(57, 19);
            this.p2_FormatBox_Large.TabIndex = 1;
            this.p2_FormatBox_Large.Text = "Large";
            this.p2_FormatBox_Large.UseVisualStyleBackColor = true;
            // 
            // p2_FormatBox_Small
            // 
            this.p2_FormatBox_Small.AutoSize = true;
            this.p2_FormatBox_Small.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_FormatBox_Small.Location = new System.Drawing.Point(6, 23);
            this.p2_FormatBox_Small.Name = "p2_FormatBox_Small";
            this.p2_FormatBox_Small.Size = new System.Drawing.Size(56, 19);
            this.p2_FormatBox_Small.TabIndex = 0;
            this.p2_FormatBox_Small.Text = "Petite";
            this.p2_FormatBox_Small.UseVisualStyleBackColor = true;
            // 
            // p2_Title
            // 
            this.p2_Title.AutoSize = true;
            this.p2_Title.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2_Title.Location = new System.Drawing.Point(18, 7);
            this.p2_Title.Name = "p2_Title";
            this.p2_Title.Size = new System.Drawing.Size(97, 23);
            this.p2_Title.TabIndex = 11;
            this.p2_Title.Text = "Commande";
            // 
            // p1_ErrorProvider
            // 
            this.p1_ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.p1_ErrorProvider.ContainerControl = this;
            this.p1_ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("p1_ErrorProvider.Icon")));
            // 
            // form1_PhoneLink
            // 
            this.form1_PhoneLink.AutoSize = true;
            this.form1_PhoneLink.BackColor = System.Drawing.Color.White;
            this.form1_PhoneLink.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1_PhoneLink.LinkColor = System.Drawing.Color.Black;
            this.form1_PhoneLink.Location = new System.Drawing.Point(714, 9);
            this.form1_PhoneLink.Name = "form1_PhoneLink";
            this.form1_PhoneLink.Size = new System.Drawing.Size(85, 15);
            this.form1_PhoneLink.TabIndex = 15;
            this.form1_PhoneLink.TabStop = true;
            this.form1_PhoneLink.Text = "666-420-0690";
            this.form1_PhoneLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // form1_WebLink
            // 
            this.form1_WebLink.AutoSize = true;
            this.form1_WebLink.BackColor = System.Drawing.Color.White;
            this.form1_WebLink.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form1_WebLink.LinkColor = System.Drawing.Color.Black;
            this.form1_WebLink.Location = new System.Drawing.Point(730, 33);
            this.form1_WebLink.Name = "form1_WebLink";
            this.form1_WebLink.Size = new System.Drawing.Size(69, 15);
            this.form1_WebLink.TabIndex = 16;
            this.form1_WebLink.TabStop = true;
            this.form1_WebLink.Text = "PizzaGo.ca";
            this.form1_WebLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pizza.Properties.Resources.PizzaBanner1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.form1_WebLink);
            this.Controls.Add(this.form1_PhoneLink);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza To Go";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.p1_GenderBox.ResumeLayout(false);
            this.p1_GenderBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.p2_LeaveBox.ResumeLayout(false);
            this.p2_AddonBox.ResumeLayout(false);
            this.p2_AddonBox.PerformLayout();
            this.p2_CrustBox.ResumeLayout(false);
            this.p2_CrustBox.PerformLayout();
            this.p2_FormatBox.ResumeLayout(false);
            this.p2_FormatBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p1_ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox p1_FirstNameInput;
        private System.Windows.Forms.Label p1_NameLbl;
        private System.Windows.Forms.TextBox p1_PhoneInput;
        private System.Windows.Forms.Label p1_PhoneLbl;
        private System.Windows.Forms.TextBox p1_AdressInput;
        private System.Windows.Forms.Label p1_FirstNameLbl;
        private System.Windows.Forms.TextBox p1_NameInput;
        private System.Windows.Forms.Label p1_AddressLbl;
        private System.Windows.Forms.GroupBox p1_GenderBox;
        private System.Windows.Forms.RadioButton p1_GenderBox_Other;
        private System.Windows.Forms.RadioButton p1_GenderBox_Female;
        private System.Windows.Forms.RadioButton p1_GenderBox_Male;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label p2_Title;
        private System.Windows.Forms.GroupBox p2_AddonBox;
        private System.Windows.Forms.GroupBox p2_CrustBox;
        private System.Windows.Forms.GroupBox p2_FormatBox;
        private System.Windows.Forms.RadioButton p2_FormatBox_Medium;
        private System.Windows.Forms.RadioButton p2_FormatBox_XLarge;
        private System.Windows.Forms.RadioButton p2_FormatBox_Large;
        private System.Windows.Forms.RadioButton p2_FormatBox_Small;
        private System.Windows.Forms.TextBox p2_SousTotal_Input;
        private System.Windows.Forms.TextBox p2_TPS_Input;
        private System.Windows.Forms.TextBox p2_Total_Input;
        private System.Windows.Forms.TextBox p2_TVQ_Input;
        private System.Windows.Forms.Label p2_TVQ_lbl;
        private System.Windows.Forms.Label p2_Total_lbl;
        private System.Windows.Forms.Label p2_TPS_lbl;
        private System.Windows.Forms.Label p2_SousTotal_lbl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox p2_AddonBox_OlivesBlack;
        private System.Windows.Forms.CheckBox p2_AddonBox_PimentHot;
        private System.Windows.Forms.CheckBox p2_AddonBox_Tomatoes;
        private System.Windows.Forms.CheckBox p2_AddonBox_Bacon;
        private System.Windows.Forms.CheckBox p2_AddonBox_Fromage;
        private System.Windows.Forms.CheckBox p2_AddonBox_Ananas;
        private System.Windows.Forms.CheckBox p2_AddonBox_FruitsMer;
        private System.Windows.Forms.CheckBox p2_AddonBox_Merguez;
        private System.Windows.Forms.CheckBox p2_AddonBox_Olives;
        private System.Windows.Forms.CheckBox p2_AddonBox_Champignons;
        private System.Windows.Forms.CheckBox p2_AddonBox_Piments;
        private System.Windows.Forms.CheckBox p2_AddonBox_Peperonis;
        private System.Windows.Forms.RadioButton p2_CrustBox_No;
        private System.Windows.Forms.RadioButton p2_CrustBox_Yes;
        private System.Windows.Forms.ErrorProvider p1_ErrorProvider;
        private System.Windows.Forms.GroupBox p2_LeaveBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel form1_PhoneLink;
        private System.Windows.Forms.LinkLabel form1_WebLink;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

