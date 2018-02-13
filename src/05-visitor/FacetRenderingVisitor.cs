namespace Visitor {

    public interface IVisitor {
        string visit(BrandFacet facet);
        string visit(SchemaFacet facet);
    }

    public class RenderFacetVisitor {

        public string Render(IElement facet) {
            var visitor = new FacetVisitor();
            return facet.accept(visitor);
        }

    }

    public class FacetVisitor : IVisitor {
    
        public string visit(BrandFacet facet) {
            return string.Format ("BRAND: {0}", facet.label);
        }

        public string visit(SchemaFacet facet) {
            return string.Format ("SCHEMA: {0}, {1}, {2}", 
                                  facet.label,
                                  facet.schemaLabel,
                                  facet.schemaIdentifier);
        }
    }
}
