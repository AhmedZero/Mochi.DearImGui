// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using InfectedImGui.Infrastructure;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace InfectedImGui
{
    [StructLayout(LayoutKind.Explicit, Size = 1076)]
    public unsafe partial struct ImGuiStyle
    {
        [FieldOffset(0)] public float Alpha;

        [FieldOffset(4)] public ImVec2 WindowPadding;

        [FieldOffset(12)] public float WindowRounding;

        [FieldOffset(16)] public float WindowBorderSize;

        [FieldOffset(20)] public ImVec2 WindowMinSize;

        [FieldOffset(28)] public ImVec2 WindowTitleAlign;

        [FieldOffset(36)] public ImGuiDir WindowMenuButtonPosition;

        [FieldOffset(40)] public float ChildRounding;

        [FieldOffset(44)] public float ChildBorderSize;

        [FieldOffset(48)] public float PopupRounding;

        [FieldOffset(52)] public float PopupBorderSize;

        [FieldOffset(56)] public ImVec2 FramePadding;

        [FieldOffset(64)] public float FrameRounding;

        [FieldOffset(68)] public float FrameBorderSize;

        [FieldOffset(72)] public ImVec2 ItemSpacing;

        [FieldOffset(80)] public ImVec2 ItemInnerSpacing;

        [FieldOffset(88)] public ImVec2 CellPadding;

        [FieldOffset(96)] public ImVec2 TouchExtraPadding;

        [FieldOffset(104)] public float IndentSpacing;

        [FieldOffset(108)] public float ColumnsMinSpacing;

        [FieldOffset(112)] public float ScrollbarSize;

        [FieldOffset(116)] public float ScrollbarRounding;

        [FieldOffset(120)] public float GrabMinSize;

        [FieldOffset(124)] public float GrabRounding;

        [FieldOffset(128)] public float LogSliderDeadzone;

        [FieldOffset(132)] public float TabRounding;

        [FieldOffset(136)] public float TabBorderSize;

        [FieldOffset(140)] public float TabMinWidthForCloseButton;

        [FieldOffset(144)] public ImGuiDir ColorButtonPosition;

        [FieldOffset(148)] public ImVec2 ButtonTextAlign;

        [FieldOffset(156)] public ImVec2 SelectableTextAlign;

        [FieldOffset(164)] public ImVec2 DisplayWindowPadding;

        [FieldOffset(172)] public ImVec2 DisplaySafeAreaPadding;

        [FieldOffset(180)] public float MouseCursorScale;

        [FieldOffset(184)] [MarshalAs(UnmanagedType.I1)] public bool AntiAliasedLines;

        [FieldOffset(185)] [MarshalAs(UnmanagedType.I1)] public bool AntiAliasedLinesUseTex;

        [FieldOffset(186)] [MarshalAs(UnmanagedType.I1)] public bool AntiAliasedFill;

        [FieldOffset(188)] public float CurveTessellationTol;

        [FieldOffset(192)] public float CircleTessellationMaxError;

        [FieldOffset(196)] public ConstantArray_ImVec4_55 Colors;

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImGuiStyleC1Ev", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiStyle* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor()
        {
            fixed (ImGuiStyle* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN10ImGuiStyle13ScaleAllSizesEf", ExactSpelling = true)]
        private static extern void ScaleAllSizes_PInvoke(ImGuiStyle* @this, float scale_factor);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ScaleAllSizes(float scale_factor)
        {
            fixed (ImGuiStyle* @this = &this)
            { ScaleAllSizes_PInvoke(@this, scale_factor); }
        }
    }
}
