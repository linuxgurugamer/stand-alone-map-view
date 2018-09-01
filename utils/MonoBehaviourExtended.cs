/*

Copyright 2014-2018 Daniel Kinsman.

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

using System;
using UnityEngine;

namespace StandAloneMapView.utils
{
    public abstract class MonoBehaviourExtended : MonoBehaviour
    {
        public string LogPrefix { get; set; }

        public virtual void Awake(){}
        public virtual void Start(){}
        public virtual void Update(){}
        public virtual void OnDestroy(){}

        public string LogFormat(string message, params object[] formatParams)
        {
            message = string.Format(message, formatParams);
            if(LogPrefix != null && LogPrefix.Length > 0)
                message =  LogPrefix + " " + message;

            return message;
        }

        public void Log(string message, params object[] formatParams)
        {
            UnityEngine.Debug.Log(LogFormat(message, formatParams));
        }

        [System.Diagnostics.Conditional("DEBUG")]
        public void LogDebug(string message, params object[] formatParams)
        {
            UnityEngine.Debug.Log(LogFormat(message, formatParams));
        }

        public void LogWarning(string message, params object[] formatParams)
        {
            UnityEngine.Debug.LogWarning(LogFormat(message, formatParams));
        }

        public void LogException(Exception e)
        {
            LogWarning("exception incoming, trace {0}", e.StackTrace.Replace("\n", " \\n "));
            UnityEngine.Debug.LogException(e);
        }
    }
}
