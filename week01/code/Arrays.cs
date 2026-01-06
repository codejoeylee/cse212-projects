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




        /*
            Step: Allocate array of size length.

            Step: Loop k from 1 to length; store at index k−1 to match zero-based arrays.

            Step: Each element is number × k.

            Step: Return array.
        */

        var result = new double[length];

        for(int k = 1; k <= length; k++){
            result[k-1] = number * k;
        }


        return result; // replace this return statement with your own
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




        /*
            Step 1: If listcount ≤ 1 or amount % listcount == 0, return.

            Step 2: Compute right slice = last amount items; left slice = first listcount − amount.

            Step 3: Clear and rebuild data as right + left.
        */
        int listcount = data.Count;
        if(listcount <= 1) return;
        amount = amount % listcount;
        if(amount == 0 ) return;

        var rightSide = data.GetRange(listcount - amount, amount);
        var leftSide = data.GetRange(0, listcount - amount);

        data.Clear();
        data.AddRange(rightSide);
        data.AddRange(leftSide);
    }
}
