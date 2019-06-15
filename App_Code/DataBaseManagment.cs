using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for DataBaseManagment
/// </summary>
public class DataBaseManagment
{
    SqlConnection con;
   
	public DataBaseManagment()
    {


        con = new SqlConnection("Server=tcp:n2e26bkzhd.database.windows.net,1433;Database=_Carnival Corporation;User ID=melani@n2e26bkzhd;Password=Tp030412;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;");
	}
    public bool addNewUser(DataManage.user userInfo)
    {
        if (!checkUserName(userInfo.username))
            return false;
        string command = "INSERT INTO [User] (UserName,Password,FirstName,LastName,Email,ContactNumber,UML) VALUES('"+userInfo.username+"','"+userInfo.password+"','"+userInfo.fn+"','"+userInfo.ln+"','"+userInfo.email+"','"+userInfo.cn+"','"+userInfo.uml+"')";
        SqlCommand com = new SqlCommand(command, con);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
        return true;
    }
    public bool checkUserName(string userName)
    {
        bool retVal=true;
        string command = "SELECT * FROM [User] WHERE UserName='" + userName + "'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        if (reader.Read())
            retVal = false;
        reader.Close();
        con.Close();
        return retVal;
    }
    public string Login(string userName,string password)
    {
        string retVal="w";
        string command = "SELECT * FROM [User] WHERE Username='" + userName + "' AND Password='" + password + "'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        if (reader.Read())
            retVal=reader.GetString(6);
        reader.Close();
        con.Close();
        return retVal;
    }
    public void addNewCruise(DataManage.cruise cruiseInfo)
    {
        string command = "INSERT INTO [Cruise] (Ccode,Cname,CabinNumber,AgentCompany,Description,Econ,EconCab,EconCap,EconMulRat,EconDes,Prem,PremCab,PremCap,PremMulRat,PremDes,Lux,LuxCab,LuxCap,LuxMulRat,LuxDes) VALUES('" + cruiseInfo.ccode + "','" + cruiseInfo.cname + "','" + cruiseInfo.cabNum + "','" + cruiseInfo.agent + "','" + cruiseInfo.des + "','" + cruiseInfo.econ + "','" + cruiseInfo.econcab + "','" + cruiseInfo.econcap + "','" + cruiseInfo.econrate + "','" + cruiseInfo.econdes + "','" + cruiseInfo.perm + "','" + cruiseInfo.permcab + "','" + cruiseInfo.permcap + "','" + cruiseInfo.permrate + "','" + cruiseInfo.permdes + "','" + cruiseInfo.lux +"','" + cruiseInfo.luxcab + "','" + cruiseInfo.luxcap + "','" + cruiseInfo.permrate + "','" + cruiseInfo.permdes + "')";
        SqlCommand com = new SqlCommand(command, con);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
    }
    public DataManage.cruise getCruiseData(string Ccode)
    {
        DataManage.cruise retVal = new DataManage.cruise();
        string command = "SELECT * FROM [Cruise] WHERE Ccode='" + Ccode + "'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        if(reader.Read())
        {
            retVal.ccode = reader.GetString(1);
            retVal.cname = reader.GetString(2);
            retVal.cabNum = reader.GetInt32(3);
            retVal.agent = reader.GetString(4);
            retVal.des = reader.GetString(5);
            retVal.econ = reader.GetInt32(6);
            retVal.econcab = reader.GetInt32(7);
            retVal.econcap = reader.GetInt32(8);
            retVal.econrate = reader.GetInt32(9);
            retVal.econdes = reader.GetString(10);
            retVal.perm = reader.GetInt32(11);
            retVal.permcab = reader.GetInt32(12);
            retVal.permcap = reader.GetInt32(13);
            retVal.permrate = reader.GetInt32(14);
            retVal.permdes = reader.GetString(15);
            retVal.lux = reader.GetInt32(16);
            retVal.luxcab = reader.GetInt32(17);
            retVal.luxcap = reader.GetInt32(18);
            retVal.lucrate = reader.GetInt32(19);
            retVal.luxdes = reader.GetString(11);
        
        }
        reader.Close();
        con.Close();
        return retVal;
    }
    public DataManage.cruise getCruiseDataByID(int ID)
    {
        DataManage.cruise retVal = new DataManage.cruise();
        string command = "SELECT * FROM [Cruise] WHERE ID='" + ID + "'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        if (reader.Read())
        {
            retVal.ccode = reader.GetString(1);
            retVal.cname = reader.GetString(2);
            retVal.cabNum = reader.GetInt32(3);
            retVal.agent = reader.GetString(4);
            retVal.des = reader.GetString(5);
            retVal.econ = reader.GetInt32(6);
            retVal.econcab = reader.GetInt32(7);
            retVal.econcap = reader.GetInt32(8);
            retVal.econrate = reader.GetInt32(9);
            retVal.econdes = reader.GetString(10);
            retVal.perm = reader.GetInt32(11);
            retVal.permcab = reader.GetInt32(12);
            retVal.permcap = reader.GetInt32(13);
            retVal.permrate = reader.GetInt32(14);
            retVal.permdes = reader.GetString(15);
            retVal.lux = reader.GetInt32(16);
            retVal.luxcab = reader.GetInt32(17);
            retVal.luxcap = reader.GetInt32(18);
            retVal.lucrate = reader.GetInt32(19);
            retVal.luxdes = reader.GetString(20);

        }
        reader.Close();
        con.Close();
        return retVal;
    }
    public List<DataManage.cruise> getAllCruise()
    {
        List<DataManage.cruise> returnVal = new List<DataManage.cruise>();
        string command = "SELECT * FROM [Cruise]";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while (reader.Read())
        {
            DataManage.cruise retVal = new DataManage.cruise();
            retVal.id = reader.GetInt32(0);
            retVal.ccode = reader.GetString(1);
            retVal.cname = reader.GetString(2);
            retVal.cabNum = reader.GetInt32(3);
            retVal.agent = reader.GetString(4);
            retVal.des = reader.GetString(5);
            retVal.econ = reader.GetInt32(6);
            retVal.econcab = reader.GetInt32(7);
            retVal.econcap = reader.GetInt32(8);
            retVal.econrate = reader.GetInt32(9);
            retVal.econdes = reader.GetString(10);
            retVal.perm = reader.GetInt32(11);
            retVal.permcab = reader.GetInt32(12);
            retVal.permcap = reader.GetInt32(13);
            retVal.permrate = reader.GetInt32(14);
            retVal.permdes = reader.GetString(15);
            retVal.lux = reader.GetInt32(16);
            retVal.luxcab = reader.GetInt32(17);
            retVal.luxcap = reader.GetInt32(18);
            retVal.lucrate = reader.GetInt32(19);
            retVal.luxdes = reader.GetString(20);
            returnVal.Add(retVal);

        }
        reader.Close();
        con.Close();
        return returnVal;
    }
    public List<int> getAllCruiseId()
    {
        List<int> cruiseId = new List<int>();
        string command = "SELECT * FROM [Cruise]";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while(reader.Read())
        {
            cruiseId.Add(reader.GetInt32(0));
        }
        reader.Close();
        con.Close();
        return cruiseId;
    }
    public void addNewTrip(DataManage.trip tripInfo)
    {
        DataManage.cruise crus = getCruiseDataByID(tripInfo.cruiseId);

        string command = "INSERT INTO [Trip] (CruiseId,depLocation,depDate,depTime,arrLocation,arrDate,arrTime,BasePrice,Description,Status,econav,premav,luxav) VALUES('" + tripInfo.cruiseId + "','" + tripInfo.deplocation + "','" + tripInfo.depdate + "','" + tripInfo.depTime + "','" + tripInfo.arrlocatio + "','" + tripInfo.arrdate + "','" + tripInfo.arrTime + "','" + tripInfo.price + "','" + tripInfo.description + "','" + tripInfo.status + "','" + crus.econcab + "','" + crus.permcab + "','" + crus.luxcap + "')";
        SqlCommand com = new SqlCommand(command, con);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
    }
    public DataManage.trip getTripData(int ID)
    {
        DataManage.trip retVal = new DataManage.trip();
        string command = "SELECT * FROM [Trip] WHERE ID='" + ID + "'";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        if(reader.Read())
        {
            retVal.cruiseId = reader.GetInt32(1);
            retVal.deplocation = reader.GetString(2);
            retVal.depdate = reader.GetDateTime(3);
            retVal.depTime = reader.GetTimeSpan(4);
            retVal.arrlocatio = reader.GetString(5);
            retVal.arrdate = reader.GetDateTime(6);
            retVal.arrTime = reader.GetTimeSpan(7);
            retVal.price = float.Parse(reader.GetValue(8).ToString());
            retVal.description = reader.GetString(9);
            retVal.status = reader.GetString(10);
        }
        reader.Close();
        con.Close();
        return retVal;
    }
    public List<DataManage.trip> getAllTrip()
    {
        List<DataManage.trip> retValue = new List<DataManage.trip>();
        string command = "SELECT * FROM [Trip]";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while (reader.Read())
        {
            DataManage.trip retVal = new DataManage.trip();
            retVal.id = reader.GetInt32(0);
            retVal.cruiseId = reader.GetInt32(1);
            retVal.deplocation = reader.GetString(2);
            retVal.depdate = reader.GetDateTime(3);
            retVal.depTime = reader.GetTimeSpan(4);
            retVal.arrlocatio = reader.GetString(5);
            retVal.arrdate = reader.GetDateTime(6);
            retVal.arrTime = reader.GetTimeSpan(7);
            retVal.price = float.Parse(reader.GetValue(8).ToString());
            retVal.description = reader.GetString(9);
            retVal.status = reader.GetString(10);
            retVal.econ = reader.GetInt32(11);
            retVal.prem = reader.GetInt32(12);
            retVal.lux = reader.GetInt32(13);
            retValue.Add(retVal);
        }
        reader.Close();
        con.Close();
        return retValue;
    }
    public void newreservation(DataManage.reservation res)
    {
        string command = "INSERT INTO [Reservation] (CostumerUserName,TripID,CabinType,CabinNum,Persons,totalAmount,status) VALUES('" + res.couser + "','" + res.tripId + "','" + res.cabintype + "','" + res.cabnum + "','" + res.person + "','" + res.amount + "','" + res.status + "')";
        SqlCommand com = new SqlCommand(command, con);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();

    }
    public void updateavailablecabin(int trip,string cabintype, int newVal)
    {
        string command = "UPDATE [Trip] SET " + cabintype + "=" + newVal + " WHERE ID=" + trip; 
        SqlCommand com = new SqlCommand(command, con);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
    }
    public List<DataManage.reservation> getreservation()
    {
        List<DataManage.reservation> retVal = new List<DataManage.reservation>();
        string command = "SELECT* FROM [Reservation]";
        SqlCommand com = new SqlCommand(command, con);
        SqlDataReader reader;
        con.Open();
        reader = com.ExecuteReader();
        while(reader.Read())
        {
            DataManage.reservation temp = new DataManage.reservation();
            temp.resId = reader.GetInt32(0);
            temp.couser = reader.GetString(1);
            temp.tripId = reader.GetInt32(2);
            temp.cabintype = reader.GetString(3);
            temp.cabnum = reader.GetInt32(4);
            temp.person = reader.GetInt32(5);
            temp.amount = float.Parse(reader.GetValue(6).ToString());
            temp.status = reader.GetString(7);
            retVal.Add(temp);
        }
        reader.Close();
        con.Close();
        return retVal;
    }

}