namespace HelloWorld;

public class leapYear{
    public static void main(String[] args){

    }
    public String UserInput(){
        Console.WriteLine("Input a year to check");
        var input = 0;
        String output;
        input = int.Parse(Console.ReadLine());
        if(IsLeapYear(input)){
            output = "yay";
        }else{
            output = "nay";
        }
        Console.WriteLine(output);
        return output;
    }
    public bool IsLeapYear(int year){
        var output = false;

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
