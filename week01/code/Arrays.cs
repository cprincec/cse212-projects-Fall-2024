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
        // STEP 1
        // Declare an array of size 'length' of type double for storing the multiples
        double[] multiples = new double[length];

        // STEP 2
        // Write a for loop that runs 'length' times starting from 1.
        for (int i = 0; i < length; i++)
        {
            // STEP 3
            // For each iteration of the loop, multiply 'number' by the iterator 
            // (Begin multiplying with 1)
            double result = number * (i + 1);

            // STEP 4
            // For each iteration, assign the result of the multiplication to the array declared in STEP 1.
            multiples[i] = result;
        }

        // STEP 5 
        // return the array
        return multiples;
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

        // STEP 1
        // Starting from position 'amount', remove 'amount' number of element(s) from 'data' 
        // and store them in a new list
        List<int> extractedNums = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);

        // STEP 2
        // Add the elements in the new list to 'data' starting from index 0.
        data.InsertRange(0, extractedNums);
    }
}
