using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vision6
{
    public class Vision6SearchCondition
    {
        public string Parameter { get; set; }
        
        public string Comparison { get; set; }
        
        public object Value { get; set; }

        public List<object> ToList()
        {
            return new List<object> { Parameter, Comparison, Value };
        }
    }    
}