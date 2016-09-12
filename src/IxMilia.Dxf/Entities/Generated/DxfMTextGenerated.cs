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
    /// DxfMText class
    /// </summary>
    public partial class DxfMText : DxfEntity
    {
        public override DxfEntityType EntityType { get { return DxfEntityType.MText; } }
        protected override DxfAcadVersion MinVersion { get { return DxfAcadVersion.R13; } }
        public DxfPoint InsertionPoint { get; set; }
        public double InitialTextHeight { get; set; }
        public double ReferenceRectangleWidth { get; set; }
        public DxfAttachmentPoint AttachmentPoint { get; set; }
        public DxfDrawingDirection DrawingDirection { get; set; }
        public IList<string> ExtendedText { get; private set; }
        public string Text { get; set; }
        public string TextStyleName { get; set; }
        public DxfVector ExtrusionDirection { get; set; }
        public DxfVector XAxisDirection { get; set; }
        public double HorizontalWidth { get; set; }
        public double VerticalHeight { get; set; }
        public double RotationAngle { get; set; }
        public DxfMTextLineSpacingStyle LineSpacingStyle { get; set; }
        public double LineSpacingFactor { get; set; }
        public DxfBackgroundFillSetting BackgroundFillSetting { get; set; }
        public int BackgroundColorRGB { get; set; }
        public string BackgroundColorName { get; set; }
        public double FillBoxScale { get; set; }
        public DxfColor BackgroundFillColor { get; set; }
        public int BackgroundFillColorTransparency { get; set; }
        public short ColumnType { get; set; }
        public int ColumnCount { get; set; }
        public bool IsColumnFlowReversed { get; set; }
        public bool IsColumnAutoHeight { get; set; }
        public double ColumnWidth { get; set; }
        public double ColumnGutter { get; set; }
        public IList<double> ColumnHeights { get; private set; }

        public DxfXData XData { get { return ((IDxfHasXDataHidden)this).XDataHidden; } set { ((IDxfHasXDataHidden)this).XDataHidden = value; } }

        public DxfMText()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.InsertionPoint = DxfPoint.Origin;
            this.InitialTextHeight = 1.0;
            this.ReferenceRectangleWidth = 1.0;
            this.AttachmentPoint = DxfAttachmentPoint.TopLeft;
            this.DrawingDirection = DxfDrawingDirection.LeftToRight;
            this.ExtendedText = new List<string>();
            this.Text = null;
            this.TextStyleName = "STANDARD";
            this.ExtrusionDirection = DxfVector.ZAxis;
            this.XAxisDirection = DxfVector.XAxis;
            this.HorizontalWidth = 1.0;
            this.VerticalHeight = 1.0;
            this.RotationAngle = 0.0;
            this.LineSpacingStyle = DxfMTextLineSpacingStyle.AtLeast;
            this.LineSpacingFactor = 1.0;
            this.BackgroundFillSetting = DxfBackgroundFillSetting.Off;
            this.BackgroundColorRGB = 0;
            this.BackgroundColorName = null;
            this.FillBoxScale = 1.0;
            this.BackgroundFillColor = DxfColor.ByLayer;
            this.BackgroundFillColorTransparency = 0;
            this.ColumnType = 0;
            this.ColumnCount = 0;
            this.IsColumnFlowReversed = false;
            this.IsColumnAutoHeight = true;
            this.ColumnWidth = 0.0;
            this.ColumnGutter = 0.0;
            this.ColumnHeights = new List<double>();
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbMText"));
            pairs.Add(new DxfCodePair(10, InsertionPoint?.X ?? default(double)));
            pairs.Add(new DxfCodePair(20, InsertionPoint?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(30, InsertionPoint?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(40, (this.InitialTextHeight)));
            pairs.Add(new DxfCodePair(41, (this.ReferenceRectangleWidth)));
            pairs.Add(new DxfCodePair(71, (short)(this.AttachmentPoint)));
            pairs.Add(new DxfCodePair(72, (short)(this.DrawingDirection)));
            pairs.AddRange(this.ExtendedText.Select(p => new DxfCodePair(3, p)));
            pairs.Add(new DxfCodePair(1, (this.Text)));
            if (this.TextStyleName != "STANDARD")
            {
                pairs.Add(new DxfCodePair(7, (this.TextStyleName)));
            }

            if (this.ExtrusionDirection != DxfVector.ZAxis)
            {
                pairs.Add(new DxfCodePair(210, ExtrusionDirection?.X ?? default(double)));
                pairs.Add(new DxfCodePair(220, ExtrusionDirection?.Y ?? default(double)));
                pairs.Add(new DxfCodePair(230, ExtrusionDirection?.Z ?? default(double)));
            }

            pairs.Add(new DxfCodePair(11, XAxisDirection?.X ?? default(double)));
            pairs.Add(new DxfCodePair(21, XAxisDirection?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(31, XAxisDirection?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(42, (this.HorizontalWidth)));
            pairs.Add(new DxfCodePair(43, (this.VerticalHeight)));
            pairs.Add(new DxfCodePair(50, (this.RotationAngle)));
            pairs.Add(new DxfCodePair(73, (short)(this.LineSpacingStyle)));
            pairs.Add(new DxfCodePair(44, (this.LineSpacingFactor)));
            pairs.Add(new DxfCodePair(90, (int)(this.BackgroundFillSetting)));
            pairs.Add(new DxfCodePair(420, (this.BackgroundColorRGB)));
            pairs.Add(new DxfCodePair(430, (this.BackgroundColorName)));
            if (this.FillBoxScale != 1.0)
            {
                pairs.Add(new DxfCodePair(45, (this.FillBoxScale)));
            }

            pairs.Add(new DxfCodePair(63, DxfColor.GetRawValue(this.BackgroundFillColor)));
            pairs.Add(new DxfCodePair(441, (this.BackgroundFillColorTransparency)));
            pairs.Add(new DxfCodePair(75, (this.ColumnType)));
            pairs.Add(new DxfCodePair(76, (short)(this.ColumnCount)));
            pairs.Add(new DxfCodePair(78, BoolShort(this.IsColumnFlowReversed)));
            pairs.Add(new DxfCodePair(79, BoolShort(this.IsColumnAutoHeight)));
            pairs.Add(new DxfCodePair(48, (this.ColumnWidth)));
            pairs.Add(new DxfCodePair(49, (this.ColumnGutter)));
            pairs.Add(new DxfCodePair(50, ColumnHeights?.Count ?? default(double)));
            pairs.AddRange(this.ColumnHeights.Select(p => new DxfCodePair(50, p)));
            if (XData != null)
            {
                XData.AddValuePairs(pairs, version, outputHandles);
            }
        }
    }
}
