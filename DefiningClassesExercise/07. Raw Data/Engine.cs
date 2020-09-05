using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Engine
    {
        public Engine(long engineSpeed, long enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }

        //{engineSpeed} {enginePower} 

        public long EngineSpeed { get; set; }
        public long EnginePower { get; set; }
    }
}
