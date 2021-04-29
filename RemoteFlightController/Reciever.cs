using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Web.Script.Serialization;

namespace RemoteFlightController
{
    public class Reciever
    {
        // Events that are tied to delegates at class construction.
        public event DataRecieve OnDataRecieve;
        public event WarningRecieve OnWarningRecieve;

        TcpClient networkClient;

        // Constructor
        public Reciever(TcpClient networkClient)
        {
            this.networkClient = networkClient;
        }

        /// <summary>
        /// Will open a NetworkStream and read data coming in. This method will then
        /// deserialize the incoming JSON data and Invoke the DataRecieve event which
        /// will append the now populated TelemetryUpdate data to dgvTelemetryUpdates.
        /// 
        /// Additionally, it will also Invoke the WarningRecieve event which will only
        /// occur when the WarningCode recieved from the simulator is greater than 0.
        /// </summary>
        public void RecieveDataFromSimulator()
        {
            Thread.Sleep(100);
            // Create an empty TelemetryUpdate struct.
            TelemetryUpdate telemetryData = new TelemetryUpdate();
            // Get the incoming stream from the NetworkClient.
            NetworkStream networkStream = networkClient.GetStream();
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            // Continously recieve data.
            while (true)
            {
                // Read the incoming data from NetworkStream into a byte buffer, then encode it as a string.
                byte[] incomingDataBuffer = new byte[256];
                int incomingLength = networkStream.Read(incomingDataBuffer, 0, 256);
                string recievedData = Encoding.ASCII.GetString(incomingDataBuffer, 0, incomingLength);

                // Deserialize the JSON data and then, using reflection, assign each value in the TelemetryUpdate struct
                // to the values recieved from the simulator.
                telemetryData = serializer.Deserialize<TelemetryUpdate>(recievedData);

                // Check if warning codes are greater than 0 and update the warning controls accordingly.
                switch (telemetryData.warningCode)
                {
                    case 1:
                        OnWarningRecieve?.Invoke("Warning: Flying too low.");
                        break;
                    case 2:
                        OnWarningRecieve?.Invoke("Warning: You are at stall risk.");
                        break;
                    default:
                        OnWarningRecieve?.Invoke("No Warning Recieved.");
                        break;
                }

                // Invoke the data recieve event.
                OnDataRecieve?.Invoke(telemetryData);
            }
        }
    }
}
