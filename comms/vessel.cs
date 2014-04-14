/*

Copyright 2014 Daniel Kinsman.

This file is part of Stand Alone Map View.

Stand Alone Map View is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Stand Alone Map View is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Stand Alone Map View.  If not, see <http://www.gnu.org/licenses/>.

*/

using KSP;
using ProtoBuf;
using System;

namespace StandAloneMapView.comms
{
    [ProtoContract]
    public class Vessel
    {
        [ProtoMember(1)]
        public Guid Id { get; set; }

        [ProtoMember(2)]
        public string Name { get; set; }

        [ProtoMember(3)]
        public Orbit Orbit { get; set; }

        [ProtoMember(4)]
        public float Height;

        public Vessel()
        {
        }

        public Vessel(global::Vessel kspVessel)
        {
            this.Id = kspVessel.id;
            this.Name = kspVessel.vesselName;
            this.Orbit = new Orbit(kspVessel.orbit);
            this.Height = Math.Min(kspVessel.GetHeightFromTerrain(), (float)kspVessel.altitude);
        }
    }
}