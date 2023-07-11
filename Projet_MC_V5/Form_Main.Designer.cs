namespace Projet_MC_V5
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (bool_com_etat == true)
            {
                // System.Diagnostics.Debug.WriteLine("");

                MC.UnRegisterSession();
                MC.ForwardClose();
                
                Timer_App.Stop();
            }

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panel_menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_lien = new System.Windows.Forms.Button();
            this.BP_disconnect = new System.Windows.Forms.Button();
            this.BP_connection = new System.Windows.Forms.Button();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabpage_Infos = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.label_code_error = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label_timeout = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.Min_temperature = new System.Windows.Forms.Label();
            this.Max_temperature = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Min_L_voltage = new System.Windows.Forms.Label();
            this.Max_L_voltage = new System.Windows.Forms.Label();
            this.Act_L_voltage = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Min_M_voltage = new System.Windows.Forms.Label();
            this.Act_temperature = new System.Windows.Forms.Label();
            this.Max_M_voltage = new System.Windows.Forms.Label();
            this.Act_M_voltage = new System.Windows.Forms.Label();
            this.label_production_date = new System.Windows.Forms.Label();
            this.label_serial_number = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_network_software = new System.Windows.Forms.Label();
            this.label_sys_software = new System.Windows.Forms.Label();
            this.label_app_software = new System.Windows.Forms.Label();
            this.label_hardware = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Bigendian = new System.Windows.Forms.Label();
            this.label_text_Bigendian = new System.Windows.Forms.Label();
            this.tabPage_Motors = new System.Windows.Forms.TabPage();
            this.aff_clockwise4 = new System.Windows.Forms.Label();
            this.aff_clockwise3 = new System.Windows.Forms.Label();
            this.aff_clockwise2 = new System.Windows.Forms.Label();
            this.aff_clockwise1 = new System.Windows.Forms.Label();
            this.button_clock_M4 = new System.Windows.Forms.Button();
            this.button_clock_M3 = new System.Windows.Forms.Button();
            this.button_clock_M2 = new System.Windows.Forms.Button();
            this.button_clock_M1 = new System.Windows.Forms.Button();
            this.comboBox_Motor4 = new System.Windows.Forms.ComboBox();
            this.comboBox_Motor3 = new System.Windows.Forms.ComboBox();
            this.comboBox_Motor2 = new System.Windows.Forms.ComboBox();
            this.comboBox_Motor1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Speed_motor_4 = new System.Windows.Forms.TrackBar();
            this.Speed_motor_3 = new System.Windows.Forms.TrackBar();
            this.Speed_motor_2 = new System.Windows.Forms.TrackBar();
            this.Speed_motor_1 = new System.Windows.Forms.TrackBar();
            this.tabPage_io = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_Sensor = new System.Windows.Forms.Label();
            this.richTextBox_IO = new System.Windows.Forms.RichTextBox();
            this.BP_textboxio_clear = new System.Windows.Forms.Button();
            this.button_test_IO_3_4 = new System.Windows.Forms.Button();
            this.button_test_IO_1_2 = new System.Windows.Forms.Button();
            this.tabPage_Datas = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_io4 = new System.Windows.Forms.ComboBox();
            this.comboBox_io3 = new System.Windows.Forms.ComboBox();
            this.comboBox_io2 = new System.Windows.Forms.ComboBox();
            this.comboBox_io1 = new System.Windows.Forms.ComboBox();
            this.richTextBox_octet = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_current = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_io = new System.Windows.Forms.Label();
            this.tabPage_Sauvegarde_carte = new System.Windows.Forms.TabPage();
            this.button_uploadbackup = new System.Windows.Forms.Button();
            this.richTextBox_save = new System.Windows.Forms.RichTextBox();
            this.button_save = new System.Windows.Forms.Button();
            this.tabPage_mode_manuel_transfert = new System.Windows.Forms.TabPage();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.Transfer_motor_4 = new System.Windows.Forms.TrackBar();
            this.Transfer_motor_3 = new System.Windows.Forms.TrackBar();
            this.Transfer_motor_2 = new System.Windows.Forms.TrackBar();
            this.BP_prog = new System.Windows.Forms.Button();
            this.BP_Initialisation = new System.Windows.Forms.Button();
            this.BP_Position = new System.Windows.Forms.Button();
            this.tabPage_mode_manuel_transfert_poseidon = new System.Windows.Forms.TabPage();
            this.BP_prog_P = new System.Windows.Forms.Button();
            this.BP_initialisation_P = new System.Windows.Forms.Button();
            this.BP_position_P = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.Transfer_P_motor_3 = new System.Windows.Forms.TrackBar();
            this.tabPage_mode_manuel_HPD = new System.Windows.Forms.TabPage();
            this.label32 = new System.Windows.Forms.Label();
            this.BP_InitialisationHPD = new System.Windows.Forms.Button();
            this.label_HPD_position_aff = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.HPD_motor_4 = new System.Windows.Forms.TrackBar();
            this.HPD_motor_3 = new System.Windows.Forms.TrackBar();
            this.HPD_motor_1 = new System.Windows.Forms.TrackBar();
            this.HPD_motor_2 = new System.Windows.Forms.TrackBar();
            this.label31 = new System.Windows.Forms.Label();
            this.tabPage_mode_manuel_HPD_poseidon = new System.Windows.Forms.TabPage();
            this.BP_Initialisation_HPD_P = new System.Windows.Forms.Button();
            this.label_HPD_P_position_aff = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.HPD_P_motor_4 = new System.Windows.Forms.TrackBar();
            this.HPD_P_motor_3 = new System.Windows.Forms.TrackBar();
            this.HPD_P_motor_1 = new System.Windows.Forms.TrackBar();
            this.HPD_P_motor_2 = new System.Windows.Forms.TrackBar();
            this.Transfer_P_motor_2 = new System.Windows.Forms.TrackBar();
            this.label28 = new System.Windows.Forms.Label();
            this.Transfer_P_motor_4 = new System.Windows.Forms.TrackBar();
            this.label36 = new System.Windows.Forms.Label();
            this.panel_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabControl_Main.SuspendLayout();
            this.tabpage_Infos.SuspendLayout();
            this.tabPage_Motors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_motor_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_motor_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_motor_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_motor_1)).BeginInit();
            this.tabPage_io.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage_Datas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage_Sauvegarde_carte.SuspendLayout();
            this.tabPage_mode_manuel_transfert.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transfer_motor_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transfer_motor_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transfer_motor_2)).BeginInit();
            this.tabPage_mode_manuel_transfert_poseidon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transfer_P_motor_3)).BeginInit();
            this.tabPage_mode_manuel_HPD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HPD_motor_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPD_motor_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPD_motor_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPD_motor_2)).BeginInit();
            this.tabPage_mode_manuel_HPD_poseidon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HPD_P_motor_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPD_P_motor_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPD_P_motor_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPD_P_motor_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transfer_P_motor_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transfer_P_motor_4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(0)))));
            this.panel_menu.Controls.Add(this.label1);
            this.panel_menu.Controls.Add(this.button_lien);
            this.panel_menu.Controls.Add(this.BP_disconnect);
            this.panel_menu.Controls.Add(this.BP_connection);
            this.panel_menu.Controls.Add(this.textBox_IP);
            this.panel_menu.Controls.Add(this.pictureBox2);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(250, 695);
            this.panel_menu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 28);
            this.label1.TabIndex = 50;
            this.label1.Text = "Time out connection";
            this.label1.Visible = false;
            // 
            // button_lien
            // 
            this.button_lien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_lien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_lien.Location = new System.Drawing.Point(21, 341);
            this.button_lien.Name = "button_lien";
            this.button_lien.Size = new System.Drawing.Size(214, 48);
            this.button_lien.TabIndex = 4;
            this.button_lien.Text = "Serveur Web";
            this.button_lien.UseVisualStyleBackColor = true;
            this.button_lien.Click += new System.EventHandler(this.button_lien_Click);
            // 
            // BP_disconnect
            // 
            this.BP_disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BP_disconnect.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BP_disconnect.Location = new System.Drawing.Point(21, 260);
            this.BP_disconnect.Name = "BP_disconnect";
            this.BP_disconnect.Size = new System.Drawing.Size(214, 48);
            this.BP_disconnect.TabIndex = 3;
            this.BP_disconnect.Text = "Disconnect";
            this.BP_disconnect.UseVisualStyleBackColor = true;
            this.BP_disconnect.Click += new System.EventHandler(this.BP_disconnect_Click);
            // 
            // BP_connection
            // 
            this.BP_connection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BP_connection.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BP_connection.Location = new System.Drawing.Point(21, 179);
            this.BP_connection.Name = "BP_connection";
            this.BP_connection.Size = new System.Drawing.Size(214, 48);
            this.BP_connection.TabIndex = 2;
            this.BP_connection.Text = "Connexion ";
            this.BP_connection.UseVisualStyleBackColor = true;
            this.BP_connection.Click += new System.EventHandler(this.BP_Connection_Click);
            // 
            // textBox_IP
            // 
            this.textBox_IP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_IP.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_IP.Location = new System.Drawing.Point(21, 119);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(214, 38);
            this.textBox_IP.TabIndex = 1;
            this.textBox_IP.Text = "172.16.132.72";
            this.textBox_IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabpage_Infos);
            this.tabControl_Main.Controls.Add(this.tabPage_Motors);
            this.tabControl_Main.Controls.Add(this.tabPage_io);
            this.tabControl_Main.Controls.Add(this.tabPage_Datas);
            this.tabControl_Main.Controls.Add(this.tabPage_Sauvegarde_carte);
            this.tabControl_Main.Controls.Add(this.tabPage_mode_manuel_transfert);
            this.tabControl_Main.Controls.Add(this.tabPage_mode_manuel_transfert_poseidon);
            this.tabControl_Main.Controls.Add(this.tabPage_mode_manuel_HPD);
            this.tabControl_Main.Controls.Add(this.tabPage_mode_manuel_HPD_poseidon);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(250, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1113, 695);
            this.tabControl_Main.TabIndex = 1;
            this.tabControl_Main.Visible = false;
            // 
            // tabpage_Infos
            // 
            this.tabpage_Infos.Controls.Add(this.label33);
            this.tabpage_Infos.Controls.Add(this.label_code_error);
            this.tabpage_Infos.Controls.Add(this.label27);
            this.tabpage_Infos.Controls.Add(this.label_timeout);
            this.tabpage_Infos.Controls.Add(this.label18);
            this.tabpage_Infos.Controls.Add(this.label23);
            this.tabpage_Infos.Controls.Add(this.label24);
            this.tabpage_Infos.Controls.Add(this.Min_temperature);
            this.tabpage_Infos.Controls.Add(this.Max_temperature);
            this.tabpage_Infos.Controls.Add(this.label20);
            this.tabpage_Infos.Controls.Add(this.label21);
            this.tabpage_Infos.Controls.Add(this.label22);
            this.tabpage_Infos.Controls.Add(this.Min_L_voltage);
            this.tabpage_Infos.Controls.Add(this.Max_L_voltage);
            this.tabpage_Infos.Controls.Add(this.Act_L_voltage);
            this.tabpage_Infos.Controls.Add(this.label16);
            this.tabpage_Infos.Controls.Add(this.label17);
            this.tabpage_Infos.Controls.Add(this.label19);
            this.tabpage_Infos.Controls.Add(this.Min_M_voltage);
            this.tabpage_Infos.Controls.Add(this.Act_temperature);
            this.tabpage_Infos.Controls.Add(this.Max_M_voltage);
            this.tabpage_Infos.Controls.Add(this.Act_M_voltage);
            this.tabpage_Infos.Controls.Add(this.label_production_date);
            this.tabpage_Infos.Controls.Add(this.label_serial_number);
            this.tabpage_Infos.Controls.Add(this.label6);
            this.tabpage_Infos.Controls.Add(this.label5);
            this.tabpage_Infos.Controls.Add(this.label_network_software);
            this.tabpage_Infos.Controls.Add(this.label_sys_software);
            this.tabpage_Infos.Controls.Add(this.label_app_software);
            this.tabpage_Infos.Controls.Add(this.label_hardware);
            this.tabpage_Infos.Controls.Add(this.label4);
            this.tabpage_Infos.Controls.Add(this.label3);
            this.tabpage_Infos.Controls.Add(this.label2);
            this.tabpage_Infos.Controls.Add(this.label7);
            this.tabpage_Infos.Controls.Add(this.label_Bigendian);
            this.tabpage_Infos.Controls.Add(this.label_text_Bigendian);
            this.tabpage_Infos.Location = new System.Drawing.Point(4, 29);
            this.tabpage_Infos.Name = "tabpage_Infos";
            this.tabpage_Infos.Padding = new System.Windows.Forms.Padding(3);
            this.tabpage_Infos.Size = new System.Drawing.Size(1105, 662);
            this.tabpage_Infos.TabIndex = 0;
            this.tabpage_Infos.Text = "Infos";
            this.tabpage_Infos.UseVisualStyleBackColor = true;
            this.tabpage_Infos.Click += new System.EventHandler(this.tabpage_Infos_Click);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(6, 637);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(160, 20);
            this.label33.TabIndex = 52;
            this.label33.Text = "Cliquez pour actualiser";
            // 
            // label_code_error
            // 
            this.label_code_error.AutoSize = true;
            this.label_code_error.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_code_error.Location = new System.Drawing.Point(598, 586);
            this.label_code_error.Name = "label_code_error";
            this.label_code_error.Size = new System.Drawing.Size(22, 25);
            this.label_code_error.TabIndex = 51;
            this.label_code_error.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(432, 586);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(160, 25);
            this.label27.TabIndex = 50;
            this.label27.Text = "Code erreur actuel:";
            // 
            // label_timeout
            // 
            this.label_timeout.AutoSize = true;
            this.label_timeout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_timeout.Location = new System.Drawing.Point(147, 49);
            this.label_timeout.Name = "label_timeout";
            this.label_timeout.Size = new System.Drawing.Size(200, 28);
            this.label_timeout.TabIndex = 49;
            this.label_timeout.Text = "00/00/0000  00:00:00";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(147, 515);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 25);
            this.label18.TabIndex = 47;
            this.label18.Text = "Min. temperature:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(147, 467);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(155, 25);
            this.label23.TabIndex = 46;
            this.label23.Text = "Max. temperature:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(147, 419);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(148, 25);
            this.label24.TabIndex = 45;
            this.label24.Text = "Act. temperature:";
            // 
            // Min_temperature
            // 
            this.Min_temperature.AutoSize = true;
            this.Min_temperature.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Min_temperature.Location = new System.Drawing.Point(319, 515);
            this.Min_temperature.Name = "Min_temperature";
            this.Min_temperature.Size = new System.Drawing.Size(181, 25);
            this.Min_temperature.TabIndex = 44;
            this.Min_temperature.Text = "Min. temperature [°C]";
            // 
            // Max_temperature
            // 
            this.Max_temperature.AutoSize = true;
            this.Max_temperature.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Max_temperature.Location = new System.Drawing.Point(319, 467);
            this.Max_temperature.Name = "Max_temperature";
            this.Max_temperature.Size = new System.Drawing.Size(184, 25);
            this.Max_temperature.TabIndex = 43;
            this.Max_temperature.Text = "Max. temperature [°C]";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(147, 371);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(157, 25);
            this.label20.TabIndex = 42;
            this.label20.Text = "Min. logic voltage:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(147, 323);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(160, 25);
            this.label21.TabIndex = 41;
            this.label21.Text = "Max. logic voltage:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(147, 275);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(153, 25);
            this.label22.TabIndex = 40;
            this.label22.Text = "Act. logic voltage:";
            // 
            // Min_L_voltage
            // 
            this.Min_L_voltage.AutoSize = true;
            this.Min_L_voltage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Min_L_voltage.Location = new System.Drawing.Point(319, 371);
            this.Min_L_voltage.Name = "Min_L_voltage";
            this.Min_L_voltage.Size = new System.Drawing.Size(195, 25);
            this.Min_L_voltage.TabIndex = 39;
            this.Min_L_voltage.Text = "Min. logic voltage [mV]";
            // 
            // Max_L_voltage
            // 
            this.Max_L_voltage.AutoSize = true;
            this.Max_L_voltage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Max_L_voltage.Location = new System.Drawing.Point(319, 323);
            this.Max_L_voltage.Name = "Max_L_voltage";
            this.Max_L_voltage.Size = new System.Drawing.Size(198, 25);
            this.Max_L_voltage.TabIndex = 38;
            this.Max_L_voltage.Text = "Max. logic voltage [mV]";
            // 
            // Act_L_voltage
            // 
            this.Act_L_voltage.AutoSize = true;
            this.Act_L_voltage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Act_L_voltage.Location = new System.Drawing.Point(319, 275);
            this.Act_L_voltage.Name = "Act_L_voltage";
            this.Act_L_voltage.Size = new System.Drawing.Size(191, 25);
            this.Act_L_voltage.TabIndex = 37;
            this.Act_L_voltage.Text = "Act. logic voltage [mV]\r\n";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(147, 227);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(169, 25);
            this.label16.TabIndex = 36;
            this.label16.Text = "Min. motor voltage:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(147, 179);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(172, 25);
            this.label17.TabIndex = 35;
            this.label17.Text = "Max. motor voltage:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(147, 131);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(165, 25);
            this.label19.TabIndex = 34;
            this.label19.Text = "Act. motor voltage:";
            // 
            // Min_M_voltage
            // 
            this.Min_M_voltage.AutoSize = true;
            this.Min_M_voltage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Min_M_voltage.Location = new System.Drawing.Point(319, 227);
            this.Min_M_voltage.Name = "Min_M_voltage";
            this.Min_M_voltage.Size = new System.Drawing.Size(207, 25);
            this.Min_M_voltage.TabIndex = 33;
            this.Min_M_voltage.Text = "Min. motor voltage [mV]";
            // 
            // Act_temperature
            // 
            this.Act_temperature.AutoSize = true;
            this.Act_temperature.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Act_temperature.Location = new System.Drawing.Point(319, 419);
            this.Act_temperature.Name = "Act_temperature";
            this.Act_temperature.Size = new System.Drawing.Size(177, 25);
            this.Act_temperature.TabIndex = 32;
            this.Act_temperature.Text = "Act. temperature [°C]";
            // 
            // Max_M_voltage
            // 
            this.Max_M_voltage.AutoSize = true;
            this.Max_M_voltage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Max_M_voltage.Location = new System.Drawing.Point(319, 179);
            this.Max_M_voltage.Name = "Max_M_voltage";
            this.Max_M_voltage.Size = new System.Drawing.Size(210, 25);
            this.Max_M_voltage.TabIndex = 31;
            this.Max_M_voltage.Text = "Max. motor voltage [mV]";
            // 
            // Act_M_voltage
            // 
            this.Act_M_voltage.AutoSize = true;
            this.Act_M_voltage.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Act_M_voltage.Location = new System.Drawing.Point(319, 131);
            this.Act_M_voltage.Name = "Act_M_voltage";
            this.Act_M_voltage.Size = new System.Drawing.Size(203, 25);
            this.Act_M_voltage.TabIndex = 30;
            this.Act_M_voltage.Text = "Act. motor voltage [mV]";
            // 
            // label_production_date
            // 
            this.label_production_date.AutoSize = true;
            this.label_production_date.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_production_date.Location = new System.Drawing.Point(898, 515);
            this.label_production_date.Name = "label_production_date";
            this.label_production_date.Size = new System.Drawing.Size(32, 25);
            this.label_production_date.TabIndex = 27;
            this.label_production_date.Text = "00";
            // 
            // label_serial_number
            // 
            this.label_serial_number.AutoSize = true;
            this.label_serial_number.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_serial_number.Location = new System.Drawing.Point(898, 451);
            this.label_serial_number.Name = "label_serial_number";
            this.label_serial_number.Size = new System.Drawing.Size(32, 25);
            this.label_serial_number.TabIndex = 26;
            this.label_serial_number.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(666, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Production date : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(666, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Serial number : ";
            // 
            // label_network_software
            // 
            this.label_network_software.AutoSize = true;
            this.label_network_software.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_network_software.Location = new System.Drawing.Point(898, 387);
            this.label_network_software.Name = "label_network_software";
            this.label_network_software.Size = new System.Drawing.Size(32, 25);
            this.label_network_software.TabIndex = 23;
            this.label_network_software.Text = "00";
            // 
            // label_sys_software
            // 
            this.label_sys_software.AutoSize = true;
            this.label_sys_software.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_sys_software.Location = new System.Drawing.Point(898, 323);
            this.label_sys_software.Name = "label_sys_software";
            this.label_sys_software.Size = new System.Drawing.Size(32, 25);
            this.label_sys_software.TabIndex = 22;
            this.label_sys_software.Text = "00";
            // 
            // label_app_software
            // 
            this.label_app_software.AutoSize = true;
            this.label_app_software.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_app_software.Location = new System.Drawing.Point(898, 259);
            this.label_app_software.Name = "label_app_software";
            this.label_app_software.Size = new System.Drawing.Size(32, 25);
            this.label_app_software.TabIndex = 21;
            this.label_app_software.Text = "00";
            // 
            // label_hardware
            // 
            this.label_hardware.AutoSize = true;
            this.label_hardware.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_hardware.Location = new System.Drawing.Point(898, 195);
            this.label_hardware.Name = "label_hardware";
            this.label_hardware.Size = new System.Drawing.Size(32, 25);
            this.label_hardware.TabIndex = 20;
            this.label_hardware.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(666, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Network software : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(666, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "System software : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(666, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Application software : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(666, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hardware : ";
            // 
            // label_Bigendian
            // 
            this.label_Bigendian.AutoSize = true;
            this.label_Bigendian.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Bigendian.Location = new System.Drawing.Point(898, 131);
            this.label_Bigendian.Name = "label_Bigendian";
            this.label_Bigendian.Size = new System.Drawing.Size(32, 25);
            this.label_Bigendian.TabIndex = 15;
            this.label_Bigendian.Text = "00";
            // 
            // label_text_Bigendian
            // 
            this.label_text_Bigendian.AutoSize = true;
            this.label_text_Bigendian.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_text_Bigendian.Location = new System.Drawing.Point(666, 131);
            this.label_text_Bigendian.Name = "label_text_Bigendian";
            this.label_text_Bigendian.Size = new System.Drawing.Size(170, 25);
            this.label_text_Bigendian.TabIndex = 14;
            this.label_text_Bigendian.Text = "Big-endian format : ";
            // 
            // tabPage_Motors
            // 
            this.tabPage_Motors.Controls.Add(this.aff_clockwise4);
            this.tabPage_Motors.Controls.Add(this.aff_clockwise3);
            this.tabPage_Motors.Controls.Add(this.aff_clockwise2);
            this.tabPage_Motors.Controls.Add(this.aff_clockwise1);
            this.tabPage_Motors.Controls.Add(this.button_clock_M4);
            this.tabPage_Motors.Controls.Add(this.button_clock_M3);
            this.tabPage_Motors.Controls.Add(this.button_clock_M2);
            this.tabPage_Motors.Controls.Add(this.button_clock_M1);
            this.tabPage_Motors.Controls.Add(this.comboBox_Motor4);
            this.tabPage_Motors.Controls.Add(this.comboBox_Motor3);
            this.tabPage_Motors.Controls.Add(this.comboBox_Motor2);
            this.tabPage_Motors.Controls.Add(this.comboBox_Motor1);
            this.tabPage_Motors.Controls.Add(this.label9);
            this.tabPage_Motors.Controls.Add(this.label10);
            this.tabPage_Motors.Controls.Add(this.label11);
            this.tabPage_Motors.Controls.Add(this.label12);
            this.tabPage_Motors.Controls.Add(this.Speed_motor_4);
            this.tabPage_Motors.Controls.Add(this.Speed_motor_3);
            this.tabPage_Motors.Controls.Add(this.Speed_motor_2);
            this.tabPage_Motors.Controls.Add(this.Speed_motor_1);
            this.tabPage_Motors.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Motors.Name = "tabPage_Motors";
            this.tabPage_Motors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Motors.Size = new System.Drawing.Size(1105, 662);
            this.tabPage_Motors.TabIndex = 2;
            this.tabPage_Motors.Text = "Motors";
            this.tabPage_Motors.UseVisualStyleBackColor = true;
            // 
            // aff_clockwise4
            // 
            this.aff_clockwise4.AutoSize = true;
            this.aff_clockwise4.Location = new System.Drawing.Point(922, 527);
            this.aff_clockwise4.Name = "aff_clockwise4";
            this.aff_clockwise4.Size = new System.Drawing.Size(42, 20);
            this.aff_clockwise4.TabIndex = 31;
            this.aff_clockwise4.Text = "label";
            // 
            // aff_clockwise3
            // 
            this.aff_clockwise3.AutoSize = true;
            this.aff_clockwise3.Location = new System.Drawing.Point(922, 384);
            this.aff_clockwise3.Name = "aff_clockwise3";
            this.aff_clockwise3.Size = new System.Drawing.Size(42, 20);
            this.aff_clockwise3.TabIndex = 30;
            this.aff_clockwise3.Text = "label";
            // 
            // aff_clockwise2
            // 
            this.aff_clockwise2.AutoSize = true;
            this.aff_clockwise2.Location = new System.Drawing.Point(922, 232);
            this.aff_clockwise2.Name = "aff_clockwise2";
            this.aff_clockwise2.Size = new System.Drawing.Size(42, 20);
            this.aff_clockwise2.TabIndex = 29;
            this.aff_clockwise2.Text = "label";
            // 
            // aff_clockwise1
            // 
            this.aff_clockwise1.AutoSize = true;
            this.aff_clockwise1.Location = new System.Drawing.Point(922, 94);
            this.aff_clockwise1.Name = "aff_clockwise1";
            this.aff_clockwise1.Size = new System.Drawing.Size(42, 20);
            this.aff_clockwise1.TabIndex = 28;
            this.aff_clockwise1.Text = "label";
            // 
            // button_clock_M4
            // 
            this.button_clock_M4.Location = new System.Drawing.Point(777, 509);
            this.button_clock_M4.Name = "button_clock_M4";
            this.button_clock_M4.Size = new System.Drawing.Size(122, 56);
            this.button_clock_M4.TabIndex = 27;
            this.button_clock_M4.Text = "Motor 4 Rotation sense ";
            this.button_clock_M4.UseVisualStyleBackColor = true;
            this.button_clock_M4.Click += new System.EventHandler(this.button_clock_M4_Click);
            // 
            // button_clock_M3
            // 
            this.button_clock_M3.Location = new System.Drawing.Point(777, 366);
            this.button_clock_M3.Name = "button_clock_M3";
            this.button_clock_M3.Size = new System.Drawing.Size(122, 56);
            this.button_clock_M3.TabIndex = 26;
            this.button_clock_M3.Text = "Motor 3 Rotation sense ";
            this.button_clock_M3.UseVisualStyleBackColor = true;
            this.button_clock_M3.Click += new System.EventHandler(this.button_clock_M3_Click);
            // 
            // button_clock_M2
            // 
            this.button_clock_M2.Location = new System.Drawing.Point(777, 214);
            this.button_clock_M2.Name = "button_clock_M2";
            this.button_clock_M2.Size = new System.Drawing.Size(122, 56);
            this.button_clock_M2.TabIndex = 25;
            this.button_clock_M2.Text = "Motor 2 Rotation sense ";
            this.button_clock_M2.UseVisualStyleBackColor = true;
            this.button_clock_M2.Click += new System.EventHandler(this.button_clock_M2_Click);
            // 
            // button_clock_M1
            // 
            this.button_clock_M1.Location = new System.Drawing.Point(777, 76);
            this.button_clock_M1.Name = "button_clock_M1";
            this.button_clock_M1.Size = new System.Drawing.Size(122, 56);
            this.button_clock_M1.TabIndex = 24;
            this.button_clock_M1.Text = "Motor 1 Rotation sense ";
            this.button_clock_M1.UseVisualStyleBackColor = true;
            this.button_clock_M1.Click += new System.EventHandler(this.button_clock_M1_Click);
            // 
            // comboBox_Motor4
            // 
            this.comboBox_Motor4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Motor4.FormattingEnabled = true;
            this.comboBox_Motor4.Location = new System.Drawing.Point(161, 537);
            this.comboBox_Motor4.Name = "comboBox_Motor4";
            this.comboBox_Motor4.Size = new System.Drawing.Size(193, 28);
            this.comboBox_Motor4.TabIndex = 23;
            this.comboBox_Motor4.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Motor4_SelectionChangeCommitted);
            // 
            // comboBox_Motor3
            // 
            this.comboBox_Motor3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Motor3.FormattingEnabled = true;
            this.comboBox_Motor3.Location = new System.Drawing.Point(161, 394);
            this.comboBox_Motor3.Name = "comboBox_Motor3";
            this.comboBox_Motor3.Size = new System.Drawing.Size(193, 28);
            this.comboBox_Motor3.TabIndex = 22;
            this.comboBox_Motor3.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Motor3_SelectionChangeCommitted);
            // 
            // comboBox_Motor2
            // 
            this.comboBox_Motor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Motor2.FormattingEnabled = true;
            this.comboBox_Motor2.Location = new System.Drawing.Point(161, 242);
            this.comboBox_Motor2.Name = "comboBox_Motor2";
            this.comboBox_Motor2.Size = new System.Drawing.Size(193, 28);
            this.comboBox_Motor2.TabIndex = 21;
            this.comboBox_Motor2.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Motor2_SelectionChangeCommitted);
            // 
            // comboBox_Motor1
            // 
            this.comboBox_Motor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Motor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Motor1.FormattingEnabled = true;
            this.comboBox_Motor1.Location = new System.Drawing.Point(161, 104);
            this.comboBox_Motor1.Name = "comboBox_Motor1";
            this.comboBox_Motor1.Size = new System.Drawing.Size(199, 28);
            this.comboBox_Motor1.TabIndex = 20;
            this.comboBox_Motor1.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Motor1_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(201, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 32);
            this.label9.TabIndex = 19;
            this.label9.Text = "Moteur 4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(201, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 32);
            this.label10.TabIndex = 18;
            this.label10.Text = "Moteur 3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(201, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 32);
            this.label11.TabIndex = 17;
            this.label11.Text = "Moteur 2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(197, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 32);
            this.label12.TabIndex = 16;
            this.label12.Text = "Moteur 1 ";
            // 
            // Speed_motor_4
            // 
            this.Speed_motor_4.Location = new System.Drawing.Point(422, 509);
            this.Speed_motor_4.Maximum = 100;
            this.Speed_motor_4.Name = "Speed_motor_4";
            this.Speed_motor_4.Size = new System.Drawing.Size(319, 56);
            this.Speed_motor_4.TabIndex = 15;
            this.Speed_motor_4.TickFrequency = 10;
            // 
            // Speed_motor_3
            // 
            this.Speed_motor_3.Location = new System.Drawing.Point(422, 366);
            this.Speed_motor_3.Maximum = 100;
            this.Speed_motor_3.Name = "Speed_motor_3";
            this.Speed_motor_3.Size = new System.Drawing.Size(319, 56);
            this.Speed_motor_3.TabIndex = 14;
            this.Speed_motor_3.TickFrequency = 10;
            // 
            // Speed_motor_2
            // 
            this.Speed_motor_2.Location = new System.Drawing.Point(422, 214);
            this.Speed_motor_2.Maximum = 100;
            this.Speed_motor_2.Name = "Speed_motor_2";
            this.Speed_motor_2.Size = new System.Drawing.Size(319, 56);
            this.Speed_motor_2.TabIndex = 13;
            this.Speed_motor_2.TickFrequency = 10;
            // 
            // Speed_motor_1
            // 
            this.Speed_motor_1.Location = new System.Drawing.Point(422, 76);
            this.Speed_motor_1.Maximum = 100;
            this.Speed_motor_1.Name = "Speed_motor_1";
            this.Speed_motor_1.Size = new System.Drawing.Size(319, 56);
            this.Speed_motor_1.TabIndex = 12;
            this.Speed_motor_1.Tag = "";
            this.Speed_motor_1.TickFrequency = 10;
            // 
            // tabPage_io
            // 
            this.tabPage_io.Controls.Add(this.pictureBox1);
            this.tabPage_io.Controls.Add(this.groupBox3);
            this.tabPage_io.Controls.Add(this.richTextBox_IO);
            this.tabPage_io.Controls.Add(this.BP_textboxio_clear);
            this.tabPage_io.Controls.Add(this.button_test_IO_3_4);
            this.tabPage_io.Controls.Add(this.button_test_IO_1_2);
            this.tabPage_io.Location = new System.Drawing.Point(4, 29);
            this.tabPage_io.Name = "tabPage_io";
            this.tabPage_io.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_io.Size = new System.Drawing.Size(1105, 662);
            this.tabPage_io.TabIndex = 3;
            this.tabPage_io.Text = "I/O";
            this.tabPage_io.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(316, 531);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 107);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label_Sensor);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(187, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 176);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sensor";
            // 
            // label_Sensor
            // 
            this.label_Sensor.AutoSize = true;
            this.label_Sensor.Location = new System.Drawing.Point(6, 45);
            this.label_Sensor.Name = "label_Sensor";
            this.label_Sensor.Size = new System.Drawing.Size(105, 124);
            this.label_Sensor.TabIndex = 18;
            this.label_Sensor.Text = "Sensor 1:\r\nSensor 2:\r\nSensor 3:\r\nSensor 4:";
            // 
            // richTextBox_IO
            // 
            this.richTextBox_IO.Location = new System.Drawing.Point(569, 122);
            this.richTextBox_IO.Name = "richTextBox_IO";
            this.richTextBox_IO.ReadOnly = true;
            this.richTextBox_IO.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_IO.Size = new System.Drawing.Size(340, 302);
            this.richTextBox_IO.TabIndex = 33;
            this.richTextBox_IO.Text = "";
            // 
            // BP_textboxio_clear
            // 
            this.BP_textboxio_clear.Location = new System.Drawing.Point(569, 88);
            this.BP_textboxio_clear.Name = "BP_textboxio_clear";
            this.BP_textboxio_clear.Size = new System.Drawing.Size(340, 28);
            this.BP_textboxio_clear.TabIndex = 32;
            this.BP_textboxio_clear.Text = "Clear";
            this.BP_textboxio_clear.UseVisualStyleBackColor = true;
            this.BP_textboxio_clear.Click += new System.EventHandler(this.BP_textboxio_clear_Click);
            // 
            // button_test_IO_3_4
            // 
            this.button_test_IO_3_4.Location = new System.Drawing.Point(753, 443);
            this.button_test_IO_3_4.Name = "button_test_IO_3_4";
            this.button_test_IO_3_4.Size = new System.Drawing.Size(156, 48);
            this.button_test_IO_3_4.TabIndex = 30;
            this.button_test_IO_3_4.Text = "Test\r\nIO 3/4";
            this.button_test_IO_3_4.UseVisualStyleBackColor = true;
            this.button_test_IO_3_4.Click += new System.EventHandler(this.button_test_IO_3_4_Click);
            // 
            // button_test_IO_1_2
            // 
            this.button_test_IO_1_2.Location = new System.Drawing.Point(569, 443);
            this.button_test_IO_1_2.Name = "button_test_IO_1_2";
            this.button_test_IO_1_2.Size = new System.Drawing.Size(156, 48);
            this.button_test_IO_1_2.TabIndex = 29;
            this.button_test_IO_1_2.Text = "Test\r\nIO 1/2";
            this.button_test_IO_1_2.UseVisualStyleBackColor = true;
            this.button_test_IO_1_2.Click += new System.EventHandler(this.button_test_IO_1_2_Click);
            // 
            // tabPage_Datas
            // 
            this.tabPage_Datas.Controls.Add(this.label15);
            this.tabPage_Datas.Controls.Add(this.label14);
            this.tabPage_Datas.Controls.Add(this.label13);
            this.tabPage_Datas.Controls.Add(this.label8);
            this.tabPage_Datas.Controls.Add(this.comboBox_io4);
            this.tabPage_Datas.Controls.Add(this.comboBox_io3);
            this.tabPage_Datas.Controls.Add(this.comboBox_io2);
            this.tabPage_Datas.Controls.Add(this.comboBox_io1);
            this.tabPage_Datas.Controls.Add(this.richTextBox_octet);
            this.tabPage_Datas.Controls.Add(this.groupBox2);
            this.tabPage_Datas.Controls.Add(this.groupBox1);
            this.tabPage_Datas.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Datas.Name = "tabPage_Datas";
            this.tabPage_Datas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Datas.Size = new System.Drawing.Size(1105, 662);
            this.tabPage_Datas.TabIndex = 4;
            this.tabPage_Datas.Text = "Datas";
            this.tabPage_Datas.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(75, 507);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 20);
            this.label15.TabIndex = 45;
            this.label15.Text = "I/O 3:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(75, 570);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 20);
            this.label14.TabIndex = 44;
            this.label14.Text = "I/O 4:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 444);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 20);
            this.label13.TabIndex = 43;
            this.label13.Text = "I/O 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "I/O 1:";
            // 
            // comboBox_io4
            // 
            this.comboBox_io4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_io4.FormattingEnabled = true;
            this.comboBox_io4.Location = new System.Drawing.Point(162, 567);
            this.comboBox_io4.Name = "comboBox_io4";
            this.comboBox_io4.Size = new System.Drawing.Size(253, 28);
            this.comboBox_io4.TabIndex = 41;
            this.comboBox_io4.SelectionChangeCommitted += new System.EventHandler(this.comboBox_io4_SelectionChangeCommitted);
            // 
            // comboBox_io3
            // 
            this.comboBox_io3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_io3.FormattingEnabled = true;
            this.comboBox_io3.Location = new System.Drawing.Point(162, 504);
            this.comboBox_io3.Name = "comboBox_io3";
            this.comboBox_io3.Size = new System.Drawing.Size(253, 28);
            this.comboBox_io3.TabIndex = 40;
            this.comboBox_io3.SelectionChangeCommitted += new System.EventHandler(this.comboBox_io3_SelectionChangeCommitted);
            // 
            // comboBox_io2
            // 
            this.comboBox_io2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_io2.FormattingEnabled = true;
            this.comboBox_io2.Location = new System.Drawing.Point(162, 441);
            this.comboBox_io2.Name = "comboBox_io2";
            this.comboBox_io2.Size = new System.Drawing.Size(253, 28);
            this.comboBox_io2.TabIndex = 39;
            this.comboBox_io2.SelectionChangeCommitted += new System.EventHandler(this.comboBox_io2_SelectionChangeCommitted);
            // 
            // comboBox_io1
            // 
            this.comboBox_io1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_io1.FormattingEnabled = true;
            this.comboBox_io1.Location = new System.Drawing.Point(162, 378);
            this.comboBox_io1.Name = "comboBox_io1";
            this.comboBox_io1.Size = new System.Drawing.Size(253, 28);
            this.comboBox_io1.TabIndex = 38;
            this.comboBox_io1.SelectionChangeCommitted += new System.EventHandler(this.comboBox_io1_SelectionChangeCommitted);
            // 
            // richTextBox_octet
            // 
            this.richTextBox_octet.Location = new System.Drawing.Point(822, 33);
            this.richTextBox_octet.Name = "richTextBox_octet";
            this.richTextBox_octet.ReadOnly = true;
            this.richTextBox_octet.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_octet.Size = new System.Drawing.Size(179, 562);
            this.richTextBox_octet.TabIndex = 37;
            this.richTextBox_octet.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_current);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(197, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(183, 158);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current (mA)";
            // 
            // label_current
            // 
            this.label_current.AutoSize = true;
            this.label_current.Location = new System.Drawing.Point(6, 40);
            this.label_current.Name = "label_current";
            this.label_current.Size = new System.Drawing.Size(92, 100);
            this.label_current.TabIndex = 0;
            this.label_current.Text = "current 1:\r\ncurrent 2:\r\ncurrent 3:\r\ncurrent 4:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label_io);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(526, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 158);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input / Output";
            // 
            // label_io
            // 
            this.label_io.AutoSize = true;
            this.label_io.Location = new System.Drawing.Point(6, 45);
            this.label_io.Name = "label_io";
            this.label_io.Size = new System.Drawing.Size(57, 100);
            this.label_io.TabIndex = 0;
            this.label_io.Text = "I/O 1:\r\nI/O 2:\r\nI/O 3:\r\nI/O 4:";
            // 
            // tabPage_Sauvegarde_carte
            // 
            this.tabPage_Sauvegarde_carte.Controls.Add(this.button_uploadbackup);
            this.tabPage_Sauvegarde_carte.Controls.Add(this.richTextBox_save);
            this.tabPage_Sauvegarde_carte.Controls.Add(this.button_save);
            this.tabPage_Sauvegarde_carte.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Sauvegarde_carte.Name = "tabPage_Sauvegarde_carte";
            this.tabPage_Sauvegarde_carte.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Sauvegarde_carte.Size = new System.Drawing.Size(1105, 662);
            this.tabPage_Sauvegarde_carte.TabIndex = 5;
            this.tabPage_Sauvegarde_carte.Text = "Sauvegarde carte ";
            this.tabPage_Sauvegarde_carte.UseVisualStyleBackColor = true;
            // 
            // button_uploadbackup
            // 
            this.button_uploadbackup.Location = new System.Drawing.Point(465, 454);
            this.button_uploadbackup.Name = "button_uploadbackup";
            this.button_uploadbackup.Size = new System.Drawing.Size(182, 50);
            this.button_uploadbackup.TabIndex = 39;
            this.button_uploadbackup.Text = "Charger la sauvegarde";
            this.button_uploadbackup.UseVisualStyleBackColor = true;
            this.button_uploadbackup.Click += new System.EventHandler(this.button_uploadbackup_Click);
            // 
            // richTextBox_save
            // 
            this.richTextBox_save.Location = new System.Drawing.Point(308, 272);
            this.richTextBox_save.Name = "richTextBox_save";
            this.richTextBox_save.ReadOnly = true;
            this.richTextBox_save.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox_save.Size = new System.Drawing.Size(496, 176);
            this.richTextBox_save.TabIndex = 38;
            this.richTextBox_save.Text = "";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(465, 218);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(182, 48);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Sauvegarde carte";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // tabPage_mode_manuel_transfert
            // 
            this.tabPage_mode_manuel_transfert.Controls.Add(this.label38);
            this.tabPage_mode_manuel_transfert.Controls.Add(this.label39);
            this.tabPage_mode_manuel_transfert.Controls.Add(this.label40);
            this.tabPage_mode_manuel_transfert.Controls.Add(this.Transfer_motor_4);
            this.tabPage_mode_manuel_transfert.Controls.Add(this.Transfer_motor_3);
            this.tabPage_mode_manuel_transfert.Controls.Add(this.Transfer_motor_2);
            this.tabPage_mode_manuel_transfert.Controls.Add(this.BP_prog);
            this.tabPage_mode_manuel_transfert.Controls.Add(this.BP_Initialisation);
            this.tabPage_mode_manuel_transfert.Controls.Add(this.BP_Position);
            this.tabPage_mode_manuel_transfert.Location = new System.Drawing.Point(4, 29);
            this.tabPage_mode_manuel_transfert.Name = "tabPage_mode_manuel_transfert";
            this.tabPage_mode_manuel_transfert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_mode_manuel_transfert.Size = new System.Drawing.Size(1105, 662);
            this.tabPage_mode_manuel_transfert.TabIndex = 6;
            this.tabPage_mode_manuel_transfert.Text = "Mode manuel Transfer";
            this.tabPage_mode_manuel_transfert.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label38.Location = new System.Drawing.Point(355, 160);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(195, 32);
            this.label38.TabIndex = 51;
            this.label38.Text = "Moteur courroie ";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label39.Location = new System.Drawing.Point(400, 440);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(113, 32);
            this.label39.TabIndex = 50;
            this.label39.Text = "Moteur 4";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label40.Location = new System.Drawing.Point(400, 300);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(113, 32);
            this.label40.TabIndex = 49;
            this.label40.Text = "Moteur 3";
            // 
            // Transfer_motor_4
            // 
            this.Transfer_motor_4.Location = new System.Drawing.Point(570, 440);
            this.Transfer_motor_4.Maximum = 100;
            this.Transfer_motor_4.Name = "Transfer_motor_4";
            this.Transfer_motor_4.Size = new System.Drawing.Size(319, 56);
            this.Transfer_motor_4.TabIndex = 48;
            this.Transfer_motor_4.TickFrequency = 10;
            // 
            // Transfer_motor_3
            // 
            this.Transfer_motor_3.Location = new System.Drawing.Point(570, 300);
            this.Transfer_motor_3.Maximum = 100;
            this.Transfer_motor_3.Name = "Transfer_motor_3";
            this.Transfer_motor_3.Size = new System.Drawing.Size(319, 56);
            this.Transfer_motor_3.TabIndex = 47;
            this.Transfer_motor_3.TickFrequency = 10;
            // 
            // Transfer_motor_2
            // 
            this.Transfer_motor_2.Location = new System.Drawing.Point(570, 160);
            this.Transfer_motor_2.Maximum = 100;
            this.Transfer_motor_2.Name = "Transfer_motor_2";
            this.Transfer_motor_2.Size = new System.Drawing.Size(319, 56);
            this.Transfer_motor_2.TabIndex = 46;
            this.Transfer_motor_2.Tag = "";
            this.Transfer_motor_2.TickFrequency = 10;
            // 
            // BP_prog
            // 
            this.BP_prog.Location = new System.Drawing.Point(92, 431);
            this.BP_prog.Name = "BP_prog";
            this.BP_prog.Size = new System.Drawing.Size(177, 56);
            this.BP_prog.TabIndex = 40;
            this.BP_prog.Text = "Cycle de fonctionnement ";
            this.BP_prog.UseVisualStyleBackColor = true;
            this.BP_prog.Click += new System.EventHandler(this.BP_prog_Click);
            // 
            // BP_Initialisation
            // 
            this.BP_Initialisation.Location = new System.Drawing.Point(92, 291);
            this.BP_Initialisation.Name = "BP_Initialisation";
            this.BP_Initialisation.Size = new System.Drawing.Size(177, 56);
            this.BP_Initialisation.TabIndex = 39;
            this.BP_Initialisation.Text = "Initialisation\r\nTransfer";
            this.BP_Initialisation.UseVisualStyleBackColor = true;
            this.BP_Initialisation.Click += new System.EventHandler(this.BP_Initialisation_Click);
            // 
            // BP_Position
            // 
            this.BP_Position.Location = new System.Drawing.Point(92, 151);
            this.BP_Position.Name = "BP_Position";
            this.BP_Position.Size = new System.Drawing.Size(177, 56);
            this.BP_Position.TabIndex = 38;
            this.BP_Position.Text = "Position\r\nTransfer";
            this.BP_Position.UseVisualStyleBackColor = true;
            this.BP_Position.Click += new System.EventHandler(this.BP_Position_Click);
            // 
            // tabPage_mode_manuel_transfert_poseidon
            // 
            this.tabPage_mode_manuel_transfert_poseidon.Controls.Add(this.BP_prog_P);
            this.tabPage_mode_manuel_transfert_poseidon.Controls.Add(this.BP_initialisation_P);
            this.tabPage_mode_manuel_transfert_poseidon.Controls.Add(this.BP_position_P);
            this.tabPage_mode_manuel_transfert_poseidon.Controls.Add(this.label28);
            this.tabPage_mode_manuel_transfert_poseidon.Controls.Add(this.label36);
            this.tabPage_mode_manuel_transfert_poseidon.Controls.Add(this.label37);
            this.tabPage_mode_manuel_transfert_poseidon.Controls.Add(this.Transfer_P_motor_4);
            this.tabPage_mode_manuel_transfert_poseidon.Controls.Add(this.Transfer_P_motor_3);
            this.tabPage_mode_manuel_transfert_poseidon.Controls.Add(this.Transfer_P_motor_2);
            this.tabPage_mode_manuel_transfert_poseidon.Location = new System.Drawing.Point(4, 29);
            this.tabPage_mode_manuel_transfert_poseidon.Name = "tabPage_mode_manuel_transfert_poseidon";
            this.tabPage_mode_manuel_transfert_poseidon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_mode_manuel_transfert_poseidon.Size = new System.Drawing.Size(1105, 662);
            this.tabPage_mode_manuel_transfert_poseidon.TabIndex = 7;
            this.tabPage_mode_manuel_transfert_poseidon.Text = "Mode manuel Transfer Poséidon ";
            this.tabPage_mode_manuel_transfert_poseidon.UseVisualStyleBackColor = true;
            // 
            // BP_prog_P
            // 
            this.BP_prog_P.Location = new System.Drawing.Point(92, 431);
            this.BP_prog_P.Name = "BP_prog_P";
            this.BP_prog_P.Size = new System.Drawing.Size(177, 56);
            this.BP_prog_P.TabIndex = 48;
            this.BP_prog_P.Text = "Cycle de fonctionnement ";
            this.BP_prog_P.UseVisualStyleBackColor = true;
            this.BP_prog_P.Click += new System.EventHandler(this.BP_prog_P_Click);
            // 
            // BP_initialisation_P
            // 
            this.BP_initialisation_P.Location = new System.Drawing.Point(92, 291);
            this.BP_initialisation_P.Name = "BP_initialisation_P";
            this.BP_initialisation_P.Size = new System.Drawing.Size(177, 56);
            this.BP_initialisation_P.TabIndex = 47;
            this.BP_initialisation_P.Text = "Initialisation\r\nTransfer";
            this.BP_initialisation_P.UseVisualStyleBackColor = true;
            this.BP_initialisation_P.Click += new System.EventHandler(this.BP_initialisation_P_Click);
            // 
            // BP_position_P
            // 
            this.BP_position_P.Location = new System.Drawing.Point(92, 151);
            this.BP_position_P.Name = "BP_position_P";
            this.BP_position_P.Size = new System.Drawing.Size(177, 56);
            this.BP_position_P.TabIndex = 46;
            this.BP_position_P.Text = "Position\r\nTransfer";
            this.BP_position_P.UseVisualStyleBackColor = true;
            this.BP_position_P.Click += new System.EventHandler(this.BP_position_P_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label37.Location = new System.Drawing.Point(358, 300);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(195, 32);
            this.label37.TabIndex = 43;
            this.label37.Text = "Moteur courroie ";
            // 
            // Transfer_P_motor_3
            // 
            this.Transfer_P_motor_3.Location = new System.Drawing.Point(570, 300);
            this.Transfer_P_motor_3.Maximum = 100;
            this.Transfer_P_motor_3.Name = "Transfer_P_motor_3";
            this.Transfer_P_motor_3.Size = new System.Drawing.Size(319, 56);
            this.Transfer_P_motor_3.TabIndex = 41;
            this.Transfer_P_motor_3.TickFrequency = 10;
            // 
            // tabPage_mode_manuel_HPD
            // 
            this.tabPage_mode_manuel_HPD.Controls.Add(this.label32);
            this.tabPage_mode_manuel_HPD.Controls.Add(this.BP_InitialisationHPD);
            this.tabPage_mode_manuel_HPD.Controls.Add(this.label_HPD_position_aff);
            this.tabPage_mode_manuel_HPD.Controls.Add(this.label25);
            this.tabPage_mode_manuel_HPD.Controls.Add(this.label26);
            this.tabPage_mode_manuel_HPD.Controls.Add(this.HPD_motor_4);
            this.tabPage_mode_manuel_HPD.Controls.Add(this.HPD_motor_3);
            this.tabPage_mode_manuel_HPD.Controls.Add(this.HPD_motor_1);
            this.tabPage_mode_manuel_HPD.Controls.Add(this.HPD_motor_2);
            this.tabPage_mode_manuel_HPD.Controls.Add(this.label31);
            this.tabPage_mode_manuel_HPD.Location = new System.Drawing.Point(4, 29);
            this.tabPage_mode_manuel_HPD.Name = "tabPage_mode_manuel_HPD";
            this.tabPage_mode_manuel_HPD.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_mode_manuel_HPD.Size = new System.Drawing.Size(1105, 662);
            this.tabPage_mode_manuel_HPD.TabIndex = 8;
            this.tabPage_mode_manuel_HPD.Text = "Mode manuel HDP";
            this.tabPage_mode_manuel_HPD.UseVisualStyleBackColor = true;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label32.Location = new System.Drawing.Point(340, 220);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(159, 32);
            this.label32.TabIndex = 39;
            this.label32.Text = "Moteur roues";
            // 
            // BP_InitialisationHPD
            // 
            this.BP_InitialisationHPD.Location = new System.Drawing.Point(29, 310);
            this.BP_InitialisationHPD.Name = "BP_InitialisationHPD";
            this.BP_InitialisationHPD.Size = new System.Drawing.Size(177, 56);
            this.BP_InitialisationHPD.TabIndex = 37;
            this.BP_InitialisationHPD.Text = "Initialisation\r\nHPD";
            this.BP_InitialisationHPD.UseVisualStyleBackColor = true;
            this.BP_InitialisationHPD.Click += new System.EventHandler(this.BP_InitialisationHPD_Click);
            // 
            // label_HPD_position_aff
            // 
            this.label_HPD_position_aff.AutoSize = true;
            this.label_HPD_position_aff.Location = new System.Drawing.Point(471, 79);
            this.label_HPD_position_aff.Name = "label_HPD_position_aff";
            this.label_HPD_position_aff.Size = new System.Drawing.Size(17, 20);
            this.label_HPD_position_aff.TabIndex = 36;
            this.label_HPD_position_aff.Text = "0";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label25.Location = new System.Drawing.Point(340, 499);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 32);
            this.label25.TabIndex = 35;
            this.label25.Text = "Moteur 4";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(340, 360);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(113, 32);
            this.label26.TabIndex = 34;
            this.label26.Text = "Moteur 3";
            // 
            // HPD_motor_4
            // 
            this.HPD_motor_4.Location = new System.Drawing.Point(560, 499);
            this.HPD_motor_4.Maximum = 100;
            this.HPD_motor_4.Name = "HPD_motor_4";
            this.HPD_motor_4.Size = new System.Drawing.Size(319, 56);
            this.HPD_motor_4.TabIndex = 33;
            this.HPD_motor_4.TickFrequency = 10;
            // 
            // HPD_motor_3
            // 
            this.HPD_motor_3.Location = new System.Drawing.Point(560, 360);
            this.HPD_motor_3.Maximum = 100;
            this.HPD_motor_3.Name = "HPD_motor_3";
            this.HPD_motor_3.Size = new System.Drawing.Size(319, 56);
            this.HPD_motor_3.TabIndex = 32;
            this.HPD_motor_3.TickFrequency = 10;
            // 
            // HPD_motor_1
            // 
            this.HPD_motor_1.Location = new System.Drawing.Point(560, 70);
            this.HPD_motor_1.Maximum = 90;
            this.HPD_motor_1.Minimum = -90;
            this.HPD_motor_1.Name = "HPD_motor_1";
            this.HPD_motor_1.Size = new System.Drawing.Size(319, 56);
            this.HPD_motor_1.TabIndex = 31;
            this.HPD_motor_1.TickFrequency = 10;
            // 
            // HPD_motor_2
            // 
            this.HPD_motor_2.Location = new System.Drawing.Point(560, 220);
            this.HPD_motor_2.Maximum = 100;
            this.HPD_motor_2.Name = "HPD_motor_2";
            this.HPD_motor_2.Size = new System.Drawing.Size(319, 56);
            this.HPD_motor_2.TabIndex = 30;
            this.HPD_motor_2.Tag = "";
            this.HPD_motor_2.TickFrequency = 10;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label31.Location = new System.Drawing.Point(340, 70);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(190, 64);
            this.label31.TabIndex = 38;
            this.label31.Text = "Moteur 1 \r\npositionnement ";
            // 
            // tabPage_mode_manuel_HPD_poseidon
            // 
            this.tabPage_mode_manuel_HPD_poseidon.Controls.Add(this.BP_Initialisation_HPD_P);
            this.tabPage_mode_manuel_HPD_poseidon.Controls.Add(this.label_HPD_P_position_aff);
            this.tabPage_mode_manuel_HPD_poseidon.Controls.Add(this.label35);
            this.tabPage_mode_manuel_HPD_poseidon.Controls.Add(this.label34);
            this.tabPage_mode_manuel_HPD_poseidon.Controls.Add(this.label29);
            this.tabPage_mode_manuel_HPD_poseidon.Controls.Add(this.label30);
            this.tabPage_mode_manuel_HPD_poseidon.Controls.Add(this.HPD_P_motor_4);
            this.tabPage_mode_manuel_HPD_poseidon.Controls.Add(this.HPD_P_motor_3);
            this.tabPage_mode_manuel_HPD_poseidon.Controls.Add(this.HPD_P_motor_1);
            this.tabPage_mode_manuel_HPD_poseidon.Controls.Add(this.HPD_P_motor_2);
            this.tabPage_mode_manuel_HPD_poseidon.Location = new System.Drawing.Point(4, 29);
            this.tabPage_mode_manuel_HPD_poseidon.Name = "tabPage_mode_manuel_HPD_poseidon";
            this.tabPage_mode_manuel_HPD_poseidon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_mode_manuel_HPD_poseidon.Size = new System.Drawing.Size(1105, 662);
            this.tabPage_mode_manuel_HPD_poseidon.TabIndex = 9;
            this.tabPage_mode_manuel_HPD_poseidon.Text = "Mode manuel HPD Poséidon ";
            this.tabPage_mode_manuel_HPD_poseidon.UseVisualStyleBackColor = true;
            // 
            // BP_Initialisation_HPD_P
            // 
            this.BP_Initialisation_HPD_P.Location = new System.Drawing.Point(29, 310);
            this.BP_Initialisation_HPD_P.Name = "BP_Initialisation_HPD_P";
            this.BP_Initialisation_HPD_P.Size = new System.Drawing.Size(177, 56);
            this.BP_Initialisation_HPD_P.TabIndex = 47;
            this.BP_Initialisation_HPD_P.Text = "Initialisation\r\nHPD";
            this.BP_Initialisation_HPD_P.UseVisualStyleBackColor = true;
            this.BP_Initialisation_HPD_P.Click += new System.EventHandler(this.BP_Initialisation_HPD_P_Click);
            // 
            // label_HPD_P_position_aff
            // 
            this.label_HPD_P_position_aff.AutoSize = true;
            this.label_HPD_P_position_aff.Location = new System.Drawing.Point(471, 79);
            this.label_HPD_P_position_aff.Name = "label_HPD_P_position_aff";
            this.label_HPD_P_position_aff.Size = new System.Drawing.Size(17, 20);
            this.label_HPD_P_position_aff.TabIndex = 45;
            this.label_HPD_P_position_aff.Text = "0";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label35.Location = new System.Drawing.Point(340, 70);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(190, 64);
            this.label35.TabIndex = 46;
            this.label35.Text = "Moteur 1 \r\npositionnement ";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label34.Location = new System.Drawing.Point(340, 220);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(113, 32);
            this.label34.TabIndex = 44;
            this.label34.Text = "Moteur 2";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(340, 500);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(113, 32);
            this.label29.TabIndex = 42;
            this.label29.Text = "Moteur 4";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label30.Location = new System.Drawing.Point(340, 360);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(166, 32);
            this.label30.TabIndex = 41;
            this.label30.Text = "Moteur  roues";
            // 
            // HPD_P_motor_4
            // 
            this.HPD_P_motor_4.Location = new System.Drawing.Point(560, 500);
            this.HPD_P_motor_4.Maximum = 100;
            this.HPD_P_motor_4.Name = "HPD_P_motor_4";
            this.HPD_P_motor_4.Size = new System.Drawing.Size(319, 56);
            this.HPD_P_motor_4.TabIndex = 40;
            this.HPD_P_motor_4.TickFrequency = 10;
            // 
            // HPD_P_motor_3
            // 
            this.HPD_P_motor_3.Location = new System.Drawing.Point(560, 360);
            this.HPD_P_motor_3.Maximum = 100;
            this.HPD_P_motor_3.Name = "HPD_P_motor_3";
            this.HPD_P_motor_3.Size = new System.Drawing.Size(319, 56);
            this.HPD_P_motor_3.TabIndex = 39;
            this.HPD_P_motor_3.TickFrequency = 10;
            // 
            // HPD_P_motor_1
            // 
            this.HPD_P_motor_1.Location = new System.Drawing.Point(560, 70);
            this.HPD_P_motor_1.Maximum = 90;
            this.HPD_P_motor_1.Minimum = -90;
            this.HPD_P_motor_1.Name = "HPD_P_motor_1";
            this.HPD_P_motor_1.Size = new System.Drawing.Size(320, 56);
            this.HPD_P_motor_1.TabIndex = 38;
            this.HPD_P_motor_1.TickFrequency = 10;
            // 
            // HPD_P_motor_2
            // 
            this.HPD_P_motor_2.Location = new System.Drawing.Point(560, 220);
            this.HPD_P_motor_2.Maximum = 100;
            this.HPD_P_motor_2.Name = "HPD_P_motor_2";
            this.HPD_P_motor_2.Size = new System.Drawing.Size(319, 56);
            this.HPD_P_motor_2.TabIndex = 37;
            this.HPD_P_motor_2.Tag = "";
            this.HPD_P_motor_2.TickFrequency = 10;
            // 
            // Transfer_P_motor_2
            // 
            this.Transfer_P_motor_2.Location = new System.Drawing.Point(570, 160);
            this.Transfer_P_motor_2.Maximum = 100;
            this.Transfer_P_motor_2.Name = "Transfer_P_motor_2";
            this.Transfer_P_motor_2.Size = new System.Drawing.Size(319, 56);
            this.Transfer_P_motor_2.TabIndex = 40;
            this.Transfer_P_motor_2.Tag = "";
            this.Transfer_P_motor_2.TickFrequency = 10;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(400, 160);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(113, 32);
            this.label28.TabIndex = 45;
            this.label28.Text = "Moteur 2";
            // 
            // Transfer_P_motor_4
            // 
            this.Transfer_P_motor_4.Location = new System.Drawing.Point(570, 440);
            this.Transfer_P_motor_4.Maximum = 100;
            this.Transfer_P_motor_4.Name = "Transfer_P_motor_4";
            this.Transfer_P_motor_4.Size = new System.Drawing.Size(319, 56);
            this.Transfer_P_motor_4.TabIndex = 42;
            this.Transfer_P_motor_4.TickFrequency = 10;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label36.Location = new System.Drawing.Point(400, 440);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(113, 32);
            this.label36.TabIndex = 44;
            this.label36.Text = "Moteur 4";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1363, 695);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiControl";
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabControl_Main.ResumeLayout(false);
            this.tabpage_Infos.ResumeLayout(false);
            this.tabpage_Infos.PerformLayout();
            this.tabPage_Motors.ResumeLayout(false);
            this.tabPage_Motors.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_motor_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_motor_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_motor_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_motor_1)).EndInit();
            this.tabPage_io.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage_Datas.ResumeLayout(false);
            this.tabPage_Datas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage_Sauvegarde_carte.ResumeLayout(false);
            this.tabPage_mode_manuel_transfert.ResumeLayout(false);
            this.tabPage_mode_manuel_transfert.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transfer_motor_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transfer_motor_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transfer_motor_2)).EndInit();
            this.tabPage_mode_manuel_transfert_poseidon.ResumeLayout(false);
            this.tabPage_mode_manuel_transfert_poseidon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Transfer_P_motor_3)).EndInit();
            this.tabPage_mode_manuel_HPD.ResumeLayout(false);
            this.tabPage_mode_manuel_HPD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HPD_motor_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPD_motor_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPD_motor_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPD_motor_2)).EndInit();
            this.tabPage_mode_manuel_HPD_poseidon.ResumeLayout(false);
            this.tabPage_mode_manuel_HPD_poseidon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HPD_P_motor_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPD_P_motor_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPD_P_motor_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HPD_P_motor_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transfer_P_motor_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transfer_P_motor_4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_menu;
        private TextBox textBox_IP;
        private Button BP_connection;
        private Button BP_disconnect;
        private TabControl tabControl_Main;
        private TabPage tabpage_Infos;
        public Label label_production_date;
        public Label label_serial_number;
        private Label label6;
        private Label label5;
        public Label label_network_software;
        public Label label_sys_software;
        public Label label_app_software;
        public Label label_hardware;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        public Label label_Bigendian;
        private Label label_text_Bigendian;
        private TabPage tabPage_Motors;
        private ComboBox comboBox_Motor4;
        private ComboBox comboBox_Motor3;
        private ComboBox comboBox_Motor2;
        private ComboBox comboBox_Motor1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        public TrackBar Speed_motor_4;
        public TrackBar Speed_motor_3;
        public TrackBar Speed_motor_2;
        public TrackBar Speed_motor_1;
        private TabPage tabPage_io;
        private Button button_clock_M4;
        private Button button_clock_M3;
        private Button button_clock_M2;
        private Button button_clock_M1;
        private Button button_test_IO_3_4;
        private Button button_test_IO_1_2;
        private Button BP_textboxio_clear;
        private RichTextBox richTextBox_IO;
        private Label Min_M_voltage;
        private Label Act_temperature;
        private Label Max_M_voltage;
        private Label Act_M_voltage;
        private Label Min_temperature;
        private Label Max_temperature;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label Min_L_voltage;
        private Label Max_L_voltage;
        private Label Act_L_voltage;
        private Label label16;
        private Label label17;
        private Label label19;
        private Label label18;
        private Label label23;
        private Label label24;
        private GroupBox groupBox3;
        public Label label_Sensor;
        private Button button_lien;
        private Label aff_clockwise4;
        private Label aff_clockwise3;
        private Label aff_clockwise2;
        private Label aff_clockwise1;
        private TabPage tabPage_Datas;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label8;
        private ComboBox comboBox_io4;
        private ComboBox comboBox_io3;
        private ComboBox comboBox_io2;
        private ComboBox comboBox_io1;
        private RichTextBox richTextBox_octet;
        private GroupBox groupBox2;
        public Label label_current;
        private GroupBox groupBox1;
        public Label label_io;
        private Label label_timeout;
        private TabPage tabPage_Sauvegarde_carte;
        private TabPage tabPage_mode_manuel_transfert;
        private TabPage tabPage_mode_manuel_transfert_poseidon;
        private TabPage tabPage_mode_manuel_HPD;
        private TabPage tabPage_mode_manuel_HPD_poseidon;
        private PictureBox pictureBox1;
        private Button button_save;
        private RichTextBox richTextBox_save;
        private Button button_uploadbackup;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label_code_error;
        private Label label27;
        private Label label_HPD_position_aff;
        private Label label25;
        private Label label26;
        public TrackBar HPD_motor_4;
        public TrackBar HPD_motor_3;
        public TrackBar HPD_motor_1;
        public TrackBar HPD_motor_2;
        public TrackBar HPD_P_motor_1;
        public TrackBar HPD_P_motor_2;
        private Button BP_InitialisationHPD;
        private Label label31;
        private Label label32;
        private Button BP_prog;
        private Button BP_Initialisation;
        private Button BP_Position;
        private Label label33;
        private Label label_HPD_P_position_aff;
        private Label label35;
        private Label label34;
        private Label label38;
        private Label label39;
        private Label label40;
        public TrackBar Transfer_motor_4;
        public TrackBar Transfer_motor_3;
        public TrackBar Transfer_motor_2;
        private Label label37;
        public TrackBar Transfer_P_motor_3;
        private Label label29;
        private Label label30;
        public TrackBar HPD_P_motor_4;
        public TrackBar HPD_P_motor_3;
        private Button BP_Initialisation_HPD_P;
        private Button BP_prog_P;
        private Button BP_initialisation_P;
        private Button BP_position_P;
        private Label label28;
        private Label label36;
        public TrackBar Transfer_P_motor_4;
        public TrackBar Transfer_P_motor_2;
    }
}