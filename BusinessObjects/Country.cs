using System;

public class Country
{	
	public int countryID {  get; set; }
	public string countryName { get; set; }
	public int RegionID { get; set; }

	public Country(int countryID, string countryName, int regionID)
	{
		this.countryID = countryID;
		this.countryName = countryName;
		this.regionID = regionID;
	}
}
