namespace WindowsFormsApp1
{
  public class MemoryClass
  {
    private double memoryValue;
    private double originalMemoryValue;

    public double MemoryValue
    {
      set
      {
        memoryValue = value;
        originalMemoryValue = value;
      }
      get => memoryValue;
    }

    public double ClearMemory
    {
      set
      {
        memoryValue = 0;
        originalMemoryValue = 0;
      }
    }

    public double RevertMemory
    {
      set => memoryValue = originalMemoryValue;
    }

    public double PlusMemory
    {
      set => memoryValue = memoryValue + originalMemoryValue;
    }

    public double MinusMemory
    {
      set => memoryValue = memoryValue - originalMemoryValue;
    }
  }
}