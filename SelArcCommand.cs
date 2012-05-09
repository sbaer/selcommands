using System;
using Rhino;
using Rhino.Commands;

namespace SelCommands
{
  [System.Runtime.InteropServices.Guid("84fc40e8-8b0d-4923-a639-bf7c60e4cd3c")]
  public class SelArcCommand : SelCommand
  {
    public override string EnglishName { get { return "SelArc"; } }

    protected override Result RunCommand(RhinoDoc doc, RunMode mode)
    {
      return Result.Success;
    }

    protected override bool SelFilter(Rhino.DocObjects.RhinoObject rhObj)
    {
      Rhino.Geometry.Curve crv = rhObj.Geometry as Rhino.Geometry.Curve;
      if (crv != null)
      {
        double tolerance = rhObj.Document.ModelAbsoluteTolerance;
        // let's say that circles are not arcs in this function
        // since we can combine it with SelCircle
        return crv.IsArc(tolerance) && !crv.IsCircle(tolerance);
      }
      return false;
    }
  }


  [System.Runtime.InteropServices.Guid("6EACCAD6-DA41-48A5-8A29-3DCCF5B46DD6")]
  public class SelCircleCommand : SelCommand
  {
    public override string EnglishName { get { return "SelCircle"; } }

    protected override Result RunCommand(RhinoDoc doc, RunMode mode)
    {
      return Result.Success;
    }

    protected override bool SelFilter(Rhino.DocObjects.RhinoObject rhObj)
    {
      Rhino.Geometry.Curve crv = rhObj.Geometry as Rhino.Geometry.Curve;
      if (crv != null)
      {
        double tolerance = rhObj.Document.ModelAbsoluteTolerance;
        return crv.IsCircle(tolerance);
      }
      return false;
    }
  }
}
