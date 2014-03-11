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
    public unsafe static partial class libavformat
    {
        public const sbyte AVIO_SEEKABLE_NORMAL = 1;

        public const int AVSEEK_SIZE = 10000;

        public const int AVSEEK_FORCE = 20000;

        public const sbyte AVIO_FLAG_READ = 1;

        public const sbyte AVIO_FLAG_WRITE = 2;

        public const sbyte AVIO_FLAG_NONBLOCK = 8;

        public const ushort AVIO_FLAG_DIRECT = 8000;

        /// <summary>
        /// Callback for checking whether to abort blocking functions.
        /// AVERROR_EXIT is returned in this case by the interrupted
        /// function. During blocking operations, callback is called with
        /// opaque as parameter. If the callback returns 1, the
        /// blocking operation will be aborted.
        /// 
        /// No members can be added to this struct without a major bump, if
        /// new elements have been added after this struct in AVFormatContext
        /// or AVIOContext.
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVIOInterruptCB
        {
            public global::System.IntPtr callback;

            public void* opaque;
        }

        /// <summary>
        /// Bytestream IO Context.
        /// New fields can be added to the end with minor version bumps.
        /// Removal, reordering and changes to existing fields require a major
        /// version bump.
        /// sizeof(AVIOContext) must not be used outside libav*.
        /// 
        /// @note None of the function pointers in AVIOContext should be called
        /// directly, they should only be set by the client application
        /// when implementing custom I/O. Normally these are set to the
        /// function pointers specified in avio_alloc_context()
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public unsafe partial struct AVIOContext
        {
            /// <summary>
            /// A class for private options.
            /// 
            /// If this AVIOContext is created by avio_open2(), av_class is set and
            /// passes the options down to protocols.
            /// 
            /// If this AVIOContext is manually allocated, then av_class may be set by
            /// the caller.
            /// 
            /// warning -- this field can be NULL, be sure to not pass this AVIOContext
            /// to any av_opt_* functions in that case.
            /// </summary>
            public libavutil.AVClass* av_class;

            /// <summary>
            /// Start of the buffer.
            /// </summary>
            public byte* buffer;

            /// <summary>
            /// Maximum buffer size
            /// </summary>
            public int buffer_size;

            /// <summary>
            /// Current position in the buffer
            /// </summary>
            public byte* buf_ptr;

            /// <summary>
            /// End of the data, may be less than
            /// buffer+buffer_size if the read function returned
            /// less data than requested, e.g. for streams where
            /// no more data has been received yet.
            /// </summary>
            public byte* buf_end;

            /// <summary>
            /// A private pointer, passed to the read/write/seek/...
            /// functions.
            /// </summary>
            public void* opaque;

            public global::System.IntPtr read_packet;

            public global::System.IntPtr write_packet;

            public global::System.IntPtr seek;

            /// <summary>
            /// position in the file of the current buffer
            /// </summary>
            public long pos;

            /// <summary>
            /// true if the next seek should flush
            /// </summary>
            public int must_flush;

            /// <summary>
            /// true if eof reached
            /// </summary>
            public int eof_reached;

            /// <summary>
            /// true if open for writing
            /// </summary>
            public int write_flag;

            public int max_packet_size;

            public uint checksum;

            public byte* checksum_ptr;

            public global::System.IntPtr update_checksum;

            /// <summary>
            /// contains the error code or 0 if no error happened
            /// </summary>
            public int error;

            /// <summary>
            /// Pause or resume playback for network streaming protocols - e.g. MMS.
            /// </summary>
            public global::System.IntPtr read_pause;

            /// <summary>
            /// Seek to a given timestamp in stream with the specified stream_index.
            /// Needed for some network streaming protocols which don't support seeking
            /// to byte position.
            /// </summary>
            public global::System.IntPtr read_seek;

            /// <summary>
            /// A combination of AVIO_SEEKABLE_ flags or 0 when the stream is not
            /// seekable.
            /// </summary>
            public int seekable;

            /// <summary>
            /// max filesize, used to limit allocations
            /// This field is internal to libavformat and access from outside is not
            /// allowed.
            /// </summary>
            public long maxsize;

            /// <summary>
            /// avio_read and avio_write should if possible be satisfied directly
            /// instead of going through a buffer, and avio_seek will always
            /// call the underlying seek function directly.
            /// </summary>
            public int direct;

            /// <summary>
            /// Bytes read statistic
            /// This field is internal to libavformat and access from outside is not
            /// allowed.
            /// </summary>
            public long bytes_read;

            /// <summary>
            /// seek statistic
            /// This field is internal to libavformat and access from outside is not
            /// allowed.
            /// </summary>
            public int seek_count;

            /// <summary>
            /// writeout statistic
            /// This field is internal to libavformat and access from outside is not
            /// allowed.
            /// </summary>
            public int writeout_count;
        }

        /// <summary>
        /// Return AVIO_FLAG_* access flags corresponding to the access permissions
        /// of the resource in url, or a negative value corresponding to an
        /// AVERROR code in case of failure. The returned access flags are
        /// masked by the value in flags.
        /// 
        /// @note This function is intrinsically unsafe, in the sense that the
        /// checked resource may change its existence or permission status from
        /// one call to another. Thus you should not trust the returned value,
        /// unless you are sure that no other processes are accessing the
        /// checked resource.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_check")]
        public static extern int avio_check(string url, int flags);

        /// <summary>
        /// Allocate and initialize an AVIOContext for buffered I/O. It must be
        /// later
        /// freed with av_free().
        /// 
        /// @param buffer Memory block for input/output operations via AVIOContext.
        /// The buffer must be allocated with av_malloc() and friends.
        /// @param buffer_size The buffer size is very important for performance.
        /// For protocols with fixed blocksize it should be set to this blocksize.
        /// For others a typical size is a cache page, e.g. 4kb.
        /// @param write_flag Set to 1 if the buffer should be writable, 0
        /// otherwise.
        /// @param opaque An opaque pointer to user-specific data.
        /// @param read_packet  A function for refilling the buffer, may be NULL.
        /// @param write_packet A function for writing the buffer contents, may be
        /// NULL.
        /// The function may not change the input buffers content.
        /// @param seek A function for seeking to specified byte position, may be
        /// NULL.
        /// 
        /// @return Allocated AVIOContext or NULL on failure.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_alloc_context")]
        public static extern libavformat.AVIOContext* avio_alloc_context(byte* buffer, int buffer_size, int write_flag, void* opaque, global::System.IntPtr read_packet, global::System.IntPtr write_packet, global::System.IntPtr seek);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_w8")]
        public static extern void avio_w8(libavformat.AVIOContext* s, int b);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_write")]
        public static extern void avio_write(libavformat.AVIOContext* s, byte* buf, int size);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_wl64")]
        public static extern void avio_wl64(libavformat.AVIOContext* s, ulong val);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_wb64")]
        public static extern void avio_wb64(libavformat.AVIOContext* s, ulong val);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_wl32")]
        public static extern void avio_wl32(libavformat.AVIOContext* s, uint val);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_wb32")]
        public static extern void avio_wb32(libavformat.AVIOContext* s, uint val);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_wl24")]
        public static extern void avio_wl24(libavformat.AVIOContext* s, uint val);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_wb24")]
        public static extern void avio_wb24(libavformat.AVIOContext* s, uint val);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_wl16")]
        public static extern void avio_wl16(libavformat.AVIOContext* s, uint val);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_wb16")]
        public static extern void avio_wb16(libavformat.AVIOContext* s, uint val);

        /// <summary>
        /// Write a NULL-terminated string.
        /// @return number of bytes written.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_put_str")]
        public static extern int avio_put_str(libavformat.AVIOContext* s, string str);

        /// <summary>
        /// Convert an UTF-8 string to UTF-16LE and write it.
        /// @return number of bytes written.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_put_str16le")]
        public static extern int avio_put_str16le(libavformat.AVIOContext* s, string str);

        /// <summary>
        /// fseek() equivalent for AVIOContext.
        /// @return new position or AVERROR.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_seek")]
        public static extern long avio_seek(libavformat.AVIOContext* s, long offset, int whence);

        /// <summary>
        /// Skip given number of bytes forward
        /// @return new position or AVERROR.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_skip")]
        public static extern long avio_skip(libavformat.AVIOContext* s, long offset);

        /// <summary>
        /// ftell() equivalent for AVIOContext.
        /// @return position or AVERROR.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_tell")]
        public static extern long avio_tell(libavformat.AVIOContext* s);

        /// <summary>
        /// Get the filesize.
        /// @return filesize or AVERROR
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_size")]
        public static extern long avio_size(libavformat.AVIOContext* s);

        /// <summary>
        /// feof() equivalent for AVIOContext.
        /// @return non zero if and only if end of file
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="url_feof")]
        public static extern int url_feof(libavformat.AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_printf")]
        public static extern int avio_printf(libavformat.AVIOContext* s, string fmt);

        /// <summary>
        /// Force flushing of buffered data to the output s.
        /// 
        /// Force the buffered data to be immediately written to the output,
        /// without to wait to fill the internal buffer.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_flush")]
        public static extern void avio_flush(libavformat.AVIOContext* s);

        /// <summary>
        /// Read size bytes from AVIOContext into buf.
        /// @return number of bytes read or AVERROR
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_read")]
        public static extern int avio_read(libavformat.AVIOContext* s, byte* buf, int size);

        /// <summary>
        /// @name Functions for reading from AVIOContext
        /// @{
        /// 
        /// @note return 0 if EOF, so you cannot use it if EOF handling is
        /// necessary
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_r8")]
        public static extern int avio_r8(libavformat.AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_rl16")]
        public static extern uint avio_rl16(libavformat.AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_rl24")]
        public static extern uint avio_rl24(libavformat.AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_rl32")]
        public static extern uint avio_rl32(libavformat.AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_rl64")]
        public static extern ulong avio_rl64(libavformat.AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_rb16")]
        public static extern uint avio_rb16(libavformat.AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_rb24")]
        public static extern uint avio_rb24(libavformat.AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_rb32")]
        public static extern uint avio_rb32(libavformat.AVIOContext* s);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_rb64")]
        public static extern ulong avio_rb64(libavformat.AVIOContext* s);

        /// <summary>
        /// Read a string from pb into buf. The reading will terminate when either
        /// a NULL character was encountered, maxlen bytes have been read, or
        /// nothing
        /// more can be read from pb. The result is guaranteed to be
        /// NULL-terminated, it
        /// will be truncated if buf is too small.
        /// Note that the string is not interpreted or validated in any way, it
        /// might get truncated in the middle of a sequence for multi-byte
        /// encodings.
        /// 
        /// @return number of bytes read (is always <= maxlen).
        /// If reading ends on EOF or error, the return value will be one more than
        /// bytes actually read.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_get_str")]
        public static extern int avio_get_str(libavformat.AVIOContext* pb, int maxlen, System.Text.StringBuilder buf, int buflen);

        /// <summary>
        /// Read a UTF-16 string from pb and convert it to UTF-8.
        /// The reading will terminate when either a null or invalid character was
        /// encountered or maxlen bytes have been read.
        /// @return number of bytes read (is always <= maxlen)
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_get_str16le")]
        public static extern int avio_get_str16le(libavformat.AVIOContext* pb, int maxlen, System.Text.StringBuilder buf, int buflen);

        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_get_str16be")]
        public static extern int avio_get_str16be(libavformat.AVIOContext* pb, int maxlen, System.Text.StringBuilder buf, int buflen);

        /// <summary>
        /// Create and initialize a AVIOContext for accessing the
        /// resource indicated by url.
        /// @note When the resource indicated by url has been opened in
        /// read+write mode, the AVIOContext can be used only for writing.
        /// 
        /// @param s Used to return the pointer to the created AVIOContext.
        /// In case of failure the pointed to value is set to NULL.
        /// @param flags flags which control how the resource indicated by url
        /// is to be opened
        /// @return >= 0 in case of success, a negative value corresponding to an
        /// AVERROR code in case of failure
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_open")]
        public static extern int avio_open(libavformat.AVIOContext** s, string url, int flags);

        /// <summary>
        /// Create and initialize a AVIOContext for accessing the
        /// resource indicated by url.
        /// @note When the resource indicated by url has been opened in
        /// read+write mode, the AVIOContext can be used only for writing.
        /// 
        /// @param s Used to return the pointer to the created AVIOContext.
        /// In case of failure the pointed to value is set to NULL.
        /// @param flags flags which control how the resource indicated by url
        /// is to be opened
        /// @return >= 0 in case of success, a negative value corresponding to an
        /// AVERROR code in case of failure
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_open")]
        public static extern int avio_open(ref libavformat.AVIOContext* s, string url, int flags);

        /// <summary>
        /// Create and initialize a AVIOContext for accessing the
        /// resource indicated by url.
        /// @note When the resource indicated by url has been opened in
        /// read+write mode, the AVIOContext can be used only for writing.
        /// 
        /// @param s Used to return the pointer to the created AVIOContext.
        /// In case of failure the pointed to value is set to NULL.
        /// @param flags flags which control how the resource indicated by url
        /// is to be opened
        /// @param int_cb an interrupt callback to be used at the protocols level
        /// @param options  A dictionary filled with protocol-private options. On
        /// return
        /// this parameter will be destroyed and replaced with a dict containing
        /// options
        /// that were not found. May be NULL.
        /// @return >= 0 in case of success, a negative value corresponding to an
        /// AVERROR code in case of failure
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_open2")]
        public static extern int avio_open2(libavformat.AVIOContext** s, string url, int flags, libavformat.AVIOInterruptCB* int_cb, libavutil.AVDictionary** options);

        /// <summary>
        /// Create and initialize a AVIOContext for accessing the
        /// resource indicated by url.
        /// @note When the resource indicated by url has been opened in
        /// read+write mode, the AVIOContext can be used only for writing.
        /// 
        /// @param s Used to return the pointer to the created AVIOContext.
        /// In case of failure the pointed to value is set to NULL.
        /// @param flags flags which control how the resource indicated by url
        /// is to be opened
        /// @param int_cb an interrupt callback to be used at the protocols level
        /// @param options  A dictionary filled with protocol-private options. On
        /// return
        /// this parameter will be destroyed and replaced with a dict containing
        /// options
        /// that were not found. May be NULL.
        /// @return >= 0 in case of success, a negative value corresponding to an
        /// AVERROR code in case of failure
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_open2")]
        public static extern int avio_open2(ref libavformat.AVIOContext* s, string url, int flags, libavformat.AVIOInterruptCB* int_cb, ref libavutil.AVDictionary* options);

        /// <summary>
        /// Close the resource accessed by the AVIOContext s and free it.
        /// This function can only be used if s was opened by avio_open().
        /// 
        /// The internal buffer is automatically flushed before closing the
        /// resource.
        /// 
        /// @return 0 on success, an AVERROR < 0 on error.
        /// @see avio_closep
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_close")]
        public static extern int avio_close(libavformat.AVIOContext* s);

        /// <summary>
        /// Close the resource accessed by the AVIOContext *s, free it
        /// and set the pointer pointing to it to NULL.
        /// This function can only be used if s was opened by avio_open().
        /// 
        /// The internal buffer is automatically flushed before closing the
        /// resource.
        /// 
        /// @return 0 on success, an AVERROR < 0 on error.
        /// @see avio_close
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_closep")]
        public static extern int avio_closep(libavformat.AVIOContext** s);

        /// <summary>
        /// Close the resource accessed by the AVIOContext *s, free it
        /// and set the pointer pointing to it to NULL.
        /// This function can only be used if s was opened by avio_open().
        /// 
        /// The internal buffer is automatically flushed before closing the
        /// resource.
        /// 
        /// @return 0 on success, an AVERROR < 0 on error.
        /// @see avio_close
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_closep")]
        public static extern int avio_closep(ref libavformat.AVIOContext* s);

        /// <summary>
        /// Open a write only memory stream.
        /// 
        /// @param s new IO context
        /// @return zero if no error.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_open_dyn_buf")]
        public static extern int avio_open_dyn_buf(libavformat.AVIOContext** s);

        /// <summary>
        /// Open a write only memory stream.
        /// 
        /// @param s new IO context
        /// @return zero if no error.
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_open_dyn_buf")]
        public static extern int avio_open_dyn_buf(ref libavformat.AVIOContext* s);

        /// <summary>
        /// Return the written size and a pointer to the buffer. The buffer
        /// must be freed with av_free().
        /// Padding of FF_INPUT_BUFFER_PADDING_SIZE is added to the buffer.
        /// 
        /// @param s IO context
        /// @param pbuffer pointer to a byte buffer
        /// @return the length of the byte buffer
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_close_dyn_buf")]
        public static extern int avio_close_dyn_buf(libavformat.AVIOContext* s, byte** pbuffer);

        /// <summary>
        /// Return the written size and a pointer to the buffer. The buffer
        /// must be freed with av_free().
        /// Padding of FF_INPUT_BUFFER_PADDING_SIZE is added to the buffer.
        /// 
        /// @param s IO context
        /// @param pbuffer pointer to a byte buffer
        /// @return the length of the byte buffer
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_close_dyn_buf")]
        public static extern int avio_close_dyn_buf(libavformat.AVIOContext* s, ref byte* pbuffer);

        /// <summary>
        /// Iterate through names of available protocols.
        /// 
        /// @param opaque A private pointer representing current protocol.
        /// It must be a pointer to NULL on first iteration and will
        /// be updated by successive calls to avio_enum_protocols.
        /// @param output If set to 1, iterate over output protocols,
        /// otherwise over input protocols.
        /// 
        /// @return A static string containing the name of current protocol or NULL
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_enum_protocols")]
        public static extern sbyte* avio_enum_protocols(void** opaque, int output);

        /// <summary>
        /// Iterate through names of available protocols.
        /// 
        /// @param opaque A private pointer representing current protocol.
        /// It must be a pointer to NULL on first iteration and will
        /// be updated by successive calls to avio_enum_protocols.
        /// @param output If set to 1, iterate over output protocols,
        /// otherwise over input protocols.
        /// 
        /// @return A static string containing the name of current protocol or NULL
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_enum_protocols")]
        public static extern sbyte* avio_enum_protocols(ref void* opaque, int output);

        /// <summary>
        /// Pause and resume playing - only meaningful if using a network streaming
        /// protocol (e.g. MMS).
        /// @param pause 1 for pause, 0 for resume
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_pause")]
        public static extern int avio_pause(libavformat.AVIOContext* h, int pause);

        /// <summary>
        /// Seek to a given timestamp relative to some component stream.
        /// Only meaningful if using a network streaming protocol (e.g. MMS.).
        /// @param stream_index The stream index that the timestamp is relative to.
        /// If stream_index is (-1) the timestamp should be in AV_TIME_BASE
        /// units from the beginning of the presentation.
        /// If a stream_index >= 0 is used and the protocol does not support
        /// seeking based on component streams, the call will fail.
        /// @param timestamp timestamp in AVStream.time_base units
        /// or if there is no stream specified then in AV_TIME_BASE units.
        /// @param flags Optional combination of AVSEEK_FLAG_BACKWARD,
        /// AVSEEK_FLAG_BYTE
        /// and AVSEEK_FLAG_ANY. The protocol may silently ignore
        /// AVSEEK_FLAG_BACKWARD and AVSEEK_FLAG_ANY, but AVSEEK_FLAG_BYTE will
        /// fail if used and not supported.
        /// @return >= 0 on success
        /// @see AVInputFormat::read_seek
        /// </summary>
        [SuppressUnmanagedCodeSecurity]
        [DllImport(AVFORMAT_DLL_NAME, CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
            CharSet = CharSet.Ansi, ExactSpelling = true,
            EntryPoint="avio_seek_time")]
        public static extern long avio_seek_time(libavformat.AVIOContext* h, int stream_index, long timestamp, int flags);
    }
}
