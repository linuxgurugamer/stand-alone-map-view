Stand Alone Map View
====================

A Kerbal Space Program mod that opens the map view in another window/monitor.
It works by launching a separate instance of the game, and syncing the time
and ship information via networking (udp).

**Still very much a work in progress, use at your own risk**  
No usability or UI, and contains horrible bugs, but luckily they don't happen
in your main game window, just on the map view. When that happens you can
keep playing and only have to restart the map view.

To get it working, you'll need two separate installs of KSP, your normal one
and a separate one just for this mod. The "server" stuff goes in your normal
game (in the GameData directory), the "client" stuff goes in the other
install (also under GameData). Start up an instance of both and you should
be in business, providing you have the CPU and GPU and RAM to handle it.

Current Features
----------------

* Syncing of time and time warp
* Syncing of active vessel's trajectory

Feature Wishlist
----------------

* Configurable ip adress/port settings
* Syncing of manoeuver nodes (bidirectional)
* Syncing of all vessels' orbits

Minimum requirements
--------------------

* 2 monitors
* 4 core processor
* 6GB RAM

Or a separate computer to run the map view on.

Licenses
--------

Stand Alone Map View copyright 2014 Daniel Kinsman  
GNU General Public License v3

protobuf-net copyright 2008 Marc Gravell  
Apache Licese v2.0

Known Issues
------------

See https://github.com/DanielKinsman/stand-alone-map-view/issues

Contact
-------

* danielkinsman@riseup.net
* https://github.com/DanielKinsman/stand-alone-map-view