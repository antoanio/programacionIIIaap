using System;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;

namespace Servidor.Biblioteca
{
    class Program
    {
        // Datos Recibidos Desde ElCliente.  
        public static string data = null;

        public static void StartListening()
        {
            // Bufer de Datos paralosdatos recibidos  
            byte[] bytes = new Byte[1024];

            // Establece el punto deentrada final para el socket.  
            // Dns.GetHostName devuelve el nombre del host donde correr la aplicacion
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = ipHostInfo.AddressList[0];

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Any, 11000);

            // Crea un Socket TCP/IP x.  
            Socket listener = new Socket(IPAddress.Any.AddressFamily,
                SocketType.Stream, ProtocolType.Tcp);


            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                // Inicia a escuchas miestras llegan conexiones.  
                while (true)
                {
                    Console.WriteLine("Esperando por ceonexiones ...");
                    // el Programa es suspendido mientras espera oconexiones de entrada .  
                    Socket handler = listener.Accept();
                    data = null;

                    // La conexion de entrada necesita ser procesada.  
                    while (true)
                    {
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        Console.WriteLine("Texto recibido: {0}", data);
                        string[] desconponer = data.Split(',');
                        Biblioteca x = Biblioteca.getInstance();
                        string p = desconponer[0];
                        string o = desconponer[1];
                        string q = desconponer[2];
                        string r = desconponer[3];
                        string s = desconponer[4];
                        Estado estado;
                        Enum.TryParse(s, out estado);
                        switch (p)
                        {
                            case "1":
                                LibrosLir libro = new LibrosLir(p, o, q, estado);
                                x.IngresarLibro(libro);
                                break;
                            case "2":

                                break;
                            case "3":


                                break;


                        }

                        // Prepara los datos para responder  al cliente.  
                        byte[] msg = Encoding.ASCII.GetBytes(data + "De Regreso");

                        handler.Send(msg);
                        handler.Shutdown(SocketShutdown.Both);
                        handler.Close();
                    }

                   
                    
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("\nPresiones ENTER para continuar...");
            Console.Read();

        }

        public static int Main(String[] args)
        {
            StartListening();
            return 0;
        }
    }
}

