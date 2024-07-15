using Demo.Nuget.HATEOAS.Hypermedia.Abstract;
using System.Collections.Generic;

namespace Demo.Nuget.HATEOAS.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
