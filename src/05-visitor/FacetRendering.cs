namespace Visitor {
    public class RenderFacet {
        public string Render(BaseFacet facet) {
            switch (facet.identifier) {
                case Facets.Brand:
                    return renderBrandFacet(facet);
                case Facets.Schema:
                    return renderSchemaFacet(facet);
            }
            return string.Empty;
        }

        private string renderBrandFacet(BaseFacet facet) {
            return string.Format ("BRAND: {0}", facet.label);
        }

        private string renderSchemaFacet(BaseFacet facet) {
            var schema = (SchemaFacet)facet;
            return string.Format ("SCHEMA: {0}, {1}, {2}", 
                                  schema.label,
                                  schema.schemaLabel,
                                  schema.schemaIdentifier);
        }
    }
}
