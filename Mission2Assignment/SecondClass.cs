namespace Mission2Assignment;

public class SecondClass
{
    // field to store the number
    private int _rollNum;
    
    // method to accept the number
    public int[] Simulation(int rollNum)
    {
        _rollNum = rollNum;
        
        // make array to hold totals (2-12)
        int[] totals = new int[11];
        
        // create instance of Random
        Random random = new Random();
        
        // loop for the number of times the user entered
        for (int i = 0; i < _rollNum; i++)
        {
            // roll both dice and store the numbers
            int randomNumber1 = random.Next(1, 7);
            int randomNumber2 = random.Next(1, 7);
            
            // add number together
            int total = randomNumber1 + randomNumber2;
            
            // update array
            totals[total - 2]++;
        }
        
        // return array
        return totals;
    }
}