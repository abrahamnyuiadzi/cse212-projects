using System.Diagnostics.Contracts;

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
      if (length <=0)
      {
        return new double[0];// Return empty array if length is zero or negative
      }
      double[] result =new double[length];//initializes the result array correctly 
      for (int i = 0; i < length; i++)
      {
        result[i] = number * (i + 1);
      }//populates the array with correct multiples
  

        return result; // return the filled array
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
        if (data == null || data.Count <= 1 || amount <= 0 || amount >= data.Count)
            return;

        int count = data.Count;

        // Helper: Reverse a portion of the list
        void Reverse(int start, int end)
        {
            while (start < end)
            {
                int temp = data[start];
                data[start] = data[end];
                data[end] = temp;
                start++;
                end--;
            }
        }

        Reverse(0, count - 1);               // Step 1: Reverse whole list
        Reverse(0, amount - 1);              // Step 2: Reverse first 'amount' elements
        Reverse(amount, count - 1);          // Step 3: Reverse the rest
    }
    }

