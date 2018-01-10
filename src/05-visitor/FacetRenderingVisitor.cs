namespace Visitor {

    public interface IVisitor {
        string acceptBrand(BrandFacet facet);
        string acceptSchema(SchemaFacet facet);
    }

    public class RenderFacetVisitor : IVisitor {
        public string Render(IBaseFacetElement facet) {
            return facet.visit(this);
        }

        public string acceptBrand(BrandFacet facet) {
            return string.Format ("BRAND: {0}", facet.label);
        }

        public string acceptSchema(SchemaFacet facet) {
            return string.Format ("SCHEMA: {0}, {1}, {2}", 
                                  facet.label,
                                  facet.schemaLabel,
                                  facet.schemaIdentifier);
        }
    }
}
