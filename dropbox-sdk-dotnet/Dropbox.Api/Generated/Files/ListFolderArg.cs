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
    /// <para>The list folder arg object</para>
    /// </summary>
    public class ListFolderArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListFolderArg> Encoder = new ListFolderArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListFolderArg> Decoder = new ListFolderArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFolderArg" /> class.</para>
        /// </summary>
        /// <param name="path">A unique identifier for the file.</param>
        /// <param name="recursive">If true, the list folder operation will be applied
        /// recursively to all subfolders and the response will contain contents of all
        /// subfolders.</param>
        /// <param name="includeMediaInfo">If true, <see
        /// cref="Dropbox.Api.Files.FileMetadata.MediaInfo" /> is set for photo and video. This
        /// parameter will no longer have an effect starting December 2, 2019.</param>
        /// <param name="includeDeleted">If true, the results will include entries for files
        /// and folders that used to exist but were deleted.</param>
        /// <param name="includeHasExplicitSharedMembers">If true, the results will include a
        /// flag for each file indicating whether or not  that file has any explicit
        /// members.</param>
        /// <param name="includeMountedFolders">If true, the results will include entries under
        /// mounted folders which includes app folder, shared folder and team folder.</param>
        /// <param name="limit">The maximum number of results to return per request. Note: This
        /// is an approximate number and there can be slightly more entries returned in some
        /// cases.</param>
        /// <param name="sharedLink">A shared link to list the contents of. If the link is
        /// password-protected, the password must be provided. If this field is present, <see
        /// cref="Dropbox.Api.Files.ListFolderArg.Path" /> will be relative to root of the
        /// shared link. Only non-recursive mode is supported for shared link.</param>
        /// <param name="includePropertyGroups">If set to a valid list of template IDs, <see
        /// cref="Dropbox.Api.Files.FileMetadata.PropertyGroups" /> is set if there exists
        /// property data associated with the file and each of the listed templates.</param>
        /// <param name="includeNonDownloadableFiles">If true, include files that are not
        /// downloadable, i.e. Google Docs.</param>
        public ListFolderArg(string path,
                             bool recursive = false,
                             bool includeMediaInfo = false,
                             bool includeDeleted = false,
                             bool includeHasExplicitSharedMembers = false,
                             bool includeMountedFolders = true,
                             uint? limit = null,
                             SharedLink sharedLink = null,
                             global::Dropbox.Api.FileProperties.TemplateFilterBase includePropertyGroups = null,
                             bool includeNonDownloadableFiles = true)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            if (!re.Regex.IsMatch(path, @"\A(?:(/(.|[\r\n])*)?|id:.*|(ns:[0-9]+(/.*)?))\z"))
            {
                throw new sys.ArgumentOutOfRangeException("path", @"Value should match pattern '\A(?:(/(.|[\r\n])*)?|id:.*|(ns:[0-9]+(/.*)?))\z'");
            }

            if (limit != null)
            {
                if (limit < 1U)
                {
                    throw new sys.ArgumentOutOfRangeException("limit", "Value should be greater or equal than 1");
                }
                if (limit > 2000U)
                {
                    throw new sys.ArgumentOutOfRangeException("limit", "Value should be less of equal than 2000");
                }
            }

            this.Path = path;
            this.Recursive = recursive;
            this.IncludeMediaInfo = includeMediaInfo;
            this.IncludeDeleted = includeDeleted;
            this.IncludeHasExplicitSharedMembers = includeHasExplicitSharedMembers;
            this.IncludeMountedFolders = includeMountedFolders;
            this.Limit = limit;
            this.SharedLink = sharedLink;
            this.IncludePropertyGroups = includePropertyGroups;
            this.IncludeNonDownloadableFiles = includeNonDownloadableFiles;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFolderArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public ListFolderArg()
        {
            this.Recursive = false;
            this.IncludeMediaInfo = false;
            this.IncludeDeleted = false;
            this.IncludeHasExplicitSharedMembers = false;
            this.IncludeMountedFolders = true;
            this.IncludeNonDownloadableFiles = true;
        }

        /// <summary>
        /// <para>A unique identifier for the file.</para>
        /// </summary>
        public string Path { get; protected set; }

        /// <summary>
        /// <para>If true, the list folder operation will be applied recursively to all
        /// subfolders and the response will contain contents of all subfolders.</para>
        /// </summary>
        public bool Recursive { get; protected set; }

        /// <summary>
        /// <para>If true, <see cref="Dropbox.Api.Files.FileMetadata.MediaInfo" /> is set for
        /// photo and video. This parameter will no longer have an effect starting December 2,
        /// 2019.</para>
        /// </summary>
        public bool IncludeMediaInfo { get; protected set; }

        /// <summary>
        /// <para>If true, the results will include entries for files and folders that used to
        /// exist but were deleted.</para>
        /// </summary>
        public bool IncludeDeleted { get; protected set; }

        /// <summary>
        /// <para>If true, the results will include a flag for each file indicating whether or
        /// not  that file has any explicit members.</para>
        /// </summary>
        public bool IncludeHasExplicitSharedMembers { get; protected set; }

        /// <summary>
        /// <para>If true, the results will include entries under mounted folders which
        /// includes app folder, shared folder and team folder.</para>
        /// </summary>
        public bool IncludeMountedFolders { get; protected set; }

        /// <summary>
        /// <para>The maximum number of results to return per request. Note: This is an
        /// approximate number and there can be slightly more entries returned in some
        /// cases.</para>
        /// </summary>
        public uint? Limit { get; protected set; }

        /// <summary>
        /// <para>A shared link to list the contents of. If the link is password-protected, the
        /// password must be provided. If this field is present, <see
        /// cref="Dropbox.Api.Files.ListFolderArg.Path" /> will be relative to root of the
        /// shared link. Only non-recursive mode is supported for shared link.</para>
        /// </summary>
        public SharedLink SharedLink { get; protected set; }

        /// <summary>
        /// <para>If set to a valid list of template IDs, <see
        /// cref="Dropbox.Api.Files.FileMetadata.PropertyGroups" /> is set if there exists
        /// property data associated with the file and each of the listed templates.</para>
        /// </summary>
        public global::Dropbox.Api.FileProperties.TemplateFilterBase IncludePropertyGroups { get; protected set; }

        /// <summary>
        /// <para>If true, include files that are not downloadable, i.e. Google Docs.</para>
        /// </summary>
        public bool IncludeNonDownloadableFiles { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="ListFolderArg" />.</para>
        /// </summary>
        private class ListFolderArgEncoder : enc.StructEncoder<ListFolderArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListFolderArg value, enc.IJsonWriter writer)
            {
                WriteProperty("path", value.Path, writer, enc.StringEncoder.Instance);
                WriteProperty("recursive", value.Recursive, writer, enc.BooleanEncoder.Instance);
                WriteProperty("include_media_info", value.IncludeMediaInfo, writer, enc.BooleanEncoder.Instance);
                WriteProperty("include_deleted", value.IncludeDeleted, writer, enc.BooleanEncoder.Instance);
                WriteProperty("include_has_explicit_shared_members", value.IncludeHasExplicitSharedMembers, writer, enc.BooleanEncoder.Instance);
                WriteProperty("include_mounted_folders", value.IncludeMountedFolders, writer, enc.BooleanEncoder.Instance);
                if (value.Limit != null)
                {
                    WriteProperty("limit", value.Limit.Value, writer, enc.UInt32Encoder.Instance);
                }
                if (value.SharedLink != null)
                {
                    WriteProperty("shared_link", value.SharedLink, writer, global::Dropbox.Api.Files.SharedLink.Encoder);
                }
                if (value.IncludePropertyGroups != null)
                {
                    WriteProperty("include_property_groups", value.IncludePropertyGroups, writer, global::Dropbox.Api.FileProperties.TemplateFilterBase.Encoder);
                }
                WriteProperty("include_non_downloadable_files", value.IncludeNonDownloadableFiles, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="ListFolderArg" />.</para>
        /// </summary>
        private class ListFolderArgDecoder : enc.StructDecoder<ListFolderArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListFolderArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListFolderArg Create()
            {
                return new ListFolderArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(ListFolderArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "path":
                        value.Path = enc.StringDecoder.Instance.Decode(reader);
                        break;
                    case "recursive":
                        value.Recursive = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "include_media_info":
                        value.IncludeMediaInfo = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "include_deleted":
                        value.IncludeDeleted = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "include_has_explicit_shared_members":
                        value.IncludeHasExplicitSharedMembers = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "include_mounted_folders":
                        value.IncludeMountedFolders = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "limit":
                        value.Limit = enc.UInt32Decoder.Instance.Decode(reader);
                        break;
                    case "shared_link":
                        value.SharedLink = global::Dropbox.Api.Files.SharedLink.Decoder.Decode(reader);
                        break;
                    case "include_property_groups":
                        value.IncludePropertyGroups = global::Dropbox.Api.FileProperties.TemplateFilterBase.Decoder.Decode(reader);
                        break;
                    case "include_non_downloadable_files":
                        value.IncludeNonDownloadableFiles = enc.BooleanDecoder.Instance.Decode(reader);
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
