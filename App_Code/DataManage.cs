using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataManage
/// </summary>
public class DataManage
{

	public DataManage()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public class trip
    {
        public int id, cruiseId,econ,prem,lux;
        public string deplocation, arrlocatio;
        public DateTime depdate, arrdate;
        public TimeSpan depTime, arrTime;
        public float price;
        public string description, status;
    }
    public class user
    {
        public string username, password, fn, ln, email, cn, uml;
    }
    public class cruise
    {
        public int id;
        public string ccode, cname;
        public int cabNum;
        public string agent, des;
        public int econ, econcab, econcap, econrate;
        public string econdes;
        public int perm, permcab, permcap, permrate;
        public string permdes;
        public int lux, luxcab, luxcap, lucrate;
        public string luxdes;
    }
    public class reservation
    {
        public int resId,tripId,cabnum,person;
        public string couser,cabintype,status;
        public float amount;
    }
}