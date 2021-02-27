// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace InfectedImGui
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public unsafe partial struct ImDrawListSplitter
    {
        [FieldOffset(0)] public int _Current;

        [FieldOffset(4)] public int _Count;

        [FieldOffset(8)] public ImVector<ImDrawChannel> _Channels;

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper21", ExactSpelling = true)]
        private static extern void Constructor_PInvoke(ImDrawListSplitter* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Constructor()
        {
            fixed (ImDrawListSplitter* @this = &this)
            { Constructor_PInvoke(@this); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "__InlineHelper22", ExactSpelling = true)]
        private static extern void Destructor_PInvoke(ImDrawListSplitter* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Destructor()
        {
            fixed (ImDrawListSplitter* @this = &this)
            { Destructor_PInvoke(@this); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?Clear@ImDrawListSplitter@@QEAAXXZ", ExactSpelling = true)]
        private static extern void Clear_PInvoke(ImDrawListSplitter* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Clear()
        {
            fixed (ImDrawListSplitter* @this = &this)
            { Clear_PInvoke(@this); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?ClearFreeMemory@ImDrawListSplitter@@QEAAXXZ", ExactSpelling = true)]
        private static extern void ClearFreeMemory_PInvoke(ImDrawListSplitter* @this);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void ClearFreeMemory()
        {
            fixed (ImDrawListSplitter* @this = &this)
            { ClearFreeMemory_PInvoke(@this); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?Split@ImDrawListSplitter@@QEAAXPEAUImDrawList@@H@Z", ExactSpelling = true)]
        private static extern void Split_PInvoke(ImDrawListSplitter* @this, ImDrawList* draw_list, int count);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Split(ImDrawList* draw_list, int count)
        {
            fixed (ImDrawListSplitter* @this = &this)
            { Split_PInvoke(@this, draw_list, count); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?Merge@ImDrawListSplitter@@QEAAXPEAUImDrawList@@@Z", ExactSpelling = true)]
        private static extern void Merge_PInvoke(ImDrawListSplitter* @this, ImDrawList* draw_list);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void Merge(ImDrawList* draw_list)
        {
            fixed (ImDrawListSplitter* @this = &this)
            { Merge_PInvoke(@this, draw_list); }
        }

        [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?SetCurrentChannel@ImDrawListSplitter@@QEAAXPEAUImDrawList@@H@Z", ExactSpelling = true)]
        private static extern void SetCurrentChannel_PInvoke(ImDrawListSplitter* @this, ImDrawList* draw_list, int channel_idx);

        [DebuggerStepThrough, DebuggerHidden]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe void SetCurrentChannel(ImDrawList* draw_list, int channel_idx)
        {
            fixed (ImDrawListSplitter* @this = &this)
            { SetCurrentChannel_PInvoke(@this, draw_list, channel_idx); }
        }
    }
}
