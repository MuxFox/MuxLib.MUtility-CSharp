﻿using System;

namespace MuxLib.MUtility.Collections.Errors
{
    public sealed class ResizingError : Exception
    {
        public ResizingError()
        {
        }

        public ResizingError(string msg) : base(msg)
        {
        }

        public ResizingError(Exception ex) : base(ex.Message)
        {
        }
    }
}