﻿/*
 *  This file is part of uEssentials project.
 *      https://uessentials.github.io/
 *
 *  Copyright (C) 2015-2016  Leonardosc
 *
 *  This program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2 of the License, or
 *  (at your option) any later version.
 *
 *  This program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License along
 *  with this program; if not, write to the Free Software Foundation, Inc.,
 *  51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
*/

using SDG.Unturned;
using UnityEngine;

namespace Essentials.Components.Player
{
    public class FrozenPlayer : PlayerComponent
    {
        private readonly Vector3 _frozenPos;
        private Vector3 _lastPos;

        private FrozenPlayer()
        {
            _frozenPos = _lastPos = Player.Position;

            if ( !Player.IsInVehicle ) return;
            var veh = Player.CurrentVehicle;
            var passagers = veh.passengers;

            for ( var i = 0; i < passagers.Length; i++ )
            {
                if ( passagers[i].player != Player.SteamPlayer ) continue;

                var pos = Player.Position;
                var seat = (byte) i;

                Vector3 point;
                byte angle;
                veh.getExit( seat, out point, out angle );
                VehicleManager.sendExitVehicle( veh, seat, (point + (point - pos)), angle, false );
            }
        }

        private void FixedUpdate()
        {
            if ( Player.Position == _lastPos ) return;
            Player.Teleport( _frozenPos );
            _lastPos = Player.Position;
        }
    }
}
