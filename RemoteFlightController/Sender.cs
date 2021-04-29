using System.Net.Sockets;
using System.Text;
using System.Web.Script.Serialization;

namespace RemoteFlightController
{
    public class Sender
    {
        // Events that are tied to delegates at class construction.
        public event DataSend OnDataSend;

        public ControlsUpdate controlsData;
        TcpClient networkClient;

        // Constructor
        public Sender(TcpClient networkClient)
        {
            controlsData = new ControlsUpdate();
            this.networkClient = networkClient;
        }

        /// <summary>
        /// Will open a NetworkStream and send data to the simulator. This method will
        /// serialize data recieved from the GUI controls and then Invoke the 
        /// DataSend event which will append the Sent Data controls in the form.
        /// </summary>
        public void SendDataToSimulator()
        {
            // Create an empty ControlsUpdate struct.

            // Get the incoming stream from the NetworkClient.      
            NetworkStream networkStream = networkClient.GetStream();
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            // Serialize the data into JSON format and encode it into a byte buffer.
            string dataToSend = serializer.Serialize(controlsData);
            byte[] bytesToSend = Encoding.ASCII.GetBytes(dataToSend);

            // Send the data to the simulator using the NetworkStream.
            networkStream.Write(bytesToSend, 0, bytesToSend.Length);

            // Invoke the data send event.
            OnDataSend?.Invoke(controlsData);
        }
    }

}
