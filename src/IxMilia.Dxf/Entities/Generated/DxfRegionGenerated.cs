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
    /// DxfRegion class
    /// </summary>
    public partial class DxfRegion : DxfEntity
    {
        public override DxfEntityType EntityType { get { return DxfEntityType.Region; } }
        protected override DxfAcadVersion MinVersion { get { return DxfAcadVersion.R13; } }
        public short FormatVersionNumber { get; set; }
        public IList<string> CustomData { get; private set; }
        public IList<string> CustomData2 { get; private set; }

        public DxfRegion()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.FormatVersionNumber = 1;
            this.CustomData = new List<string>();
            this.CustomData2 = new List<string>();
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbModelerGeometry"));
            pairs.Add(new DxfCodePair(70, (this.FormatVersionNumber)));
            pairs.AddRange(this.CustomData.Select(p => new DxfCodePair(1, p)));
            pairs.AddRange(this.CustomData2.Select(p => new DxfCodePair(3, p)));
        }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 1:
                    this.CustomData.Add((pair.StringValue));
                    break;
                case 3:
                    this.CustomData2.Add((pair.StringValue));
                    break;
                case 70:
                    this.FormatVersionNumber = (pair.ShortValue);
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }
}
