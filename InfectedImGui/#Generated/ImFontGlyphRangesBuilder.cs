// This file was automatically generated by Biohazrd and should not be modified by hand!
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Size = 16)]
public unsafe partial struct ImFontGlyphRangesBuilder
{
    [FieldOffset(0)] public ImVector<uint> UsedChars;

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "??0ImFontGlyphRangesBuilder@@QEAA@XZ", ExactSpelling = true)]
    private static extern void Constructor_PInvoke(ImFontGlyphRangesBuilder* @this);

    public unsafe void Constructor()
    {
        fixed (ImFontGlyphRangesBuilder* @this = &this)
        { Constructor_PInvoke(@this); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?Clear@ImFontGlyphRangesBuilder@@QEAAXXZ", ExactSpelling = true)]
    private static extern void Clear_PInvoke(ImFontGlyphRangesBuilder* @this);

    public unsafe void Clear()
    {
        fixed (ImFontGlyphRangesBuilder* @this = &this)
        { Clear_PInvoke(@this); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?GetBit@ImFontGlyphRangesBuilder@@QEBA_N_K@Z", ExactSpelling = true)]
    private static extern bool GetBit_PInvoke(ImFontGlyphRangesBuilder* @this, ulong n);

    public unsafe bool GetBit(ulong n)
    {
        fixed (ImFontGlyphRangesBuilder* @this = &this)
        { return GetBit_PInvoke(@this, n); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?SetBit@ImFontGlyphRangesBuilder@@QEAAX_K@Z", ExactSpelling = true)]
    private static extern void SetBit_PInvoke(ImFontGlyphRangesBuilder* @this, ulong n);

    public unsafe void SetBit(ulong n)
    {
        fixed (ImFontGlyphRangesBuilder* @this = &this)
        { SetBit_PInvoke(@this, n); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddChar@ImFontGlyphRangesBuilder@@QEAAXG@Z", ExactSpelling = true)]
    private static extern void AddChar_PInvoke(ImFontGlyphRangesBuilder* @this, ushort c);

    public unsafe void AddChar(ushort c)
    {
        fixed (ImFontGlyphRangesBuilder* @this = &this)
        { AddChar_PInvoke(@this, c); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddText@ImFontGlyphRangesBuilder@@QEAAXPEBD0@Z", ExactSpelling = true)]
    private static extern void AddText_PInvoke(ImFontGlyphRangesBuilder* @this, byte* text, byte* text_end);

    public unsafe void AddText(byte* text, byte* text_end = null)
    {
        fixed (ImFontGlyphRangesBuilder* @this = &this)
        { AddText_PInvoke(@this, text, text_end); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?AddRanges@ImFontGlyphRangesBuilder@@QEAAXPEBG@Z", ExactSpelling = true)]
    private static extern void AddRanges_PInvoke(ImFontGlyphRangesBuilder* @this, ushort* ranges);

    public unsafe void AddRanges(ushort* ranges)
    {
        fixed (ImFontGlyphRangesBuilder* @this = &this)
        { AddRanges_PInvoke(@this, ranges); }
    }

    [DllImport("InfectedImGui.Native.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "?BuildRanges@ImFontGlyphRangesBuilder@@QEAAXPEAU?$ImVector@G@@@Z", ExactSpelling = true)]
    private static extern void BuildRanges_PInvoke(ImFontGlyphRangesBuilder* @this, ImVector<ushort>* out_ranges);

    public unsafe void BuildRanges(ImVector<ushort>* out_ranges)
    {
        fixed (ImFontGlyphRangesBuilder* @this = &this)
        { BuildRanges_PInvoke(@this, out_ranges); }
    }
}
