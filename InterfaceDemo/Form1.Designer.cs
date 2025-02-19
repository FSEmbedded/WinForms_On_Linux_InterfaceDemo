
namespace InterfaceDemo
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPageUART = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbUartSender = new System.Windows.Forms.ComboBox();
            this.btnGetSerialPorts = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.lblUartRead = new System.Windows.Forms.Label();
            this.cbUartParity = new System.Windows.Forms.ComboBox();
            this.cbUartStopBit = new System.Windows.Forms.ComboBox();
            this.cbUartHandshake = new System.Windows.Forms.ComboBox();
            this.cbUartBaudrate = new System.Windows.Forms.ComboBox();
            this.cbUartDataBit = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tbUartWriteData = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnUart = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.tabPageSPI = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnNativeSpi = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lblSpiRead = new System.Windows.Forms.Label();
            this.tbSpiDev = new System.Windows.Forms.TextBox();
            this.tbSpiWriteData = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSpiV1Read = new System.Windows.Forms.Label();
            this.btnNativeSpiV1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSpiV1WriteData = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbSpiV1Dev = new System.Windows.Forms.TextBox();
            this.tabPageI2C = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.btnI2c = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbI2cDev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbI2cData1 = new System.Windows.Forms.TextBox();
            this.tbI2cDevAddr = new System.Windows.Forms.TextBox();
            this.tbI2cData2 = new System.Windows.Forms.TextBox();
            this.tbI2cData0 = new System.Windows.Forms.TextBox();
            this.tbI2cFlags = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.checkBoxDbgMsg = new System.Windows.Forms.CheckBox();
            this.cbUartReceiver = new System.Windows.Forms.ComboBox();
            this.lblSpiDescription = new System.Windows.Forms.Label();
            this.lblI2cDescription = new System.Windows.Forms.Label();
            this.lblUartDescription = new System.Windows.Forms.Label();
            this.lblUartResult = new System.Windows.Forms.Label();
            this.lblSpiResult = new System.Windows.Forms.Label();
            this.lblSpiV1Result = new System.Windows.Forms.Label();
            this.tabPageUART.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPageSPI.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPageI2C.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageUART
            // 
            this.tabPageUART.Controls.Add(this.lblUartDescription);
            this.tabPageUART.Controls.Add(this.panel5);
            this.tabPageUART.Location = new System.Drawing.Point(4, 25);
            this.tabPageUART.Name = "tabPageUART";
            this.tabPageUART.Size = new System.Drawing.Size(792, 420);
            this.tabPageUART.Text = "UART";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.lblUartResult);
            this.panel5.Controls.Add(this.cbUartReceiver);
            this.panel5.Controls.Add(this.cbUartSender);
            this.panel5.Controls.Add(this.btnGetSerialPorts);
            this.panel5.Controls.Add(this.label25);
            this.panel5.Controls.Add(this.lblUartRead);
            this.panel5.Controls.Add(this.cbUartParity);
            this.panel5.Controls.Add(this.cbUartStopBit);
            this.panel5.Controls.Add(this.cbUartHandshake);
            this.panel5.Controls.Add(this.cbUartBaudrate);
            this.panel5.Controls.Add(this.cbUartDataBit);
            this.panel5.Controls.Add(this.label22);
            this.panel5.Controls.Add(this.label23);
            this.panel5.Controls.Add(this.tbUartWriteData);
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.btnUart);
            this.panel5.Controls.Add(this.label24);
            this.panel5.Controls.Add(this.label26);
            this.panel5.Controls.Add(this.label28);
            this.panel5.Controls.Add(this.label30);
            this.panel5.Controls.Add(this.label32);
            this.panel5.Controls.Add(this.label33);
            this.panel5.Location = new System.Drawing.Point(40, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(712, 287);
            // 
            // cbUartSender
            // 
            this.cbUartSender.Location = new System.Drawing.Point(269, 31);
            this.cbUartSender.Name = "cbUartSender";
            this.cbUartSender.Size = new System.Drawing.Size(150, 23);
            this.cbUartSender.TabIndex = 1;
            // 
            // btnGetSerialPorts
            // 
            this.btnGetSerialPorts.Location = new System.Drawing.Point(49, 32);
            this.btnGetSerialPorts.Name = "btnGetSerialPorts";
            this.btnGetSerialPorts.Size = new System.Drawing.Size(144, 20);
            this.btnGetSerialPorts.TabIndex = 0;
            this.btnGetSerialPorts.Text = "Get Serial Ports";
            this.btnGetSerialPorts.Click += new System.EventHandler(this.btnGetSerialPorts_Click);
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(347, 187);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(72, 20);
            this.label25.Text = "Data Read";
            // 
            // lblUartRead
            // 
            this.lblUartRead.Location = new System.Drawing.Point(425, 187);
            this.lblUartRead.Name = "lblUartRead";
            this.lblUartRead.Size = new System.Drawing.Size(242, 57);
            this.lblUartRead.Text = "value";
            // 
            // cbUartParity
            // 
            this.cbUartParity.Location = new System.Drawing.Point(347, 129);
            this.cbUartParity.Name = "cbUartParity";
            this.cbUartParity.Size = new System.Drawing.Size(100, 23);
            this.cbUartParity.TabIndex = 7;
            // 
            // cbUartStopBit
            // 
            this.cbUartStopBit.Location = new System.Drawing.Point(347, 84);
            this.cbUartStopBit.Name = "cbUartStopBit";
            this.cbUartStopBit.Size = new System.Drawing.Size(100, 23);
            this.cbUartStopBit.TabIndex = 4;
            // 
            // cbUartHandshake
            // 
            this.cbUartHandshake.Location = new System.Drawing.Point(127, 129);
            this.cbUartHandshake.Name = "cbUartHandshake";
            this.cbUartHandshake.Size = new System.Drawing.Size(100, 23);
            this.cbUartHandshake.TabIndex = 6;
            // 
            // cbUartBaudrate
            // 
            this.cbUartBaudrate.Location = new System.Drawing.Point(567, 84);
            this.cbUartBaudrate.Name = "cbUartBaudrate";
            this.cbUartBaudrate.Size = new System.Drawing.Size(100, 23);
            this.cbUartBaudrate.TabIndex = 5;
            // 
            // cbUartDataBit
            // 
            this.cbUartDataBit.Location = new System.Drawing.Point(127, 87);
            this.cbUartDataBit.Name = "cbUartDataBit";
            this.cbUartDataBit.Size = new System.Drawing.Size(100, 23);
            this.cbUartDataBit.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(49, 132);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 20);
            this.label22.Text = "Handshake";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(46, 187);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 20);
            this.label23.Text = "Data Write";
            // 
            // tbUartWriteData
            // 
            this.tbUartWriteData.Location = new System.Drawing.Point(124, 184);
            this.tbUartWriteData.Name = "tbUartWriteData";
            this.tbUartWriteData.Size = new System.Drawing.Size(150, 23);
            this.tbUartWriteData.TabIndex = 8;
            this.tbUartWriteData.Text = "Hello World";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 20);
            this.label21.Text = "UART";
            // 
            // btnUart
            // 
            this.btnUart.Location = new System.Drawing.Point(46, 235);
            this.btnUart.Name = "btnUart";
            this.btnUart.Size = new System.Drawing.Size(147, 23);
            this.btnUart.TabIndex = 9;
            this.btnUart.Text = "Read / Write UART";
            this.btnUart.Click += new System.EventHandler(this.btnUart_Click);
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(49, 87);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(72, 20);
            this.label24.Text = "Data Bit";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(489, 87);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(72, 20);
            this.label26.Text = "Baudrate";
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(449, 32);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(74, 20);
            this.label28.Text = "Receiver";
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(269, 132);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(72, 20);
            this.label30.Text = "Parity";
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(269, 87);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(72, 20);
            this.label32.Text = "Stop Bit";
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(210, 31);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(64, 20);
            this.label33.Text = "Sender";
            // 
            // tabPageSPI
            // 
            this.tabPageSPI.Controls.Add(this.lblSpiDescription);
            this.tabPageSPI.Controls.Add(this.panel2);
            this.tabPageSPI.Controls.Add(this.panel1);
            this.tabPageSPI.Location = new System.Drawing.Point(4, 25);
            this.tabPageSPI.Name = "tabPageSPI";
            this.tabPageSPI.Size = new System.Drawing.Size(792, 420);
            this.tabPageSPI.Text = "SPI";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.lblSpiResult);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.btnNativeSpi);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.lblSpiRead);
            this.panel2.Controls.Add(this.tbSpiDev);
            this.panel2.Controls.Add(this.tbSpiWriteData);
            this.panel2.Location = new System.Drawing.Point(57, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 230);
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 20);
            this.label18.Text = "NativeSPI";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(20, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 20);
            this.label19.Text = "Data Read";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(20, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 20);
            this.label17.Text = "SPI Dev";
            // 
            // btnNativeSpi
            // 
            this.btnNativeSpi.Location = new System.Drawing.Point(20, 180);
            this.btnNativeSpi.Name = "btnNativeSpi";
            this.btnNativeSpi.Size = new System.Drawing.Size(134, 23);
            this.btnNativeSpi.TabIndex = 3;
            this.btnNativeSpi.Text = "NativeSPI Test";
            this.btnNativeSpi.Click += new System.EventHandler(this.btnNativeSpi_Click);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(20, 75);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 20);
            this.label16.Text = "Data Write";
            // 
            // lblSpiRead
            // 
            this.lblSpiRead.Location = new System.Drawing.Point(98, 120);
            this.lblSpiRead.Name = "lblSpiRead";
            this.lblSpiRead.Size = new System.Drawing.Size(162, 57);
            this.lblSpiRead.Text = "value";
            // 
            // tbSpiDev
            // 
            this.tbSpiDev.Location = new System.Drawing.Point(98, 27);
            this.tbSpiDev.Name = "tbSpiDev";
            this.tbSpiDev.Size = new System.Drawing.Size(100, 23);
            this.tbSpiDev.TabIndex = 1;
            this.tbSpiDev.Text = "SPI1:";
            // 
            // tbSpiWriteData
            // 
            this.tbSpiWriteData.Location = new System.Drawing.Point(98, 72);
            this.tbSpiWriteData.Name = "tbSpiWriteData";
            this.tbSpiWriteData.Size = new System.Drawing.Size(100, 23);
            this.tbSpiWriteData.TabIndex = 2;
            this.tbSpiWriteData.Text = "Hello World";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblSpiV1Result);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblSpiV1Read);
            this.panel1.Controls.Add(this.btnNativeSpiV1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.tbSpiV1WriteData);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.tbSpiV1Dev);
            this.panel1.Location = new System.Drawing.Point(455, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 230);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(20, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.Text = "Data Read";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 20);
            this.label12.Text = "NativeSPI-V1";
            // 
            // lblSpiV1Read
            // 
            this.lblSpiV1Read.Location = new System.Drawing.Point(98, 119);
            this.lblSpiV1Read.Name = "lblSpiV1Read";
            this.lblSpiV1Read.Size = new System.Drawing.Size(162, 57);
            this.lblSpiV1Read.Text = "value";
            // 
            // btnNativeSpiV1
            // 
            this.btnNativeSpiV1.Location = new System.Drawing.Point(20, 179);
            this.btnNativeSpiV1.Name = "btnNativeSpiV1";
            this.btnNativeSpiV1.Size = new System.Drawing.Size(134, 23);
            this.btnNativeSpiV1.TabIndex = 6;
            this.btnNativeSpiV1.Text = "NativeSPI-V1 Test";
            this.btnNativeSpiV1.Click += new System.EventHandler(this.btnNativeSpiV1_Click);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(20, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 20);
            this.label15.Text = "SPI Dev";
            // 
            // tbSpiV1WriteData
            // 
            this.tbSpiV1WriteData.Location = new System.Drawing.Point(98, 71);
            this.tbSpiV1WriteData.Name = "tbSpiV1WriteData";
            this.tbSpiV1WriteData.Size = new System.Drawing.Size(100, 23);
            this.tbSpiV1WriteData.TabIndex = 5;
            this.tbSpiV1WriteData.Text = "Hello World";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(20, 74);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 20);
            this.label14.Text = "Data Write";
            // 
            // tbSpiV1Dev
            // 
            this.tbSpiV1Dev.Location = new System.Drawing.Point(98, 29);
            this.tbSpiV1Dev.Name = "tbSpiV1Dev";
            this.tbSpiV1Dev.Size = new System.Drawing.Size(100, 23);
            this.tbSpiV1Dev.TabIndex = 4;
            this.tbSpiV1Dev.Text = "SPI2:";
            // 
            // tabPageI2C
            // 
            this.tabPageI2C.Controls.Add(this.lblI2cDescription);
            this.tabPageI2C.Controls.Add(this.panel3);
            this.tabPageI2C.Location = new System.Drawing.Point(4, 25);
            this.tabPageI2C.Name = "tabPageI2C";
            this.tabPageI2C.Size = new System.Drawing.Size(792, 420);
            this.tabPageI2C.Text = "I2C";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.btnI2c);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbI2cDev);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.tbI2cData1);
            this.panel3.Controls.Add(this.tbI2cDevAddr);
            this.panel3.Controls.Add(this.tbI2cData2);
            this.panel3.Controls.Add(this.tbI2cData0);
            this.panel3.Controls.Add(this.tbI2cFlags);
            this.panel3.Location = new System.Drawing.Point(123, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(547, 220);
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 20);
            this.label20.Text = "NativeI2C";
            // 
            // btnI2c
            // 
            this.btnI2c.Location = new System.Drawing.Point(46, 175);
            this.btnI2c.Name = "btnI2c";
            this.btnI2c.Size = new System.Drawing.Size(134, 23);
            this.btnI2c.TabIndex = 7;
            this.btnI2c.Text = "Write I2C Data";
            this.btnI2c.Click += new System.EventHandler(this.btnI2c_Click);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(482, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 20);
            this.label11.Text = "0x";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.Text = "DevAddr";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(482, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 20);
            this.label10.Text = "0x";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(46, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.Text = "Flags";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(230, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 20);
            this.label9.Text = "0x";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(298, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.Text = "Data[0]";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(230, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 20);
            this.label8.Text = "0x";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(298, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.Text = "Data[2]";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(482, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 20);
            this.label7.Text = "0x";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(298, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.Text = "Data[1]";
            // 
            // tbI2cDev
            // 
            this.tbI2cDev.Location = new System.Drawing.Point(124, 22);
            this.tbI2cDev.Name = "tbI2cDev";
            this.tbI2cDev.Size = new System.Drawing.Size(100, 23);
            this.tbI2cDev.TabIndex = 1;
            this.tbI2cDev.Text = "I2C2:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(46, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.Text = "I2C Dev";
            // 
            // tbI2cData1
            // 
            this.tbI2cData1.Location = new System.Drawing.Point(376, 70);
            this.tbI2cData1.Name = "tbI2cData1";
            this.tbI2cData1.Size = new System.Drawing.Size(100, 23);
            this.tbI2cData1.TabIndex = 5;
            this.tbI2cData1.Text = "00";
            // 
            // tbI2cDevAddr
            // 
            this.tbI2cDevAddr.Location = new System.Drawing.Point(124, 67);
            this.tbI2cDevAddr.Name = "tbI2cDevAddr";
            this.tbI2cDevAddr.Size = new System.Drawing.Size(100, 23);
            this.tbI2cDevAddr.TabIndex = 2;
            this.tbI2cDevAddr.Text = "23";
            // 
            // tbI2cData2
            // 
            this.tbI2cData2.Location = new System.Drawing.Point(376, 112);
            this.tbI2cData2.Name = "tbI2cData2";
            this.tbI2cData2.Size = new System.Drawing.Size(100, 23);
            this.tbI2cData2.TabIndex = 6;
            this.tbI2cData2.Text = "00";
            // 
            // tbI2cData0
            // 
            this.tbI2cData0.Location = new System.Drawing.Point(376, 22);
            this.tbI2cData0.Name = "tbI2cData0";
            this.tbI2cData0.Size = new System.Drawing.Size(100, 23);
            this.tbI2cData0.TabIndex = 4;
            this.tbI2cData0.Text = "02";
            // 
            // tbI2cFlags
            // 
            this.tbI2cFlags.Location = new System.Drawing.Point(124, 112);
            this.tbI2cFlags.Name = "tbI2cFlags";
            this.tbI2cFlags.Size = new System.Drawing.Size(100, 23);
            this.tbI2cFlags.TabIndex = 3;
            this.tbI2cFlags.Text = "00";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageI2C);
            this.tabControl.Controls.Add(this.tabPageSPI);
            this.tabControl.Controls.Add(this.tabPageUART);
            this.tabControl.Controls.Add(this.tabPageSettings);
            this.tabControl.Location = new System.Drawing.Point(1, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 449);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.checkBoxDbgMsg);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 25);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(792, 420);
            this.tabPageSettings.Text = "Settings";
            // 
            // checkBoxDbgMsg
            // 
            this.checkBoxDbgMsg.Location = new System.Drawing.Point(25, 31);
            this.checkBoxDbgMsg.Name = "checkBoxDbgMsg";
            this.checkBoxDbgMsg.Size = new System.Drawing.Size(271, 20);
            this.checkBoxDbgMsg.TabIndex = 23;
            this.checkBoxDbgMsg.Text = "Show Debug Messages on Serial Port";
            this.checkBoxDbgMsg.CheckStateChanged += new System.EventHandler(this.checkBoxDbgMsg_CheckStateChanged);
            // 
            // cbUartReceiver
            // 
            this.cbUartReceiver.Location = new System.Drawing.Point(517, 31);
            this.cbUartReceiver.Name = "cbUartReceiver";
            this.cbUartReceiver.Size = new System.Drawing.Size(150, 23);
            this.cbUartReceiver.TabIndex = 2;
            // 
            // lblSpiDescription
            // 
            this.lblSpiDescription.Location = new System.Drawing.Point(57, 280);
            this.lblSpiDescription.Name = "lblSpiDescription";
            this.lblSpiDescription.Size = new System.Drawing.Size(678, 125);
            this.lblSpiDescription.Text = "Description";
            // 
            // lblI2cDescription
            // 
            this.lblI2cDescription.Location = new System.Drawing.Point(123, 275);
            this.lblI2cDescription.Name = "lblI2cDescription";
            this.lblI2cDescription.Size = new System.Drawing.Size(547, 125);
            this.lblI2cDescription.Text = "Description";
            // 
            // lblUartDescription
            // 
            this.lblUartDescription.Location = new System.Drawing.Point(40, 321);
            this.lblUartDescription.Name = "lblUartDescription";
            this.lblUartDescription.Size = new System.Drawing.Size(712, 84);
            this.lblUartDescription.Text = "Description";
            // 
            // lblUartResult
            // 
            this.lblUartResult.Location = new System.Drawing.Point(199, 238);
            this.lblUartResult.Name = "lblUartResult";
            this.lblUartResult.Size = new System.Drawing.Size(134, 20);
            this.lblUartResult.Text = "Result";
            // 
            // lblSpiResult
            // 
            this.lblSpiResult.Location = new System.Drawing.Point(160, 183);
            this.lblSpiResult.Name = "lblSpiResult";
            this.lblSpiResult.Size = new System.Drawing.Size(100, 20);
            this.lblSpiResult.Text = "Result";
            // 
            // lblSpiV1Result
            // 
            this.lblSpiV1Result.Location = new System.Drawing.Point(160, 183);
            this.lblSpiV1Result.Name = "lblSpiV1Result";
            this.lblSpiV1Result.Size = new System.Drawing.Size(100, 20);
            this.lblSpiV1Result.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Interface Demo";
            this.tabPageUART.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tabPageSPI.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPageI2C.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageUART;
        private System.Windows.Forms.TabPage tabPageSPI;
        private System.Windows.Forms.Label lblSpiRead;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbSpiWriteData;
        private System.Windows.Forms.TextBox tbSpiDev;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabPageI2C;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbI2cDev;
        private System.Windows.Forms.TextBox tbI2cData1;
        private System.Windows.Forms.TextBox tbI2cData2;
        private System.Windows.Forms.TextBox tbI2cFlags;
        private System.Windows.Forms.TextBox tbI2cData0;
        private System.Windows.Forms.TextBox tbI2cDevAddr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnI2c;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button btnNativeSpi;
        private System.Windows.Forms.Button btnNativeSpiV1;
        private System.Windows.Forms.Label lblSpiV1Read;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbSpiV1WriteData;
        private System.Windows.Forms.TextBox tbSpiV1Dev;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.CheckBox checkBoxDbgMsg;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbUartWriteData;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnUart;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox cbUartParity;
        private System.Windows.Forms.ComboBox cbUartStopBit;
        private System.Windows.Forms.ComboBox cbUartHandshake;
        private System.Windows.Forms.ComboBox cbUartBaudrate;
        private System.Windows.Forms.ComboBox cbUartDataBit;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblUartRead;
        private System.Windows.Forms.Button btnGetSerialPorts;
        private System.Windows.Forms.ComboBox cbUartSender;
        private System.Windows.Forms.ComboBox cbUartReceiver;
        private System.Windows.Forms.Label lblSpiDescription;
        private System.Windows.Forms.Label lblI2cDescription;
        private System.Windows.Forms.Label lblUartDescription;
        private System.Windows.Forms.Label lblUartResult;
        private System.Windows.Forms.Label lblSpiResult;
        private System.Windows.Forms.Label lblSpiV1Result;
    }
}

