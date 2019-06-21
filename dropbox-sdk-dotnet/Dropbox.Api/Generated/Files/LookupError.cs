// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The lookup error object</para>
    /// </summary>
    public class LookupError
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<LookupError> Encoder = new LookupErrorEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<LookupError> Decoder = new LookupErrorDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="LookupError" /> class.</para>
        /// </summary>
        public LookupError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is MalformedPath</para>
        /// </summary>
        public bool IsMalformedPath
        {
            get
            {
                return this is MalformedPath;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a MalformedPath, or <c>null</c>.</para>
        /// </summary>
        public MalformedPath AsMalformedPath
        {
            get
            {
                return this as MalformedPath;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotFound</para>
        /// </summary>
        public bool IsNotFound
        {
            get
            {
                return this is NotFound;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotFound, or <c>null</c>.</para>
        /// </summary>
        public NotFound AsNotFound
        {
            get
            {
                return this as NotFound;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotFile</para>
        /// </summary>
        public bool IsNotFile
        {
            get
            {
                return this is NotFile;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotFile, or <c>null</c>.</para>
        /// </summary>
        public NotFile AsNotFile
        {
            get
            {
                return this as NotFile;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NotFolder</para>
        /// </summary>
        public bool IsNotFolder
        {
            get
            {
                return this is NotFolder;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NotFolder, or <c>null</c>.</para>
        /// </summary>
        public NotFolder AsNotFolder
        {
            get
            {
                return this as NotFolder;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is RestrictedContent</para>
        /// </summary>
        public bool IsRestrictedContent
        {
            get
            {
                return this is RestrictedContent;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a RestrictedContent, or <c>null</c>.</para>
        /// </summary>
        public RestrictedContent AsRestrictedContent
        {
            get
            {
                return this as RestrictedContent;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is
        /// UnsupportedContentType</para>
        /// </summary>
        public bool IsUnsupportedContentType
        {
            get
            {
                return this is UnsupportedContentType;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UnsupportedContentType, or <c>null</c>.</para>
        /// </summary>
        public UnsupportedContentType AsUnsupportedContentType
        {
            get
            {
                return this as UnsupportedContentType;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="LookupError" />.</para>
        /// </summary>
        private class LookupErrorEncoder : enc.StructEncoder<LookupError>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(LookupError value, enc.IJsonWriter writer)
            {
                if (value is MalformedPath)
                {
                    WriteProperty(".tag", "malformed_path", writer, enc.StringEncoder.Instance);
                    MalformedPath.Encoder.EncodeFields((MalformedPath)value, writer);
                    return;
                }
                if (value is NotFound)
                {
                    WriteProperty(".tag", "not_found", writer, enc.StringEncoder.Instance);
                    NotFound.Encoder.EncodeFields((NotFound)value, writer);
                    return;
                }
                if (value is NotFile)
                {
                    WriteProperty(".tag", "not_file", writer, enc.StringEncoder.Instance);
                    NotFile.Encoder.EncodeFields((NotFile)value, writer);
                    return;
                }
                if (value is NotFolder)
                {
                    WriteProperty(".tag", "not_folder", writer, enc.StringEncoder.Instance);
                    NotFolder.Encoder.EncodeFields((NotFolder)value, writer);
                    return;
                }
                if (value is RestrictedContent)
                {
                    WriteProperty(".tag", "restricted_content", writer, enc.StringEncoder.Instance);
                    RestrictedContent.Encoder.EncodeFields((RestrictedContent)value, writer);
                    return;
                }
                if (value is UnsupportedContentType)
                {
                    WriteProperty(".tag", "unsupported_content_type", writer, enc.StringEncoder.Instance);
                    UnsupportedContentType.Encoder.EncodeFields((UnsupportedContentType)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="LookupError" />.</para>
        /// </summary>
        private class LookupErrorDecoder : enc.UnionDecoder<LookupError>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="LookupError" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override LookupError Create()
            {
                return new LookupError();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override LookupError Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "malformed_path":
                        return MalformedPath.Decoder.DecodeFields(reader);
                    case "not_found":
                        return NotFound.Decoder.DecodeFields(reader);
                    case "not_file":
                        return NotFile.Decoder.DecodeFields(reader);
                    case "not_folder":
                        return NotFolder.Decoder.DecodeFields(reader);
                    case "restricted_content":
                        return RestrictedContent.Decoder.DecodeFields(reader);
                    case "unsupported_content_type":
                        return UnsupportedContentType.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The given path does not satisfy the required path format. Please refer to the
        /// <a
        /// href="https://www.dropbox.com/developers/documentation/http/documentation#path-formats">Path
        /// formats documentation</a> for more information.</para>
        /// </summary>
        public sealed class MalformedPath : LookupError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<MalformedPath> Encoder = new MalformedPathEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<MalformedPath> Decoder = new MalformedPathDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MalformedPath" />
            /// class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public MalformedPath(string value)
            {
                this.Value = value;
            }
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="MalformedPath" />
            /// class.</para>
            /// </summary>
            private MalformedPath()
            {
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public string Value { get; private set; }

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="MalformedPath" />.</para>
            /// </summary>
            private class MalformedPathEncoder : enc.StructEncoder<MalformedPath>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(MalformedPath value, enc.IJsonWriter writer)
                {
                    if (value.Value != null)
                    {
                        WriteProperty("malformed_path", value.Value, writer, enc.StringEncoder.Instance);
                    }
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="MalformedPath" />.</para>
            /// </summary>
            private class MalformedPathDecoder : enc.StructDecoder<MalformedPath>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="MalformedPath" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override MalformedPath Create()
                {
                    return new MalformedPath();
                }

                /// <summary>
                /// <para>Set given field.</para>
                /// </summary>
                /// <param name="value">The field value.</param>
                /// <param name="fieldName">The field name.</param>
                /// <param name="reader">The json reader.</param>
                protected override void SetField(MalformedPath value, string fieldName, enc.IJsonReader reader)
                {
                    switch (fieldName)
                    {
                        case "malformed_path":
                            value.Value = enc.StringDecoder.Instance.Decode(reader);
                            break;
                        default:
                            reader.Skip();
                            break;
                    }
                }
            }

            #endregion
        }

        /// <summary>
        /// <para>There is nothing at the given path.</para>
        /// </summary>
        public sealed class NotFound : LookupError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotFound> Encoder = new NotFoundEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotFound> Decoder = new NotFoundDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotFound" /> class.</para>
            /// </summary>
            private NotFound()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotFound</para>
            /// </summary>
            public static readonly NotFound Instance = new NotFound();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotFound" />.</para>
            /// </summary>
            private class NotFoundEncoder : enc.StructEncoder<NotFound>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotFound value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotFound" />.</para>
            /// </summary>
            private class NotFoundDecoder : enc.StructDecoder<NotFound>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotFound" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotFound Create()
                {
                    return NotFound.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>We were expecting a file, but the given path refers to something that isn't a
        /// file.</para>
        /// </summary>
        public sealed class NotFile : LookupError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotFile> Encoder = new NotFileEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotFile> Decoder = new NotFileDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotFile" /> class.</para>
            /// </summary>
            private NotFile()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotFile</para>
            /// </summary>
            public static readonly NotFile Instance = new NotFile();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotFile" />.</para>
            /// </summary>
            private class NotFileEncoder : enc.StructEncoder<NotFile>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotFile value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotFile" />.</para>
            /// </summary>
            private class NotFileDecoder : enc.StructDecoder<NotFile>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotFile" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotFile Create()
                {
                    return NotFile.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>We were expecting a folder, but the given path refers to something that isn't
        /// a folder.</para>
        /// </summary>
        public sealed class NotFolder : LookupError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<NotFolder> Encoder = new NotFolderEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<NotFolder> Decoder = new NotFolderDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NotFolder" /> class.</para>
            /// </summary>
            private NotFolder()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NotFolder</para>
            /// </summary>
            public static readonly NotFolder Instance = new NotFolder();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="NotFolder" />.</para>
            /// </summary>
            private class NotFolderEncoder : enc.StructEncoder<NotFolder>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(NotFolder value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="NotFolder" />.</para>
            /// </summary>
            private class NotFolderDecoder : enc.StructDecoder<NotFolder>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="NotFolder" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override NotFolder Create()
                {
                    return NotFolder.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The file cannot be transferred because the content is restricted.  For
        /// example, sometimes there are legal restrictions due to copyright claims.</para>
        /// </summary>
        public sealed class RestrictedContent : LookupError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<RestrictedContent> Encoder = new RestrictedContentEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<RestrictedContent> Decoder = new RestrictedContentDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="RestrictedContent" />
            /// class.</para>
            /// </summary>
            private RestrictedContent()
            {
            }

            /// <summary>
            /// <para>A singleton instance of RestrictedContent</para>
            /// </summary>
            public static readonly RestrictedContent Instance = new RestrictedContent();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="RestrictedContent" />.</para>
            /// </summary>
            private class RestrictedContentEncoder : enc.StructEncoder<RestrictedContent>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(RestrictedContent value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="RestrictedContent" />.</para>
            /// </summary>
            private class RestrictedContentDecoder : enc.StructDecoder<RestrictedContent>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="RestrictedContent"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override RestrictedContent Create()
                {
                    return RestrictedContent.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>This operation is not supported for this content type.</para>
        /// </summary>
        public sealed class UnsupportedContentType : LookupError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<UnsupportedContentType> Encoder = new UnsupportedContentTypeEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<UnsupportedContentType> Decoder = new UnsupportedContentTypeDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UnsupportedContentType" />
            /// class.</para>
            /// </summary>
            private UnsupportedContentType()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UnsupportedContentType</para>
            /// </summary>
            public static readonly UnsupportedContentType Instance = new UnsupportedContentType();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="UnsupportedContentType" />.</para>
            /// </summary>
            private class UnsupportedContentTypeEncoder : enc.StructEncoder<UnsupportedContentType>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(UnsupportedContentType value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="UnsupportedContentType" />.</para>
            /// </summary>
            private class UnsupportedContentTypeDecoder : enc.StructDecoder<UnsupportedContentType>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="UnsupportedContentType"
                /// />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override UnsupportedContentType Create()
                {
                    return UnsupportedContentType.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : LookupError
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
