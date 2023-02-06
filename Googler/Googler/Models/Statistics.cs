/*
 * Googler
 *
 * This is Googler API. It contains methods to perform various operations with search engines. You can find out more about Swagger at [http://swagger.io](http://swagger.io) or on [irc.freenode.net, #swagger](http://swagger.io/irc/). 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Googler.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Statistics : IEquatable<Statistics>
    { 
        /// <summary>
        /// Gets or Sets DomainMentionCount
        /// </summary>

        [DataMember(Name="domainMentionCount")]
        public int? DomainMentionCount { get; set; }

        /// <summary>
        /// Gets or Sets PageMentionCount
        /// </summary>

        [DataMember(Name="pageMentionCount")]
        public int? PageMentionCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Statistics {\n");
            sb.Append("  DomainMentionCount: ").Append(DomainMentionCount).Append("\n");
            sb.Append("  PageMentionCount: ").Append(PageMentionCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Statistics)obj);
        }

        /// <summary>
        /// Returns true if Statistics instances are equal
        /// </summary>
        /// <param name="other">Instance of Statistics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Statistics other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DomainMentionCount == other.DomainMentionCount ||
                    DomainMentionCount != null &&
                    DomainMentionCount.Equals(other.DomainMentionCount)
                ) && 
                (
                    PageMentionCount == other.PageMentionCount ||
                    PageMentionCount != null &&
                    PageMentionCount.Equals(other.PageMentionCount)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (DomainMentionCount != null)
                    hashCode = hashCode * 59 + DomainMentionCount.GetHashCode();
                    if (PageMentionCount != null)
                    hashCode = hashCode * 59 + PageMentionCount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Statistics left, Statistics right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Statistics left, Statistics right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
