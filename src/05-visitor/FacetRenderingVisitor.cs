namespace Visitor {

    public interface IVisitor {
        string accept(BrandFacet facet);
        string accept(SchemaFacet facet);
    }

    public class RenderFacetVisitor {

        public string Render(IElement facet) {
            var visitor = new FacetVisitor();
            return facet.visit(visitor);
        }

    }

    public class FacetVisitor : IVisitor {
    
        public string accept(BrandFacet facet) {
            return string.Format ("BRAND: {0}", facet.label);
        }

        public string accept(SchemaFacet facet) {
            return string.Format ("SCHEMA: {0}, {1}, {2}", 
                                  facet.label,
                                  facet.schemaLabel,
                                  facet.schemaIdentifier);
        }
    }
}
