// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using InfectedImGui.Internal;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace InfectedImGui
{
    [StructLayout(LayoutKind.Explicit, Size = 200)]
    public unsafe partial struct ImDrawList
    {
        [FieldOffset(0)] public ImVector<ImDrawCmd> CmdBuffer;

        [FieldOffset(16)] public ImVector<ushort> IdxBuffer;

        [FieldOffset(32)] public ImVector<ImDrawVert> VtxBuffer;

        [FieldOffset(48)] public ImDrawListFlags Flags;

        [FieldOffset(52)] public uint _VtxCurrentIdx;

        [FieldOffset(56)] public ImDrawListSharedData* _Data;

        [FieldOffset(64)] public byte* _OwnerName;

        [FieldOffset(72)] public ImDrawVert* _VtxWritePtr;

        [FieldOffset(80)] public ushort* _IdxWritePtr;

        [FieldOffset(88)] public ImVector<ImVec4> _ClipRectStack;

        [FieldOffset(104)] public ImVector<nint> _TextureIdStack;

        [FieldOffset(120)] public ImVector<ImVec2> _Path;

        [FieldOffset(136)] public ImDrawCmdHeader _CmdHeader;

        [FieldOffset(168)] public ImDrawListSplitter _Splitter;

        [FieldOffset(192)] public float _FringeScale;

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper23", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImDrawList* @this, ImDrawListSharedData* shared_data);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor(ImDrawListSharedData* shared_data)
        {
            fixed (ImDrawList* @this = &this)
            { Constructor_PInvoke(@this, shared_data); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper24", ExactSpelling = true)]
        private static extern void Destructor_PInvoke(ImDrawList* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Destructor()
        {
            fixed (ImDrawList* @this = &this)
            { Destructor_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList12PushClipRectE6ImVec2S0_b", ExactSpelling = true)]
        private static extern void PushClipRect_PInvoke(ImDrawList* @this, ImVec2 clip_rect_min, ImVec2 clip_rect_max, [MarshalAs(UnmanagedType.I1)] bool intersect_with_current_clip_rect);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushClipRect(ImVec2 clip_rect_min, ImVec2 clip_rect_max, bool intersect_with_current_clip_rect = false)
        {
            fixed (ImDrawList* @this = &this)
            { PushClipRect_PInvoke(@this, clip_rect_min, clip_rect_max, intersect_with_current_clip_rect); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList22PushClipRectFullScreenEv", ExactSpelling = true)]
        private static extern void PushClipRectFullScreen_PInvoke(ImDrawList* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushClipRectFullScreen()
        {
            fixed (ImDrawList* @this = &this)
            { PushClipRectFullScreen_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList11PopClipRectEv", ExactSpelling = true)]
        private static extern void PopClipRect_PInvoke(ImDrawList* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PopClipRect()
        {
            fixed (ImDrawList* @this = &this)
            { PopClipRect_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList13PushTextureIDEPv", ExactSpelling = true)]
        private static extern void PushTextureID_PInvoke(ImDrawList* @this, void* texture_id);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PushTextureID(void* texture_id)
        {
            fixed (ImDrawList* @this = &this)
            { PushTextureID_PInvoke(@this, texture_id); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList12PopTextureIDEv", ExactSpelling = true)]
        private static extern void PopTextureID_PInvoke(ImDrawList* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PopTextureID()
        {
            fixed (ImDrawList* @this = &this)
            { PopTextureID_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZNK10ImDrawList14GetClipRectMinEv", ExactSpelling = true)]
        private static extern ImVec2 GetClipRectMin_PInvoke(ImDrawList* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImVec2 GetClipRectMin()
        {
            fixed (ImDrawList* @this = &this)
            { return GetClipRectMin_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZNK10ImDrawList14GetClipRectMaxEv", ExactSpelling = true)]
        private static extern ImVec2 GetClipRectMax_PInvoke(ImDrawList* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImVec2 GetClipRectMax()
        {
            fixed (ImDrawList* @this = &this)
            { return GetClipRectMax_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList7AddLineERK6ImVec2S2_jf", ExactSpelling = true)]
        private static extern void AddLine_PInvoke(ImDrawList* @this, ImVec2* p1, ImVec2* p2, uint col, float thickness);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddLine(ImVec2* p1, ImVec2* p2, uint col, float thickness = 1f)
        {
            fixed (ImDrawList* @this = &this)
            { AddLine_PInvoke(@this, p1, p2, col, thickness); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList7AddRectERK6ImVec2S2_jfif", ExactSpelling = true)]
        private static extern void AddRect_PInvoke(ImDrawList* @this, ImVec2* p_min, ImVec2* p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners, float thickness);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRect(ImVec2* p_min, ImVec2* p_max, uint col, float rounding = 0f, ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All, float thickness = 1f)
        {
            fixed (ImDrawList* @this = &this)
            { AddRect_PInvoke(@this, p_min, p_max, col, rounding, rounding_corners, thickness); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList13AddRectFilledERK6ImVec2S2_jfi", ExactSpelling = true)]
        private static extern void AddRectFilled_PInvoke(ImDrawList* @this, ImVec2* p_min, ImVec2* p_max, uint col, float rounding, ImDrawCornerFlags rounding_corners);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRectFilled(ImVec2* p_min, ImVec2* p_max, uint col, float rounding = 0f, ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All)
        {
            fixed (ImDrawList* @this = &this)
            { AddRectFilled_PInvoke(@this, p_min, p_max, col, rounding, rounding_corners); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList23AddRectFilledMultiColorERK6ImVec2S2_jjjj", ExactSpelling = true)]
        private static extern void AddRectFilledMultiColor_PInvoke(ImDrawList* @this, ImVec2* p_min, ImVec2* p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddRectFilledMultiColor(ImVec2* p_min, ImVec2* p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left)
        {
            fixed (ImDrawList* @this = &this)
            { AddRectFilledMultiColor_PInvoke(@this, p_min, p_max, col_upr_left, col_upr_right, col_bot_right, col_bot_left); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList7AddQuadERK6ImVec2S2_S2_S2_jf", ExactSpelling = true)]
        private static extern void AddQuad_PInvoke(ImDrawList* @this, ImVec2* p1, ImVec2* p2, ImVec2* p3, ImVec2* p4, uint col, float thickness);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddQuad(ImVec2* p1, ImVec2* p2, ImVec2* p3, ImVec2* p4, uint col, float thickness = 1f)
        {
            fixed (ImDrawList* @this = &this)
            { AddQuad_PInvoke(@this, p1, p2, p3, p4, col, thickness); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList13AddQuadFilledERK6ImVec2S2_S2_S2_j", ExactSpelling = true)]
        private static extern void AddQuadFilled_PInvoke(ImDrawList* @this, ImVec2* p1, ImVec2* p2, ImVec2* p3, ImVec2* p4, uint col);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddQuadFilled(ImVec2* p1, ImVec2* p2, ImVec2* p3, ImVec2* p4, uint col)
        {
            fixed (ImDrawList* @this = &this)
            { AddQuadFilled_PInvoke(@this, p1, p2, p3, p4, col); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList11AddTriangleERK6ImVec2S2_S2_jf", ExactSpelling = true)]
        private static extern void AddTriangle_PInvoke(ImDrawList* @this, ImVec2* p1, ImVec2* p2, ImVec2* p3, uint col, float thickness);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddTriangle(ImVec2* p1, ImVec2* p2, ImVec2* p3, uint col, float thickness = 1f)
        {
            fixed (ImDrawList* @this = &this)
            { AddTriangle_PInvoke(@this, p1, p2, p3, col, thickness); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList17AddTriangleFilledERK6ImVec2S2_S2_j", ExactSpelling = true)]
        private static extern void AddTriangleFilled_PInvoke(ImDrawList* @this, ImVec2* p1, ImVec2* p2, ImVec2* p3, uint col);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddTriangleFilled(ImVec2* p1, ImVec2* p2, ImVec2* p3, uint col)
        {
            fixed (ImDrawList* @this = &this)
            { AddTriangleFilled_PInvoke(@this, p1, p2, p3, col); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList9AddCircleERK6ImVec2fjif", ExactSpelling = true)]
        private static extern void AddCircle_PInvoke(ImDrawList* @this, ImVec2* center, float radius, uint col, int num_segments, float thickness);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddCircle(ImVec2* center, float radius, uint col, int num_segments = 0, float thickness = 1f)
        {
            fixed (ImDrawList* @this = &this)
            { AddCircle_PInvoke(@this, center, radius, col, num_segments, thickness); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList15AddCircleFilledERK6ImVec2fji", ExactSpelling = true)]
        private static extern void AddCircleFilled_PInvoke(ImDrawList* @this, ImVec2* center, float radius, uint col, int num_segments);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddCircleFilled(ImVec2* center, float radius, uint col, int num_segments = 0)
        {
            fixed (ImDrawList* @this = &this)
            { AddCircleFilled_PInvoke(@this, center, radius, col, num_segments); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList7AddNgonERK6ImVec2fjif", ExactSpelling = true)]
        private static extern void AddNgon_PInvoke(ImDrawList* @this, ImVec2* center, float radius, uint col, int num_segments, float thickness);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddNgon(ImVec2* center, float radius, uint col, int num_segments, float thickness = 1f)
        {
            fixed (ImDrawList* @this = &this)
            { AddNgon_PInvoke(@this, center, radius, col, num_segments, thickness); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList13AddNgonFilledERK6ImVec2fji", ExactSpelling = true)]
        private static extern void AddNgonFilled_PInvoke(ImDrawList* @this, ImVec2* center, float radius, uint col, int num_segments);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddNgonFilled(ImVec2* center, float radius, uint col, int num_segments)
        {
            fixed (ImDrawList* @this = &this)
            { AddNgonFilled_PInvoke(@this, center, radius, col, num_segments); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList7AddTextERK6ImVec2jPKcS4_", ExactSpelling = true)]
        private static extern void AddText_PInvoke(ImDrawList* @this, ImVec2* pos, uint col, byte* text_begin, byte* text_end);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddText(ImVec2* pos, uint col, byte* text_begin, byte* text_end = null)
        {
            fixed (ImDrawList* @this = &this)
            { AddText_PInvoke(@this, pos, col, text_begin, text_end); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList7AddTextEPK6ImFontfRK6ImVec2jPKcS7_fPK6ImVec4", ExactSpelling = true)]
        private static extern void AddText_PInvoke(ImDrawList* @this, ImFont* font, float font_size, ImVec2* pos, uint col, byte* text_begin, byte* text_end, float wrap_width, ImVec4* cpu_fine_clip_rect);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddText(ImFont* font, float font_size, ImVec2* pos, uint col, byte* text_begin, byte* text_end = null, float wrap_width = 0f, ImVec4* cpu_fine_clip_rect = null)
        {
            fixed (ImDrawList* @this = &this)
            { AddText_PInvoke(@this, font, font_size, pos, col, text_begin, text_end, wrap_width, cpu_fine_clip_rect); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList11AddPolylineEPK6ImVec2ijbf", ExactSpelling = true)]
        private static extern void AddPolyline_PInvoke(ImDrawList* @this, ImVec2* points, int num_points, uint col, [MarshalAs(UnmanagedType.I1)] bool closed, float thickness);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddPolyline(ImVec2* points, int num_points, uint col, bool closed, float thickness)
        {
            fixed (ImDrawList* @this = &this)
            { AddPolyline_PInvoke(@this, points, num_points, col, closed, thickness); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList19AddConvexPolyFilledEPK6ImVec2ij", ExactSpelling = true)]
        private static extern void AddConvexPolyFilled_PInvoke(ImDrawList* @this, ImVec2* points, int num_points, uint col);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddConvexPolyFilled(ImVec2* points, int num_points, uint col)
        {
            fixed (ImDrawList* @this = &this)
            { AddConvexPolyFilled_PInvoke(@this, points, num_points, col); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList14AddBezierCubicERK6ImVec2S2_S2_S2_jfi", ExactSpelling = true)]
        private static extern void AddBezierCubic_PInvoke(ImDrawList* @this, ImVec2* p1, ImVec2* p2, ImVec2* p3, ImVec2* p4, uint col, float thickness, int num_segments);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddBezierCubic(ImVec2* p1, ImVec2* p2, ImVec2* p3, ImVec2* p4, uint col, float thickness, int num_segments = 0)
        {
            fixed (ImDrawList* @this = &this)
            { AddBezierCubic_PInvoke(@this, p1, p2, p3, p4, col, thickness, num_segments); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList18AddBezierQuadraticERK6ImVec2S2_S2_jfi", ExactSpelling = true)]
        private static extern void AddBezierQuadratic_PInvoke(ImDrawList* @this, ImVec2* p1, ImVec2* p2, ImVec2* p3, uint col, float thickness, int num_segments);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddBezierQuadratic(ImVec2* p1, ImVec2* p2, ImVec2* p3, uint col, float thickness, int num_segments = 0)
        {
            fixed (ImDrawList* @this = &this)
            { AddBezierQuadratic_PInvoke(@this, p1, p2, p3, col, thickness, num_segments); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList8AddImageEPvRK6ImVec2S3_S3_S3_j", ExactSpelling = true)]
        private static extern void AddImage_PInvoke(ImDrawList* @this, void* user_texture_id, ImVec2* p_min, ImVec2* p_max, ImVec2* uv_min, ImVec2* uv_max, uint col);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddImage(void* user_texture_id, ImVec2* p_min, ImVec2* p_max, ImVec2* uv_min, ImVec2* uv_max, uint col = 4294967295)
        {
            fixed (ImDrawList* @this = &this)
            { AddImage_PInvoke(@this, user_texture_id, p_min, p_max, uv_min, uv_max, col); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList12AddImageQuadEPvRK6ImVec2S3_S3_S3_S3_S3_S3_S3_j", ExactSpelling = true)]
        private static extern void AddImageQuad_PInvoke(ImDrawList* @this, void* user_texture_id, ImVec2* p1, ImVec2* p2, ImVec2* p3, ImVec2* p4, ImVec2* uv1, ImVec2* uv2, ImVec2* uv3, ImVec2* uv4, uint col);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddImageQuad(void* user_texture_id, ImVec2* p1, ImVec2* p2, ImVec2* p3, ImVec2* p4, ImVec2* uv1, ImVec2* uv2, ImVec2* uv3, ImVec2* uv4, uint col = 4294967295)
        {
            fixed (ImDrawList* @this = &this)
            { AddImageQuad_PInvoke(@this, user_texture_id, p1, p2, p3, p4, uv1, uv2, uv3, uv4, col); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList15AddImageRoundedEPvRK6ImVec2S3_S3_S3_jfi", ExactSpelling = true)]
        private static extern void AddImageRounded_PInvoke(ImDrawList* @this, void* user_texture_id, ImVec2* p_min, ImVec2* p_max, ImVec2* uv_min, ImVec2* uv_max, uint col, float rounding, ImDrawCornerFlags rounding_corners);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddImageRounded(void* user_texture_id, ImVec2* p_min, ImVec2* p_max, ImVec2* uv_min, ImVec2* uv_max, uint col, float rounding, ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All)
        {
            fixed (ImDrawList* @this = &this)
            { AddImageRounded_PInvoke(@this, user_texture_id, p_min, p_max, uv_min, uv_max, col, rounding, rounding_corners); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList9PathClearEv", ExactSpelling = true)]
        private static extern void PathClear_PInvoke(ImDrawList* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PathClear()
        {
            fixed (ImDrawList* @this = &this)
            { PathClear_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList10PathLineToERK6ImVec2", ExactSpelling = true)]
        private static extern void PathLineTo_PInvoke(ImDrawList* @this, ImVec2* pos);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PathLineTo(ImVec2* pos)
        {
            fixed (ImDrawList* @this = &this)
            { PathLineTo_PInvoke(@this, pos); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList24PathLineToMergeDuplicateERK6ImVec2", ExactSpelling = true)]
        private static extern void PathLineToMergeDuplicate_PInvoke(ImDrawList* @this, ImVec2* pos);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PathLineToMergeDuplicate(ImVec2* pos)
        {
            fixed (ImDrawList* @this = &this)
            { PathLineToMergeDuplicate_PInvoke(@this, pos); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList14PathFillConvexEj", ExactSpelling = true)]
        private static extern void PathFillConvex_PInvoke(ImDrawList* @this, uint col);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PathFillConvex(uint col)
        {
            fixed (ImDrawList* @this = &this)
            { PathFillConvex_PInvoke(@this, col); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList10PathStrokeEjbf", ExactSpelling = true)]
        private static extern void PathStroke_PInvoke(ImDrawList* @this, uint col, [MarshalAs(UnmanagedType.I1)] bool closed, float thickness);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PathStroke(uint col, bool closed, float thickness = 1f)
        {
            fixed (ImDrawList* @this = &this)
            { PathStroke_PInvoke(@this, col, closed, thickness); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList9PathArcToERK6ImVec2fffi", ExactSpelling = true)]
        private static extern void PathArcTo_PInvoke(ImDrawList* @this, ImVec2* center, float radius, float a_min, float a_max, int num_segments);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PathArcTo(ImVec2* center, float radius, float a_min, float a_max, int num_segments = 10)
        {
            fixed (ImDrawList* @this = &this)
            { PathArcTo_PInvoke(@this, center, radius, a_min, a_max, num_segments); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList13PathArcToFastERK6ImVec2fii", ExactSpelling = true)]
        private static extern void PathArcToFast_PInvoke(ImDrawList* @this, ImVec2* center, float radius, int a_min_of_12, int a_max_of_12);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PathArcToFast(ImVec2* center, float radius, int a_min_of_12, int a_max_of_12)
        {
            fixed (ImDrawList* @this = &this)
            { PathArcToFast_PInvoke(@this, center, radius, a_min_of_12, a_max_of_12); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList22PathBezierCubicCurveToERK6ImVec2S2_S2_i", ExactSpelling = true)]
        private static extern void PathBezierCubicCurveTo_PInvoke(ImDrawList* @this, ImVec2* p2, ImVec2* p3, ImVec2* p4, int num_segments);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PathBezierCubicCurveTo(ImVec2* p2, ImVec2* p3, ImVec2* p4, int num_segments = 0)
        {
            fixed (ImDrawList* @this = &this)
            { PathBezierCubicCurveTo_PInvoke(@this, p2, p3, p4, num_segments); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList26PathBezierQuadraticCurveToERK6ImVec2S2_i", ExactSpelling = true)]
        private static extern void PathBezierQuadraticCurveTo_PInvoke(ImDrawList* @this, ImVec2* p2, ImVec2* p3, int num_segments);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PathBezierQuadraticCurveTo(ImVec2* p2, ImVec2* p3, int num_segments = 0)
        {
            fixed (ImDrawList* @this = &this)
            { PathBezierQuadraticCurveTo_PInvoke(@this, p2, p3, num_segments); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList8PathRectERK6ImVec2S2_fi", ExactSpelling = true)]
        private static extern void PathRect_PInvoke(ImDrawList* @this, ImVec2* rect_min, ImVec2* rect_max, float rounding, ImDrawCornerFlags rounding_corners);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PathRect(ImVec2* rect_min, ImVec2* rect_max, float rounding = 0f, ImDrawCornerFlags rounding_corners = ImDrawCornerFlags.All)
        {
            fixed (ImDrawList* @this = &this)
            { PathRect_PInvoke(@this, rect_min, rect_max, rounding, rounding_corners); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList11AddCallbackEPFvPKS_PK9ImDrawCmdEPv", ExactSpelling = true)]
        private static extern void AddCallback_PInvoke(ImDrawList* @this, delegate* unmanaged[Cdecl]<ImDrawList*, ImDrawCmd*, void> callback, void* callback_data);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddCallback(delegate* unmanaged[Cdecl]<ImDrawList*, ImDrawCmd*, void> callback, void* callback_data)
        {
            fixed (ImDrawList* @this = &this)
            { AddCallback_PInvoke(@this, callback, callback_data); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList10AddDrawCmdEv", ExactSpelling = true)]
        private static extern void AddDrawCmd_PInvoke(ImDrawList* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void AddDrawCmd()
        {
            fixed (ImDrawList* @this = &this)
            { AddDrawCmd_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZNK10ImDrawList11CloneOutputEv", ExactSpelling = true)]
        private static extern ImDrawList* CloneOutput_PInvoke(ImDrawList* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ImDrawList* CloneOutput()
        {
            fixed (ImDrawList* @this = &this)
            { return CloneOutput_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList13ChannelsSplitEi", ExactSpelling = true)]
        private static extern void ChannelsSplit_PInvoke(ImDrawList* @this, int count);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ChannelsSplit(int count)
        {
            fixed (ImDrawList* @this = &this)
            { ChannelsSplit_PInvoke(@this, count); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList13ChannelsMergeEv", ExactSpelling = true)]
        private static extern void ChannelsMerge_PInvoke(ImDrawList* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ChannelsMerge()
        {
            fixed (ImDrawList* @this = &this)
            { ChannelsMerge_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList18ChannelsSetCurrentEi", ExactSpelling = true)]
        private static extern void ChannelsSetCurrent_PInvoke(ImDrawList* @this, int n);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ChannelsSetCurrent(int n)
        {
            fixed (ImDrawList* @this = &this)
            { ChannelsSetCurrent_PInvoke(@this, n); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList11PrimReserveEii", ExactSpelling = true)]
        private static extern void PrimReserve_PInvoke(ImDrawList* @this, int idx_count, int vtx_count);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PrimReserve(int idx_count, int vtx_count)
        {
            fixed (ImDrawList* @this = &this)
            { PrimReserve_PInvoke(@this, idx_count, vtx_count); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList13PrimUnreserveEii", ExactSpelling = true)]
        private static extern void PrimUnreserve_PInvoke(ImDrawList* @this, int idx_count, int vtx_count);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PrimUnreserve(int idx_count, int vtx_count)
        {
            fixed (ImDrawList* @this = &this)
            { PrimUnreserve_PInvoke(@this, idx_count, vtx_count); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList8PrimRectERK6ImVec2S2_j", ExactSpelling = true)]
        private static extern void PrimRect_PInvoke(ImDrawList* @this, ImVec2* a, ImVec2* b, uint col);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PrimRect(ImVec2* a, ImVec2* b, uint col)
        {
            fixed (ImDrawList* @this = &this)
            { PrimRect_PInvoke(@this, a, b, col); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList10PrimRectUVERK6ImVec2S2_S2_S2_j", ExactSpelling = true)]
        private static extern void PrimRectUV_PInvoke(ImDrawList* @this, ImVec2* a, ImVec2* b, ImVec2* uv_a, ImVec2* uv_b, uint col);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PrimRectUV(ImVec2* a, ImVec2* b, ImVec2* uv_a, ImVec2* uv_b, uint col)
        {
            fixed (ImDrawList* @this = &this)
            { PrimRectUV_PInvoke(@this, a, b, uv_a, uv_b, col); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList10PrimQuadUVERK6ImVec2S2_S2_S2_S2_S2_S2_S2_j", ExactSpelling = true)]
        private static extern void PrimQuadUV_PInvoke(ImDrawList* @this, ImVec2* a, ImVec2* b, ImVec2* c, ImVec2* d, ImVec2* uv_a, ImVec2* uv_b, ImVec2* uv_c, ImVec2* uv_d, uint col);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PrimQuadUV(ImVec2* a, ImVec2* b, ImVec2* c, ImVec2* d, ImVec2* uv_a, ImVec2* uv_b, ImVec2* uv_c, ImVec2* uv_d, uint col)
        {
            fixed (ImDrawList* @this = &this)
            { PrimQuadUV_PInvoke(@this, a, b, c, d, uv_a, uv_b, uv_c, uv_d, col); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList12PrimWriteVtxERK6ImVec2S2_j", ExactSpelling = true)]
        private static extern void PrimWriteVtx_PInvoke(ImDrawList* @this, ImVec2* pos, ImVec2* uv, uint col);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PrimWriteVtx(ImVec2* pos, ImVec2* uv, uint col)
        {
            fixed (ImDrawList* @this = &this)
            { PrimWriteVtx_PInvoke(@this, pos, uv, col); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList12PrimWriteIdxEt", ExactSpelling = true)]
        private static extern void PrimWriteIdx_PInvoke(ImDrawList* @this, ushort idx);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PrimWriteIdx(ushort idx)
        {
            fixed (ImDrawList* @this = &this)
            { PrimWriteIdx_PInvoke(@this, idx); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList7PrimVtxERK6ImVec2S2_j", ExactSpelling = true)]
        private static extern void PrimVtx_PInvoke(ImDrawList* @this, ImVec2* pos, ImVec2* uv, uint col);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void PrimVtx(ImVec2* pos, ImVec2* uv, uint col)
        {
            fixed (ImDrawList* @this = &this)
            { PrimVtx_PInvoke(@this, pos, uv, col); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList17_ResetForNewFrameEv", ExactSpelling = true)]
        private static extern void _ResetForNewFrame_PInvoke(ImDrawList* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void _ResetForNewFrame()
        {
            fixed (ImDrawList* @this = &this)
            { _ResetForNewFrame_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList16_ClearFreeMemoryEv", ExactSpelling = true)]
        private static extern void _ClearFreeMemory_PInvoke(ImDrawList* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void _ClearFreeMemory()
        {
            fixed (ImDrawList* @this = &this)
            { _ClearFreeMemory_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList17_PopUnusedDrawCmdEv", ExactSpelling = true)]
        private static extern void _PopUnusedDrawCmd_PInvoke(ImDrawList* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void _PopUnusedDrawCmd()
        {
            fixed (ImDrawList* @this = &this)
            { _PopUnusedDrawCmd_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList18_OnChangedClipRectEv", ExactSpelling = true)]
        private static extern void _OnChangedClipRect_PInvoke(ImDrawList* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void _OnChangedClipRect()
        {
            fixed (ImDrawList* @this = &this)
            { _OnChangedClipRect_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList19_OnChangedTextureIDEv", ExactSpelling = true)]
        private static extern void _OnChangedTextureID_PInvoke(ImDrawList* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void _OnChangedTextureID()
        {
            fixed (ImDrawList* @this = &this)
            { _OnChangedTextureID_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImDrawList19_OnChangedVtxOffsetEv", ExactSpelling = true)]
        private static extern void _OnChangedVtxOffset_PInvoke(ImDrawList* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void _OnChangedVtxOffset()
        {
            fixed (ImDrawList* @this = &this)
            { _OnChangedVtxOffset_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZNK10ImDrawList27_CalcCircleAutoSegmentCountEf", ExactSpelling = true)]
        private static extern int _CalcCircleAutoSegmentCount_PInvoke(ImDrawList* @this, float radius);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int _CalcCircleAutoSegmentCount(float radius)
        {
            fixed (ImDrawList* @this = &this)
            { return _CalcCircleAutoSegmentCount_PInvoke(@this, radius); }
        }
    }
}
