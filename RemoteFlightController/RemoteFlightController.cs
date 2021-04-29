using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Net.Sockets;
using System.Windows.Forms;

namespace RemoteFlightController
{
    #region Delegates and Structs
    // Will be invoked on during data sending and will append the Sent Data controls in the form.
    public delegate void DataSend(ControlsUpdate update);
    // Will be invoked on during data recieving and will append the read data to dgvTelemetryUpdates.
    public delegate void DataRecieve(TelemetryUpdate update);
    // Will be invoked on data recieving when the warning code is greater than 0 and will append the warning controls in the form.
    public delegate void WarningRecieve(string WarningCode);

    // ControlsUpdate struct - gets populated with data we send to the simulator.
    public struct ControlsUpdate
    {
        public double throttle;
        public double elevatorPitch;
    }

    // TelemetryUpdate struct - gets populated with data we recieve from the simulator.
    public struct TelemetryUpdate
    {
        public double altitude;
        public double speed;
        public double pitch;
        public double verticalSpeed;
        public double throttle;
        public double elevatorPitch;
        public int warningCode;
    }
    #endregion

    /// <summary>
    /// Main class for GUI and Network operations.
    /// </summary>
    public partial class RemoteFlightController : Form
    {
        // Used to connect to the simulator and then send and read data from it.
        TcpClient networkClient = new TcpClient();
        Reciever reciever;
        Sender sender;

        // Class constructor, will initalize WinForms components.
        public RemoteFlightController()
        {
            reciever = new Reciever(networkClient);
            sender = new Sender(networkClient);
            reciever.OnDataRecieve += new DataRecieve(OnDataRecieveHandler);
            reciever.OnWarningRecieve += new WarningRecieve(OnWarningRecieveHandler);
            sender.OnDataSend += new DataSend(OnDataSendHandler);
            InitializeComponent();
        }

