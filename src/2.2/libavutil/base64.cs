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
        /// <summary>
        /// Decode a base64-encoded string.
        /// </summary>
        /// <param name="out">
        /// buffer for decoded data
        /// </param>
        /// <param name="in">
        /// null-terminated input string
        /// </param>
        /// <param name="out_size">
        /// size in bytes of the out buffer, must be at
        /// least 3/4 of the length of in
        /// </param>
        /// <returns>
        /// number of bytes written, or a negative value in case of
        /// invalid input
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_base64_decode")]
        public static extern int av_base64_decode(byte* _out, string _in, int out_size);

        /// <summary>
        /// Encode data to base64 and null-terminate.
        /// </summary>
        /// <param name="out">
        /// buffer for encoded data
        /// </param>
        /// <param name="out_size">
        /// size in bytes of the out buffer (including the
        /// null terminator), must be at least AV_BASE64_SIZE(in_size)
        /// </param>
        /// <param name="in">
        /// input buffer containing the data to encode
        /// </param>
        /// <param name="in_size">
        /// size in bytes of the in buffer
        /// </param>
        /// <returns>
        /// out or NULL in case of error
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_base64_encode")]
        public static extern sbyte* av_base64_encode(System.Text.StringBuilder _out, int out_size, byte* _in, int in_size);
    }
}
