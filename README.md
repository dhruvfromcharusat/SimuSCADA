# SimuSCADA
A robust SCADA system simulator using intelligent, scriptable devices with mTLS (x509 certificates) for secure communication and real-time monitoring.

# SimuSCADA

SimuSCADA is an intelligent SCADA system simulator designed to replicate real-world sensor networks with secure, authenticated communication. It uses **mTLS (x509 certificates)** for secure, encrypted data exchange, combined with **SignalR** for real-time, bidirectional data streaming and control.

### Key Features:
- **Secure Communication**: Each simulated device uses x509 certificates to establish mutual TLS (mTLS) connections with the backend, ensuring encrypted and authenticated communication.
- **Real-time Monitoring**: Devices stream live sensor data to the SCADA system using SignalR, allowing real-time control and monitoring.
- **Scriptable Devices**: Devices are intelligent and capable of running custom scripts to simulate various sensor behaviors and scenarios (e.g., faulty readings, extreme conditions, network dropouts).
- **Modular and Flexible**: Supports multiple sensor types (e.g., temperature, pressure, etc.), each with customizable behaviors and interaction models.
- **Historical Data Compression**: Uses LZ4 compression for storing large volumes of historical sensor data, with the ability to analyze and retrieve data efficiently.

### Use Cases:
- **SCADA System Development**: Simulate a complete SCADA environment with secure, real-time communication between devices and a backend system.
- **IoT Device Simulation**: Replicate IoT networks for testing real-time monitoring and control with secure communication.
- **System Stress Testing**: Use script-driven device simulations to generate various edge cases and scenarios for robust system testing.

### Technologies:
- **Backend**: .NET Core, MongoDB, SignalR
- **Frontend**: React
- **Security**: mTLS (x509 certificates) for secure device-to-backend communication
- **Compression**: LZ4 for efficient historical data storage
