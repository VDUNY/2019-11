﻿using GraphQL;
using Pubs.Types;
using System.Linq;

namespace Pubs.SchemaFirst
{
    // Partial class is useful for source control purposes, to allow multiple people to work on the various query parts.
    public partial class Query
    {
        [GraphQLMetadata("publishers")]
        public Publisher[] GetAllPublications()
        {
            return PubsData.Publishers.ToArray();
        }
    }
}
