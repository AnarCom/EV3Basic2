﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;
using EV3Communication;

namespace SmallBasicEV3Extension
{
    /// <summary>
    /// A set of quick methods for a motors connected to ports A and B.
    /// </summary>
    [SmallBasicType]
    public static class MotorBD
    {
        /// <summary>
        /// Stop motor ports BD. This will also cancel any scheduled movement for this motors.
        /// Motors will continue to rotate by inertia
        /// </summary>
        public static void Off()
        {
            ByteCodeBuffer c = new ByteCodeBuffer();
            c.OP(0xA3);
            c.CONST(0);
            c.CONST(10);
            c.CONST(0);
            EV3RemoteControler.DirectCommand(c, 0, 0);
        }

        /// <summary>
        /// Stop motors port BD. This will also cancel any scheduled movement for this motors.
        /// Motors will stop completely
        /// </summary>
        public static void OffAndBrake()
        {
            ByteCodeBuffer c = new ByteCodeBuffer();
            c.OP(0xA3);
            c.CONST(0);
            c.CONST(10);
            c.CONST(1);
            EV3RemoteControler.DirectCommand(c, 0, 0);
        }

        /// <summary>
        /// Set motors speed to port BD.
        /// </summary>
        /// <param name="speed">Speed value from -100 (full reverse) to 100 (full forward)</param>
        public static void SetSpeed(Primitive speed)
        {
        }

        /// <summary>
        /// Set motors power to ports BD.
        /// </summary>
        /// <param name="power">Speed value from -100 (full reverse) to 100 (full forward)</param>
        public static void SetPower(Primitive power)
        {
        }

        /// <summary>
        /// Start motors to pirts BD.
        /// </summary>
        public static void Start()
        {
        }

        /// <summary>
        /// Set motors speed to ports BD, then start motors.
        /// </summary>
        /// <param name="speed">Speed value from -100 (full reverse) to 100 (full forward)</param>
        public static void StartSpeed(Primitive speed)
        {
        }

        /// <summary>
        /// Set motors power to ports BD, then start motors.
        /// </summary>
        /// <param name="power">Speed value from -100 (full reverse) to 100 (full forward)</param>
        public static void StartPower(Primitive power)
        {
        }
    }
}
