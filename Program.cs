using System;

namespace FacadePatternDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      var facade = new Facade();
      facade.SubsystemOneDoWork();
      facade.SubsystemTwoDoWork();
    }
  }
}
