namespace RemoteFlightController
{
    partial class RemoteFlightController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteFlightController));
            this.gbxConnectionSettings = new System.Windows.Forms.GroupBox();
            this.lblCurrentConnection = new System.Windows.Forms.Label();
            this.lblCurrentConnectionTitle = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvTelemetryUpdates = new System.Windows.Forms.DataGridView();
            this.gbxPlaneControls = new System.Windows.Forms.GroupBox();
            this.btnSendControls = new System.Windows.Forms.Button();
            this.lblElevationController = new System.Windows.Forms.Label();
            this.lblThrottleController = new System.Windows.Forms.Label();
            this.tbrElevationController = new System.Windows.Forms.TrackBar();
            this.lblElevationCurrentValue = new System.Windows.Forms.Label();
            this.tbrThrottleController = new System.Windows.Forms.TrackBar();
            this.lblThrottleCurrentValue = new System.Windows.Forms.Label();
            this.gbxTelemetry = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxWarning = new System.Windows.Forms.GroupBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.gbxSentData = new System.Windows.Forms.GroupBox();
            this.lblSentElevatorPitchValue = new System.Windows.Forms.Label();
            this.lblSentThrottleValue = new System.Windows.Forms.Label();
            this.lblSentElevatorPitch = new System.Windows.Forms.Label();
            this.lblSentThrottle = new System.Windows.Forms.Label();
            this.gbxFileSettings = new System.Windows.Forms.GroupBox();
            this.chkEnableWriting = new System.Windows.Forms.CheckBox();
            this.clnAltidude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAngle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnVertSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnThrottle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnElevator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnWarning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxConnectionSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelemetryUpdates)).BeginInit();
            this.gbxPlaneControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrElevationController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrThrottleController)).BeginInit();
            this.gbxTelemetry.SuspendLayout();
            this.gbxWarning.SuspendLayout();
            this.gbxSentData.SuspendLayout();
            this.gbxFileSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxConnectionSettings
            // 
            this.gbxConnectionSettings.Controls.Add(this.lblCurrentConnection);
            this.gbxConnectionSettings.Controls.Add(this.lblCurrentConnectionTitle);
            this.gbxConnectionSettings.Controls.Add(this.btnConnect);
            this.gbxConnectionSettings.Controls.Add(this.lblPort);
            this.gbxConnectionSettings.Controls.Add(this.lblIPAddress);
            this.gbxConnectionSettings.Controls.Add(this.txtPort);
            this.gbxConnectionSettings.Controls.Add(this.txtIPAddress);
            this.gbxConnectionSettings.Location = new System.Drawing.Point(11, 39);
            this.gbxConnectionSettings.Name = "gbxConnectionSettings";
            this.gbxConnectionSettings.Size = new System.Drawing.Size(797, 54);
            this.gbxConnectionSettings.TabIndex = 0;
            this.gbxConnectionSettings.TabStop = false;
            this.gbxConnectionSettings.Text = "Connection Settings:";
            // 
            // lblCurrentConnection
            // 
            this.lblCurrentConnection.AutoSize = true;
            this.lblCurrentConnection.Location = new System.Drawing.Point(626, 26);
            this.lblCurrentConnection.Name = "lblCurrentConnection";
            this.lblCurrentConnection.Size = new System.Drawing.Size(79, 13);
            this.lblCurrentConnection.TabIndex = 3;
            this.lblCurrentConnection.Text = "Not Connected";
            // 
            // lblCurrentConnectionTitle
            // 
            this.lblCurrentConnectionTitle.AutoSize = true;
            this.lblCurrentConnectionTitle.Location = new System.Drawing.Point(520, 26);
            this.lblCurrentConnectionTitle.Name = "lblCurrentConnectionTitle";
            this.lblCurrentConnectionTitle.Size = new System.Drawing.Size(101, 13);
            this.lblCurrentConnectionTitle.TabIndex = 3;
            this.lblCurrentConnectionTitle.Text = "Current Connection:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(381, 21);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(133, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(208, 26);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Port";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(7, 26);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(58, 13);
            this.lblIPAddress.TabIndex = 1;
            this.lblIPAddress.Text = "IP Address";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(238, 23);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(127, 20);
            this.txtPort.TabIndex = 1;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(68, 23);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(127, 20);
            this.txtIPAddress.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(11, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 16);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Remote Flight Controller";
            // 
            // dgvTelemetryUpdates
            // 
            this.dgvTelemetryUpdates.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTelemetryUpdates.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTelemetryUpdates.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTelemetryUpdates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTelemetryUpdates.ColumnHeadersHeight = 50;
            this.dgvTelemetryUpdates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnAltidude,
            this.clnSpeed,
            this.clnAngle,
            this.clnVertSpeed,
            this.clnThrottle,
            this.clnElevator,
            this.clnWarning});
            this.dgvTelemetryUpdates.Enabled = false;
            this.dgvTelemetryUpdates.EnableHeadersVisualStyles = false;
            this.dgvTelemetryUpdates.GridColor = System.Drawing.SystemColors.Control;
            this.dgvTelemetryUpdates.Location = new System.Drawing.Point(1, 7);
            this.dgvTelemetryUpdates.Name = "dgvTelemetryUpdates";
            this.dgvTelemetryUpdates.ReadOnly = true;
            this.dgvTelemetryUpdates.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTelemetryUpdates.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTelemetryUpdates.ShowCellErrors = false;
            this.dgvTelemetryUpdates.ShowCellToolTips = false;
            this.dgvTelemetryUpdates.ShowEditingIcon = false;
            this.dgvTelemetryUpdates.ShowRowErrors = false;
            this.dgvTelemetryUpdates.Size = new System.Drawing.Size(784, 260);
            this.dgvTelemetryUpdates.TabIndex = 2;
            this.dgvTelemetryUpdates.TabStop = false;
            // 
            // gbxPlaneControls
            // 
            this.gbxPlaneControls.Controls.Add(this.btnSendControls);
            this.gbxPlaneControls.Controls.Add(this.lblElevationController);
            this.gbxPlaneControls.Controls.Add(this.lblThrottleController);
            this.gbxPlaneControls.Controls.Add(this.tbrElevationController);
            this.gbxPlaneControls.Controls.Add(this.lblElevationCurrentValue);
            this.gbxPlaneControls.Controls.Add(this.tbrThrottleController);
            this.gbxPlaneControls.Controls.Add(this.lblThrottleCurrentValue);
            this.gbxPlaneControls.Location = new System.Drawing.Point(11, 97);
            this.gbxPlaneControls.Name = "gbxPlaneControls";
            this.gbxPlaneControls.Size = new System.Drawing.Size(183, 271);
            this.gbxPlaneControls.TabIndex = 3;
            this.gbxPlaneControls.TabStop = false;
            this.gbxPlaneControls.Text = "Plane Controllers:";
            // 
            // btnSendControls
            // 
            this.btnSendControls.Enabled = false;
            this.btnSendControls.Location = new System.Drawing.Point(10, 238);
            this.btnSendControls.Name = "btnSendControls";
            this.btnSendControls.Size = new System.Drawing.Size(159, 23);
            this.btnSendControls.TabIndex = 6;
            this.btnSendControls.Text = "Send Controls";
            this.btnSendControls.UseVisualStyleBackColor = true;
            this.btnSendControls.Click += new System.EventHandler(this.btnSendControls_Click);
            // 
            // lblElevationController
            // 
            this.lblElevationController.AutoSize = true;
            this.lblElevationController.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElevationController.Location = new System.Drawing.Point(86, 30);
            this.lblElevationController.Name = "lblElevationController";
            this.lblElevationController.Size = new System.Drawing.Size(67, 16);
            this.lblElevationController.TabIndex = 5;
            this.lblElevationController.Text = "Elevation";
            // 
            // lblThrottleController
            // 
            this.lblThrottleController.AutoSize = true;
            this.lblThrottleController.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThrottleController.Location = new System.Drawing.Point(16, 30);
            this.lblThrottleController.Name = "lblThrottleController";
            this.lblThrottleController.Size = new System.Drawing.Size(57, 16);
            this.lblThrottleController.TabIndex = 5;
            this.lblThrottleController.Text = "Throttle";
            // 
            // tbrElevationController
            // 
            this.tbrElevationController.Enabled = false;
            this.tbrElevationController.Location = new System.Drawing.Point(106, 43);
            this.tbrElevationController.Maximum = 5;
            this.tbrElevationController.Minimum = -5;
            this.tbrElevationController.Name = "tbrElevationController";
            this.tbrElevationController.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrElevationController.Size = new System.Drawing.Size(45, 166);
            this.tbrElevationController.TabIndex = 5;
            this.tbrElevationController.Scroll += new System.EventHandler(this.tbrController_Scroll);
            // 
            // lblElevationCurrentValue
            // 
            this.lblElevationCurrentValue.AutoSize = true;
            this.lblElevationCurrentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElevationCurrentValue.Location = new System.Drawing.Point(111, 212);
            this.lblElevationCurrentValue.Name = "lblElevationCurrentValue";
            this.lblElevationCurrentValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblElevationCurrentValue.Size = new System.Drawing.Size(16, 16);
            this.lblElevationCurrentValue.TabIndex = 1;
            this.lblElevationCurrentValue.Text = "0";
            // 
            // tbrThrottleController
            // 
            this.tbrThrottleController.Enabled = false;
            this.tbrThrottleController.Location = new System.Drawing.Point(34, 43);
            this.tbrThrottleController.Maximum = 100;
            this.tbrThrottleController.Name = "tbrThrottleController";
            this.tbrThrottleController.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbrThrottleController.Size = new System.Drawing.Size(45, 166);
            this.tbrThrottleController.TabIndex = 4;
            this.tbrThrottleController.TickFrequency = 10;
            this.tbrThrottleController.Scroll += new System.EventHandler(this.tbrController_Scroll);
            // 
            // lblThrottleCurrentValue
            // 
            this.lblThrottleCurrentValue.AutoSize = true;
            this.lblThrottleCurrentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThrottleCurrentValue.Location = new System.Drawing.Point(39, 212);
            this.lblThrottleCurrentValue.Name = "lblThrottleCurrentValue";
            this.lblThrottleCurrentValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblThrottleCurrentValue.Size = new System.Drawing.Size(16, 16);
            this.lblThrottleCurrentValue.TabIndex = 1;
            this.lblThrottleCurrentValue.Text = "0";
            // 
            // gbxTelemetry
            // 
            this.gbxTelemetry.Controls.Add(this.dgvTelemetryUpdates);
            this.gbxTelemetry.Location = new System.Drawing.Point(193, 97);
            this.gbxTelemetry.Name = "gbxTelemetry";
            this.gbxTelemetry.Size = new System.Drawing.Size(786, 271);
            this.gbxTelemetry.TabIndex = 4;
            this.gbxTelemetry.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(903, 389);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbxWarning
            // 
            this.gbxWarning.Controls.Add(this.lblWarning);
            this.gbxWarning.Location = new System.Drawing.Point(11, 372);
            this.gbxWarning.Name = "gbxWarning";
            this.gbxWarning.Size = new System.Drawing.Size(386, 52);
            this.gbxWarning.TabIndex = 5;
            this.gbxWarning.TabStop = false;
            this.gbxWarning.Text = "Warning From Client:";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(10, 25);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(122, 14);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "No Warning Recieved";
            // 
            // gbxSentData
            // 
            this.gbxSentData.Controls.Add(this.lblSentElevatorPitchValue);
            this.gbxSentData.Controls.Add(this.lblSentThrottleValue);
            this.gbxSentData.Controls.Add(this.lblSentElevatorPitch);
            this.gbxSentData.Controls.Add(this.lblSentThrottle);
            this.gbxSentData.Location = new System.Drawing.Point(396, 372);
            this.gbxSentData.Name = "gbxSentData";
            this.gbxSentData.Size = new System.Drawing.Size(490, 52);
            this.gbxSentData.TabIndex = 6;
            this.gbxSentData.TabStop = false;
            this.gbxSentData.Text = "Sent Data:";
            // 
            // lblSentElevatorPitchValue
            // 
            this.lblSentElevatorPitchValue.AutoSize = true;
            this.lblSentElevatorPitchValue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentElevatorPitchValue.Location = new System.Drawing.Point(323, 25);
            this.lblSentElevatorPitchValue.Name = "lblSentElevatorPitchValue";
            this.lblSentElevatorPitchValue.Size = new System.Drawing.Size(13, 14);
            this.lblSentElevatorPitchValue.TabIndex = 1;
            this.lblSentElevatorPitchValue.Text = "0";
            // 
            // lblSentThrottleValue
            // 
            this.lblSentThrottleValue.AutoSize = true;
            this.lblSentThrottleValue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentThrottleValue.Location = new System.Drawing.Point(121, 25);
            this.lblSentThrottleValue.Name = "lblSentThrottleValue";
            this.lblSentThrottleValue.Size = new System.Drawing.Size(13, 14);
            this.lblSentThrottleValue.TabIndex = 1;
            this.lblSentThrottleValue.Text = "0";
            // 
            // lblSentElevatorPitch
            // 
            this.lblSentElevatorPitch.AutoSize = true;
            this.lblSentElevatorPitch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentElevatorPitch.Location = new System.Drawing.Point(175, 25);
            this.lblSentElevatorPitch.Name = "lblSentElevatorPitch";
            this.lblSentElevatorPitch.Size = new System.Drawing.Size(142, 14);
            this.lblSentElevatorPitch.TabIndex = 0;
            this.lblSentElevatorPitch.Text = "Elevator Pitch (degrees):";
            // 
            // lblSentThrottle
            // 
            this.lblSentThrottle.AutoSize = true;
            this.lblSentThrottle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSentThrottle.Location = new System.Drawing.Point(7, 25);
            this.lblSentThrottle.Name = "lblSentThrottle";
            this.lblSentThrottle.Size = new System.Drawing.Size(108, 14);
            this.lblSentThrottle.TabIndex = 0;
            this.lblSentThrottle.Text = "Throttle (percent):";
            // 
            // gbxFileSettings
            // 
            this.gbxFileSettings.Controls.Add(this.chkEnableWriting);
            this.gbxFileSettings.Location = new System.Drawing.Point(803, 39);
            this.gbxFileSettings.Name = "gbxFileSettings";
            this.gbxFileSettings.Size = new System.Drawing.Size(175, 54);
            this.gbxFileSettings.TabIndex = 7;
            this.gbxFileSettings.TabStop = false;
            this.gbxFileSettings.Text = "File Settings:";
            // 
            // chkEnableWriting
            // 
            this.chkEnableWriting.AutoSize = true;
            this.chkEnableWriting.Location = new System.Drawing.Point(11, 23);
            this.chkEnableWriting.Name = "chkEnableWriting";
            this.chkEnableWriting.Size = new System.Drawing.Size(86, 17);
            this.chkEnableWriting.TabIndex = 0;
            this.chkEnableWriting.Text = "Write To File";
            this.chkEnableWriting.UseVisualStyleBackColor = true;
            // 
            // clnAltidude
            // 
            this.clnAltidude.FillWeight = 50F;
            this.clnAltidude.HeaderText = "Altitude (feet)";
            this.clnAltidude.Name = "clnAltidude";
            this.clnAltidude.ReadOnly = true;
            this.clnAltidude.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnAltidude.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnAltidude.Width = 125;
            // 
            // clnSpeed
            // 
            this.clnSpeed.HeaderText = "Speed (knots)";
            this.clnSpeed.Name = "clnSpeed";
            this.clnSpeed.ReadOnly = true;
            this.clnSpeed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnSpeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnAngle
            // 
            this.clnAngle.HeaderText = "Pitch (degrees)";
            this.clnAngle.Name = "clnAngle";
            this.clnAngle.ReadOnly = true;
            this.clnAngle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnAngle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnAngle.Width = 118;
            // 
            // clnVertSpeed
            // 
            this.clnVertSpeed.HeaderText = "Vertical Speed (feet per minute)";
            this.clnVertSpeed.Name = "clnVertSpeed";
            this.clnVertSpeed.ReadOnly = true;
            this.clnVertSpeed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnVertSpeed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnThrottle
            // 
            this.clnThrottle.HeaderText = "Throttle (percent)";
            this.clnThrottle.Name = "clnThrottle";
            this.clnThrottle.ReadOnly = true;
            this.clnThrottle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnThrottle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnElevator
            // 
            this.clnElevator.HeaderText = "Elevator Pitch (degrees)";
            this.clnElevator.Name = "clnElevator";
            this.clnElevator.ReadOnly = true;
            this.clnElevator.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnElevator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnElevator.Width = 125;
            // 
            // clnWarning
            // 
            this.clnWarning.HeaderText = "Warning Code";
            this.clnWarning.Name = "clnWarning";
            this.clnWarning.ReadOnly = true;
            this.clnWarning.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clnWarning.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clnWarning.Width = 75;
            // 
            // RemoteFlightController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 432);
            this.Controls.Add(this.gbxFileSettings);
            this.Controls.Add(this.gbxSentData);
            this.Controls.Add(this.gbxWarning);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbxTelemetry);
            this.Controls.Add(this.gbxPlaneControls);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbxConnectionSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RemoteFlightController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Flight Controller";
            this.gbxConnectionSettings.ResumeLayout(false);
            this.gbxConnectionSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelemetryUpdates)).EndInit();
            this.gbxPlaneControls.ResumeLayout(false);
            this.gbxPlaneControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbrElevationController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbrThrottleController)).EndInit();
            this.gbxTelemetry.ResumeLayout(false);
            this.gbxWarning.ResumeLayout(false);
            this.gbxWarning.PerformLayout();
            this.gbxSentData.ResumeLayout(false);
            this.gbxSentData.PerformLayout();
            this.gbxFileSettings.ResumeLayout(false);
            this.gbxFileSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxConnectionSettings;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCurrentConnection;
        private System.Windows.Forms.Label lblCurrentConnectionTitle;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.DataGridView dgvTelemetryUpdates;
        private System.Windows.Forms.GroupBox gbxPlaneControls;
        private System.Windows.Forms.Label lblThrottleController;
        private System.Windows.Forms.TrackBar tbrThrottleController;
        private System.Windows.Forms.Label lblThrottleCurrentValue;
        private System.Windows.Forms.Button btnSendControls;
        private System.Windows.Forms.Label lblElevationController;
        private System.Windows.Forms.TrackBar tbrElevationController;
        private System.Windows.Forms.Label lblElevationCurrentValue;
        private System.Windows.Forms.GroupBox gbxTelemetry;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbxWarning;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.GroupBox gbxSentData;
        private System.Windows.Forms.Label lblSentThrottle;
        private System.Windows.Forms.Label lblSentElevatorPitch;
        private System.Windows.Forms.Label lblSentElevatorPitchValue;
        private System.Windows.Forms.Label lblSentThrottleValue;
        private System.Windows.Forms.GroupBox gbxFileSettings;
        private System.Windows.Forms.CheckBox chkEnableWriting;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAltidude;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAngle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnVertSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnThrottle;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnElevator;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnWarning;
    }
}

