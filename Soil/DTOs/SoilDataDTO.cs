namespace Soil.DTOs;

public record SoilDataDTO
(   string SceneId,   
    string ViewId,    
    DateTime Date,   
    string Cloud,     
    List<string> Notes,  
    double Q1,     
    double Q3,        
    double Max,   
    double Min,   
    double P10,    
    double P90,   
    double Std,      
    double Median, 
    double Average, 
    double Variance,  
    double Ctime10);
