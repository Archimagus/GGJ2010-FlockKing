﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace FlocKing.Objects
{
    public interface ICOllideable
    {
        BoundingSphere Bounds { get; }
        bool CollidesWith(ICOllideable target);
    }
}
