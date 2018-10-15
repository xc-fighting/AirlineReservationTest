package airLineServer.Main;



import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;




import airLineServer.Thread.ServerChildTask;



public class ServerMain {
	
	
	
	public static void main(String[] args) {
		
		  //the main thread of server 
		 //task is start all of other threads and wait for socket
		 
		   System.out.println("Server program start....");
		  
		   ExecutorService threads_pool= Executors.newFixedThreadPool(20);
		   boolean isRunning = true;
		   try {
				ServerSocket s_socket = new ServerSocket(4321);
				while( isRunning ) {
					
					Socket s_client=s_socket.accept();
					//put the client socket in a queue
					threads_pool.execute(new ServerChildTask(s_client));
					System.out.println("airline reservation program receive a client request:"+s_client.getInetAddress().toString());
				}
				s_socket.close();
				threads_pool.shutdown();
		   }
		   catch (IOException e) 
		   {
				// TODO Auto-generated catch block
				e.printStackTrace();
		   }
		  
	
		
	}

}
