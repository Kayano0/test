public class FizzBuzz{
    public static void Main(){
        for (int i = 1; i <= 100; i++) {

            var str = "";

            // ここから記述
            if (i % 3 == 0 && i % 5 == 0){
                str = "FizzBuzz";
            }
            else if (i % 3 == 0){
                str = "Fizz";
            }
            else if (i % 5 == 0){
                str = "Buzz";
            }
            else {
            	str = i.ToString();
            }

            // ここから記述

            System.Console.WriteLine(str);
        }
    }
}