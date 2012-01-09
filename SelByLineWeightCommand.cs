using System;
using Rhino;
using Rhino.Commands;

namespace SelCommands
{
  [System.Runtime.InteropServices.Guid("418fa004-4f4a-4a4b-9d1e-e3a6a793235d")]
  public class SelByLineWeightCommand : SelCommand
  {
    public override string EnglishName { get { return "SelByLineWeight"; } }

    double m_val;
    protected override Result RunCommand(RhinoDoc doc, RunMode mode)
    {
      // You don't have to override RunCommand if you don't need any user input. In
      // this case we want to get a key from the user. If you return something other
      // than Success, the selection is canceled
      return Rhino.Input.RhinoGet.GetNumber("weight", true, ref m_val, 0, RhinoMath.UnsetValue);
    }

    protected override bool SelFilter(Rhino.DocObjects.RhinoObject rhObj)
    {
      double weight = -1;
      if (rhObj.Attributes.PlotWeightSource == Rhino.DocObjects.ObjectPlotWeightSource.PlotWeightFromObject)
        weight = rhObj.Attributes.PlotWeight;
      else
        weight = rhObj.Document.Layers[rhObj.Attributes.LayerIndex].PlotWeight;

      return (m_val == weight);
    }
  }
}
