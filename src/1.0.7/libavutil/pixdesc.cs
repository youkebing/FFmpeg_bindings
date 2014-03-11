//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace libavutil
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct AVComponentDescriptor
    {
        /// <summary>
        /// < which of the 4 planes contains the component
        /// </summary>
        [FieldOffset(0)]
        public ushort plane;

        /// <summary>
        /// Number of elements between 2 horizontally consecutive pixels minus
        /// 1.
        /// Elements are bits for bitstream formats, bytes otherwise.
        /// </summary>
        [FieldOffset(0)]
        public ushort step_minus1;

        /// <summary>
        /// Number of elements before the component of the first pixel plus 1.
        /// Elements are bits for bitstream formats, bytes otherwise.
        /// </summary>
        [FieldOffset(0)]
        public ushort offset_plus1;

        /// <summary>
        /// < number of least significant bits that must be shifted away to get
        /// the value
        /// </summary>
        [FieldOffset(1)]
        public ushort shift;

        /// <summary>
        /// < number of bits in the component minus 1
        /// </summary>
        [FieldOffset(1)]
        public ushort depth_minus1;
    }

    /// <summary>
    /// Descriptor that unambiguously describes how the bits of a pixel are
    /// stored in the up to 4 data planes of an image. It also stores the
    /// subsampling factors and number of components.
    /// 
    /// @note This is separate of the colorspace (RGB, YCbCr, YPbPr, JPEG-style
    /// YUV
    /// and all the YUV variants) AVPixFmtDescriptor just stores how values
    /// are stored not what these values represent.
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct AVPixFmtDescriptor
    {
        [FieldOffset(0)]
        public global::System.IntPtr name;

        /// <summary>
        /// < The number of components each pixel has, (1-4)
        /// </summary>
        [FieldOffset(4)]
        public byte nb_components;

        /// <summary>
        /// < chroma_width = -((-luma_width )>>log2_chroma_w)
        /// </summary>
        [FieldOffset(5)]
        public byte log2_chroma_w;

        /// <summary>
        /// Amount to shift the luma height right to find the chroma height.
        /// For YV12 this is 1 for example.
        /// chroma_height= -((-luma_height) >> log2_chroma_h)
        /// The note above is needed to ensure rounding up.
        /// This value only refers to the chroma components.
        /// </summary>
        [FieldOffset(6)]
        public byte log2_chroma_h;

        [FieldOffset(7)]
        public byte flags;

        /// <summary>
        /// Parameters that describe how pixels are packed.
        /// If the format has 2 or 4 components, then alpha is last.
        /// If the format has 1 or 2 components, then luma is 0.
        /// If the format has 3 or 4 components,
        /// if the RGB flag is set then 0 is red, 1 is green and 2 is blue;
        /// otherwise 0 is luma, 1 is chroma-U and 2 is chroma-V.
        /// </summary>
        [FieldOffset(8)]
        public AVComponentDescriptor* comp_0;

        /// <summary>
        /// Parameters that describe how pixels are packed.
        /// If the format has 2 or 4 components, then alpha is last.
        /// If the format has 1 or 2 components, then luma is 0.
        /// If the format has 3 or 4 components,
        /// if the RGB flag is set then 0 is red, 1 is green and 2 is blue;
        /// otherwise 0 is luma, 1 is chroma-U and 2 is chroma-V.
        /// </summary>
        [FieldOffset(12)]
        public AVComponentDescriptor* comp_1;

        /// <summary>
        /// Parameters that describe how pixels are packed.
        /// If the format has 2 or 4 components, then alpha is last.
        /// If the format has 1 or 2 components, then luma is 0.
        /// If the format has 3 or 4 components,
        /// if the RGB flag is set then 0 is red, 1 is green and 2 is blue;
        /// otherwise 0 is luma, 1 is chroma-U and 2 is chroma-V.
        /// </summary>
        [FieldOffset(16)]
        public AVComponentDescriptor* comp_2;

        /// <summary>
        /// Parameters that describe how pixels are packed.
        /// If the format has 2 or 4 components, then alpha is last.
        /// If the format has 1 or 2 components, then luma is 0.
        /// If the format has 3 or 4 components,
        /// if the RGB flag is set then 0 is red, 1 is green and 2 is blue;
        /// otherwise 0 is luma, 1 is chroma-U and 2 is chroma-V.
        /// </summary>
        [FieldOffset(20)]
        public AVComponentDescriptor* comp_3;
    }

    public unsafe partial class libavutil
    {
        /// <summary>
        /// Read a line from an image, and write the values of the
        /// pixel format component c to dst.
        /// 
        /// @param data the array containing the pointers to the planes of the
        /// image
        /// @param linesize the array containing the linesizes of the image
        /// @param desc the pixel format descriptor for the image
        /// @param x the horizontal coordinate of the first pixel to read
        /// @param y the vertical coordinate of the first pixel to read
        /// @param w the width of the line to read, that is the number of
        /// values to write to dst
        /// @param read_pal_component if not zero and the format is a paletted
        /// format writes the values corresponding to the palette
        /// component c in data[1] to dst, rather than the palette indexes in
        /// data[0]. The behavior is undefined if the format is not paletted.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_read_image_line")]
        internal static extern void av_read_image_line(ushort* dst, byte* data, int* linesize, AVPixFmtDescriptor* desc, int x, int y, int c, int w, int read_pal_component);

        /// <summary>
        /// Write the values from src to the pixel format component c of an
        /// image line.
        /// 
        /// @param src array containing the values to write
        /// @param data the array containing the pointers to the planes of the
        /// image to write into. It is supposed to be zeroed.
        /// @param linesize the array containing the linesizes of the image
        /// @param desc the pixel format descriptor for the image
        /// @param x the horizontal coordinate of the first pixel to write
        /// @param y the vertical coordinate of the first pixel to write
        /// @param w the width of the line to write, that is the number of
        /// values to write to the image line
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_write_image_line")]
        internal static extern void av_write_image_line(ushort* src, byte* data, int* linesize, AVPixFmtDescriptor* desc, int x, int y, int c, int w);

        /// <summary>
        /// Return the pixel format corresponding to name.
        /// 
        /// If there is no pixel format with name name, then looks for a
        /// pixel format with the name corresponding to the native endian
        /// format of name.
        /// For example in a little-endian system, first looks for "gray16",
        /// then for "gray16le".
        /// 
        /// Finally if no pixel format has been found, returns PIX_FMT_NONE.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_get_pix_fmt")]
        internal static extern PixelFormat av_get_pix_fmt(global::System.IntPtr name);

        /// <summary>
        /// Return the short name for a pixel format, NULL in case pix_fmt is
        /// unknown.
        /// 
        /// @see av_get_pix_fmt(), av_get_pix_fmt_string()
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_get_pix_fmt_name")]
        internal static extern global::System.IntPtr av_get_pix_fmt_name(PixelFormat pix_fmt);

        /// <summary>
        /// Print in buf the string corresponding to the pixel format with
        /// number pix_fmt, or an header if pix_fmt is negative.
        /// 
        /// @param buf the buffer where to write the string
        /// @param buf_size the size of buf
        /// @param pix_fmt the number of the pixel format to print the
        /// corresponding info string, or a negative value to print the
        /// corresponding header.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_get_pix_fmt_string")]
        internal static extern sbyte* av_get_pix_fmt_string(sbyte* buf, int buf_size, PixelFormat pix_fmt);

        /// <summary>
        /// Return the number of bits per pixel used by the pixel format
        /// described by pixdesc.
        /// 
        /// The returned number of bits refers to the number of bits actually
        /// used for storing the pixel information, that is padding bits are
        /// not counted.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport("avutil-if-51.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            EntryPoint="av_get_bits_per_pixel")]
        internal static extern int av_get_bits_per_pixel(AVPixFmtDescriptor* pixdesc);
    }
}