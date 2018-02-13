namespace Visitor {

    public interface IElement {
        string accept(IVisitor visitor);
    }

    public class BrandFacetVisitor : BrandFacet,
                                     IElement {
        public string accept(IVisitor visitor) {
            return visitor.visit(this);
        }
    }

    public class SchemaFacetVisitor : SchemaFacet,
                                      IElement {
        public string accept(IVisitor visitor) {
            return visitor.visit(this);
        }
    }
}
