package airLineServer.Entity;

import java.net.Socket;

import airLineServer.Global.Config;
import airLineServer.Tools.DBTools;
import airLineServer.Tools.XmlManipulator;

public class DBEntity {
    
	
	private String role;
	private String action;
	private String[] contentLines;
	private Socket socket;
	
	public DBEntity(Socket ss,String r,String a,String[] lines) {
		this.socket=ss;
		this.role=r;
		this.action=a;
		this.contentLines=lines;
	}
	
	
	/*
	 * use for test purpose
	 * */
	public DBEntity(String r,String a,String[] lines) {
		 this.role=r;
		 this.action=a;
		 this.contentLines=lines;
	}
	
	    public String getRole() {
	    	return this.role;
	    }
	    public String getAction() {
	    	 return this.action;
	    }
	    
	    public String[] getContent() {
	    	return this.contentLines;
	    }
	    
	    public Socket getSocket() {
	    	return this.socket;
	    }
	
	/*
	 * 
	 * business logic implement here for db operation
	 * */
    public String action() {
    	
    	StringBuilder builder=new StringBuilder();
    	
    	/*
    	 *  two roles existing in this system
    	 *  one for admin
    	 *  one for customer
    	 * */
    	if(role.equals("admin")) {
    		
    		 /*
    		  * admin action is addFlight
    		  * */
    		 if(action.equals("register")) {
    			 
    			 String firstname=null;
    			 String lastname=null;
    			 String password=null;
    			 String username=null;
    			 String adminID=null;
    			 for(int i=0;i<this.contentLines.length;i++) {
    				 String[] column=contentLines[i].split(":");
    				 if(column[0].equals("firstname")) {
    					  firstname=column[1];
    				 }
    				 else if(column[0].equals("lastname")) {
    					 lastname=column[1];
    				 }
    				 else if(column[0].equals("password")) {
    					  password=column[1];
    				 }
    				 else if(column[0].equals("username")) {
    					  username=column[1];
    				 }
    			 }
    			 adminID="admin"+(1000+Config.admin_sum);
    			 Config.admin_sum++;
    			 DBTools db=new DBTools();
    			 db.open();
    			 boolean flag=db.registerAdmin(adminID, firstname, lastname, password, username);
    			 db.close();
    			 if(flag) {
    				  builder.append("success");
    			 }
    			 else {
    				 builder.append("fail");
    			 }
    		 }
    		 else if(action.equals("login")) {
    			 String username=null;
    			 String password=null;
    			 for(int i=0;i<this.contentLines.length;i++) {
    				 String[] column=contentLines[i].split(":");
    				 if(column[0].equals("password")) {
    					  password=column[1];
    				 }
    				 else if(column[0].equals("username")) {
    					  username=column[1];
    				 }
    			 }
    			 DBTools db=new DBTools();
    			 db.open();
    			 boolean flag=db.checkAdminExist(username, password);
    			 db.close();
    			 if(flag) {
    				 builder.append("success;");
    				 builder.append(db.getAdminID());
    			 }
    			 else {
    				 builder.append("failure");
    			 }
    		 }
    		 else if(action.equals("addFlight")) {
    			  String flightID="";
    			  String departure_place=null;
    			  String arrival_place=null;
    			  String departure_time=null;
    			  String arrival_time=null;
    			  int seats=0;
    			  int firstseat=0;
    			  int ecoseat=0;
    			  int price_first=0;
    			  int price_eco=0;
    			 
    			  boolean availability=true;
    			  for(int i=0;i<contentLines.length;i++) {
    				  String[] column=contentLines[i].split(":");
    				  if(column[0].equals("departurePlace")) {
    					  departure_place=column[1];
    				  }
    				  else if(column[0].equals("arrivalPlace")) {
    					  arrival_place=column[1];
    				  }
    				  else if(column[0].equals("departureTime")) {
    					  departure_time=column[1];
    				  }
    				  else if(column[0].equals("arrivalTime")) {
    					  arrival_time=column[1];
    				  }
    				  else if(column[0].equals("Seats")) {
    					  seats=Integer.parseInt(column[1]);
    				  }
    				  else if(column[0].equals("firstSeats")) {
    					  firstseat=Integer.parseInt(column[1]);
    				  }
    				  else if(column[0].equals("ecoSeats")) {
    					  ecoseat=Integer.parseInt(column[1]);
    				  }
    				  else if(column[0].equals("priceFirstClass")) {
    					  price_first=Integer.parseInt(column[1]);
    				  }
    				  else if(column[0].equals("priceEcoClass")) {
    					  price_eco=Integer.parseInt(column[1]);
    				  }
    			  }
    			 
    			  flightID="Flight"+(1000+Config.Flight_sum);
    			  Config.Flight_sum++;
    			  
    			  XmlManipulator xml=new XmlManipulator();
    			  xml.createSeatGraph(flightID,firstseat, ecoseat);
    			  
    			  DBTools db=new DBTools();
    			  db.open();
   
    			  db.insertFlight(flightID, departure_place, arrival_place, departure_time, 
    					  arrival_time, seats, firstseat, ecoseat, price_first, 
    					  price_eco, firstseat, ecoseat, availability);
    			  builder.append("success");
    			  
    			  db.close();
    		 }
    		 
    	}
    	else if(role.equals("customer")) {
    		
    		 /*
    		  * customer actions are:
    		  * getAvailableFlight
    		  * selectSeat
    		  * makeOrder
    		  * */
    		 if(action.equals("register")) {
    			 
    			 String firstname=null;
    			 String lastname=null;
    			 String realID=null;
    			 String username=null;
    			 String customerID=null;
    			 int age=0;
    			 for(int i=0;i<this.contentLines.length;i++) {
    				 String[] column=contentLines[i].split(":");
    				 if(column[0].equals("firstname")) {
    					  firstname=column[1];
    				 }
    				 else if(column[0].equals("lastname")) {
    					 lastname=column[1];
    				 }
    				 else if(column[0].equals("realID")) {
    					  realID=column[1];
    				 }
    				 else if(column[0].equals("username")) {
    					  username=column[1];
    				 }
    				 else if(column[0].equals("age")) {
    					 age=Integer.parseInt(column[1]);
    				 }
    				 
    			 }
    			 customerID="customer"+(1000+Config.customer_sum);
    			 Config.customer_sum++;
    			 DBTools db=new DBTools();
    			 db.open();
    			 boolean flag=db.registerCustomer(customerID, username, firstname, lastname, age, realID);
    			 db.close();
    			 if(flag) {
    				  builder.append("success");
    			 }
    			 else {
    				 builder.append("fail");
    			 }
    			 		 
    			 
    		 }
    		 else if(action.equals("login")) {
    			 String username=null;
    			 String realID=null;
    			 for(int i=0;i<this.contentLines.length;i++) {
    				 String[] column=contentLines[i].split(":");
    				 if(column[0].equals("realID")) {
    					  realID=column[1];
    				 }
    				 else if(column[0].equals("username")) {
    					  username=column[1];
    				 }
    			 }
    			 DBTools db=new DBTools();
    			 db.open();
    			 boolean flag=db.checkCustomerExist(username, realID);
    			 db.close();
    			 if(flag) {
    				 builder.append("success;");
    				 builder.append(db.getCustomerID());
    			 }
    			 else {
    				 builder.append("failure");
    			 }
    			 
    		 }
    		 else if(action.equals("getAvailableFlight")) {
    			 DBTools db=new DBTools();
    			 db.open();
    			 builder.append(db.getAvailableFlights());
    			 db.close();
    		 }
    		 else if(action.equals("selectSeat")) {
    			 
    			 String flightID=null;
    			 for(int i=0;i<contentLines.length;i++) {
   				  
	   				  String[] columns=contentLines[i].split(":");
	   				  if(columns[0].equals("flightID")) {
	   					   flightID= columns[1];
	   				  }
   			      }
    			  XmlManipulator xml=new XmlManipulator();
  				  xml.getXMLContent(flightID, builder);
    		 }
    		 else if(action.equals("makeOrder")) {
    			 //first flightid and customid seat number and type
    			 //check in xml file if it is occupied
    			 //if it is  set the seat and add the order return success	 
    			 //if not return false
    			 String flightID=null;
    			 String customerID=null;
    			 int seatType=0;
    			 int seatNumber=0;
    			 for(int i=0;i<contentLines.length;i++) {
    				 String[] column=contentLines[i].split(":");
    				 if(column[0].equals("flightID")) {
    					 flightID=column[1];
    				 }
    				 else if(column[0].equals("customerID")) {
    					 customerID=column[1];
    				 }
    				 else if(column[0].equals("seatType")) {
    					 seatType=Integer.parseInt(column[1]);
    				 }
    				 else if(column[0].equals("seatNumber")) {
    					 seatNumber=Integer.parseInt(column[1]);
    				 }
    			 }
    			 DBTools db=new DBTools();
    			 db.open();
    			 int numFirstClass=db.getFirstClassSeats(flightID);
    			 XmlManipulator xml=new XmlManipulator();
    			 int still_available=xml.getSeatValue(flightID, seatType, seatNumber,numFirstClass);
    			 if(still_available == 1) {
    				 builder.append("fail");
    			 }
    			 else {
    				 
    				 xml.setSeatValue(flightID, seatType, seatNumber, 1,numFirstClass);
    				 
    				 db.makeOrder(flightID, customerID, seatType, seatNumber);
    				 
    				 builder.append("success");
    			 }
    			 db.close();
    		 }
    	}
    	else {
    		builder.append("error");
    	}
    	return builder.toString();
    }
	
  
    
}
