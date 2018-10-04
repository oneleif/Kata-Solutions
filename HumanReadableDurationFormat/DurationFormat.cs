using System.Collections.Generic;
public class HumanTimeFormat{
  public static string formatDuration(int seconds){
    List<int> timeConversions = new List<int>() {31536000, 86400, 3600, 60, 1};
    List<string> textConversions = new List<string>(){"year","day","hour","minute","second"};
    string returnString = "";
    
    if(seconds == 0){
      return "now";
    }
    
    for(int i = 0; i < timeConversions.Capacity; i++){
      int nextRemainder = seconds % timeConversions[i];
      if(seconds >= timeConversions[i])
          returnString += "" + seconds/timeConversions[i] + " " + textConversions[i];
      else 
        continue;
        
      if(seconds/timeConversions[i] > 1) 
        returnString += "s";
     if(nextRemainder <= 0)
        break;
      else if(nextRemainder % timeConversions[i+1] == 0)
        returnString += " and ";
      else if(nextRemainder %timeConversions[i+1] > 0)
        returnString += ", ";
        
      seconds = nextRemainder;
    }
    return returnString;
  }
}