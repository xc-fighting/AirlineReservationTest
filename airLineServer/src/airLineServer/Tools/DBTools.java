package airLineServer.Tools;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import airLineServer.Global.Config;

public class DBTools {
	
	private Connection conn = null;
	private Statement statement = null;
	
	private String customerID=null;
	private String adminID=null;
	
	public void setCustomerID(String customer) {
		this.customerID=customer;
	}
	
	public void setAdminID(String admin) {
		this.adminID=admin;
	}
	
	public String getCustomerID() {
		return this.customerID;
	}
	
	public String getAdminID() {
		return this.adminID;
	}
	
	public DBTools() {
		
	}
	
	public void open() {
		try {
			Class.forName("net.ucanaccess.jdbc.UcanaccessDriver");
			conn=DriverManager.getConnection("jdbc:ucanaccess://airline_db.accdb");
			statement=conn.createStatement();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public void close() {
		
		try {
			statement.close();
			conn.close();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		
	}
	
	public void insertFlight(String flightNumber, String departurePlace, 
			String arrivalPlace,String departureTime,String arrivalTime,
			int Seats,int firstSeats,int ecoSeats,int priceFirstClass,int priceEcoClass,
			int firstSeatRemain,int ecoSeatRemain,boolean availability) {
		 
		

		  String sql="INSERT INTO flightTable(flightNumber,departurePlace,"
		  		+ "arrivalPlace,departureTime,arrivalTime,Seats,firstSeats,ecoSeats,"
		  		+ "priceFirstClass,priceEcoClass,firstSeatRemain,ecoSeatRemain,availability) VALUES ("
		  		+"'"+flightNumber+"',"
		  		+"'"+departurePlace+"',"
		  		+"'"+arrivalPlace+"',"
		  		+"'"+departureTime+"',"
		  		+"'"+arrivalTime+"',"
		  		+Seats+","
		  		+firstSeats+","
		  		+ecoSeats+","
		  		+priceFirstClass+","
		  		+priceEcoClass+","
		  		+firstSeatRemain+","
		  		+ecoSeatRemain+","
		  		+availability
		  		+ ");";
		  System.out.println(sql);
		  try {
			statement.executeUpdate(sql);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		
	}
	
	public void makeOrder(String flightID,String customerID,int seatType,int seatNumber) {
		 String sql="select * from flightTable where flightNumber='"+flightID+"'";
		 System.out.println(sql);
		 try {
			
			ResultSet result=statement.executeQuery(sql);
			while(result.next()) {
				int firstSeatRemain=result.getInt(11);
				int ecoSeatRemain=result.getInt(12);
				System.out.println(firstSeatRemain+" "+ecoSeatRemain);
				boolean availability=true;
				if(seatType==1) {
					 firstSeatRemain--;
				}
				else {
					 ecoSeatRemain--;
				}
				if(firstSeatRemain==0 && ecoSeatRemain==0) {
					availability=false;
				}
				String update="UPDATE flightTable SET firstSeatRemain="+firstSeatRemain+",ecoSeatRemain="+ecoSeatRemain+",availability="+availability;
				System.out.println(update);
				statement.execute(update);
				String orderID="order"+(1000+Config.order_sum);
				Config.order_sum++;
				String order="INSERT INTO orderTable(orderID,customerID,flightID,seatType,seatNumber) VALUES ("
						+"'"+orderID+"',"
						+"'"+customerID+"',"
						+"'"+flightID+"',"
						+seatType+","
						+seatNumber+")";
				System.out.println(order);
				statement.executeUpdate(order);
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	}
	
	public String getAvailableFlights() {
		String sql="select * from flightTable where availability=true";
		StringBuilder sb=new StringBuilder();
		try {
			ResultSet result=statement.executeQuery(sql);
			sb.append("header:availableflight\t");
			while(result.next()) {
				String flightID=result.getString(1);
				String departurePlace=result.getString(2);
				String arrivalPlace=result.getString(3);
				String departureTime=result.getString(4);
				String arrivalTime=result.getString(5);
				int price_first=result.getInt(9);
				int price_eco=result.getInt(10);
				String row=flightID+"~"+departurePlace+"~"+arrivalPlace+"~"+departureTime+"~"+arrivalTime+"~"
						+price_first+"~"+price_eco;
				sb.append(row);
				sb.append("\t");
			}
			return sb.toString();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
		
	}
  
	public boolean checkAdminExist(String username,String password) {
		String sql="SELECT * from adminTable where userName='"+username+"' and password='"+password+"'";
		try {
			ResultSet result=statement.executeQuery(sql);
			if(result.next()) {
				 this.setAdminID(result.getString(1));
				 return true;
			}
			else {
				return false;
			}
		}
		catch(Exception e) {
			e.printStackTrace();
		}
		return false;
		
	}
	public boolean registerAdmin(String adminID,String firstname,String lastname,String password,String username) {
		 if(checkAdminExist(username,password)) {
			  return false;
		 }
		 else {
			 String sql="INSERT INTO adminTable(adminID,firstname,lastname,password,userName) VALUES ('"+adminID+"',"
					 +"'"+firstname+"','"+lastname+"','"+password+"','"+username+"')";
			 try {
				statement.executeUpdate(sql);
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			return true;
		 }
	}
	
	public boolean checkCustomerExist(String userName,String realID) {
		String sql="SELECT * FROM customerTable WHERE userName='"+userName+"' AND realID='"+realID+"'";
		ResultSet result;
		try {
			result = statement.executeQuery(sql);
			if(result.next()) {
				 this.setCustomerID(result.getString(1));
				 return true;
			}
			else {
				return false;
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return false;
	}
	
	public int getFirstClassSeats(String flightID) {
		String sql="SELECT firstSeats FROM flightTable WHERE flightNumber='"+flightID+"'";
		ResultSet result;
		try {
			result=statement.executeQuery(sql);
			if(result.next()) {
				return result.getInt(1);
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return -1;
		
	}
	
	public boolean registerCustomer(String customerID,String userName,String firstName,String lastName,int age,String realID) {
		 if(checkCustomerExist(userName,realID)) {
			 return false;
		 }
		 String sql="INSERT INTO customerTable (customerID,userName,firstName,lastName,age,realID) VALUES ('"+customerID+"','"+userName+"','"
				 +firstName+"','"+lastName+"',"+age+",'"+realID+"')";
		 try {
			statement.executeUpdate(sql);
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return true;
	}
	
	public  void printResult() {
		try {
		
			
			ResultSet result=statement.executeQuery("select * from admin_table");
			while(result.next()) {
				System.out.println(result.getString(3));
			}
		}  catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} 
		
	}
}
