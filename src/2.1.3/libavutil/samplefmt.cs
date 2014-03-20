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
        /// Audio Sample Formats
        /// 
        /// @par
        /// The data described by the sample format is always in native-endian
        /// order.
        /// Sample values can be expressed by native C types, hence the lack of a
        /// signed
        /// 24-bit sample format even though it is a common raw audio data format.
        /// 
        /// @par
        /// The floating-point formats are based on full volume being in the range
        /// [-1.0, 1.0]. Any values outside this range are beyond full volume
        /// level.
        /// 
        /// @par
        /// The data layout as used in av_samples_fill_arrays() and elsewhere in
        /// FFmpeg
        /// (such as AVFrame in libavcodec) is as follows:
        /// 
        /// For planar sample formats, each audio channel is in a separate data
        /// plane,
        /// and linesize is the buffer size, in bytes, for a single plane. All data
        /// planes must be the same size. For packed sample formats, only the first
        /// data
        /// plane is used, and samples for each channel are interleaved. In this
        /// case,
        /// linesize is the buffer size, in bytes, for the 1 plane.
        /// </summary>
        public enum AVSampleFormat
        {
            AV_SAMPLE_FMT_NONE = -1,
            /// <summary>unsigned 8 bits</summary>
            AV_SAMPLE_FMT_U8 = 0,
            /// <summary>signed 16 bits</summary>
            AV_SAMPLE_FMT_S16 = 1,
            /// <summary>signed 32 bits</summary>
            AV_SAMPLE_FMT_S32 = 2,
            /// <summary>float</summary>
            AV_SAMPLE_FMT_FLT = 3,
            /// <summary>double</summary>
            AV_SAMPLE_FMT_DBL = 4,
            /// <summary>unsigned 8 bits, planar</summary>
            AV_SAMPLE_FMT_U8P = 5,
            /// <summary>signed 16 bits, planar</summary>
            AV_SAMPLE_FMT_S16P = 6,
            /// <summary>signed 32 bits, planar</summary>
            AV_SAMPLE_FMT_S32P = 7,
            /// <summary>float, planar</summary>
            AV_SAMPLE_FMT_FLTP = 8,
            /// <summary>double, planar</summary>
            AV_SAMPLE_FMT_DBLP = 9,
            /// <summary>Number of sample formats. DO NOT USE if linking dynamically</summary>
            AV_SAMPLE_FMT_NB = 10
        }

        /// <summary>
        /// Return the name of sample_fmt, or NULL if sample_fmt is not
        /// recognized.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_sample_fmt_name")]
        public static extern sbyte* av_get_sample_fmt_name(libavutil.AVSampleFormat sample_fmt);

        /// <summary>
        /// Return a sample format corresponding to name, or AV_SAMPLE_FMT_NONE
        /// on error.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_sample_fmt")]
        public static extern libavutil.AVSampleFormat av_get_sample_fmt(string name);

        /// <summary>
        /// Return the planar<->packed alternative form of the given sample format,
        /// or
        /// AV_SAMPLE_FMT_NONE on error. If the passed sample_fmt is already in the
        /// requested planar/packed format, the format returned is the same as the
        /// input.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_alt_sample_fmt")]
        public static extern libavutil.AVSampleFormat av_get_alt_sample_fmt(libavutil.AVSampleFormat sample_fmt, int planar);

        /// <summary>
        /// Get the packed alternative form of the given sample format.
        /// 
        /// If the passed sample_fmt is already in packed format, the format
        /// returned is
        /// the same as the input.
        /// </summary>
        /// <returns>
        /// the packed alternative form of the given sample format or
        /// AV_SAMPLE_FMT_NONE on error.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_packed_sample_fmt")]
        public static extern libavutil.AVSampleFormat av_get_packed_sample_fmt(libavutil.AVSampleFormat sample_fmt);

        /// <summary>
        /// Get the planar alternative form of the given sample format.
        /// 
        /// If the passed sample_fmt is already in planar format, the format
        /// returned is
        /// the same as the input.
        /// </summary>
        /// <returns>
        /// the planar alternative form of the given sample format or
        /// AV_SAMPLE_FMT_NONE on error.
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_planar_sample_fmt")]
        public static extern libavutil.AVSampleFormat av_get_planar_sample_fmt(libavutil.AVSampleFormat sample_fmt);

        /// <summary>
        /// Generate a string corresponding to the sample format with
        /// sample_fmt, or a header if sample_fmt is negative.
        /// </summary>
        /// <param name="buf">
        /// the buffer where to write the string
        /// </param>
        /// <param name="buf_size">
        /// the size of buf
        /// </param>
        /// <param name="sample_fmt">
        /// the number of the sample format to print the
        /// corresponding info string, or a negative value to print the
        /// corresponding header.
        /// </param>
        /// <returns>
        /// the pointer to the filled buffer or NULL if sample_fmt is
        /// unknown or in case of other errors
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_sample_fmt_string")]
        public static extern sbyte* av_get_sample_fmt_string(System.Text.StringBuilder buf, int buf_size, libavutil.AVSampleFormat sample_fmt);

        [System.ObsoleteAttribute()]
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_bits_per_sample_fmt")]
        public static extern int av_get_bits_per_sample_fmt(libavutil.AVSampleFormat sample_fmt);

        /// <summary>
        /// Return number of bytes per sample.
        /// </summary>
        /// <param name="sample_fmt">
        /// the sample format
        /// </param>
        /// <returns>
        /// number of bytes per sample or zero if unknown for the given
        /// sample format
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_get_bytes_per_sample")]
        public static extern int av_get_bytes_per_sample(libavutil.AVSampleFormat sample_fmt);

        /// <summary>
        /// Check if the sample format is planar.
        /// </summary>
        /// <param name="sample_fmt">
        /// the sample format to inspect
        /// </param>
        /// <returns>
        /// 1 if the sample format is planar, 0 if it is interleaved
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_sample_fmt_is_planar")]
        public static extern int av_sample_fmt_is_planar(libavutil.AVSampleFormat sample_fmt);

        /// <summary>
        /// Get the required buffer size for the given audio parameters.
        /// </summary>
        /// <param name="[out]">
        /// linesize calculated linesize, may be NULL
        /// </param>
        /// <param name="nb_channels">
        /// the number of channels
        /// </param>
        /// <param name="nb_samples">
        /// the number of samples in a single channel
        /// </param>
        /// <param name="sample_fmt">
        /// the sample format
        /// </param>
        /// <param name="align">
        /// buffer size alignment (0 = default, 1 = no alignment)
        /// </param>
        /// <returns>
        /// required buffer size, or negative error code on failure
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_samples_get_buffer_size")]
        public static extern int av_samples_get_buffer_size(int* linesize, int nb_channels, int nb_samples, libavutil.AVSampleFormat sample_fmt, int align);

        /// <summary>
        /// Fill plane data pointers and linesize for samples with sample
        /// format sample_fmt.
        /// 
        /// The audio_data array is filled with the pointers to the samples data
        /// planes:
        /// for planar, set the start point of each channel's data within the
        /// buffer,
        /// for packed, set the start point of the entire buffer only.
        /// 
        /// The value pointed to by linesize is set to the aligned size of each
        /// channel's data buffer for planar layout, or to the aligned size of the
        /// buffer for all channels for packed layout.
        /// 
        /// The buffer in buf must be big enough to contain all the samples
        /// (use av_samples_get_buffer_size() to compute its minimum size),
        /// otherwise the audio_data pointers will point to invalid data.
        /// 
        /// @see enum AVSampleFormat
        /// The documentation for AVSampleFormat describes the data layout.
        /// </summary>
        /// <param name="[out]">
        /// audio_data  array to be filled with the pointer for each channel
        /// </param>
        /// <param name="[out]">
        /// linesize    calculated linesize, may be NULL
        /// </param>
        /// <param name="buf">
        /// the pointer to a buffer containing the samples
        /// </param>
        /// <param name="nb_channels">
        /// the number of channels
        /// </param>
        /// <param name="nb_samples">
        /// the number of samples in a single channel
        /// </param>
        /// <param name="sample_fmt">
        /// the sample format
        /// </param>
        /// <param name="align">
        /// buffer size alignment (0 = default, 1 = no alignment)
        /// </param>
        /// <returns>
        /// >=0 on success or a negative error code on failure
        /// @todo return minimum size in bytes required for the buffer in case
        /// of success at the next bump
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_samples_fill_arrays")]
        public static extern int av_samples_fill_arrays(byte** audio_data, int* linesize, byte* buf, int nb_channels, int nb_samples, libavutil.AVSampleFormat sample_fmt, int align);

        /// <summary>
        /// Fill plane data pointers and linesize for samples with sample
        /// format sample_fmt.
        /// 
        /// The audio_data array is filled with the pointers to the samples data
        /// planes:
        /// for planar, set the start point of each channel's data within the
        /// buffer,
        /// for packed, set the start point of the entire buffer only.
        /// 
        /// The value pointed to by linesize is set to the aligned size of each
        /// channel's data buffer for planar layout, or to the aligned size of the
        /// buffer for all channels for packed layout.
        /// 
        /// The buffer in buf must be big enough to contain all the samples
        /// (use av_samples_get_buffer_size() to compute its minimum size),
        /// otherwise the audio_data pointers will point to invalid data.
        /// 
        /// @see enum AVSampleFormat
        /// The documentation for AVSampleFormat describes the data layout.
        /// </summary>
        /// <param name="[out]">
        /// audio_data  array to be filled with the pointer for each channel
        /// </param>
        /// <param name="[out]">
        /// linesize    calculated linesize, may be NULL
        /// </param>
        /// <param name="buf">
        /// the pointer to a buffer containing the samples
        /// </param>
        /// <param name="nb_channels">
        /// the number of channels
        /// </param>
        /// <param name="nb_samples">
        /// the number of samples in a single channel
        /// </param>
        /// <param name="sample_fmt">
        /// the sample format
        /// </param>
        /// <param name="align">
        /// buffer size alignment (0 = default, 1 = no alignment)
        /// </param>
        /// <returns>
        /// >=0 on success or a negative error code on failure
        /// @todo return minimum size in bytes required for the buffer in case
        /// of success at the next bump
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_samples_fill_arrays")]
        public static extern int av_samples_fill_arrays(ref byte* audio_data, int* linesize, byte* buf, int nb_channels, int nb_samples, libavutil.AVSampleFormat sample_fmt, int align);

        /// <summary>
        /// Allocate a samples buffer for nb_samples samples, and fill data
        /// pointers and
        /// linesize accordingly.
        /// The allocated samples buffer can be freed by using
        /// av_freep(&audio_data[0])
        /// Allocated data will be initialized to silence.
        /// 
        /// @see enum AVSampleFormat
        /// The documentation for AVSampleFormat describes the data layout.
        /// </summary>
        /// <param name="[out]">
        /// audio_data  array to be filled with the pointer for each channel
        /// </param>
        /// <param name="[out]">
        /// linesize    aligned size for audio buffer(s), may be NULL
        /// </param>
        /// <param name="nb_channels">
        /// number of audio channels
        /// </param>
        /// <param name="nb_samples">
        /// number of samples per channel
        /// </param>
        /// <param name="align">
        /// buffer size alignment (0 = default, 1 = no alignment)
        /// </param>
        /// <returns>
        /// >=0 on success or a negative error code on failure
        /// @todo return the size of the allocated buffer in case of success at the
        /// next bump
        /// @see av_samples_fill_arrays()
        /// @see av_samples_alloc_array_and_samples()
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_samples_alloc")]
        public static extern int av_samples_alloc(byte** audio_data, int* linesize, int nb_channels, int nb_samples, libavutil.AVSampleFormat sample_fmt, int align);

        /// <summary>
        /// Allocate a samples buffer for nb_samples samples, and fill data
        /// pointers and
        /// linesize accordingly.
        /// The allocated samples buffer can be freed by using
        /// av_freep(&audio_data[0])
        /// Allocated data will be initialized to silence.
        /// 
        /// @see enum AVSampleFormat
        /// The documentation for AVSampleFormat describes the data layout.
        /// </summary>
        /// <param name="[out]">
        /// audio_data  array to be filled with the pointer for each channel
        /// </param>
        /// <param name="[out]">
        /// linesize    aligned size for audio buffer(s), may be NULL
        /// </param>
        /// <param name="nb_channels">
        /// number of audio channels
        /// </param>
        /// <param name="nb_samples">
        /// number of samples per channel
        /// </param>
        /// <param name="align">
        /// buffer size alignment (0 = default, 1 = no alignment)
        /// </param>
        /// <returns>
        /// >=0 on success or a negative error code on failure
        /// @todo return the size of the allocated buffer in case of success at the
        /// next bump
        /// @see av_samples_fill_arrays()
        /// @see av_samples_alloc_array_and_samples()
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_samples_alloc")]
        public static extern int av_samples_alloc(ref byte* audio_data, int* linesize, int nb_channels, int nb_samples, libavutil.AVSampleFormat sample_fmt, int align);

        /// <summary>
        /// Allocate a data pointers array, samples buffer for nb_samples
        /// samples, and fill data pointers and linesize accordingly.
        /// 
        /// This is the same as av_samples_alloc(), but also allocates the data
        /// pointers array.
        /// 
        /// @see av_samples_alloc()
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_samples_alloc_array_and_samples")]
        public static extern int av_samples_alloc_array_and_samples(byte*** audio_data, int* linesize, int nb_channels, int nb_samples, libavutil.AVSampleFormat sample_fmt, int align);

        /// <summary>
        /// Copy samples from src to dst.
        /// </summary>
        /// <param name="dst">
        /// destination array of pointers to data planes
        /// </param>
        /// <param name="src">
        /// source array of pointers to data planes
        /// </param>
        /// <param name="dst_offset">
        /// offset in samples at which the data will be written to dst
        /// </param>
        /// <param name="src_offset">
        /// offset in samples at which the data will be read from src
        /// </param>
        /// <param name="nb_samples">
        /// number of samples to be copied
        /// </param>
        /// <param name="nb_channels">
        /// number of audio channels
        /// </param>
        /// <param name="sample_fmt">
        /// audio sample format
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_samples_copy")]
        public static extern int av_samples_copy(byte** dst, byte** src, int dst_offset, int src_offset, int nb_samples, int nb_channels, libavutil.AVSampleFormat sample_fmt);

        /// <summary>
        /// Copy samples from src to dst.
        /// </summary>
        /// <param name="dst">
        /// destination array of pointers to data planes
        /// </param>
        /// <param name="src">
        /// source array of pointers to data planes
        /// </param>
        /// <param name="dst_offset">
        /// offset in samples at which the data will be written to dst
        /// </param>
        /// <param name="src_offset">
        /// offset in samples at which the data will be read from src
        /// </param>
        /// <param name="nb_samples">
        /// number of samples to be copied
        /// </param>
        /// <param name="nb_channels">
        /// number of audio channels
        /// </param>
        /// <param name="sample_fmt">
        /// audio sample format
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_samples_copy")]
        public static extern int av_samples_copy(ref byte* dst, ref byte* src, int dst_offset, int src_offset, int nb_samples, int nb_channels, libavutil.AVSampleFormat sample_fmt);

        /// <summary>
        /// Fill an audio buffer with silence.
        /// </summary>
        /// <param name="audio_data">
        /// array of pointers to data planes
        /// </param>
        /// <param name="offset">
        /// offset in samples at which to start filling
        /// </param>
        /// <param name="nb_samples">
        /// number of samples to fill
        /// </param>
        /// <param name="nb_channels">
        /// number of audio channels
        /// </param>
        /// <param name="sample_fmt">
        /// audio sample format
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_samples_set_silence")]
        public static extern int av_samples_set_silence(byte** audio_data, int offset, int nb_samples, int nb_channels, libavutil.AVSampleFormat sample_fmt);

        /// <summary>
        /// Fill an audio buffer with silence.
        /// </summary>
        /// <param name="audio_data">
        /// array of pointers to data planes
        /// </param>
        /// <param name="offset">
        /// offset in samples at which to start filling
        /// </param>
        /// <param name="nb_samples">
        /// number of samples to fill
        /// </param>
        /// <param name="nb_channels">
        /// number of audio channels
        /// </param>
        /// <param name="sample_fmt">
        /// audio sample format
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_samples_set_silence")]
        public static extern int av_samples_set_silence(ref byte* audio_data, int offset, int nb_samples, int nb_channels, libavutil.AVSampleFormat sample_fmt);
    }
}
