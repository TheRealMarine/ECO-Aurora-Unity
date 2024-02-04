// Copyright (c) Strange Loop Games. All rights reserved.
// See LICENSE file in the project root for full license information.

namespace Assets.EcoLibs.Utils.MiscUtils
{
    using Humanizer;
    using TMPro;

    /// <summary>Contains helper methods to build TMP assets.</summary>
    public static class TMPUtils
    {
        const float TmpOffsetX  = 5f;  //The horizontal distance from the current drawing position (origin) relative to the element's left bounding box edge (bbox).
        const float TmpOffsetY  = 64f; //The vertical distance from the current baseline relative to the element's top bounding box edge (bbox).
        const float TmpAdvanceX = 74f; //The horizontal distance to increase (left to right) or decrease (right to left) the drawing position relative to the origin of the text element.
        const float TmpWidth    = 64f; //The width of the glyph.
        const float TmpHeight   = 64f; //The height of the glyph.

        //These are fields for the FaceInfo - basically description for a font. 
        const int   FacePointSize   = 58;
        const float FaceScale       = 1f;
        const float FaceAscentLine  = 50f;
        const float FaceBaseline    = -18f;
        const float FaceDescentLine = -14f;

        /// <summary>Set up metrics of tmp glyphs, it decides on size and also on the offset.</summary>
        public static void FixGlyphs(TMP_SpriteGlyph spriteInfo)
        {
            var metrics                = spriteInfo.metrics;
            metrics.height             = TmpWidth;
            metrics.width              = TmpHeight;
            metrics.horizontalBearingX = TmpOffsetX;
            metrics.horizontalBearingY = TmpOffsetY;
            metrics.horizontalAdvance  = TmpAdvanceX;
            spriteInfo.metrics         = metrics;
            spriteInfo.scale           = 1;
        }

        public static void FixFaceInfoValues(TMP_SpriteAsset spriteAsset)
        {
            var faceInfo         = spriteAsset.faceInfo;
            faceInfo.pointSize   = FacePointSize;
            faceInfo.scale       = FaceScale;
            faceInfo.ascentLine  = FaceAscentLine;
            faceInfo.baseline    = FaceBaseline;
            faceInfo.descentLine = FaceDescentLine;

            // force call private methods for automatization purposes
            typeof(TMP_SpriteAsset).GetProperty("faceInfo").SetValue(spriteAsset, faceInfo);
        }
    }
}
