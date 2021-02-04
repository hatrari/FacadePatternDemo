using System;

namespace FacadePatternDemo
{
  public class Facade
  {
    private SubsystemOne _subsystemOne = new SubsystemOne();
    private SubsystemTwo _subsystemTwo = new SubsystemTwo();
    public void SubsystemOneDoWork()
    {
      _subsystemOne.PrintName();
    }
    public void SubsystemTwoDoWork()
    {
      _subsystemTwo.PrintName();
    }
  }
}