using System;
using Rhino;

namespace SelCommands
{
  [System.Runtime.InteropServices.Guid("eefd1f8d-bf5d-458f-adc5-aa080574e3b6")]
  public class SelSmallCommand : Rhino.Commands.SelCommand
  {
    public override string EnglishName { get { return "SelSmallSurface"; } }

    double m_diagonal = 0.1;
    protected override Rhino.Commands.Result RunCommand(RhinoDoc doc, Rhino.Commands.RunMode mode)
    {
      return Rhino.Input.RhinoGet.GetNumber("Bounding Box Diagonal", true, ref m_diagonal, 0.0000001, 1000000);
    }

    // Classes derived from SelCommand are required to provide a SelFilter override
    protected override bool SelFilter(Rhino.DocObjects.RhinoObject rhObj)
    {
      var bbox = rhObj.Geometry.GetBoundingBox(false);
      return bbox.Diagonal.Length <= m_diagonal;
    }
  }
}

