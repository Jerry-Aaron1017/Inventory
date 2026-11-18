
namespace Inventory;

public class CostumExceptions : Exception
{
    public class NumberFormatException : Exception
    {
        public NumberFormatException(string message) : base(message)
        {
            try
            {
                throw new Exception(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wrong input in Quantity: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class StringFormatException : Exception
    {
        public StringFormatException(string message) : base(message)
        {
            try
            {
                throw new Exception(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wrong input in Product Name: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class CurrenctFormatException : Exception
    {
        public CurrenctFormatException(string message) : base(message)
        {
            try
            {
                throw new Exception(message);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wrong input in Selling Price: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}