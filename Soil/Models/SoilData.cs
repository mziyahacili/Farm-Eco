namespace Soil.Models;
public class SoilData
{
    public SoilData(
        string sceneId, 
        string viewId, 
        DateTime date, 
        string cloud, 
        List<string> notes, 
        double q1, 
        double q3, 
        double max, 
        double min, 
        double p10, 
        double p90, 
        double std, 
        double median, 
        double average, 
        double variance, 
        double ctime10)
    {
        SceneId = sceneId;
        ViewId = viewId;
        Date = date;
        Cloud = cloud;
        Notes = notes ?? new List<string>();  
        Q1 = q1;
        Q3 = q3;
        Max = max;
        Min = min;
        P10 = p10;
        P90 = p90;
        Std = std;
        Median = median;
        Average = average;
        Variance = variance;
        Ctime10 = ctime10;
    }
    
    
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