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
        /// Compute the max pixel step for each plane of an image with a
        /// format described by pixdesc.
        /// 
        /// The pixel step is the distance in bytes between the first byte of
        /// the group of bytes which describe a pixel component and the first
        /// byte of the successive group in the same plane for the same
        /// component.
        /// </summary>
        /// <param name="max_pixsteps">
        /// an array which is filled with the max pixel step
        /// for each plane. Since a plane may contain different pixel
        /// components, the computed max_pixsteps[plane] is relative to the
        /// component in the plane with the max pixel step.
        /// </param>
        /// <param name="max_pixstep_comps">
        /// an array which is filled with the component
        /// for each plane which has the max pixel step. May be NULL.
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_image_fill_max_pixsteps")]
        public static extern void av_image_fill_max_pixsteps(int* max_pixsteps, int* max_pixstep_comps, libavutil.AVPixFmtDescriptor* pixdesc);

        /// <summary>
        /// Compute the size of an image line with format pix_fmt and width
        /// width for the plane plane.
        /// </summary>
        /// <returns>
        /// the computed size in bytes
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_image_get_linesize")]
        public static extern int av_image_get_linesize(libavutil.AVPixelFormat pix_fmt, int width, int plane);

        /// <summary>
        /// Fill plane linesizes for an image with pixel format pix_fmt and
        /// width width.
        /// </summary>
        /// <param name="linesizes">
        /// array to be filled with the linesize for each plane
        /// </param>
        /// <returns>
        /// >= 0 in case of success, a negative error code otherwise
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_image_fill_linesizes")]
        public static extern int av_image_fill_linesizes(int* linesizes, libavutil.AVPixelFormat pix_fmt, int width);

        /// <summary>
        /// Fill plane data pointers for an image with pixel format pix_fmt and
        /// height height.
        /// </summary>
        /// <param name="data">
        /// pointers array to be filled with the pointer for each image plane
        /// </param>
        /// <param name="ptr">
        /// the pointer to a buffer which will contain the image
        /// </param>
        /// <param name="linesizes">
        /// the array containing the linesize for each
        /// plane, should be filled by av_image_fill_linesizes()
        /// </param>
        /// <returns>
        /// the size in bytes required for the image buffer, a negative
        /// error code in case of failure
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_image_fill_pointers")]
        public static extern int av_image_fill_pointers(byte** data, libavutil.AVPixelFormat pix_fmt, int height, byte* ptr, int* linesizes);

        /// <summary>
        /// Allocate an image with size w and h and pixel format pix_fmt, and
        /// fill pointers and linesizes accordingly.
        /// The allocated image buffer has to be freed by using
        /// av_freep(&pointers[0]).
        /// </summary>
        /// <param name="align">
        /// the value to use for buffer size alignment
        /// </param>
        /// <returns>
        /// the size in bytes required for the image buffer, a negative
        /// error code in case of failure
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_image_alloc")]
        public static extern int av_image_alloc(byte** pointers, int* linesizes, int w, int h, libavutil.AVPixelFormat pix_fmt, int align);

        /// <summary>
        /// Copy image plane from src to dst.
        /// That is, copy "height" number of lines of "bytewidth" bytes each.
        /// The first byte of each successive line is separated by *_linesize
        /// bytes.
        /// 
        /// bytewidth must be contained by both absolute values of dst_linesize
        /// and src_linesize, otherwise the function behavior is undefined.
        /// </summary>
        /// <param name="dst_linesize">
        /// linesize for the image plane in dst
        /// </param>
        /// <param name="src_linesize">
        /// linesize for the image plane in src
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_image_copy_plane")]
        public static extern void av_image_copy_plane(byte* dst, int dst_linesize, byte* src, int src_linesize, int bytewidth, int height);

        /// <summary>
        /// Copy image in src_data to dst_data.
        /// </summary>
        /// <param name="dst_linesizes">
        /// linesizes for the image in dst_data
        /// </param>
        /// <param name="src_linesizes">
        /// linesizes for the image in src_data
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_image_copy")]
        public static extern void av_image_copy(byte** dst_data, int* dst_linesizes, byte** src_data, int* src_linesizes, libavutil.AVPixelFormat pix_fmt, int width, int height);

        /// <summary>
        /// Setup the data pointers and linesizes based on the specified image
        /// parameters and the provided array.
        /// 
        /// The fields of the given image are filled in by using the src
        /// address which points to the image data buffer. Depending on the
        /// specified pixel format, one or multiple image data pointers and
        /// line sizes will be set.  If a planar format is specified, several
        /// pointers will be set pointing to the different picture planes and
        /// the line sizes of the different planes will be stored in the
        /// lines_sizes array. Call with src == NULL to get the required
        /// size for the src buffer.
        /// 
        /// To allocate the buffer and fill in the dst_data and dst_linesize in
        /// one call, use av_image_alloc().
        /// </summary>
        /// <param name="dst_data">
        /// data pointers to be filled in
        /// </param>
        /// <param name="dst_linesizes">
        /// linesizes for the image in dst_data to be filled in
        /// </param>
        /// <param name="src">
        /// buffer which will contain or contains the actual image data, can be
        /// NULL
        /// </param>
        /// <param name="pix_fmt">
        /// the pixel format of the image
        /// </param>
        /// <param name="width">
        /// the width of the image in pixels
        /// </param>
        /// <param name="height">
        /// the height of the image in pixels
        /// </param>
        /// <param name="align">
        /// the value used in src for linesize alignment
        /// </param>
        /// <returns>
        /// the size in bytes required for src, a negative error code
        /// in case of failure
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_image_fill_arrays")]
        public static extern int av_image_fill_arrays(byte** dst_data, int* dst_linesize, byte* src, libavutil.AVPixelFormat pix_fmt, int width, int height, int align);

        /// <summary>
        /// Return the size in bytes of the amount of data required to store an
        /// image with the given parameters.
        /// </summary>
        /// <param name="[in]">
        /// align the assumed linesize alignment
        /// </param>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_image_get_buffer_size")]
        public static extern int av_image_get_buffer_size(libavutil.AVPixelFormat pix_fmt, int width, int height, int align);

        /// <summary>
        /// Copy image data from an image into a buffer.
        /// 
        /// av_image_get_buffer_size() can be used to compute the required size
        /// for the buffer to fill.
        /// </summary>
        /// <param name="dst">
        /// a buffer into which picture data will be copied
        /// </param>
        /// <param name="dst_size">
        /// the size in bytes of dst
        /// </param>
        /// <param name="src_data">
        /// pointers containing the source image data
        /// </param>
        /// <param name="src_linesizes">
        /// linesizes for the image in src_data
        /// </param>
        /// <param name="pix_fmt">
        /// the pixel format of the source image
        /// </param>
        /// <param name="width">
        /// the width of the source image in pixels
        /// </param>
        /// <param name="height">
        /// the height of the source image in pixels
        /// </param>
        /// <param name="align">
        /// the assumed linesize alignment for dst
        /// </param>
        /// <returns>
        /// the number of bytes written to dst, or a negative value
        /// (error code) on error
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_image_copy_to_buffer")]
        public static extern int av_image_copy_to_buffer(byte* dst, int dst_size, byte** src_data, int* src_linesize, libavutil.AVPixelFormat pix_fmt, int width, int height, int align);

        /// <summary>
        /// Check if the given dimension of an image is valid, meaning that all
        /// bytes of the image can be addressed with a signed int.
        /// </summary>
        /// <param name="w">
        /// the width of the picture
        /// </param>
        /// <param name="h">
        /// the height of the picture
        /// </param>
        /// <param name="log_offset">
        /// the offset to sum to the log level for logging with log_ctx
        /// </param>
        /// <param name="log_ctx">
        /// the parent logging context, it may be NULL
        /// </param>
        /// <returns>
        /// >= 0 if valid, a negative error code otherwise
        /// </returns>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="av_image_check_size")]
        public static extern int av_image_check_size(uint w, uint h, int log_offset, void* log_ctx);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVUTIL_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avpriv_set_systematic_pal2")]
        public static extern int avpriv_set_systematic_pal2(uint* pal, libavutil.AVPixelFormat pix_fmt);
    }
}
