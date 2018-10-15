package airLineServer.Thread;


import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.IOException;
import java.io.InputStream;

import java.io.OutputStream;

import java.net.Socket;


import airLineServer.Entity.DBEntity;


public class ServerChildTask implements Runnable{

					private Socket socket=null;
					InputStream is = null;
				    OutputStream os = null;
				    DataInputStream din = null;
				    DataOutputStream dout = null;
					public ServerChildTask(Socket ss) {
						    socket=ss;
						    try {
								is = socket.getInputStream();
								os = socket.getOutputStream();
							} catch (IOException e) {
								// TODO Auto-generated catch block
								e.printStackTrace();
							}
						   
						    din=new DataInputStream(is);
						    dout=new DataOutputStream(os);
					}
					@SuppressWarnings("deprecation")
					@Override
					public void run() {
						// TODO Auto-generated method stub
						System.out.println("Start the child server thread....");
		
				       
				       try {
				    	       
						    StringBuilder builder = new StringBuilder();
						    String line = null;
						   System.out.println("prepare to read");
						   line=din.readLine();
						   builder.append(line);
						   
						   
						   
						    
						    System.out.println("read over");
						    String content = builder.toString();
						    System.out.println(content);
						
						    String[] group=content.split("\t");
						    String role_line=group[0];
						    String action_line=group[1];
						    String role=role_line.split(":")[1];
						    String action=action_line.split(":")[1];
						    int len=group.length;
						    
						    String[] lines=new String[len-2];
						    for(int i=0;i<len-2;i++) {
						    	 lines[i]=group[i+2];
						    }
						    
						    //do some easy parse and put the item in data queue
						    DBEntity item=new DBEntity(role,action,lines);
						    String result = null;
						    synchronized(this){
						    	result=item.action();
						    }
						    
						   
						    dout.writeBytes(result);
						    dout.flush();
						    
						} catch (IOException e) {
							// TODO Auto-generated catch block
							e.printStackTrace();
						}
				        finally {
				        	    
				        	   
							    try {
								    	 din.close();
										 dout.close();
									     is.close();
									     os.close();
										 socket.close();
								} catch (IOException e) {
									// TODO Auto-generated catch block
									e.printStackTrace();
								}
					
							    System.out.println("server child thread over");
				        	
				        }
				 
				
			
		
	             }

}