        #region Telemetry Methods
        /// <summary>
        /// Will open the user specified connection given by txtIPAddress and txtPort by using the
        /// the global NetworkClient variable (which is of type TcpClient.) 
        /// </summary>
        void OpenConnection()
        {
            // Check if both text boxes are empty and prompt the user with an error.
            if (txtIPAddress.Text.Length == 0 || txtPort.Text.Length == 0)
            {
                MessageBox.Show("You need to specify an IP Address or Port in order to connect!", "Error When Opening Connection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Parse the value of txtIPAddress as an IPAddress
                IPAddress ipAddress = IPAddress.Parse(txtIPAddress.Text);
                // Try to parse the value of txtPort as an integer.
                int.TryParse(txtPort.Text, out int port);

                // Try to connect to specified port, if successful, prompt the user and append the current connection control.
                try
                {
                    networkClient.Connect(ipAddress, port);
                    MessageBox.Show("Opened connection to: " + ipAddress + ":" + port + ".", "Opened Connection (" + ipAddress + ":" + port + ")", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblCurrentConnection.Text = ipAddress + ":" + port;
                }
                // This exception is only called when the connection is unsuccessful, prompting the user so.
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error When Opening Connection (" + ipAddress + ":" + port + ")", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Enable user controls that allow the user to send data to client.
                tbrElevationController.Enabled = true;
                tbrThrottleController.Enabled = true;
                btnSendControls.Enabled = true;

                // Start data recieving.
                StartRecieverThread();

                // Write the date to file for formatting.
                WriteDataToFile("=====================================================" + Environment.NewLine
                    + "Session started at: " + DateTime.Now.ToString() + Environment.NewLine);
            }
        }

        /// <summary>
        /// Will start the thread which will run RecieveDataFromSimulator().
        /// </summary>
        void StartRecieverThread() => new Thread(new ThreadStart(reciever.RecieveDataFromSimulator)).Start();


        /// <summary>
        /// Will write telemetry data to a file.
        /// </summary>
        /// <param name="dataToWrite">String that will be written to file.</param>
        void WriteDataToFile(string dataToWrite)
        {
            // Open a file stream and use the append filemode.
            FileStream fileStream = new FileStream("PlaneTelemetryData.txt", FileMode.Append);
            // Convert dataToWrite to it's raw bytes.
            byte[] bytesToWrite = Encoding.ASCII.GetBytes(dataToWrite);
            // Write data to file.
            fileStream.Write(bytesToWrite, 0, bytesToWrite.Length);
            // Close the file stream.
            fileStream.Close();
        }
        #endregion

        #region Delegated Event Handlers
        /// <summary>
        /// Will take data coming in from the simulator and will append it to dgvTelemetryUpdates.
        /// </summary>
        /// <param name="telemetryData">TelemetryUpdate struct that gets passed through RecieveDataFromSimulator()</param>
        void OnDataRecieveHandler(TelemetryUpdate telemetryData)
        {
            // Check if the delegate was invoked, and then invoke it.
            if (InvokeRequired)
            {
                Invoke(new DataRecieve(OnDataRecieveHandler), new object[] { telemetryData });
            }
            else
            {
                // Check if writing is enabled and start writing to a file.
                if (chkEnableWriting.Checked)
                {
                    string telemetryUpdateString = "Altidude: " + telemetryData.altitude +
                                               " | Speed: " + telemetryData.speed +
                                               " | Pitch: " + telemetryData.pitch +
                                               " | Vertical Speed: " + telemetryData.verticalSpeed +
                                               " | Throttle: " + telemetryData.throttle +
                                               " | Elevator Pitch: " + telemetryData.elevatorPitch + Environment.NewLine;

                    WriteDataToFile(telemetryUpdateString);
                }

                // Get the DataGridView.
                DataGridViewRow dgvRow = (DataGridViewRow)dgvTelemetryUpdates.Rows[0].Clone();

                // Append each row with data whilst rounding values and formatting data with units.
                dgvRow.Cells[0].Value = Math.Round(telemetryData.altitude, 2).ToString() + " ft";
                dgvRow.Cells[1].Value = Math.Round(telemetryData.speed, 2).ToString() + " kt";
                dgvRow.Cells[2].Value = Math.Round(telemetryData.pitch, 2).ToString() + "°";
                dgvRow.Cells[3].Value = Math.Round(telemetryData.verticalSpeed, 2).ToString() + " fpm";
                dgvRow.Cells[4].Value = Math.Round(telemetryData.throttle).ToString() + "%";
                dgvRow.Cells[5].Value = Math.Round(telemetryData.elevatorPitch, 1).ToString() + "°";
                dgvRow.Cells[6].Value = telemetryData.warningCode.ToString();

                // Insert the row into the grid.
                dgvTelemetryUpdates.Rows.Insert(0, dgvRow);

                // Replace the last row if the grid is getting too large.
                if (dgvTelemetryUpdates.Rows.Count > 9)
                    dgvTelemetryUpdates.Rows.RemoveAt(8);

            }
        }

        /// <summary>
        /// Will take data from form controls and update labels with the sent data.
        /// </summary>
        /// <param name="controlData">ControlsUpdate struct that gets passed through SendDataToSimulator()</param>
        void OnDataSendHandler(ControlsUpdate controlData)
        {
            // Check if the delegate was invoked, and then invoke it.
            if (InvokeRequired)
            {
                Invoke(new DataSend(OnDataSendHandler), new object[] { controlData });
            }
            else
            {
                // Append labels with the sent data whilst rounding values and formatting data with units.
                lblSentThrottleValue.Text = Math.Round(controlData.throttle).ToString() + "%";
                lblSentElevatorPitchValue.Text = Math.Round(controlData.elevatorPitch, 1).ToString() + "°";
            }
        }

        /// <summary>
        /// Will take data coming in from simulator and will append the warning controls accordingly.
        /// </summary>
        /// <param name="warningData">Warning message that gets passed through RecieveDataFromSimulator()</param>
        void OnWarningRecieveHandler(string warningData)
        {
            // Check if the delegate was invoked, and then invoke it.
            if (InvokeRequired)
            {
                Invoke(new WarningRecieve(OnWarningRecieveHandler), new object[] { warningData });
            }
            else
            {
                // Append labels with the sent data whilst formatting data.
                lblWarning.Text = warningData;
            }
        }
        #endregion

        #region Windows Forms Event Handlers
        // Update form labels when any track bar is being scrolled.
        void tbrController_Scroll(object sender, System.EventArgs eventArgs)
        {
            lblThrottleCurrentValue.Text = tbrThrottleController.Value.ToString() + "%";
            lblElevationCurrentValue.Text = tbrElevationController.Value.ToString() + "°";
        }

        // Exit the application when btnExit is clicked.
        void btnExit_Click(object sender, System.EventArgs eventArgs) => Application.Exit();

        // Call OpenConnection() when btnConnect is clicked.
        void btnConnect_Click(object sender, EventArgs e) => OpenConnection();

        // Call SendDataToSimulator() when btnSendControls is clicked.
        void btnSendControls_Click(object sender, EventArgs eventArgs)
        {
            // Assign the values of the ControlsUpdate struct to the values from the form controls.
            this.sender.controlsData.throttle = tbrThrottleController.Value;
            this.sender.controlsData.elevatorPitch = tbrElevationController.Value;
            this.sender.SendDataToSimulator();
        }
        #endregion
    }
}
