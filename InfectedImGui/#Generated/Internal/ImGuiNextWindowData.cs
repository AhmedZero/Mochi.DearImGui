// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace InfectedImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 152)]
    public unsafe partial struct ImGuiNextWindowData
    {
        [FieldOffset(0)] public ImGuiNextWindowDataFlags Flags;

        [FieldOffset(4)] public ImGuiCond PosCond;

        [FieldOffset(8)] public ImGuiCond SizeCond;

        [FieldOffset(12)] public ImGuiCond CollapsedCond;

        [FieldOffset(16)] public ImGuiCond DockCond;

        [FieldOffset(20)] public ImVec2 PosVal;

        [FieldOffset(28)] public ImVec2 PosPivotVal;

        [FieldOffset(36)] public ImVec2 SizeVal;

        [FieldOffset(44)] public ImVec2 ContentSizeVal;

        [FieldOffset(52)] public ImVec2 ScrollVal;

        [FieldOffset(60)] [MarshalAs(UnmanagedType.I1)] public bool PosUndock;

        [FieldOffset(61)] [MarshalAs(UnmanagedType.I1)] public bool CollapsedVal;

        [FieldOffset(64)] public ImRect SizeConstraintRect;

        [FieldOffset(80)] public delegate* unmanaged[Cdecl]<ImGuiSizeCallbackData*, void> SizeCallback;

        [FieldOffset(88)] public void* SizeCallbackUserData;

        [FieldOffset(96)] public float BgAlphaVal;

        [FieldOffset(100)] public uint ViewportId;

        [FieldOffset(104)] public uint DockId;

        [FieldOffset(108)] public ImGuiWindowClass WindowClass;

        [FieldOffset(140)] public ImVec2 MenuBarOffsetMinVal;

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper48", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiNextWindowData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor()
        {
            fixed (ImGuiNextWindowData* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN19ImGuiNextWindowData10ClearFlagsEv", ExactSpelling = true)]
        private static extern void ClearFlags_PInvoke(ImGuiNextWindowData* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClearFlags()
        {
            fixed (ImGuiNextWindowData* @this = &this)
            { ClearFlags_PInvoke(@this); }
        }
    }
}
