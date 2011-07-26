using System;
using Rhino;

namespace SelCommands
{
  ///<summary>
  /// Every RhinoCommon Plug-In must have one and only one PlugIn derived
  /// class. DO NOT create an instance of this class. It is the responsibility
  /// of Rhino to create an instance of this class.
  ///</summary>
  public class SelCommandsPlugIn : Rhino.PlugIns.PlugIn
  {
    static SelCommandsPlugIn m_theplugin;

    public SelCommandsPlugIn()
    {
      m_theplugin = this;
    }

    public static SelCommandsPlugIn ThePlugIn
    {
      get { return m_theplugin; }
    }

  }
}
