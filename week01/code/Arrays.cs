public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        //Step 1: Create a new array of doubles with the size of 'length'.
        double[] result = new double[length];
        //Step 2: Use a for loop to iterate from 0 to length - 1. I will be using O(n) here.
        for (int i = 0; i < length; i++)
        {
            //Step 3: For each index, calculate the multiple of 'number' and assign it to the array at that index.
            result[i] = number * (i + 1);
        }
        //Step 4: Return the array.
        return result; // replace this return statement with your own

        // I used O(n+1) = O(n) in this case because I am creating an array of size n and then iterating through it to fill it with values.
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Get the last 'amount' elements (these will go to the front)
        List<int> rightPart = data.GetRange(data.Count - amount, amount);

        // Step 2: Get the rest of the list (everything before those last 'amount' elements)
        List<int> leftPart = data.GetRange(0, data.Count - amount);

        // Step 3: Combine right part and left part
        List<int> rotated = new List<int>();
        rotated.AddRange(rightPart);
        rotated.AddRange(leftPart);

        // Step 4: Clear original list and copy in the rotated result
        data.Clear();
        data.AddRange(rotated);

        // I used O(n+1+1+1+1) = O(n) in this case because I am creating a new list of size n and then spliting it into two parts,
        // and then combining them back into a new list of size n. The clear and addrange operations are O(n) as well.        
    }
}
