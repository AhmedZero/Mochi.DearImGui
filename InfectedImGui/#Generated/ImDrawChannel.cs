// <auto-generated>
// This file was automatically generated by Biohazrd and should not be modified by hand!
// </auto-generated>
#nullable enable
using System.Runtime.InteropServices;

namespace InfectedImGui
{
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public unsafe partial struct ImDrawChannel
    {
        [FieldOffset(0)] public ImVector<ImDrawCmd> _CmdBuffer;

        [FieldOffset(16)] public ImVector<ushort> _IdxBuffer;
    }
}
