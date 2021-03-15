﻿using System.Collections.Generic;

namespace DMISharp.Metadata
{
    /// <summary>
    /// Represents the header data for an individual DMI state
    /// </summary>
    public class StateMetadata
    {
        internal StateMetadata()
        {
            
        }

        public StateMetadata(string name, DirectionDepth directionDepth, int frames)
        {
            State = name;
            Dirs = (int)directionDepth;
            Frames = frames;
        }

        /// <summary>
        /// The name of the state
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The number of directions for the state. Generally 1, 4, or 8.
        /// </summary>
        public int Dirs { get; internal set; }

        /// <summary>
        /// The number of frames per direction
        /// </summary>
        public int Frames { get; internal set; }

        /// <summary>
        /// The delays used for animating each frame in each direction
        /// </summary>
        public double[] Delay { get; internal set; }

        /// <summary>
        /// Controls if the state has rewind, which will run the animation to end frame and then back
        /// </summary>
        public bool Rewind { get; internal set; }

        /// <summary>
        /// Controls if the animation is only used for when this state is used by a moving object
        /// </summary>
        public bool Movement { get; internal set; }

        /// <summary>
        /// Controls if the animation loops, or just plays once
        /// </summary>
        public int Loop { get; internal set; }

        /// <summary>
        /// Controls the hotspots, used for defining custom cursors
        /// </summary>
        public List<int[]> Hotspots { get; set; }
    }
}
