//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FFmpeg
{
    public unsafe static partial class libavutil
    {
        public const sbyte AV_BPRINT_SIZE_AUTOMATIC = 1;

        public const sbyte AV_BPRINT_SIZE_COUNT_ONLY = 0;

        /// <summary>
        /// Buffer to print data progressively
        /// 
        /// The string buffer grows as necessary and is always 0-terminated.
        /// The content of the string is never accessed, and thus is
        /// encoding-agnostic and can even hold binary data.
        /// 
        /// Small buffers are kept in the structure itself, and thus require no
        /// memory allocation at all (unless the contents of the buffer is needed
        /// after the structure goes out of scope). This is almost as lightweight
        /// as
        /// declaring a local "char buf[512]".
        /// 
        /// The length of the string can go beyond the allocated size: the buffer
        /// is
        /// then truncated, but the functions still keep account of the actual
        /// total
        /// length.
        /// 
        /// In other words, buf->len can be greater than buf->size and records the
        /// total length of what would have been to the buffer if there had been
        /// enough memory.
        /// 
        /// Append operations do not need to be tested for failure: if a memory
        /// allocation fails, data stop being appended to the buffer, but the
        /// length
        /// is still updated. This situation can be tested with
        /// av_bprint_is_complete().
        /// 
        /// The size_max field determines several possible behaviours:
        /// 
        /// size_max = -1 (= UINT_MAX) or any large value will let the buffer be
        /// reallocated as necessary, with an amortized linear cost.
        /// 
        /// size_max = 0 prevents writing anything to the buffer: only the total
        /// length is computed. The write operations can then possibly be repeated
        /// in
        /// a buffer with exactly the necessary size
        /// (using size_init = size_max = len + 1).
        /// 
        /// size_max = 1 is automatically replaced by the exact size available in
        /// the
        /// structure itself, thus ensuring no dynamic memory allocation. The
        /// internal buffer is large enough to hold a reasonable paragraph of text,
        /// such as the current paragraph.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVBPrint
        {
            public sbyte* str;

            public uint len;

            public uint size;

            public uint size_max;

            public fixed sbyte reserved_internal_buffer[1];

            public fixed sbyte reserved_padding[1004];

            [StructLayout(LayoutKind.Sequential)]
            public unsafe partial struct AVBPrint_anon
            {
                public sbyte* str;

                public uint len;

                public uint size;

                public uint size_max;

                public fixed sbyte reserved_internal_buffer[1];
            }
        }

        /// <summary>
        /// Init a print buffer.
        /// </summary>
        /// <param name="buf">
        /// buffer to init
        /// </param>
        /// <param name="size_init">
        /// initial size (including the final 0)
        /// </param>
        /// <param name="size_max">
        /// maximum size;
        /// 0 means do not write anything, just count the length;
        /// 1 is replaced by the maximum value for automatic storage;
        /// any large value means that the internal buffer will be
        /// reallocated as needed up to that limit; -1 is converted to
        /// UINT_MAX, the largest limit possible.
        /// Check also AV_BPRINT_SIZE_* macros.
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_bprint_init")]
        public static extern void av_bprint_init(libavutil.AVBPrint* buf, uint size_init, uint size_max);

        /// <summary>
        /// Init a print buffer using a pre-existing buffer.
        /// 
        /// The buffer will not be reallocated.
        /// </summary>
        /// <param name="buf">
        /// buffer structure to init
        /// </param>
        /// <param name="buffer">
        /// byte buffer to use for the string data
        /// </param>
        /// <param name="size">
        /// size of buffer
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_bprint_init_for_buffer")]
        public static extern void av_bprint_init_for_buffer(libavutil.AVBPrint* buf, System.Text.StringBuilder buffer, uint size);

        /// <summary>
        /// Append a formatted string to a print buffer.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_bprintf")]
        public static extern void av_bprintf(libavutil.AVBPrint* buf, string fmt);

        /// <summary>
        /// Append char c n times to a print buffer.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_bprint_chars")]
        public static extern void av_bprint_chars(libavutil.AVBPrint* buf, sbyte c, uint n);

        /// <summary>
        /// Append data to a print buffer.
        /// 
        /// param buf  bprint buffer to use
        /// param data pointer to data
        /// param size size of data
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_bprint_append_data")]
        public static extern void av_bprint_append_data(libavutil.AVBPrint* buf, string data, uint size);

        /// <summary>
        /// Allocate bytes in the buffer for external use.
        /// </summary>
        /// <param name="[in]">
        /// buf          buffer structure
        /// </param>
        /// <param name="[in]">
        /// size         required size
        /// </param>
        /// <param name="[out]">
        /// mem          pointer to the memory area
        /// </param>
        /// <param name="[out]">
        /// actual_size  size of the memory area after allocation;
        /// can be larger or smaller than size
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_bprint_get_buffer")]
        public static extern void av_bprint_get_buffer(libavutil.AVBPrint* buf, uint size, byte** mem, uint* actual_size);

        /// <summary>
        /// Allocate bytes in the buffer for external use.
        /// </summary>
        /// <param name="[in]">
        /// buf          buffer structure
        /// </param>
        /// <param name="[in]">
        /// size         required size
        /// </param>
        /// <param name="[out]">
        /// mem          pointer to the memory area
        /// </param>
        /// <param name="[out]">
        /// actual_size  size of the memory area after allocation;
        /// can be larger or smaller than size
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_bprint_get_buffer")]
        public static extern void av_bprint_get_buffer(libavutil.AVBPrint* buf, uint size, ref byte* mem, uint* actual_size);

        /// <summary>
        /// Reset the string to "" but keep internal allocated data.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_bprint_clear")]
        public static extern void av_bprint_clear(libavutil.AVBPrint* buf);

        /// <summary>
        /// Test if the print buffer is complete (not truncated).
        /// 
        /// It may have been truncated due to a memory allocation failure
        /// or the size_max limit (compare size and size_max if necessary).
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_bprint_is_complete")]
        public static extern int av_bprint_is_complete(libavutil.AVBPrint* buf);

        /// <summary>
        /// Finalize a print buffer.
        /// 
        /// The print buffer can no longer be used afterwards,
        /// but the len and size fields are still valid.
        /// 
        /// @arg[out] ret_str  if not NULL, used to return a permanent copy of the
        /// buffer contents, or NULL if memory allocation fails;
        /// if NULL, the buffer is discarded and freed
        /// </summary>
        /// <returns>
        /// 0 for success or error code (probably AVERROR(ENOMEM))
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_bprint_finalize")]
        public static extern int av_bprint_finalize(libavutil.AVBPrint* buf, sbyte** ret_str);

        /// <summary>
        /// Finalize a print buffer.
        /// 
        /// The print buffer can no longer be used afterwards,
        /// but the len and size fields are still valid.
        /// 
        /// @arg[out] ret_str  if not NULL, used to return a permanent copy of the
        /// buffer contents, or NULL if memory allocation fails;
        /// if NULL, the buffer is discarded and freed
        /// </summary>
        /// <returns>
        /// 0 for success or error code (probably AVERROR(ENOMEM))
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_bprint_finalize")]
        public static extern int av_bprint_finalize(libavutil.AVBPrint* buf, ref System.Text.StringBuilder ret_str);

        /// <summary>
        /// Escape the content in src and append it to dstbuf.
        /// </summary>
        /// <param name="dstbuf">
        /// already inited destination bprint buffer
        /// </param>
        /// <param name="src">
        /// string containing the text to escape
        /// </param>
        /// <param name="special_chars">
        /// string containing the special characters which
        /// need to be escaped, can be NULL
        /// </param>
        /// <param name="mode">
        /// escape mode to employ, see AV_ESCAPE_MODE_* macros.
        /// Any unknown value for mode will be considered equivalent to
        /// AV_ESCAPE_MODE_BACKSLASH, but this behaviour can change without
        /// notice.
        /// </param>
        /// <param name="flags">
        /// flags which control how to escape, see AV_ESCAPE_FLAG_* macros
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_bprint_escape")]
        public static extern void av_bprint_escape(libavutil.AVBPrint* dstbuf, string src, string special_chars, libavutil.AVEscapeMode mode, int flags);
    }
}
