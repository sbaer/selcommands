selcommands sample RhinoCommon plug-in
======================================

Rhino 5 (http://rhino3d.com/) plug-in that adds a few new "Sel" style commands to Rhino.

* SelByUserText - select all objects that have a given user text key
* SelByLineWeight - select objects based on their line (plot) weight
* SelSmallSurface - select all surfaces / polysurfaces that have a bounding box diagonal smaller than a given value
* SelArc - select all arcs using the current document tolerance. Full circular arcs are NOT selected
* SelCircle - select all circles using the current document tolerance

Downloading
-----------
NOTE: If you download the rhp file, you may need to right click and "unblock" the file before it can be used in Rhino


Get Involved
------------
If you want to tinker with and possibly add more "Sel" commands, feel free to send me a message on github and we'll try to figure out the best way to make that happen.

You are also welcome to submit bugs and wishlist items for these scripts at https://github.com/sbaer/selcommands/issues

Using the Source
----------------
You are going to need either:

* The latest Rhino5 Beta (http://www.rhino3d.com/nr.htm)
* The latest Mac Rhino WIP (http://mac.rhino3d.com/)

Start Rhino and run PlugInManager to install the rhp plug-in.  Once installed, you should now have these new commands available in Rhino.

Authors
-------
Steve Baer - https://github.com/sbaer steve@mcneel.com

Legal Stuff
-----------
Copyright (c) 2012 Robert McNeel & Associates. All Rights Reserved.

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to use,
copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the
Software.

THIS SOFTWARE IS PROVIDED "AS IS" WITHOUT EXPRESS OR IMPLIED WARRANTY. ALL IMPLIED
WARRANTIES OF FITNESS FOR ANY PARTICULAR PURPOSE AND OF MERCHANTABILITY ARE HEREBY
DISCLAIMED.

Rhinoceros is a registered trademark of Robert McNeel & Associates.

![Rhino](https://lh6.googleusercontent.com/-pQtuyrwmcmg/TYtWECHGYNI/AAAAAAAAA7Y/rphjSmq1cuo/s200/Rhino_logo_wire.jpg)
