// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Delete file request.</para>
    /// </summary>
    public class FileRequestDeleteDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<FileRequestDeleteDetails> Encoder = new FileRequestDeleteDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<FileRequestDeleteDetails> Decoder = new FileRequestDeleteDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileRequestDeleteDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="fileRequestId">File request id. Might be missing due to historical
        /// data gap.</param>
        /// <param name="previousDetails">Previous file request details. Might be missing due
        /// to historical data gap.</param>
        public FileRequestDeleteDetails(string fileRequestId = null,
                                        FileRequestDetails previousDetails = null)
        {
            if (fileRequestId != null)
            {
                if (fileRequestId.Length < 1)
                {
                    throw new sys.ArgumentOutOfRangeException("fileRequestId", "Length should be at least 1");
                }
                if (!re.Regex.IsMatch(fileRequestId, @"\A(?:[-_0-9a-zA-Z]+)\z"))
                {
                    throw new sys.ArgumentOutOfRangeException("fileRequestId", @"Value should match pattern '\A(?:[-_0-9a-zA-Z]+)\z'");
                }
            }

            this.FileRequestId = fileRequestId;
            this.PreviousDetails = previousDetails;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FileRequestDeleteDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public FileRequestDeleteDetails()
        {
        }

        /// <summary>
        /// <para>File request id. Might be missing due to historical data gap.</para>
        /// </summary>
        public string FileRequestId { get; protected set; }

        /// <summary>
        /// <para>Previous file request details. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public FileRequestDetails PreviousDetails { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="FileRequestDeleteDetails" />.</para>
        /// </summary>
        private class FileRequestDeleteDetailsEncoder : enc.StructEncoder<FileRequestDeleteDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(FileRequestDeleteDetails value, enc.IJsonWriter writer)
            {
                if (value.FileRequestId != null)
                {
                    WriteProperty("file_request_id", value.FileRequestId, writer, enc.StringEncoder.Instance);
                }
                if (value.PreviousDetails != null)
                {
                    WriteProperty("previous_details", value.PreviousDetails, writer, global::Dropbox.Api.TeamLog.FileRequestDetails.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="FileRequestDeleteDetails" />.</para>
        /// </summary>
        private class FileRequestDeleteDetailsDecoder : enc.StructDecoder<FileRequestDeleteDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="FileRequestDeleteDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override FileRequestDeleteDetails Create()
            {
                return new FileRequestDeleteDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(FileRequestDeleteDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "file_request_id":
                        value.FileRequestId = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "previous_details":
                        value.PreviousDetails = global::Dropbox.Api.TeamLog.FileRequestDetails.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
