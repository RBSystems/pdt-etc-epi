﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using PepperDash.Essentials.Core;
using PepperDash.Essentials.Core.Config;
using PepperDash.Core;

namespace EtcEPI
{


	public class EtcConfigObject
	{
        public ControlPropertiesConfig Control { get; set; }

        public Dictionary<string, EtcSceneConfig> scenes { get; set; }

    }


    public class EtcSceneConfig
    {
        public bool enabled;
        public string sceneName;
        public string spaceName;
        public string fadeTime;
    }



}