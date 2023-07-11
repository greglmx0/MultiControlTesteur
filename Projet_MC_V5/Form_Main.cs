using Sres.Net.EEIP;
using System.Collections;
using System.Diagnostics;

namespace Projet_MC_V5
{
    public partial class Form_Main : Form
    {

        #region Variables 

        // System.Diagnostics.Debug.WriteLine();

        private bool bool_com_etat = false;                        // Bool de connexion a la MutiControl      / \
        private bool bool_BigEndian = false;                      // Bool format big endian de la MC          \ /

        private List<states_combo> list_io1 = new List<states_combo>();
        private List<states_combo> list_io2 = new List<states_combo>();
        private List<states_combo> list_io3 = new List<states_combo>();
        private List<states_combo> list_io4 = new List<states_combo>();

        private EEIPClient MC = new();                             // MC = MultiControl 
        private System.Windows.Forms.Timer Timer_App = new();    // Timer maj des forms 

        byte[][] byte_array_save_data_4700 = new byte[0x20][];   // Sauvegarde index 0x4700 - Moteur settings
        byte[][] byte_array_save_data_4800 = new byte[0x15][];   // Sauvegarde index 0x4800 - Sensor and I/O
        byte[][] byte_array_save_data_4900 = new byte[0x5][];    // Sauvegarde index 0x4900 - Application module
        byte[][] byte_array_save_data_4A00 = new byte[0x6][];    // Sauvegarde index 0x4A00 - Error behaviour


        #endregion

