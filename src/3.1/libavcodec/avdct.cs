//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
// ReSharper disable RedundantUsingDirective
// ReSharper disable CheckNamespace
#pragma warning disable 1584,1711,1572,1581,1580,1573
using System;
using System.Runtime.InteropServices;
using System.Security;
using FFmpeg;

namespace FFmpeg
{
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "UnusedMember.Global")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "InconsistentNaming")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "RedundantUnsafeContext")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "MemberCanBePrivate.Global")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "MemberCanBePrivate.Global")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "FieldCanBeMadeReadOnly.Global")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "PartialTypeWithSinglePart")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "RedundantNameQualifier")]
    [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("ReSharper", "ArrangeModifiersOrder")]
    public unsafe static partial class libavcodec
    {
        /// <summary>
        /// AVDCT context.
        /// </summary>
        /// <remark>
        /// function pointers can be NULL if the specific features have been
        /// disabled at build time.
        /// </remark>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVDCT
        {
            public libavutil.AVClass* av_class;

            public global::System.IntPtr idct;

            /// <summary>
            /// IDCT input permutation.
            /// Several optimized IDCTs need a permutated input (relative to the
            /// normal order of the reference IDCT).
            /// This permutation must be performed before the idct_put/add.
            /// Note, normally this can be merged with the zigzag/alternate
            /// scan&lt;br&gt;
            /// An example to avoid confusion:
            /// - (-&gt;decode coeffs -&gt; zigzag reorder -&gt; dequant -&gt;
            /// reference IDCT -&gt; ...)
            /// - (x -&gt; reference DCT -&gt; reference IDCT -&gt; x)
            /// - (x -&gt; reference DCT -&gt; simple_mmx_perm = idct_permutation
            /// -&gt; simple_idct_mmx -&gt; x)
            /// - (-&gt; decode coeffs -&gt; zigzag reorder -&gt; simple_mmx_perm -&gt;
            /// dequant
            /// -&gt; simple_idct_mmx -&gt; ...)
            /// </summary>
            public fixed byte idct_permutation[64];

            public global::System.IntPtr fdct;

            /// <summary>
            /// DCT algorithm.
            /// must use AVOptions to set this field.
            /// </summary>
            public int dct_algo;

            /// <summary>
            /// IDCT algorithm.
            /// must use AVOptions to set this field.
            /// </summary>
            public int idct_algo;

            public global::System.IntPtr get_pixels;

            public int bits_per_sample;
        }

        /// <summary>
        /// Allocates a AVDCT context.
        /// This needs to be initialized with avcodec_dct_init() after optionally
        /// configuring it with AVOptions.
        /// 
        /// To free it use av_free()
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avcodec_dct_alloc")]
        public static extern libavcodec.AVDCT* avcodec_dct_alloc();

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avcodec_dct_init")]
        public static extern int avcodec_dct_init(libavcodec.AVDCT* _0);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVCODEC_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avcodec_dct_get_class")]
        public static extern libavutil.AVClass* avcodec_dct_get_class();
    }
}