# RemoteFlightController-Client
This project is the client implementation of a "Remote Flight Controller" made for a University of South Wales project. It was one of the first projects I made in C#. It's built with Windows Forms and .NET Framework 4.7.2.

The application is fairly simple, it communicates with the Simulator server over TCP and uses JSON for data transfer, similar to modern Web APIs. It will display the Altitude, Speed, Pitch, Throttle, Warnings etc. from the simulator and you can send throttle and elevation data to the simulator. There are also various events that trigger in different scenarios, such as the plane stalling.

The application is totally useless without the Simulator server, which is provided by the University and is proprietary, however its a good example of using event and delegates and .NET's network and JSON tools.