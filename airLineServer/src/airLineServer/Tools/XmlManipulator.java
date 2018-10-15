package airLineServer.Tools;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerConfigurationException;
import javax.xml.transform.TransformerException;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;


import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.xml.sax.SAXException;

public class XmlManipulator {
	
	public String createSeatGraph(String flightNo,int firstNo,int ecoNo) {
		
		
		try {
			
			DocumentBuilderFactory docFactory=DocumentBuilderFactory.newInstance();
			DocumentBuilder docBuilder=docFactory.newDocumentBuilder();
			
			Document doc=docBuilder.newDocument();
			
			Element root=doc.createElement("flight");
			doc.appendChild(root);
			Element first_root=doc.createElement("firstclass");
			Element eco_root=doc.createElement("ecoclass");
			
			root.appendChild(first_root);
			root.appendChild(eco_root);
			
			for(int i=1;i<=firstNo;i++) {
				Element seat=doc.createElement("seat");
				seat.setAttribute("Number",i+"");
				seat.appendChild(doc.createTextNode("0"));
				first_root.appendChild(seat);
			}
			
			for(int i=1;i<=ecoNo;i++) {
				int no=i+firstNo;
				Element seat=doc.createElement("seat");
				seat.setAttribute("Number", no+"");
				seat.appendChild(doc.createTextNode("0"));
				eco_root.appendChild(seat);
			}
			
			TransformerFactory transFac=TransformerFactory.newInstance();
			Transformer transfer=transFac.newTransformer();
			DOMSource source=new DOMSource(doc);
			
			StreamResult result=new StreamResult(new File("flight_graph/"+flightNo+".xml"));
			
			transfer.transform(source, result);
			
			System.out.println(flightNo+".xml"+" create success!");
			
			return flightNo+".xml";
			
		} catch (ParserConfigurationException | TransformerException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return null;
		
	}
	
	public void getXMLContent(String flightID,StringBuilder builder) {
		String filePath="flight_graph/"+flightID+".xml";
		File file=new File(filePath);
		try {
			BufferedReader br=new BufferedReader(new FileReader(file));
			String str=null;
			
				while((str=br.readLine())!=null) {
					builder.append(str);
				}
			br.close();
			
			
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}  
	
	public void setSeatValue(String flightno,int seatType,int seatNo,int val,int NumFirstClass) {
		
		try {
			String filePath="flight_graph/"+flightno+".xml";
			DocumentBuilderFactory docFactory=DocumentBuilderFactory.newInstance();
			DocumentBuilder docBuilder=docFactory.newDocumentBuilder();
			Document doc=docBuilder.parse(filePath);
			
			String seat_type=null;
			int index=-1;
			if(seatType==1) {
				seat_type="firstclass";
				index=seatNo-1;
			}
			else {
				seat_type="ecoclass";
				index=seatNo-NumFirstClass-1;
			}
			
		
			
			NodeList seatlist=doc.getElementsByTagName(seat_type);
			NodeList seats=seatlist.item(0).getChildNodes();
			
			Node seat=seats.item(index);
			seat.setTextContent(val+"");
			
			TransformerFactory transformerFactory = TransformerFactory.newInstance();
			Transformer transformer = transformerFactory.newTransformer();
			DOMSource source = new DOMSource(doc);
			StreamResult result = new StreamResult(new File(filePath));
			transformer.transform(source, result);

			System.out.println("Done");
			
		} catch (ParserConfigurationException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SAXException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (TransformerConfigurationException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (TransformerException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public int getSeatValue(String flightno,int seatType,int seatNo,int numFirstClass) {
		try {
			String filePath="flight_graph/"+flightno+".xml";
			DocumentBuilderFactory docFactory=DocumentBuilderFactory.newInstance();
			DocumentBuilder docBuilder=docFactory.newDocumentBuilder();
			Document doc=docBuilder.parse(filePath);
			
			String seat_type=null;
			int index=-1;
			if(seatType==1) {
				seat_type="firstclass";
				index=seatNo-1;
				
			}
			else {
				seat_type="ecoclass";
				index=seatNo-1-numFirstClass;
			}
			
			
			NodeList seatlist=doc.getElementsByTagName(seat_type);
			NodeList seats=seatlist.item(0).getChildNodes();
			
			System.out.println(index);
			Node seat=seats.item(index);
			String val=seat.getTextContent();
			
			return Integer.parseInt(val);
			
		} catch (ParserConfigurationException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (SAXException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} 
		return -1;
	}
	

}
