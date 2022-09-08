namespace HelloWorld;

public class leapYear{
    public static void main(String[] args){
        
    }
    public String UserInput(){
        Console.WriteLine("Input a year to check");
        var input = 0;
        String output;
        try{
            input = int.Parse(Console.ReadLine());
        }catch (FormatException){
            throw new FormatException("Only numbers can be checked");
        }
        if(IsLeapYear(input)){
            output = "yay";
        }else{
            output = "nay";
        }
        Console.WriteLine(output);
        return output;
    }
    public void checkYear(int year){
        if (year < 1582){
            throw new ArgumentException("can only validate years from 1582");
        }
    }
    public bool IsLeapYear(int year){
        var output = false;
        checkYear(year);
        if(year % 4 == 0){
            if(year % 100 == 0){
                if(year % 400 == 0){
                    output = true;
                }else{
                    output = false;
                }
            }else{
                output = true;
            }
        }else{
            output = false;
        }
        return output;
        
    }
}
