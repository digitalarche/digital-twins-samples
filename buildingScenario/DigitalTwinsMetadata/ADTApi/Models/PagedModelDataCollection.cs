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
    /// A collection of ModelData objects.
    /// </summary>
    public partial class PagedModelDataCollection
    {
        /// <summary>
        /// Initializes a new instance of the PagedModelDataCollection class.
        /// </summary>
        public PagedModelDataCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PagedModelDataCollection class.
        /// </summary>
        /// <param name="value">The ModelData objects.</param>
        /// <param name="nextLink">A URI to retrieve the next page of
        /// objects.</param>
        public PagedModelDataCollection(IList<ModelData> value = default(IList<ModelData>), string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ModelData objects.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ModelData> Value { get; set; }

        /// <summary>
        /// Gets or sets a URI to retrieve the next page of objects.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