        #region Main form
        public Form_Main()
        {
            InitializeComponent();

        }
        private void BP_Connection_Click(object sender, EventArgs e)
        {
            connection();
        }  // BP connexion MC
        private void BP_disconnect_Click(object sender, EventArgs e)
        {
            disconnect();
        }  // BP de déconnexion de la MC
        private void button_lien_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo { FileName = @"http://" + textBox_IP.Text, UseShellExecute = true });
            }
            catch
            {
                MessageBox.Show("Error", "Error");
            }


        }    // BP lien serveur web
        #endregion

        #region Méthodes MC
        private void connection()
        {
            if (bool_com_etat == false)
            {
                label1.Hide();
                label1.ForeColor = Color.Black;
                MC.IPAddress = textBox_IP.Text;
                //A Session has to be registered before any communication can be established
                try
                {
                    MC.RegisterSession();
                    //Parameters from Originator -> Target
                    MC.O_T_InstanceID = 0x64;              //Instance ID of the Output Assembly
                    MC.O_T_Length = 5;                     //The Method "Detect_O_T_Length" detect the Length using an UCMM Message
                    MC.O_T_RealTimeFormat = Sres.Net.EEIP.RealTimeFormat.Header32Bit;   //Header Format
                    MC.O_T_OwnerRedundant = false;
                    MC.O_T_VariableLength = false;
                    MC.O_T_ConnectionType = Sres.Net.EEIP.ConnectionType.Point_to_Point;
                    MC.RequestedPacketRate_O_T = 10000;        //10ms is the Standard value
                    MC.O_T_Priority = Sres.Net.EEIP.Priority.Scheduled;


                    //Parameters from Target -> Originator
                    MC.T_O_InstanceID = 0x65;
                    MC.T_O_Length = 36;
                    MC.T_O_RealTimeFormat = Sres.Net.EEIP.RealTimeFormat.Header32Bit;
                    MC.T_O_OwnerRedundant = false;
                    MC.T_O_VariableLength = false;
                    MC.T_O_ConnectionType = Sres.Net.EEIP.ConnectionType.Multicast;
                    MC.RequestedPacketRate_T_O = 10000;    //RPI in  10ms is the Standard value
                    MC.T_O_Priority = Sres.Net.EEIP.Priority.Scheduled;


                    //Forward open initiates the Implicit Messaging
                    MC.ForwardOpen();
                    textBox_IP.ReadOnly = true;
                    bool_com_etat = true;
                    Timer_App.Tick += new EventHandler(Mainloop);   // lance la MAJ avec Mainloop
                    Timer_App.Interval = 1000; // 1 second
                    Timer_App.Start();

                    // loadform(new Form_Infos(MC, mc_class));

                    tabControl_Main.Show();

                    try
                    {
                        MAJ_Infos();
                    }
                    catch
                    {
                        System.Diagnostics.Debug.WriteLine("infos");
                    }
                    try
                    {
                        MAJ_Motor();
                    }
                    catch
                    {
                        System.Diagnostics.Debug.WriteLine("Motor");
                    }
                    try
                    {
                        MAJ_io();
                    }
                    catch
                    {
                        System.Diagnostics.Debug.WriteLine("io");
                    }
                    try
                    {
                        MAJ_sens_Motor();
                    }
                    catch
                    {
                        System.Diagnostics.Debug.WriteLine("motor sens");
                    }

                }
                catch
                {
                    label1.Show();
                    label1.ForeColor = Color.Red;
                }

                




                // 192.168.1.31

            }
            else
            {
                MessageBox.Show(Text = "Comunication already run", "Error");
            }
        }
        private void disconnect()
        {
            if (bool_com_etat == false)
            {
                MessageBox.Show(Text = "Comunication already done", "Error");
            }
            else
            {
                Timer_App.Stop();

                tabControl_Main.Hide();

                MC.UnRegisterSession();
                MC.ForwardClose();

                textBox_IP.ReadOnly = false;
                bool_com_etat = false;
            }
        }

        #endregion

        #region MAJ tabpage (Mainloop) and Time out
        private void Mainloop(Object myObject, EventArgs myEventArgs)
        {
            byte_display();           // Affichage: octets / sensors / I/O / Current acctual / time out message

            // time_out();               // Détection si carte débranché

            consigne_speed_motors();  // Le tabpage Motor test  (Si active) envoie les consignes aux moteurs

            consigne_transfert();
            consigne_transfert_poseidon();
            consigne_HPD();                 // Le tabpage transfert Manu (Si active) envoie les consignes aux moteurs + MAJ
            consigne_HPD_poseidon();

        } // MAJ des Forms (Datas et commande moteur)

        private void byte_display()
        {
            String var_sensor = "";
            String var_io = "";
            String current = "";
            String var_tempo_1 = "Octet  0- 35:\n\n";

            // Affichage des octets de 0 à 35
            for (int i = 0; i < 36; i++)
            {
                var_tempo_1 += "Octet " + i.ToString() + ":  " + MC.T_O_IOData[i].ToString() + "\n";
            }
            richTextBox_octet.Text = var_tempo_1;

            // Affichage de 4 bits sensors
            BitArray sensorbit = new(new byte[] { MC.T_O_IOData[0] });
            for (int i = 0; i < 4; i++)
            {
                var_sensor = var_sensor + "Sensor " + (i + 1).ToString() + ":  " + (sensorbit[i]).ToString() + "\n";
            };
            label_Sensor.Text = var_sensor;

            // Affichage des 4 bits I/O
            BitArray iobit = new(new byte[] { MC.T_O_IOData[1] });
            for (int i = 0; i < 4; i++)
            {
                var_io = var_io + "I/O " + (i + 1).ToString() + ":  " + (iobit[i]).ToString() + "\n";
            };
            label_io.Text = var_io;

            // Current acctual 
            if (bool_BigEndian == false)
            {
                for (int i = 8; i < 16; i = i + 2)
                {
                    byte[] current_byte = new byte[2] { MC.T_O_IOData[i], MC.T_O_IOData[i + 1] };
                    ushort current_int = BitConverter.ToUInt16(current_byte, 0);

                    current = current + "Current " + ((i - 6) / 2).ToString() + ":  " + (current_int).ToString() + "\n";
                };
            }
            else
            {
                for (int i = 8; i < 16; i = i + 2)
                {
                    byte[] current_byte = new byte[2] { MC.T_O_IOData[i + 1], MC.T_O_IOData[i] };
                    ushort current_int = BitConverter.ToUInt16(current_byte, 0);

                    current = current + "Current " + ((i - 6) / 2).ToString() + ":  " + (current_int).ToString() + "\n";
                };
            }
            label_current.Text = current;

            // Time out label tabpage info
            label_timeout.Text = MC.LastReceivedImplicitMessage.ToString();
        }
        private void time_out()
        {
            int Time_MC = MC.LastReceivedImplicitMessage.Minute * 60 + MC.LastReceivedImplicitMessage.Second;
            int Time_Master = DateTime.Now.Minute * 60 + DateTime.Now.Second;

            // System.Diagnostics.Debug.WriteLine(Time_MC);
            // System.Diagnostics.Debug.WriteLine(Time_Master);

            if (Time_Master >= Time_MC + 5)
            {
                disconnect();
                MessageBox.Show("Time out\nMC disconnect", "Error");
            }
        }
        private void consigne_speed_motors()
        {
            if (tabControl_Main.SelectedTab == tabControl_Main.TabPages["tabPage_Motors"])  // "tabPage_io" | "tabpage_Infos" | "tabPage_Datas" |
            {
                // Speed Motors
                MC.O_T_IOData[1] = (byte)Speed_motor_1.Value;
                MC.O_T_IOData[2] = (byte)Speed_motor_2.Value;
                MC.O_T_IOData[3] = (byte)Speed_motor_3.Value;
                MC.O_T_IOData[4] = (byte)Speed_motor_4.Value;
            }
            else
            {
                Speed_motor_1.Value = 0;
                Speed_motor_2.Value = 0;
                Speed_motor_3.Value = 0;
                Speed_motor_4.Value = 0;
            }
        }

        private void consigne_transfert()
        {

            label_HPD_position_aff.Text = HPD_motor_1.Value.ToString();  

            if (tabControl_Main.SelectedTab == tabControl_Main.TabPages["tabPage_mode_manuel_transfert"])
            {

                MC.O_T_IOData[2] = (byte)Transfer_motor_2.Value;
                MC.O_T_IOData[3] = (byte)Transfer_motor_3.Value;
                MC.O_T_IOData[4] = (byte)Transfer_motor_4.Value;
            }
            else
            {
                Transfer_motor_2.Value = 0;
                Transfer_motor_3.Value = 0;
                Transfer_motor_4.Value = 0;
            }

        }
        private void consigne_transfert_poseidon()
        {

            label_HPD_position_aff.Text = HPD_motor_1.Value.ToString();    

            if (tabControl_Main.SelectedTab == tabControl_Main.TabPages["tabPage_mode_manuel_transfert_poseidon"])
            {

                MC.O_T_IOData[2] = (byte)Transfer_P_motor_2.Value;
                MC.O_T_IOData[3] = (byte)Transfer_P_motor_3.Value;
                MC.O_T_IOData[4] = (byte)Transfer_P_motor_4.Value;
            }
            else
            {
                Transfer_P_motor_2.Value = 0;
                Transfer_P_motor_3.Value = 0;
                Transfer_P_motor_4.Value = 0;
            }

        }

        private void consigne_HPD_poseidon()
        {

            label_HPD_P_position_aff.Text = HPD_P_motor_1.Value.ToString();    

            if (tabControl_Main.SelectedTab == tabControl_Main.TabPages["tabPage_mode_manuel_HPD_poseidon"])
            {
      
                MC.O_T_IOData[1] = (byte)HPD_P_motor_1.Value;
                MC.O_T_IOData[2] = (byte)HPD_P_motor_2.Value;
                MC.O_T_IOData[3] = (byte)HPD_P_motor_3.Value;
                MC.O_T_IOData[4] = (byte)HPD_P_motor_4.Value;
               
            }
            else
            {
                HPD_P_motor_1.Value = 0;
                HPD_P_motor_2.Value = 0;
                HPD_P_motor_3.Value = 0;
                HPD_P_motor_4.Value = 0;
            }
        }

        private void consigne_HPD() 
        {

            label_HPD_position_aff.Text = HPD_motor_1.Value.ToString();

            if (tabControl_Main.SelectedTab == tabControl_Main.TabPages["tabPage_mode_manuel_HPD"])
            {
                MC.O_T_IOData[1] = (byte)HPD_motor_1.Value;
                MC.O_T_IOData[2] = (byte)HPD_motor_2.Value;
                MC.O_T_IOData[3] = (byte)HPD_motor_3.Value;
                MC.O_T_IOData[4] = (byte)HPD_motor_4.Value;
            }
            else
            {
                HPD_motor_1.Value = 0;
                HPD_motor_2.Value = 0;
                HPD_motor_3.Value = 0;
                HPD_motor_4.Value = 0;
            }
        }

        #endregion

        #region tabpage onglet Info
        private void tabpage_Infos_Click(object sender, EventArgs e)
        {
            MAJ_Infos();


        }  //MAJ du form Info avec click

        #endregion

        #region Méthodes Infos
        private void MAJ_Infos()
        {
            MAJ_version();
            MAJ_Diagnosis_information();
            MAJ_error_code();

        } //MAJ du form Info (Datas Carte)

        private void MAJ_version()
        {
            label_Bigendian.Text = Read_SDO_string(0x4614);
            bool_BigEndian = Read_SDO_Bool(0x4614);
            label_hardware.Text = Read_SDO_char(0x4001);
            label_app_software.Text = Read_SDO_char(0x4002);
            label_sys_software.Text = Read_SDO_char(0x4003);
            label_network_software.Text = Read_SDO_char(0x4004);
            label_serial_number.Text = Read_SDO_char(0x4101);
            label_production_date.Text = Read_SDO_char(0x4102);
        }

        private void MAJ_Diagnosis_information()
        {
            Act_M_voltage.Text = Read_SDO_int16(0x4201).ToString() + " mV";
            Max_M_voltage.Text = Read_SDO_int16(0x4202).ToString() + " mV";
            Min_M_voltage.Text = Read_SDO_int16(0x4203).ToString() + " mV";
            Act_L_voltage.Text = Read_SDO_int16(0x4203).ToString() + " mV";
            Max_L_voltage.Text = Read_SDO_int16(0x4205).ToString() + " mV";
            Min_L_voltage.Text = Read_SDO_int16(0x4206).ToString() + " mV";
            Act_temperature.Text = (String.Format("{0:0.##}", Read_SDO_int16(0x4207) * 0.1)).ToString() + " C°";
            Max_temperature.Text = (String.Format("{0:0.##}", Read_SDO_int16(0x4208) * 0.1)).ToString() + " C°";
            Min_temperature.Text = (String.Format("{0:0.##}", Read_SDO_int16(0x4209) * 0.1)).ToString() + " C°";
        }  // MAJ tabinfos (logic / motor / C°)

        private void MAJ_error_code()
        {
            label_code_error.Text = Read_SDO_int16(0x4302).ToString();
        }
        #endregion

        #region tabpage onglet motor
        private void comboBox_Motor1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            send_motor(comboBox_Motor1, 0x4701);
        }  // choix type moteur 1
        private void comboBox_Motor2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            send_motor(comboBox_Motor2, 0x4702);
        }  // choix type moteur 2
        private void comboBox_Motor3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            send_motor(comboBox_Motor3, 0x4703);
        }  // choix type moteur 3
        private void comboBox_Motor4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            send_motor(comboBox_Motor4, 0x4704);
        }  // choix type moteur 4

        private void button_clock_M1_Click(object sender, EventArgs e)
        {
            try
            {
                Change_clock_tabmotor(aff_clockwise1, Speed_motor_1, 0x4705);
            }
            catch
            {
                MessageBox.Show(Text = "Error SDO\nDisconnect and Reconnect", "Error");
            }

        }   // sens de rotation M1
        private void button_clock_M2_Click(object sender, EventArgs e)
        {
            try
            {
                Change_clock_tabmotor(aff_clockwise2, Speed_motor_2, 0x4706);
            }
            catch
            {
                MessageBox.Show(Text = "Error SDO\nDisconnect and Reconnect", "Error");
            }

        }   // sens de rotation M2
        private void button_clock_M3_Click(object sender, EventArgs e)
        {
            try
            {
                Change_clock_tabmotor(aff_clockwise3, Speed_motor_3, 0x4707);
            }
            catch
            {
                MessageBox.Show(Text = "Error SDO\nDisconnect and Reconnect", "Error");
            }

        }   // sens de rotation M3
        private void button_clock_M4_Click(object sender, EventArgs e)
        {

            try
            {
                Change_clock_tabmotor(aff_clockwise4, Speed_motor_4, 0x4708);
            }
            catch
            {
                MessageBox.Show(Text = "Error SDO\nDisconnect and Reconnect", "Error");
            }

        }   // sens de rotation M4

        #endregion

        #region Méthodes Motors
        private void MAJ_Motor()
        {
            Setup_ComboBox(comboBox_Motor1);
            comboBox_Motor1.SelectedIndex = Read_SDO_int8(0x4701);
            Setup_ComboBox(comboBox_Motor2);
            comboBox_Motor2.SelectedIndex = Read_SDO_int8(0x4702);
            Setup_ComboBox(comboBox_Motor3);
            comboBox_Motor3.SelectedIndex = Read_SDO_int8(0x4703);
            Setup_ComboBox(comboBox_Motor4);
            comboBox_Motor4.SelectedIndex = Read_SDO_int8(0x4704);
        }  // MAJ des types moteur dans ComboBox au lancement du form

        private void MAJ_sens_Motor()
        {
            for (int i = 0; i < 4; i++)
            {
                byte[] Motor_clock = Read_SDO(0x4705 + i);
                if (Motor_clock[0] == 1)
                {
                    switch (i)
                    {
                        case 0:
                            aff_clockwise1.Text = "Clockwise";
                            break;
                        case 1:
                            aff_clockwise2.Text = "Clockwise";
                            break;
                        case 2:
                            aff_clockwise3.Text = "Clockwise";
                            break;
                        case 3:
                            aff_clockwise4.Text = "Clockwise";
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            aff_clockwise1.Text = "Counterclockwise";
                            break;
                        case 1:
                            aff_clockwise2.Text = "Counterclockwise";
                            break;
                        case 2:
                            aff_clockwise3.Text = "Counterclockwise";
                            break;
                        case 3:
                            aff_clockwise4.Text = "Counterclockwise";
                            break;
                    }
                }


            }


        }

        public void Setup_ComboBox(ComboBox combo)
        {
            List<states_combo> list = new List<states_combo>();

            list.Add(new states_combo() { ID = 0, Name = "none" });
            list.Add(new states_combo() { ID = 1, Name = "EC310" });
            list.Add(new states_combo() { ID = 2, Name = "VDC_SPEED" });
            list.Add(new states_combo() { ID = 3, Name = "VDC_POSITION" });
            list.Add(new states_combo() { ID = 4, Name = "EC5000" });
            // 0 = none ; 1 = EC310 ; 2 = VDC_SPEED ; 3 = VDC_POSITION ; 4 = EC5000
            combo.DataSource = list;
            combo.ValueMember = "ID";
            combo.DisplayMember = "Name";
        }   // Pour setup ComboBox Motor

        private void send_motor(ComboBox combo, int attribut = 0x1)
        {
            states_combo obj = combo.SelectedItem as states_combo;
            try
            {
                if (obj != null)
                {
                    byte[] var_send_motor = BitConverter.GetBytes(obj.ID);
                    send_SDO_without_errors(var_send_motor, attribut);
                }
            }
            catch
            {
                obj.ID = 0;
                byte[] var_send_motor = BitConverter.GetBytes(obj.ID);
                send_SDO_without_errors(var_send_motor, attribut);
                MessageBox.Show(Text = "MultiControl not compatible or restart connection ", "Error");
                combo.SelectedIndex = 0;
            }
        }  // Changement de types de moteur dans ComboBox 

        private void Change_clock_tabmotor(Label lab, TrackBar bar, int Attribute = 0x1)
        {
            bar.Value = 0;
            byte[] Motor_clock = Read_SDO(Attribute);
            // System.Diagnostics.Debug.WriteLine(Motor_clock[0]);
            if (Motor_clock[0] == 0)
            {
                send_SDO(BitConverter.GetBytes(1), Attribute);
                lab.Text = "Clockwise";
            }
            else
            {
                send_SDO(BitConverter.GetBytes(0), Attribute);
                lab.Text = "Counterclockwise";
            }

        }  // changer le sens de rotation moteur
        #endregion

        #region tabpage onglet I/O
        private void comboBox_io1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            send_io(comboBox_io1, 0x4811);
        }     // choix type I/O 1 
        private void comboBox_io2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            send_io(comboBox_io2, 0x4812);
        }     // choix type I/O 2
        private void comboBox_io3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            send_io(comboBox_io3, 0x4813);
        }     // choix type I/O 3
        private void comboBox_io4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            send_io(comboBox_io4, 0x4814);
        }     // choix type I/O 4

        private void button_test_IO_1_2_Click(object sender, EventArgs e)
        {
            Test_io(1, 2);
        }  // BP test I/O 1 et I/O 2
        private void button_test_IO_3_4_Click(object sender, EventArgs e)
        {
            Test_io(3, 4);
        } // BP test I/O 3 et I/O 4

        private void BP_textboxio_clear_Click(object sender, EventArgs e)   // Clear Textbox I/O
        {
            Clear_textbox_io();
        }

        #endregion

        #region Méthodes I/O
        public void Setup_ComboBox_io(ComboBox combo, List<states_combo> list_io)
        {

            list_io.Add(new states_combo() { ID = 0, Name = "none" });
            list_io.Add(new states_combo() { ID = 1, Name = "Input" });
            list_io.Add(new states_combo() { ID = 2, Name = "Output" });
            list_io.Add(new states_combo() { ID = 15, Name = "Sensor 5" });
            list_io.Add(new states_combo() { ID = 16, Name = "Sensor 6" });
            list_io.Add(new states_combo() { ID = 17, Name = "Sensor 7" });
            list_io.Add(new states_combo() { ID = 18, Name = "Sensor 8" });

            list_io.Add(new states_combo() { ID = 19, Name = "Dirt detect sensor" });
            list_io.Add(new states_combo() { ID = 20, Name = "Ouput error" });
            list_io.Add(new states_combo() { ID = 21, Name = "ControlInput 1" });
            list_io.Add(new states_combo() { ID = 22, Name = "ControlInput 2" });
            list_io.Add(new states_combo() { ID = 23, Name = "ControlInput 3" });
            list_io.Add(new states_combo() { ID = 24, Name = "ControlInput 4" });
            list_io.Add(new states_combo() { ID = 25, Name = "ControlInput 5" });
            list_io.Add(new states_combo() { ID = 26, Name = "ControlInput 6" });
            list_io.Add(new states_combo() { ID = 27, Name = "ControlInput 7" });
            list_io.Add(new states_combo() { ID = 28, Name = "ControlInput 8" });

            list_io.Add(new states_combo() { ID = 31, Name = "ControlOutput 1" });
            list_io.Add(new states_combo() { ID = 32, Name = "ControlOutput 2" });
            list_io.Add(new states_combo() { ID = 33, Name = "ControlOutput 3" });
            list_io.Add(new states_combo() { ID = 34, Name = "ControlOutput 4" });
            list_io.Add(new states_combo() { ID = 35, Name = "ControlOutput 5" });
            list_io.Add(new states_combo() { ID = 36, Name = "ControlOutput 6" });
            list_io.Add(new states_combo() { ID = 37, Name = "ControlOutput 7" });
            list_io.Add(new states_combo() { ID = 38, Name = "ControlOutput 8" });

            list_io.Add(new states_combo() { ID = 41, Name = "Handshake InUp" });
            list_io.Add(new states_combo() { ID = 42, Name = "Handshake InDown" });
            list_io.Add(new states_combo() { ID = 43, Name = "Handshake InSide 1 (left)" });
            list_io.Add(new states_combo() { ID = 44, Name = "Handshake InSide 2 (right)" });
            list_io.Add(new states_combo() { ID = 45, Name = "Handshake OutUp" });
            list_io.Add(new states_combo() { ID = 46, Name = "Handshake OutDown" });
            list_io.Add(new states_combo() { ID = 47, Name = "Handshake OutSide 1 (left)" });
            list_io.Add(new states_combo() { ID = 48, Name = "Handshake OutSide 2 (right)" });

            list_io.Add(new states_combo() { ID = 61, Name = "VDC Error In 1" });
            list_io.Add(new states_combo() { ID = 62, Name = "VDC Error In 2" });
            list_io.Add(new states_combo() { ID = 63, Name = "VDC Direction Out 1" });
            list_io.Add(new states_combo() { ID = 64, Name = "VDC Direction Out 2" });
            list_io.Add(new states_combo() { ID = 65, Name = "VDC Step Pulse Out 1" });
            list_io.Add(new states_combo() { ID = 66, Name = "VDC Step Pulse Out 2" });


            combo.DataSource = list_io;
            combo.ValueMember = "ID";
            combo.DisplayMember = "Name";

        }   // Pour setup ComboBox io

        private void send_io(ComboBox combo, int attribut)
        {
            states_combo obj_io = combo.SelectedItem as states_combo;

            try
            {

                if (obj_io != null)
                {
                    // System.Diagnostics.Debug.WriteLine("io " + (attribut - 0x4810).ToString() + ": ");
                    // System.Diagnostics.Debug.Write(obj_io.ID + "\n");

                    byte[] var_send_io = BitConverter.GetBytes(obj_io.ID);
                    send_SDO(var_send_io, attribut);
                }
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("error send io");
                obj_io.ID = 0;
                byte[] var_send_io = BitConverter.GetBytes(obj_io.ID);
                send_SDO(var_send_io, attribut);
                combo.SelectedIndex = 0;
            }

        }  // Changement de types de io dans ComboBox 


        private void MAJ_io()
        {

            Setup_ComboBox_io(comboBox_io1, list_io1);
            // System.Diagnostics.Debug.WriteLine((list_io1.FindIndex(x => x.ID == Read_SDO_int8(0x4811)).ToString()));
            comboBox_io1.SelectedIndex = list_io1.FindIndex(x => x.ID == Read_SDO_int8(0x4811));

            Setup_ComboBox_io(comboBox_io2, list_io2);
            // System.Diagnostics.Debug.WriteLine((list_io2.FindIndex(x => x.ID == Read_SDO_int8(0x4812)).ToString()));
            comboBox_io2.SelectedIndex = list_io2.FindIndex(x => x.ID == Read_SDO_int8(0x4812));

            Setup_ComboBox_io(comboBox_io3, list_io3);
            // System.Diagnostics.Debug.WriteLine((list_io3.FindIndex(x => x.ID == Read_SDO_int8(0x4813)).ToString()));
            comboBox_io3.SelectedIndex = list_io3.FindIndex(x => x.ID == Read_SDO_int8(0x4813));

            Setup_ComboBox_io(comboBox_io4, list_io4);
            // System.Diagnostics.Debug.WriteLine((list_io4.FindIndex(x => x.ID == Read_SDO_int8(0x4814)).ToString()));
            comboBox_io4.SelectedIndex = list_io4.FindIndex(x => x.ID == Read_SDO_int8(0x4814));

        }  // MAJ des types I/O dans ComboBox au lancement du form
        private void Clear_textbox_io()
        {
            richTextBox_IO.Clear();
            richTextBox_IO.ForeColor = Color.Black;
            richTextBox_IO.BackColor = Color.White;
        }
        private void Test_io(int IO1, int IO2)
        {
            try
            {

                MC.O_T_IOData[0] = 0;
                send_SDO(BitConverter.GetBytes(1), 0x4800 + IO1); // set senser 1 PNP
                send_SDO(BitConverter.GetBytes(1), 0x4800 + IO2); // set senser 2 PNP
                send_SDO(BitConverter.GetBytes(2), 0x4810 + IO1); // Passage de I/O 1 en output
                send_SDO(BitConverter.GetBytes(1), 0x4810 + IO2); // Passage de I/O 2 en input
                send_SDO(BitConverter.GetBytes(1), 0x4808 + IO1); // Passage de I/O 1 en positif
                send_SDO(BitConverter.GetBytes(1), 0x4808 + IO2); // Passage de I/O 2 en positif
                byte IO1_int = (byte)Convert.ToSByte(IO1 - 1);
                byte IO2_int = (byte)Convert.ToSByte(IO2 - 1);

                richTextBox_IO.SelectionColor = Color.Black;
                richTextBox_IO.SelectedText += "Start" + Environment.NewLine;

                // Verif de I/O 1 en output et I/O2 en input
                if (Read_SDO_int8(0x4810 + IO1) == 2)
                {
                    richTextBox_IO.SelectionColor = Color.Black;
                    richTextBox_IO.SelectedText += "I/O " + IO1.ToString() + " = output" + Environment.NewLine;
                }
                else
                {
                    richTextBox_IO.SelectionColor = Color.Red;
                    richTextBox_IO.SelectedText += "I/O " + IO1.ToString() + " not output" + Environment.NewLine;
                }  // I/O 1 = Output ?

                if (Read_SDO_int8(0x4810 + IO2) == 1)
                {
                    richTextBox_IO.SelectionColor = Color.Black;
                    richTextBox_IO.SelectedText += "I/O " + IO2.ToString() + " = input" + Environment.NewLine;
                }
                else
                {
                    richTextBox_IO.SelectionColor = Color.Red;
                    richTextBox_IO.SelectedText += "I/O " + IO2.ToString() + " not input" + Environment.NewLine;
                }  // I/O 2 = Input ??

                // Test (passage de output 1 a True)
                if (Read_SDO_int8(0x4810 + IO1) == 2 || Read_SDO_int8(0x4810 + IO2) == 1 || Read_SDO_int8(0x4800 + IO1) == 1 || Read_SDO_int8(0x4800 + IO2) == 1)
                {
                    richTextBox_IO.SelectionColor = Color.Black;
                    richTextBox_IO.SelectedText += "Lancement test ..." + Environment.NewLine;


                    if (RetryUntilSuccessOrTimeout(IO1_int, IO2_int, TimeSpan.FromSeconds(2)))
                    {
                        richTextBox_IO.SelectionColor = Color.Green;
                        richTextBox_IO.SelectedText += "I/O " + IO2.ToString() + "(input) receive I/O " + IO1.ToString() + "(output)" + Environment.NewLine;
                    }
                    else
                    {
                        richTextBox_IO.SelectionColor = Color.Red;
                        richTextBox_IO.SelectedText = "I/O " + IO2.ToString() + "(input) does not receive I/O " + IO1.ToString() + "(output)" + Environment.NewLine;
                    }

                    //System.Diagnostics.Debug.WriteLine(MC.O_T_IOData[0]);
                    //System.Diagnostics.Debug.WriteLine(MC.T_O_IOData[1]);
                }
                MC.O_T_IOData[0] = 0;


                // Changement de I/O 1 en input et I/O 2 en output
                send_SDO(BitConverter.GetBytes(1), 0x4810 + IO1); // Passage de I/O 1 en input
                send_SDO(BitConverter.GetBytes(2), 0x4810 + IO2); // Passage de I/O 2 en output

                if (Read_SDO_int8(0x4810 + IO1) == 1)
                {
                    richTextBox_IO.SelectionColor = Color.Black;
                    richTextBox_IO.SelectedText += "I/O " + IO1.ToString() + " = input" + Environment.NewLine;
                }
                else
                {
                    richTextBox_IO.SelectionColor = Color.Red;
                    richTextBox_IO.SelectedText += "I/O " + IO1.ToString() + " not input" + Environment.NewLine;
                }// I/O 1 = Input ?

                if (Read_SDO_int8(0x4810 + IO2) == 2)
                {
                    richTextBox_IO.SelectionColor = Color.Black;
                    richTextBox_IO.SelectedText += "I/O " + IO2.ToString() + " = output" + Environment.NewLine;
                }
                else
                {

                    richTextBox_IO.SelectionColor = Color.Red;
                    richTextBox_IO.SelectedText += "I/O " + IO2.ToString() + " not output" + Environment.NewLine;
                }  // I/O 2 = Output ?

                // Test (passage de output 2 a True)
                if (Read_SDO_int8(0x4810 + IO1) == 1 || Read_SDO_int8(0x4810 + IO2) == 2 || Read_SDO_int8(0x4800 + IO1) == 1 || Read_SDO_int8(0x4800 + IO2) == 1)
                {
                    richTextBox_IO.SelectionColor = Color.Black;
                    richTextBox_IO.SelectedText += "Lancement test ..." + Environment.NewLine;



                    if (RetryUntilSuccessOrTimeout(IO2_int, IO1_int, TimeSpan.FromSeconds(2)))
                    {
                        richTextBox_IO.SelectionColor = Color.Green;
                        richTextBox_IO.SelectedText += "I/O " + IO1.ToString() + "(input) receive I/O " + IO2.ToString() + "(output)" + Environment.NewLine;
                    }
                    else
                    {
                        richTextBox_IO.SelectionColor = Color.Red;
                        richTextBox_IO.SelectedText += "I/O " + IO1.ToString() + "(input) does not receive I/O " + IO2.ToString() + "(output)" + Environment.NewLine;
                    }

                    //System.Diagnostics.Debug.WriteLine(MC.O_T_IOData[0]);
                    //System.Diagnostics.Debug.WriteLine(MC.T_O_IOData[1]);

                    richTextBox_IO.SelectionColor = Color.Black;
                    richTextBox_IO.SelectedText += Environment.NewLine;
                }

                MC.O_T_IOData[0] = 0;

                send_SDO(BitConverter.GetBytes(0), 0x4810 + IO1); // Passage de I/O 1 en none
                send_SDO(BitConverter.GetBytes(0), 0x4810 + IO2); // Passage de I/O 2 en none

                MAJ_io();
            }
            catch
            {

            }
        } // Test I/O
        public bool RetryUntilSuccessOrTimeout(byte MC_O_T, byte MC_T_O, TimeSpan timeSpan)
        {
            bool success = false;
            int elapsed = 0;
            while ((!success) && (elapsed < timeSpan.TotalMilliseconds))
            {
                // System.Diagnostics.Debug.WriteLine((Convert.ToString(MC.T_O_IOData[1], toBase: 2).PadRight(8, '0')));

                Thread.Sleep(100);
                elapsed += 100;

                BitArray MC_bits_MC_T_O = new BitArray(new byte[] { MC.T_O_IOData[1] });
                BitArray MC_bits_MC_O_T = new BitArray(new byte[] { MC.O_T_IOData[0] });

                MC_bits_MC_O_T[MC_O_T] = true;

                byte MC_byte_MC_O_T = ConvertToByte(MC_bits_MC_O_T);
                MC.O_T_IOData[0] = MC_byte_MC_O_T;

                if (MC_bits_MC_T_O[MC_T_O] == true)
                    success = true;
            }
            return success;
        }  // verif input reçois output
        #endregion

        #region tabpage onglet sauvgarde carte

        private void button_save_Click(object sender, EventArgs e)
        {
            BP_data();

        }

        private void button_uploadbackup_Click(object sender, EventArgs e)
        {
            BP_upload();
        }

        #endregion

        #region Méthodes sauvgarde carte

        private void BP_data()
        {

            richTextBox_save.Text = "Sauvegarde - Moteur settings ...";
            byte_array_save_data_4700 = save_data(0x4700, 0x20);
            richTextBox_save.Text += "\nSauvegarde - Moteur settings - OK";
            richTextBox_save.Text += "\nSauvegarde - Sensor and I/O settings...";
            byte_array_save_data_4800 = save_data(0x4800, 0x15);
            richTextBox_save.Text += "\nSauvegarde - Sensor and I/O settings - OK";
            richTextBox_save.Text += "\nSauvegarde - Application module settings...";
            byte_array_save_data_4900 = save_data(0x4900, 0x5);
            richTextBox_save.Text += "\nSauvegarde - Application module settings - OK";
            richTextBox_save.Text += "\nSauvegarde - Error behaviour settings...";
            byte_array_save_data_4A00 = save_data(0x4A00, 0x6);
            richTextBox_save.Text += "\nSauvegarde - Error behaviour settings - OK";
            richTextBox_save.Text += "\nSauvegarde effectué ";
        }

        private byte[][] save_data(int attribute, int length)
        {

            var tab_save_data = new byte[length][];
            tab_save_data[0] = BitConverter.GetBytes(attribute);

            for (int i = 1; i < length; i++)
            {
                tab_save_data[i] = Read_SDO(attribute + i);
            }

            return tab_save_data;
        }

        private void BP_upload()
        {
            if (byte_array_save_data_4700[0] == null)
            {
                richTextBox_save.Text += "\nMultiControl non sauvegardé";
            }
            else
            {
                send_upload(byte_array_save_data_4700);
                send_upload(byte_array_save_data_4800);
                send_upload(byte_array_save_data_4900);
                send_upload(byte_array_save_data_4A00);
            }

        }

        private void send_upload(byte[][] save)
        {
            System.Diagnostics.Debug.Write($"\nIndex 0x{BitConverter.ToInt32(save[0], 0):X}:");
            for (int i = 1; i < save.Length; i++)
            {
                System.Diagnostics.Debug.Write("\nfor " + i.ToString() + ":");

                for (int o = 0; o < save[i].Length; o++)
                {
                    System.Diagnostics.Debug.Write(save[i][o].ToString());

                    if (o + 1 < save[i].Length)
                        System.Diagnostics.Debug.Write(" | ");
                }

                send_SDO(save[i], BitConverter.ToInt32(save[0], 0) + i);
            }
        }


        #endregion

        #region tabpage transfert


        private void BP_Position_Click(object sender, EventArgs e)
        {
            position_transfert();
        }

        private void BP_prog_Click(object sender, EventArgs e)
        {
            prog_transfert();
        }

        private void BP_Initialisation_Click(object sender, EventArgs e)
        {
            Initialisation_transfert();
        }

        #endregion

        #region tabpage transfert Méthodes

        private void Initialisation_transfert()
        {
            BitArray MC_bits_MC_T_O_0 = new BitArray(new byte[] { MC.T_O_IOData[0] });

            while (MC_bits_MC_T_O_0[0] == false)
            {
                System.Diagnostics.Debug.WriteLine("in while else");
                MC.O_T_IOData[1] = 50;
                MC_bits_MC_T_O_0 = new BitArray(new byte[] { MC.T_O_IOData[0] });
            }
            MC.O_T_IOData[1] = 0;
        }
        private void position_transfert()
        {

            BitArray MC_bits_MC_T_O_0 = new BitArray(new byte[] { MC.T_O_IOData[0] });

            System.Diagnostics.Debug.WriteLine(MC_bits_MC_T_O_0[0]);

            // 192.168.1.31
            if (MC_bits_MC_T_O_0[0] != false)
            {
                // System.Diagnostics.Debug.WriteLine("in if");
                while (MC_bits_MC_T_O_0[0] != false)
                {

                    System.Diagnostics.Debug.WriteLine("in while if");
                    MC.O_T_IOData[1] = 50;
                    MC_bits_MC_T_O_0 = new BitArray(new byte[] { MC.T_O_IOData[0] });
                }
                MC.O_T_IOData[1] = 0;
            }
            else
            {
                // System.Diagnostics.Debug.WriteLine("in else");
                while (MC_bits_MC_T_O_0[0] == false)
                {
                    System.Diagnostics.Debug.WriteLine("in while else");
                    MC.O_T_IOData[1] = 50;
                    MC_bits_MC_T_O_0 = new BitArray(new byte[] { MC.T_O_IOData[0] });
                }
                MC.O_T_IOData[1] = 0;
            }

        }
        private void prog_transfert()
        {
            Initialisation_transfert();
            position_transfert();
            MC.O_T_IOData[2] = 100;
            Thread.Sleep(2000);
            MC.O_T_IOData[2] = 0;
            Change_clock(2);
            MC.O_T_IOData[2] = 100;
            Thread.Sleep(2000);
            MC.O_T_IOData[2] = 0;
            Initialisation_transfert();
        }

        #endregion

        #region tabpage transfert Poséidon 

        private void BP_position_P_Click(object sender, EventArgs e)
        {
            position_transfert_P();
        }

        private void BP_initialisation_P_Click(object sender, EventArgs e)
        {
            Initialisation_transfert_P();
        }

        private void BP_prog_P_Click(object sender, EventArgs e)
        {
            prog_transfert_P();
        }

        #endregion

        #region tabpage transfert Poséidon Méthodes
        private void Initialisation_transfert_P()
        {
            BitArray MC_bits_MC_T_O_0 = new BitArray(new byte[] { MC.T_O_IOData[0] });

            while (MC_bits_MC_T_O_0[0] == false)
            {
                // System.Diagnostics.Debug.WriteLine("in while else");
                MC.O_T_IOData[1] = 50;
                MC_bits_MC_T_O_0 = new BitArray(new byte[] { MC.T_O_IOData[0] });
            }
            MC.O_T_IOData[1] = 0;
        }
        private void position_transfert_P()
        {

            BitArray MC_bits_MC_T_O_0 = new BitArray(new byte[] { MC.T_O_IOData[0] });

            // System.Diagnostics.Debug.WriteLine(MC_bits_MC_T_O_0[0]);

            if (MC_bits_MC_T_O_0[0] != false)
            {
                // System.Diagnostics.Debug.WriteLine("in if");
                while (MC_bits_MC_T_O_0[0] != false)
                {

                    // System.Diagnostics.Debug.WriteLine("in while if");
                    MC.O_T_IOData[1] = 50;
                    MC_bits_MC_T_O_0 = new BitArray(new byte[] { MC.T_O_IOData[0] });
                }
                MC.O_T_IOData[1] = 0;
            }
            else
            {
                // System.Diagnostics.Debug.WriteLine("in else");
                while (MC_bits_MC_T_O_0[0] == false)
                {
                    // System.Diagnostics.Debug.WriteLine("in while else");
                    MC.O_T_IOData[1] = 50;
                    MC_bits_MC_T_O_0 = new BitArray(new byte[] { MC.T_O_IOData[0] });
                }
                MC.O_T_IOData[1] = 0;
            }

        }
        private void prog_transfert_P()
        {
            Initialisation_transfert();
            position_transfert();
            MC.O_T_IOData[3] = 100;
            Thread.Sleep(2000);
            MC.O_T_IOData[3] = 0;
            Thread.Sleep(500);
            Change_clock(2);
            Thread.Sleep(500);
            MC.O_T_IOData[3] = 100;
            Thread.Sleep(2000);
            MC.O_T_IOData[3] = 0;
            Initialisation_transfert_P();
        }

        #endregion

        #region tabpage HPD

        private void BP_InitialisationHPD_Click(object sender, EventArgs e)
        {
            homingOrTimeout(1, TimeSpan.FromMilliseconds(500));
            HPD_motor_1.Value = 0;
        }

        #endregion

        #region tabpage HPD Méthodes



        #endregion

        #region tabpage HPD Poséidon
        private void BP_Initialisation_HPD_P_Click(object sender, EventArgs e)
        {
            homingOrTimeout(1, TimeSpan.FromMilliseconds(500));
            HPD_P_motor_1.Value = 0;
        }
        #endregion

        #region tabpage HPD Poséidon Méthodes

        #endregion

        #region Méthodes
        // Setup  
        public class states_combo
        {
            public byte ID { get; set; }
            public string Name { get; set; }

        }       // Pour setup ComboBox 

        // Conversions 
        byte ConvertToByte(BitArray bits)  // Convert To Byte
        {
            if (bits.Count != 8)
            {
                throw new ArgumentException("bits");
            }
            byte[] bytes = new byte[1];
            bits.CopyTo(bytes, 0);
            return bytes[0];
        }
        private void homingOrTimeout(int n_motor, TimeSpan timeSpan)
        {
            int elapsed = 0;
            bool success = false;
            while ((!success) && (elapsed < timeSpan.TotalMilliseconds))
            {
                // System.Diagnostics.Debug.WriteLine((Convert.ToString(MC.T_O_IOData[1], toBase: 2).PadRight(8, '0')));

                Thread.Sleep(20);
                elapsed += 20;


                MC.O_T_IOData[n_motor] = 127;

                if (MC.T_O_IOData[n_motor + 2] == 0)
                {
                    success = true;
                }

            }

        }  // homing hpd 

        private void Change_clock(int n_motor)
        {
            byte[] Motor_clock = Read_SDO(0x4704 + n_motor);
            // System.Diagnostics.Debug.WriteLine(Motor_clock[0]);
            if (Motor_clock[0] == 0)
            {
                send_SDO(BitConverter.GetBytes(1), 0x4704 + n_motor);
                // .Text = "Clockwise";
            }
            else
            {
                send_SDO(BitConverter.GetBytes(0), 0x4704 + n_motor);
                // .Text = "Counterclockwise";
            }

        }  // changer le sens de rotation moteur
        #endregion

        #region Conversion SDO to ...
        // Read
        public Byte[]? Read_SDO(int attribut = 0x1)
        {
            try
            {
                byte[] return_SDO = MC.GetAttributeSingle(0x64, 1, attribut);
                return return_SDO;
            }
            catch
            {
                try
                {
                    MC.ForwardClose();
                    MC.UnRegisterSession();
                    MC.RegisterSession();
                    MC.ForwardOpen();

                    byte[] return_SDO = MC.GetAttributeSingle(0x64, 1, attribut);
                    return return_SDO;
                }
                catch
                {
                    MessageBox.Show(Text = "Error SDO\nMultiControl indétectable", "Error");
                    return null;
                }
                return null;
            }


        }  // Read SDO send to byte[]
        public bool Read_SDO_Bool(int attribut = 0x1)
        {
            byte[] SDO_byte_array = Read_SDO(attribut);
            bool var_bool = BitConverter.ToBoolean(SDO_byte_array);
            return var_bool;
        }  // Read SDO send to bool
        public int Read_SDO_int8(int attribut = 0x1)
        {
            byte[] SDO_byte_array = Read_SDO(attribut);
            var return_SDO_int = SDO_byte_array[0];
            return return_SDO_int;
        }  // Read SDO send to int (for 1 byte)
        public int Read_SDO_int16(int attribut = 0x1)
        {
            byte[] SDO_byte_array = Read_SDO(attribut);
            if (bool_BigEndian == true)
            {
                // if Big Endian
                int return_SDO_int = (SDO_byte_array[0] << 8) | SDO_byte_array[1];
                return return_SDO_int;
            }
            else
            {
                // if Little Endian
                int return_SDO_int = SDO_byte_array[0] | (SDO_byte_array[1] << 8);
                return return_SDO_int;
            }

        }  // Read SDO send to int (for 2 bytes)
        public uint Read_SDO_Uint16(int attribut = 0x1)
        {
            byte[] SDO_byte_array = Read_SDO(attribut);
            if (bool_BigEndian == true)
            {
                uint return_SDO_int = BitConverter.ToUInt16(SDO_byte_array, 0);                   // (SDO_byte_array[0] << 8) | SDO_byte_array[0 + 1];
                return return_SDO_int;
            }
            else
            {
                Array.Reverse(SDO_byte_array);
                uint return_SDO_int = BitConverter.ToUInt16(SDO_byte_array, 0);
                return return_SDO_int;
            } // Read SDO send to usingned int (for 2 bytes)
        }  // Pas utilisé
        public string Read_SDO_string(int attribut = 0x1)
        {
            byte[] return_SDO = Read_SDO(attribut);
            string return_SDO_string = (return_SDO[return_SDO.Length - 1]).ToString();
            return return_SDO_string;
        }  // Read SDO send to string
        public string Read_SDO_char(int attribut = 0x1)
        {

            byte[] return_SDO = Read_SDO(attribut);
            string return_SDO_string = null;

            for (int i = 0; i < return_SDO.Length; i++)
            {
                return_SDO_string = return_SDO_string + (char)return_SDO[i];
            }
            return return_SDO_string;

        }  // Read SDO send to string

        // Send 
        public void send_SDO(byte[] value, int attribut = 0x1)
        {
            try
            {
                MC.SetAttributeSingle(0x64, 1, attribut, value);
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("catch send SDO");
                try
                {
                    MC.ForwardClose();
                    MC.UnRegisterSession();
                    MC.RegisterSession();
                    MC.ForwardOpen();

                    MC.SetAttributeSingle(0x64, 1, attribut, value);
                }
                catch
                {
                    System.Diagnostics.Debug.WriteLine("catch send SDO part 2");
                    MessageBox.Show(Text = "Error SDO\nMultiControl indétectable", "Error");
                }
            }

        }  // send SDO need byte[] with error
        public void send_SDO_without_errors(byte[] value, int attribut = 0x1)
        {

            MC.SetAttributeSingle(0x64, 1, attribut, value);

        }  // send SDO need byte[]
        public void send_SDO_array_without_errors(byte[] value, int attribut = 0x1)
        {
            MC.SetAttributeSingle(0x64, 1, attribut, value);

        }  // send SDO need byte[]



        #endregion

        
    }
}