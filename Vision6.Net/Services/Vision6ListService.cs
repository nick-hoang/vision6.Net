using System.Collections.Generic;

namespace Vision6
{
    public class Vision6ListService : Vision6Service
    {
        /// <summary>
        /// Returns the Lists that match the search criteria.
        /// </summary>
        /// <param name="searchCriteria">An array of search criteria [http://developers.vision6.com.au/3.0/guide/search].</param>
        /// <param name="limit"></param>
        /// <param name="offset">Number of items to skip before beginning to return results</param>
        /// <param name="sortBy">The name of the value to sort the results by.</param>
        /// <param name="sortOrder">The order the results are returned in (either ascending or descending): DESC or ASC</param>
        /// <returns></returns>
        public virtual Vision6ResponseObject Search(List<string> searchCriteria, int limit = 0, int offset = 0, string sortBy = "Name", string sortOrder = "ASC")
        {
            var requestObject = new Vision6RequestObject
            {
                Method = Methods.SearchLists,
            };
            requestObject.Params.Add(searchCriteria);

            requestObject.Params.Add(limit);

            requestObject.Params.Add(offset);

            requestObject.Params.Add(sortBy);

            requestObject.Params.Add(sortOrder);

            return Requestor.Post(requestObject);
        }        
    }
}