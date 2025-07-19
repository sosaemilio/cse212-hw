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

        // EMILIO'S RESPONSE
        // I started by setting up an static array using the defined paramenter of the method, since it was mentioned it can be a double I select a array of type double.
        // after that since it is a list/arrway I created a loop that stopped when the max lenght is reached out.
        // Using i I added the value or number inside the space and multiplied the existing itineration with the number, since the itineration starts with 0 I added + 1, 
        // so it doesn't start with 0, it starts with the real number

        double[] multipleStaticArray = new double[length];

        for (int i = 0; i < length; i++)
        {
            multipleStaticArray[i] = (i + 1) * number;
        }

        return  multipleStaticArray;; // replace this return statement with your own
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

        //EMILIO'S RESPONSE
        // We start by getting how many numbers we are getting in the input
        // We use module to cut the number in case the amount is higher than the total values
        // using the effectiveNumber and the total values we reduce the number and find the index where we will cut the arrawy
        // using getRange we will extract the values, using the point index where we will start and the amount
        // then the head which is supposed to be the rest of the values, we will use the same method but with the index 0 and the splitIndex
        // Finally we create a new list and add the tail first and then the head, so the values are in the right order.
        // now that we saved the values we need we clean the old data list and add/append the new values

        int totalNumberOfValues = data.Count;
        int effectiveNumber = amount % totalNumberOfValues;
        int splitIndex = totalNumberOfValues - effectiveNumber;

        List<int> tail = data.GetRange(splitIndex, effectiveNumber);

        List<int> head = data.GetRange(0, splitIndex);

        data.Clear();
        data.AddRange(tail);
        data.AddRange(head);
    }
}
