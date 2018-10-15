using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace airlineclientside
{
    class Network
    {
        String content;
        public Network(String input) {
            content = input;
        }

        public String getResult() {
            String result = null;
            try
            {
                TcpClient socketforserver = new TcpClient("127.0.0.1", 4321);
                NetworkStream networkStream = socketforserver.GetStream();
                System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(networkStream);
                System.IO.StreamReader streamReader = new System.IO.StreamReader(networkStream);
                streamWriter.WriteLine(content);
                streamWriter.Flush();
                string line = null;
                StringBuilder builder = new StringBuilder();
                line = streamReader.ReadLine();
                builder.Append(line);


                result = builder.ToString();

                socketforserver.Close();
                return result;
            }
            catch
            {
                Console.WriteLine("fail to connect the server");

            }
            return null;


        }




    }
}
