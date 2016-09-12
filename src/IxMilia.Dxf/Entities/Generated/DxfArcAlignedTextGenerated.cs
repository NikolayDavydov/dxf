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
    /// DxfArcAlignedText class
    /// </summary>
    public partial class DxfArcAlignedText : DxfEntity
    {
        public override DxfEntityType EntityType { get { return DxfEntityType.ArcAlignedText; } }
        protected override DxfAcadVersion MinVersion { get { return DxfAcadVersion.R2000; } }
        protected override DxfAcadVersion MaxVersion { get { return DxfAcadVersion.R2000; } }
        public string Text { get; set; }
        public string FontName { get; set; }
        public string BigfontName { get; set; }
        public string TextStyleName { get; set; }
        public DxfPoint CenterPoint { get; set; }
        public double ArcRadius { get; set; }
        public double WidthFactor { get; set; }
        public double TextHeight { get; set; }
        public double CharacterSpacing { get; set; }
        public double OffsetFromArc { get; set; }
        public double RightOffset { get; set; }
        public double LeftOffset { get; set; }
        public double StartAngle { get; set; }
        public double EndAngle { get; set; }
        public bool IsCharacterOrderReversed { get; set; }
        public short DirectionFlag { get; set; }
        public short AlignmentFlag { get; set; }
        public short SideFlag { get; set; }
        public bool IsBold { get; set; }
        public bool IsItalic { get; set; }
        public bool IsUnderline { get; set; }
        public short CharacterSetValue { get; set; }
        public short PitchAndFamilyValue { get; set; }
        public DxfFontType FontType { get; set; }
        public int ColorIndex { get; set; }
        public DxfVector ExtrusionDirection { get; set; }
        public short WizardFlag { get; set; }

        public DxfArcAlignedText()
            : base()
        {
        }

        protected override void Initialize()
        {
            base.Initialize();
            this.Text = null;
            this.FontName = null;
            this.BigfontName = null;
            this.TextStyleName = null;
            this.CenterPoint = DxfPoint.Origin;
            this.ArcRadius = 0.0;
            this.WidthFactor = 1.0;
            this.TextHeight = 0.0;
            this.CharacterSpacing = 0.0;
            this.OffsetFromArc = 0.0;
            this.RightOffset = 0.0;
            this.LeftOffset = 0.0;
            this.StartAngle = 0.0;
            this.EndAngle = 0.0;
            this.IsCharacterOrderReversed = false;
            this.DirectionFlag = 0;
            this.AlignmentFlag = 0;
            this.SideFlag = 0;
            this.IsBold = false;
            this.IsItalic = false;
            this.IsUnderline = false;
            this.CharacterSetValue = 0;
            this.PitchAndFamilyValue = 0;
            this.FontType = DxfFontType.TTF;
            this.ColorIndex = 0;
            this.ExtrusionDirection = DxfVector.ZAxis;
            this.WizardFlag = 0;
        }

        protected override void AddValuePairs(List<DxfCodePair> pairs, DxfAcadVersion version, bool outputHandles)
        {
            base.AddValuePairs(pairs, version, outputHandles);
            pairs.Add(new DxfCodePair(100, "AcDbArcAlignedText"));
            pairs.Add(new DxfCodePair(1, (this.Text)));
            pairs.Add(new DxfCodePair(2, (this.FontName)));
            pairs.Add(new DxfCodePair(3, (this.BigfontName)));
            pairs.Add(new DxfCodePair(7, (this.TextStyleName)));
            pairs.Add(new DxfCodePair(10, CenterPoint?.X ?? default(double)));
            pairs.Add(new DxfCodePair(20, CenterPoint?.Y ?? default(double)));
            pairs.Add(new DxfCodePair(30, CenterPoint?.Z ?? default(double)));
            pairs.Add(new DxfCodePair(40, (this.ArcRadius)));
            pairs.Add(new DxfCodePair(41, (this.WidthFactor)));
            pairs.Add(new DxfCodePair(42, (this.TextHeight)));
            pairs.Add(new DxfCodePair(43, (this.CharacterSpacing)));
            pairs.Add(new DxfCodePair(44, (this.OffsetFromArc)));
            pairs.Add(new DxfCodePair(45, (this.RightOffset)));
            pairs.Add(new DxfCodePair(46, (this.LeftOffset)));
            pairs.Add(new DxfCodePair(50, (this.StartAngle)));
            pairs.Add(new DxfCodePair(51, (this.EndAngle)));
            pairs.Add(new DxfCodePair(70, BoolShort(this.IsCharacterOrderReversed)));
            pairs.Add(new DxfCodePair(71, (this.DirectionFlag)));
            pairs.Add(new DxfCodePair(72, (this.AlignmentFlag)));
            pairs.Add(new DxfCodePair(73, (this.SideFlag)));
            pairs.Add(new DxfCodePair(74, BoolShort(this.IsBold)));
            pairs.Add(new DxfCodePair(75, BoolShort(this.IsItalic)));
            pairs.Add(new DxfCodePair(76, BoolShort(this.IsUnderline)));
            pairs.Add(new DxfCodePair(77, (this.CharacterSetValue)));
            pairs.Add(new DxfCodePair(78, (this.PitchAndFamilyValue)));
            pairs.Add(new DxfCodePair(79, (short)(this.FontType)));
            pairs.Add(new DxfCodePair(90, (this.ColorIndex)));
            if (this.ExtrusionDirection != DxfVector.ZAxis)
            {
                pairs.Add(new DxfCodePair(210, ExtrusionDirection?.X ?? default(double)));
                pairs.Add(new DxfCodePair(220, ExtrusionDirection?.Y ?? default(double)));
                pairs.Add(new DxfCodePair(230, ExtrusionDirection?.Z ?? default(double)));
            }

            pairs.Add(new DxfCodePair(280, (this.WizardFlag)));
        }

        internal override bool TrySetPair(DxfCodePair pair)
        {
            switch (pair.Code)
            {
                case 1:
                    this.Text = (pair.StringValue);
                    break;
                case 2:
                    this.FontName = (pair.StringValue);
                    break;
                case 3:
                    this.BigfontName = (pair.StringValue);
                    break;
                case 7:
                    this.TextStyleName = (pair.StringValue);
                    break;
                case 10:
                    this.CenterPoint.X = pair.DoubleValue;
                    break;
                case 20:
                    this.CenterPoint.Y = pair.DoubleValue;
                    break;
                case 30:
                    this.CenterPoint.Z = pair.DoubleValue;
                    break;
                case 40:
                    this.ArcRadius = (pair.DoubleValue);
                    break;
                case 41:
                    this.WidthFactor = (pair.DoubleValue);
                    break;
                case 42:
                    this.TextHeight = (pair.DoubleValue);
                    break;
                case 43:
                    this.CharacterSpacing = (pair.DoubleValue);
                    break;
                case 44:
                    this.OffsetFromArc = (pair.DoubleValue);
                    break;
                case 45:
                    this.RightOffset = (pair.DoubleValue);
                    break;
                case 46:
                    this.LeftOffset = (pair.DoubleValue);
                    break;
                case 50:
                    this.StartAngle = (pair.DoubleValue);
                    break;
                case 51:
                    this.EndAngle = (pair.DoubleValue);
                    break;
                case 70:
                    this.IsCharacterOrderReversed = BoolShort(pair.ShortValue);
                    break;
                case 71:
                    this.DirectionFlag = (pair.ShortValue);
                    break;
                case 72:
                    this.AlignmentFlag = (pair.ShortValue);
                    break;
                case 73:
                    this.SideFlag = (pair.ShortValue);
                    break;
                case 74:
                    this.IsBold = BoolShort(pair.ShortValue);
                    break;
                case 75:
                    this.IsItalic = BoolShort(pair.ShortValue);
                    break;
                case 76:
                    this.IsUnderline = BoolShort(pair.ShortValue);
                    break;
                case 77:
                    this.CharacterSetValue = (pair.ShortValue);
                    break;
                case 78:
                    this.PitchAndFamilyValue = (pair.ShortValue);
                    break;
                case 79:
                    this.FontType = (DxfFontType)(pair.ShortValue);
                    break;
                case 90:
                    this.ColorIndex = (pair.IntegerValue);
                    break;
                case 210:
                    this.ExtrusionDirection.X = pair.DoubleValue;
                    break;
                case 220:
                    this.ExtrusionDirection.Y = pair.DoubleValue;
                    break;
                case 230:
                    this.ExtrusionDirection.Z = pair.DoubleValue;
                    break;
                case 280:
                    this.WizardFlag = (pair.ShortValue);
                    break;
                default:
                    return base.TrySetPair(pair);
            }

            return true;
        }
    }
}
