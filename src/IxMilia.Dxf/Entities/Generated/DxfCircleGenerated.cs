// Copyright (c) IxMilia.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

// The contents of this file are automatically generated by a tool, and should not be directly modified.

using System;
using System.Collections.Generic;
using System.Linq;
using IxMilia.Dxf.Collections;
using IxMilia.Dxf.Objects;

namespace IxMilia.Dxf.Entities
{
    /// <summary>
    /// DxfCircle class
    /// </summary>
    public partial class DxfCircle : DxfEntity
    {
        public override DxfEntityType EntityType { get { return DxfEntityType.Circle; } }
        public double Thickness { get; set; }
        public DxfPoint Center { get; set; }
        public double Radius { get; set; }
        public DxfVector Normal { get; set; }

        public DxfCircle()
            : base()
        {
        }

        public DxfCircle(DxfPoint center, double radius)
            : this()
        {
            this.Center = center;
            this.Radius = radius;
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.Thickness = 0.0;
            this.Center = DxfPoint.Origin;
            this.Radius = 0.0;
            this.Normal = DxfVector.ZAxis;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbCircle"));
            if (this.Thickness != 0.0)
            {
                pairs.Add(new DxfCodePair(39, (this.Thickness)));
            }

            pairs.Add(new DxfCodePair(10, Center?.X ?? default(double)));
            pairs.Add(new DxfCodePair(20, Center?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(30, Center?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(40, (this.Radius)));
            if (this.Normal != DxfVector.ZAxis)
            {
                pairs.Add(new DxfCodePair(210, Normal?.X ?? default(double)));
                pairs.Add(new DxfCodePair(220, Normal?.Y ?? default(double)));
                pairs.Add(new DxfCodePair(230, Normal?.Z ?? default(double)));
            }

        }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 10:
                    this.Center.X = pair.DoubleValue;
                    break;
                case 20:
                    this.Center.Y = pair.DoubleValue;
                    break;
                case 30:
                    this.Center.Z = pair.DoubleValue;
                    break;
                case 39:
                    this.Thickness = (pair.DoubleValue);
                    break;
                case 40:
                    this.Radius = (pair.DoubleValue);
                    break;
                case 210:
                    this.Normal.X = pair.DoubleValue;
                    break;
                case 220:
                    this.Normal.Y = pair.DoubleValue;
                    break;
                case 230:
                    this.Normal.Z = pair.DoubleValue;
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }
}
