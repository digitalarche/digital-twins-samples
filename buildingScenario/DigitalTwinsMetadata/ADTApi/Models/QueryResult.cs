// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ADTApi.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The results of a query operation and an optional continuation token.
    /// </summary>
    public partial class QueryResult
    {
        /// <summary>
        /// Initializes a new instance of the QueryResult class.
        /// </summary>
        public QueryResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryResult class.
        /// </summary>
        /// <param name="items">The query results.</param>
        /// <param name="continuationToken">A token which can be used to
        /// construct a new QuerySpecification to retrieve the next set of
        /// results.</param>
        public QueryResult(IList<object> items = default(IList<object>), string continuationToken = default(string))
        {
            Items = items;
            ContinuationToken = continuationToken;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the query results.
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<object> Items { get; set; }

        /// <summary>
        /// Gets or sets a token which can be used to construct a new
        /// QuerySpecification to retrieve the next set of results.
        /// </summary>
        [JsonProperty(PropertyName = "continuationToken")]
        public string ContinuationToken { get; set; }

    }
}
