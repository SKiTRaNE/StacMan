// <auto-generated>
//     This file was generated by a T4 template.
//     Don't change it directly as your change would get overwritten. Instead, make changes
//     to the .tt file (i.e. the T4 template) and save it to regenerate this file.
// </auto-generated>

using System;
using System.Text.Json.Serialization;

namespace StackExchange.StacMan
{
    /// <summary>
    /// StacMan Revision, corresponding to Stack Exchange API v2's revision type
    /// http://api.stackexchange.com/docs/types/revision
    /// </summary>
    public partial class Revision : StacManType
    {
        /// <summary>
        /// body
        /// </summary>
        [JsonPropertyName("body")]
        public string Body { get; init; }

        /// <summary>
        /// comment
        /// </summary>
        [JsonPropertyName("comment")]
        public string Comment { get; init; }

        /// <summary>
        /// creation_date
        /// </summary>
        [JsonPropertyName("creation_date")]
        public DateTime CreationDate { get; init; }

        /// <summary>
        /// is_rollback
        /// </summary>
        [JsonPropertyName("is_rollback")]
        public bool IsRollback { get; init; }

        /// <summary>
        /// last_body
        /// </summary>
        [JsonPropertyName("last_body")]
        public string LastBody { get; init; }

        /// <summary>
        /// last_tags
        /// </summary>
        [JsonPropertyName("last_tags")]
        public string[] LastTags { get; init; }

        /// <summary>
        /// last_title
        /// </summary>
        [JsonPropertyName("last_title")]
        public string LastTitle { get; init; }

        /// <summary>
        /// post_id
        /// </summary>
        [JsonPropertyName("post_id")]
        public int PostId { get; init; }

        /// <summary>
        /// post_type
        /// </summary>
        [JsonPropertyName("post_type")]
        public Posts.PostType PostType { get; init; }

        /// <summary>
        /// revision_guid
        /// </summary>
        [JsonPropertyName("revision_guid")]
        public Guid RevisionGuid { get; init; }

        /// <summary>
        /// revision_number
        /// </summary>
        [JsonPropertyName("revision_number")]
        public int RevisionNumber { get; init; }

        /// <summary>
        /// revision_type
        /// </summary>
        [JsonPropertyName("revision_type")]
        public Revisions.RevisionType RevisionType { get; init; }

        /// <summary>
        /// set_community_wiki
        /// </summary>
        [JsonPropertyName("set_community_wiki")]
        public bool SetCommunityWiki { get; init; }

        /// <summary>
        /// tags
        /// </summary>
        [JsonPropertyName("tags")]
        public string[] Tags { get; init; }

        /// <summary>
        /// title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; init; }

        /// <summary>
        /// user
        /// </summary>
        [JsonPropertyName("user")]
        public ShallowUser User { get; init; }

    }
}
