// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Flag to indicate pending upload default (for linking to not-yet-existing
    /// paths).</para>
    /// </summary>
    public class PendingUploadMode
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<PendingUploadMode> Encoder = new PendingUploadModeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<PendingUploadMode> Decoder = new PendingUploadModeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PendingUploadMode" />
        /// class.</para>
        /// </summary>
        public PendingUploadMode()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is File</para>
        /// </summary>
        public bool IsFile
        {
            get
            {
                return this is File;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a File, or <c>null</c>.</para>
        /// </summary>
        public File AsFile
        {
            get
            {
                return this as File;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Folder</para>
        /// </summary>
        public bool IsFolder
        {
            get
            {
                return this is Folder;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Folder, or <c>null</c>.</para>
        /// </summary>
        public Folder AsFolder
        {
            get
            {
                return this as Folder;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="PendingUploadMode" />.</para>
        /// </summary>
        private class PendingUploadModeEncoder : enc.StructEncoder<PendingUploadMode>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(PendingUploadMode value, enc.IJsonWriter writer)
            {
                if (value is File)
                {
                    WriteProperty(".tag", "file", writer, enc.StringEncoder.Instance);
                    File.Encoder.EncodeFields((File)value, writer);
                    return;
                }
                if (value is Folder)
                {
                    WriteProperty(".tag", "folder", writer, enc.StringEncoder.Instance);
                    Folder.Encoder.EncodeFields((Folder)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="PendingUploadMode" />.</para>
        /// </summary>
        private class PendingUploadModeDecoder : enc.UnionDecoder<PendingUploadMode>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="PendingUploadMode" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override PendingUploadMode Create()
            {
                return new PendingUploadMode();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override PendingUploadMode Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "file":
                        return File.Decoder.DecodeFields(reader);
                    case "folder":
                        return Folder.Decoder.DecodeFields(reader);
                    default:
                        throw new sys.InvalidOperationException();
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Assume pending uploads are files.</para>
        /// </summary>
        public sealed class File : PendingUploadMode
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<File> Encoder = new FileEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<File> Decoder = new FileDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="File" /> class.</para>
            /// </summary>
            private File()
            {
            }

            /// <summary>
            /// <para>A singleton instance of File</para>
            /// </summary>
            public static readonly File Instance = new File();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="File" />.</para>
            /// </summary>
            private class FileEncoder : enc.StructEncoder<File>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(File value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="File" />.</para>
            /// </summary>
            private class FileDecoder : enc.StructDecoder<File>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="File" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override File Create()
                {
                    return new File();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override File DecodeFields(enc.IJsonReader reader)
                {
                    return File.Instance;
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>Assume pending uploads are folders.</para>
        /// </summary>
        public sealed class Folder : PendingUploadMode
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Folder> Encoder = new FolderEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Folder> Decoder = new FolderDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Folder" /> class.</para>
            /// </summary>
            private Folder()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Folder</para>
            /// </summary>
            public static readonly Folder Instance = new Folder();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Folder" />.</para>
            /// </summary>
            private class FolderEncoder : enc.StructEncoder<Folder>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Folder value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Folder" />.</para>
            /// </summary>
            private class FolderDecoder : enc.StructDecoder<Folder>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Folder" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Folder Create()
                {
                    return new Folder();
                }

                /// <summary>
                /// <para>Decode fields without ensuring start and end object.</para>
                /// </summary>
                /// <param name="reader">The json reader.</param>
                /// <returns>The decoded object.</returns>
                public override Folder DecodeFields(enc.IJsonReader reader)
                {
                    return Folder.Instance;
                }
            }

            #endregion
        }
    }
}