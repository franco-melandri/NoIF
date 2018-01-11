namespace Visitor {

    public interface IElement {
        string visit(IVisitor visitor);
    }

    public class BrandFacetVisitor : BrandFacet,
                                     IElement {
        public string visit(IVisitor visitor) {
            return visitor.accept(this);
        }
    }

    public class SchemaFacetVisitor : SchemaFacet,
                                      IElement {
        public string visit(IVisitor visitor) {
            return visitor.accept(this);
        }
    }
}
