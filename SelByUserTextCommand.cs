using System;
using Rhino;

namespace SelCommands
{
  [System.Runtime.InteropServices.Guid("834304ae-ed34-4ab3-9d83-c09b611629bf")]
  public class SelByUserTextCommand : Rhino.Commands.SelCommand
  {
    public override string EnglishName { get { return "SelByUserText"; } }

    string m_key = string.Empty;
    protected override Rhino.Commands.Result RunCommand(RhinoDoc doc, Rhino.Commands.RunMode mode)
    {
      // You don't have to override RunCommand if you don't need any user input. In
      // this case we want to get a key from the user. If you return something other
      // than Success, the selection is canceled
      return Rhino.Input.RhinoGet.GetString("key", true, ref m_key);
    }

    // Classes derived from SelCommand are required to provide a SelFilter override
    protected override bool SelFilter(Rhino.DocObjects.RhinoObject rhObj)
    {
      // return true if the key exists for this object
      string s = rhObj.Attributes.GetUserString(m_key);
      return !string.IsNullOrEmpty(s);
    }
  }
}

