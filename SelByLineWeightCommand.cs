using System;
using Rhino;
using Rhino.Commands;

namespace SelCommands
{
  [System.Runtime.InteropServices.Guid("418fa004-4f4a-4a4b-9d1e-e3a6a793235d")]
  public class SelByLineWeightCommand : SelCommand
  {
    public override string EnglishName { get { return "SelByPrintWidth"; } }

    double m_val;
    protected override Result RunCommand(RhinoDoc doc, RunMode mode)
    {
      // You don't have to override RunCommand if you don't need any user input. In
      // this case we want to get a key from the user. If you return something other
      // than Success, the selection is canceled
      return Rhino.Input.RhinoGet.GetNumber("width", true, ref m_val, 0, RhinoMath.UnsetValue);
    }

    protected override bool SelFilter(Rhino.DocObjects.RhinoObject rhObj)
    {
      double weight = rhObj.Attributes.PlotWeightSource == Rhino.DocObjects.ObjectPlotWeightSource.PlotWeightFromObject ? 
        rhObj.Attributes.PlotWeight : 
        rhObj.Document.Layers[rhObj.Attributes.LayerIndex].PlotWeight;

      return (Math.Abs(m_val-weight)<RhinoMath.ZeroTolerance);
    }
  }
}
