namespace Soil.Models;

public class SoilMoisture
{
    public string SceneId { get; set; }   
    public string ViewId { get; set; }    
    public DateTime Date { get; set; }   
    public string Cloud { get; set; }     
    public List<string> Notes { get; set; }  
    public double Q1 { get; set; }     
    public double Q3 { get; set; }        
    public double Max { get; set; }   
    public double Min { get; set; }   
    public double P10 { get; set; }    
    public double P90 { get; set; }   
    public double Std { get; set; }      
    public double Median { get; set; }
    public double Average { get; set; }
    public double Variance { get; set; }  
    public double Ctime10 { get; set; }  

}