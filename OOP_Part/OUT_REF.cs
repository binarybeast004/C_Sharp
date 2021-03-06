//help us to pass variable data to function by refrenece 
//We need this to return more than one output from a method 
//modify parameter


// concept of ref parameter
using System;
  
class GFG {
  
    // Main Method
    public static void Main()
    {
  
        // Assign string value
        string str = "Geek";
  
        // Pass as a reference parameter
        SetValue(ref str);
  
        // Display the given string
        Console.WriteLine(str);
    }
  
    static void SetValue(ref string str1)
    {
  
        // Check parameter value
        if (str1 == "Geek") {
            Console.WriteLine("Hello!!Geek");
        }
  
        // Assign the new value
        // of the parameter
        str1 = "GeeksforGeeks";
    }
}
//Output:
//Hello!!Geek
//GeeksforGeeks




// concept of out parameter
using System;
  
class GFG {
  
    // Main method
    static public void Main()
    {
  
        // Declaring variable
        // without assigning value
        int G;
  
        // Pass variable G to the method
        // using out keyword
        Sum(out G);
  
        // Display the value G
        Console.WriteLine("The sum of" + 
                " the value is: {0}", G);
    }
  
    // Method in which out parameter is passed
    // and this method returns the value of
    // the passed parameter
    public static void Sum(out int G)
    {
        G = 80;
        G += G;
    }
}

//Output: 
//The sum of the value is: 160



It is necessary the parameters should initialize before it pass to ref.	
It is not necessary to initialize parameters before it pass to out.

It is not necessary to initialize the value of a parameter before returning to the calling method.	
It is necessary to initialize the value of a parameter before returning to the calling method.

The passing of value through ref parameter is useful when the called method also need to change the value of passed parameter.	
The declaring of parameter through out parameter is useful when a method return multiple values.

When ref keyword is used the data may pass in bi-directional.	
When out keyword is used the data only passed in unidirectional.
