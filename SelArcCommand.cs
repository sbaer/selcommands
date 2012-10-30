using Rhino;
using Rhino.Commands;

namespace SelCommands
{
  [System.Runtime.InteropServices.Guid("84fc40e8-8b0d-4923-a639-bf7c60e4cd3c")]
  public class SelArcCommand : SelCommand
  {
    public override string EnglishName { get { return "SelArc"; } }

    protected bool m_bUseDocTol = true;
    protected override Result RunCommand(RhinoDoc doc, RunMode mode)
    {
      var use_doc_tol = new Rhino.Input.Custom.OptionToggle(m_bUseDocTol, "No", "Yes");
      var go = new Rhino.Input.Custom.GetOption();
      go.AddOptionToggle("UseDocumentTolerance", ref use_doc_tol);
      go.AcceptNothing(true);
      go.SetCommandPrompt("Tolerance");
      while (go.Get() == Rhino.Input.GetResult.Option) { }

      if (go.CommandResult() != Result.Success && go.CommandResult()!= Result.Nothing)
        return go.CommandResult();
      m_bUseDocTol = use_doc_tol.CurrentValue;
      return Result.Success;
    }

    protected double GetTolerance(Rhino.RhinoDoc doc)
    {
      if (m_bUseDocTol && doc != null)
        return doc.ModelAbsoluteTolerance;
      return 0;
    }

    protected override bool SelFilter(Rhino.DocObjects.RhinoObject rhObj)
    {
      Rhino.Geometry.Curve crv = rhObj.Geometry as Rhino.Geometry.Curve;
      if (crv != null)
      {
        double tolerance = GetTolerance(rhObj.Document);
        // let's say that circles are not arcs in this function
        // since we can combine it with SelCircle
        return crv.IsArc(tolerance) && !crv.IsCircle(tolerance);
      }
      return false;
    }
  }


  [System.Runtime.InteropServices.Guid("6EACCAD6-DA41-48A5-8A29-3DCCF5B46DD6")]
  public class SelCircleCommand : SelArcCommand
  {
    public override string EnglishName { get { return "SelCircle"; } }

    protected override bool SelFilter(Rhino.DocObjects.RhinoObject rhObj)
    {
      Rhino.Geometry.Curve crv = rhObj.Geometry as Rhino.Geometry.Curve;
      if (crv != null)
      {
        double tolerance = GetTolerance(rhObj.Document);
        return crv.IsCircle(tolerance);
      }
      return false;
    }
  }
}
