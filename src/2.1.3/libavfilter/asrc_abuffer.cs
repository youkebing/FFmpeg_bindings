//----------------------------------------------------------------------------
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
//----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using FFmpeg;

namespace FFmpeg
{
    public unsafe static partial class libavfilter
    {
        /// <summary>
        /// Queue an audio buffer to the audio buffer source.
        /// 
        /// @param abuffersrc audio source buffer context
        /// @param data pointers to the samples planes
        /// @param linesize linesizes of each audio buffer plane
        /// @param nb_samples number of samples per channel
        /// @param sample_fmt sample format of the audio data
        /// @param ch_layout channel layout of the audio data
        /// @param planar flag to indicate if audio data is planar or packed
        /// @param pts presentation timestamp of the audio buffer
        /// @param flags unused
        /// 
        /// @deprecated use av_buffersrc_add_ref() instead.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_asrc_buffer_add_samples")]
        public static extern int av_asrc_buffer_add_samples(libavfilter.AVFilterContext* abuffersrc, byte** data, int* linesize, int nb_samples, int sample_rate, int sample_fmt, long ch_layout, int planar, long pts, int flags);

        /// <summary>
        /// Queue an audio buffer to the audio buffer source.
        /// 
        /// This is similar to av_asrc_buffer_add_samples(), but the samples
        /// are stored in a buffer with known size.
        /// 
        /// @param abuffersrc audio source buffer context
        /// @param buf pointer to the samples data, packed is assumed
        /// @param size the size in bytes of the buffer, it must contain an
        /// integer number of samples
        /// @param sample_fmt sample format of the audio data
        /// @param ch_layout channel layout of the audio data
        /// @param pts presentation timestamp of the audio buffer
        /// @param flags unused
        /// 
        /// @deprecated use av_buffersrc_add_ref() instead.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_asrc_buffer_add_buffer")]
        public static extern int av_asrc_buffer_add_buffer(libavfilter.AVFilterContext* abuffersrc, byte* buf, int buf_size, int sample_rate, int sample_fmt, long ch_layout, int planar, long pts, int flags);

        /// <summary>
        /// Queue an audio buffer to the audio buffer source.
        /// 
        /// @param abuffersrc audio source buffer context
        /// @param samplesref buffer ref to queue
        /// @param flags unused
        /// 
        /// @deprecated use av_buffersrc_add_ref() instead.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFILTER_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_asrc_buffer_add_audio_buffer_ref")]
        public static extern int av_asrc_buffer_add_audio_buffer_ref(libavfilter.AVFilterContext* abuffersrc, libavfilter.AVFilterBufferRef* samplesref, int flags);
    }
}
