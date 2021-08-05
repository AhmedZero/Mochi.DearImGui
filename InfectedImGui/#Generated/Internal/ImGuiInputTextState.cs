// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace InfectedImGui.Internal
{
    [StructLayout(LayoutKind.Explicit, Size = 3736)]
    public unsafe partial struct ImGuiInputTextState
    {
        [FieldOffset(0)] public uint ID;

        [FieldOffset(4)] public int CurLenW;

        [FieldOffset(8)] public int CurLenA;

        [FieldOffset(16)] public ImVector<ushort> TextW;

        [FieldOffset(32)] public ImVector<byte> TextA;

        [FieldOffset(48)] public ImVector<byte> InitialTextA;

        [FieldOffset(64)] [MarshalAs(UnmanagedType.I1)] public bool TextAIsValid;

        [FieldOffset(68)] public int BufCapacityA;

        [FieldOffset(72)] public float ScrollX;

        [FieldOffset(3704)] public float CursorAnim;

        [FieldOffset(3708)] [MarshalAs(UnmanagedType.I1)] public bool CursorFollow;

        [FieldOffset(3709)] [MarshalAs(UnmanagedType.I1)] public bool SelectedAllMouseLock;

        [FieldOffset(3710)] [MarshalAs(UnmanagedType.I1)] public bool Edited;

        [FieldOffset(3712)] public ImGuiInputTextFlags UserFlags;

        [FieldOffset(3720)] public delegate* unmanaged[Cdecl]<ImGuiInputTextCallbackData*, int> UserCallback;

        [FieldOffset(3728)] public void* UserCallbackData;

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper45", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImGuiInputTextState* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Constructor()
        {
            fixed (ImGuiInputTextState* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN19ImGuiInputTextState9ClearTextEv", ExactSpelling = true)]
        private static extern void ClearText_PInvoke(ImGuiInputTextState* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClearText()
        {
            fixed (ImGuiInputTextState* @this = &this)
            { ClearText_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN19ImGuiInputTextState15ClearFreeMemoryEv", ExactSpelling = true)]
        private static extern void ClearFreeMemory_PInvoke(ImGuiInputTextState* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClearFreeMemory()
        {
            fixed (ImGuiInputTextState* @this = &this)
            { ClearFreeMemory_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZNK19ImGuiInputTextState17GetUndoAvailCountEv", ExactSpelling = true)]
        private static extern int GetUndoAvailCount_PInvoke(ImGuiInputTextState* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetUndoAvailCount()
        {
            fixed (ImGuiInputTextState* @this = &this)
            { return GetUndoAvailCount_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZNK19ImGuiInputTextState17GetRedoAvailCountEv", ExactSpelling = true)]
        private static extern int GetRedoAvailCount_PInvoke(ImGuiInputTextState* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int GetRedoAvailCount()
        {
            fixed (ImGuiInputTextState* @this = &this)
            { return GetRedoAvailCount_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN19ImGuiInputTextState12OnKeyPressedEi", ExactSpelling = true)]
        private static extern void OnKeyPressed_PInvoke(ImGuiInputTextState* @this, int key);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void OnKeyPressed(int key)
        {
            fixed (ImGuiInputTextState* @this = &this)
            { OnKeyPressed_PInvoke(@this, key); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN19ImGuiInputTextState15CursorAnimResetEv", ExactSpelling = true)]
        private static extern void CursorAnimReset_PInvoke(ImGuiInputTextState* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CursorAnimReset()
        {
            fixed (ImGuiInputTextState* @this = &this)
            { CursorAnimReset_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN19ImGuiInputTextState11CursorClampEv", ExactSpelling = true)]
        private static extern void CursorClamp_PInvoke(ImGuiInputTextState* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CursorClamp()
        {
            fixed (ImGuiInputTextState* @this = &this)
            { CursorClamp_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZNK19ImGuiInputTextState12HasSelectionEv", ExactSpelling = true)]
        [return: MarshalAs(UnmanagedType.I1)]
        private static extern bool HasSelection_PInvoke(ImGuiInputTextState* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool HasSelection()
        {
            fixed (ImGuiInputTextState* @this = &this)
            { return HasSelection_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN19ImGuiInputTextState14ClearSelectionEv", ExactSpelling = true)]
        private static extern void ClearSelection_PInvoke(ImGuiInputTextState* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void ClearSelection()
        {
            fixed (ImGuiInputTextState* @this = &this)
            { ClearSelection_PInvoke(@this); }
        }

        [DllImport("libInfectedImGui.Native.so", CallingConvention = CallingConvention.Cdecl, EntryPoint = "_ZN19ImGuiInputTextState9SelectAllEv", ExactSpelling = true)]
        private static extern void SelectAll_PInvoke(ImGuiInputTextState* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SelectAll()
        {
            fixed (ImGuiInputTextState* @this = &this)
            { SelectAll_PInvoke(@this); }
        }
    }
}
